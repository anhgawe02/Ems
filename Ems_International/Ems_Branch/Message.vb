Option Explicit On 
Option Strict On

Imports System.Runtime.InteropServices

#Region " Class CMessageBox "

Public Class CMessageBox

    Public Overloads Shared Function Show( _
                        ByVal text As String) As System.Windows.Forms.DialogResult

        Return Show(text, String.Empty)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal text As String, _
                        ByVal caption As String) As System.Windows.Forms.DialogResult

        Return Show(text, caption, MessageBoxButtons.OK)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons) _
                            As System.Windows.Forms.DialogResult

        Return Show(text, caption, buttons, MessageBoxIcon.None)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons, _
                        ByVal icon As System.Windows.Forms.MessageBoxIcon) _
                            As System.Windows.Forms.DialogResult

        Return Show(text, caption, buttons, icon, MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons, _
                        ByVal icon As System.Windows.Forms.MessageBoxIcon, _
                        ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton) _
                            As System.Windows.Forms.DialogResult

        Return Show(text, caption, buttons, icon, defaultButton, Nothing)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons, _
                        ByVal icon As System.Windows.Forms.MessageBoxIcon, _
                        ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton, _
                        ByVal options As System.Windows.Forms.MessageBoxOptions) _
                            As System.Windows.Forms.DialogResult

        Return Show(Nothing, text, caption, buttons, icon, defaultButton, options)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal owner As System.Windows.Forms.IWin32Window, _
                        ByVal text As String) As System.Windows.Forms.DialogResult

        Return Show(Nothing, text, String.Empty)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal owner As System.Windows.Forms.IWin32Window, _
                        ByVal text As String, _
                        ByVal caption As String) _
                            As System.Windows.Forms.DialogResult

        Return Show(owner, text, caption, MessageBoxButtons.OK)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal owner As System.Windows.Forms.IWin32Window, _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons) _
                            As System.Windows.Forms.DialogResult

        Return Show(owner, text, caption, buttons, MessageBoxIcon.None)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal owner As System.Windows.Forms.IWin32Window, _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons, _
                        ByVal icon As System.Windows.Forms.MessageBoxIcon) _
                            As System.Windows.Forms.DialogResult

        Return Show(owner, text, caption, buttons, icon, _
                MessageBoxDefaultButton.Button1)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal owner As System.Windows.Forms.IWin32Window, _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons, _
                        ByVal icon As System.Windows.Forms.MessageBoxIcon, _
                        ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton) _
                            As System.Windows.Forms.DialogResult

        Return Show(owner, text, caption, buttons, icon, defaultButton, Nothing)
    End Function

    Public Overloads Shared Function Show( _
                        ByVal owner As System.Windows.Forms.IWin32Window, _
                        ByVal text As String, _
                        ByVal caption As String, _
                        ByVal buttons As System.Windows.Forms.MessageBoxButtons, _
                        ByVal icon As System.Windows.Forms.MessageBoxIcon, _
                        ByVal defaultButton As System.Windows.Forms.MessageBoxDefaultButton, _
                        ByVal options As System.Windows.Forms.MessageBoxOptions) _
                            As System.Windows.Forms.DialogResult

        Dim cysymsgbox As New CSysMsgBoxHook

        cysymsgbox.HookDialog()
        Dim res As DialogResult

        res = MessageBox.Show(owner, text, _
                              caption, buttons, _
                              icon, defaultButton, options)

        cysymsgbox.UnHookDialog()
        cysymsgbox = Nothing

        Return res
    End Function

End Class

#End Region

#Region " Class CSysMsgBoxHook "

Public Class CSysMsgBoxHook

#Region " API Declarations "

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
    Private Shared Function SetWindowsHookEx( _
                            ByVal idHook As Integer, _
                            ByVal lpfn As HookProc, _
                            ByVal hInstance As IntPtr, _
                            ByVal threadId As Integer) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function UnhookWindowsHookEx( _
                            ByVal idHook As IntPtr) As Integer
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function CallNextHookEx( _
                            ByVal idHook As IntPtr, _
                            ByVal nCode As Integer, _
                            ByVal wParam As IntPtr, _
                            ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
    Private Shared Function SetDlgItemText( _
                            ByVal hWnd As IntPtr, _
                            ByVal nIDDlgItem As Integer, _
                            ByVal lpString As String) As Boolean
    End Function

#End Region

#Region " Delegates "

    Private Delegate Function HookProc( _
                            ByVal nCode As Integer, _
                            ByVal wParam As IntPtr, _
                            ByVal lParam As IntPtr) As IntPtr

#End Region

#Region " Private Constants "

#Region " System  "

    Private Const WH_CBT As Long = &H5
    Private Const HCBT_ACTIVATE As Long = &H5

#End Region

#Region " Buttons "

    Private Const ID_BUT_OK As Integer = &H1
    Private Const ID_BUT_CANCEL As Integer = &H2
    Private Const ID_BUT_ABORT As Integer = &H3
    Private Const ID_BUT_RETRY As Integer = &H4
    Private Const ID_BUT_IGNORE As Integer = &H5
    Private Const ID_BUT_YES As Integer = &H6
    Private Const ID_BUT_NO As Integer = &H7

    Private Const BUT_OK As String = "Đồng ý"
    Private Const BUT_CANCLE As String = "Hủy"
    Private Const BUT_ABORT As String = "Hủy bỏ"
    Private Const BUT_RETRY As String = "Thử lại"
    Private Const BUT_IGNORE As String = "Lờ đi"
    Private Const BUT_YES As String = "Đúng"
    Private Const BUT_NO As String = "Không"

#End Region

#End Region

#Region " Private variables "

    Private _hook As IntPtr

#End Region

#Region " Public methods "

    Public Sub HookDialog()

        Me.UnHookDialog()

        _hook = SetWindowsHookEx( _
                        WH_CBT, _
                        New HookProc(AddressOf DialogHookProc), _
                        IntPtr.Zero, _
                        AppDomain.GetCurrentThreadId())
    End Sub

    Public Sub UnHookDialog()
        If Not _hook.Equals(IntPtr.Zero) Then
            UnhookWindowsHookEx(_hook)
        End If
    End Sub

#End Region

#Region " Private functions "

    Private Function DialogHookProc( _
                            ByVal nCode As Integer, _
                            ByVal wParam As IntPtr, _
                            ByVal lParam As IntPtr) As IntPtr

        If nCode < 0 Then
            Return CallNextHookEx(_hook, nCode, wParam, lParam)
        End If

        If nCode = HCBT_ACTIVATE Then

            SetDlgItemText(wParam, ID_BUT_OK, BUT_OK)
            SetDlgItemText(wParam, ID_BUT_CANCEL, BUT_CANCLE)
            SetDlgItemText(wParam, ID_BUT_ABORT, BUT_ABORT)
            SetDlgItemText(wParam, ID_BUT_RETRY, BUT_RETRY)
            SetDlgItemText(wParam, ID_BUT_IGNORE, BUT_IGNORE)
            SetDlgItemText(wParam, ID_BUT_YES, BUT_YES)
            SetDlgItemText(wParam, ID_BUT_NO, BUT_NO)

            UnhookWindowsHookEx(_hook)
        End If

        Return CallNextHookEx(_hook, nCode, wParam, lParam)
    End Function

#End Region

End Class

#End Region