'Người viết: Nguyễn Bằng
'Ngày tạo: 20/08/2008
'Nội dung: Đọc, ghi vào registry của windows
Imports System
Imports Microsoft.Win32
Public Class ModifyRegistry
    Private m_showError As Boolean = False
    Public Property ShowError() As Boolean
        Get
            Return m_showError
        End Get
        Set(ByVal Value As Boolean)
            m_showError = Value
        End Set
    End Property

    Private m_subKey As String = "SOFTWARE\EMS\EMS_INTERNATIONAL"
    ''' <summary>
    ''' Gán giá trị thuộc tính cho một SubKey
    ''' (mặc định là = "SOFTWARE\\EMS")
    ''' </summary>
    Public Property SubKey() As String
        Get
            Return m_subKey
        End Get
        Set(ByVal Value As String)
            m_subKey = Value
        End Set
    End Property

    Private m_baseRegistryKey As RegistryKey = Registry.LocalMachine
    ''' <summary>
    ''' (mặc định là = Registry.LocalMachine)
    ''' </summary>
    Public Property BaseRegistryKey() As RegistryKey
        Get
            Return m_baseRegistryKey
        End Get
        Set(ByVal Value As RegistryKey)
            m_baseRegistryKey = Value
        End Set
    End Property

    ' **************************************************************************
    ' * *************************************************************************
    ''' <summary>
    ''' Đọc một khóa trong registry.
    ''' input: KeyName (string)
    ''' output: value (string)
    ''' </summary>
    Public Function Doc(ByVal KeyName As String) As String
        ' Mở một khóa
        Dim rk As RegistryKey = m_baseRegistryKey
        ' Mở một subKey dạng đọc
        Dim sk1 As RegistryKey = rk.OpenSubKey(m_subKey)
        ' If the RegistrySubKey doesn't exist -> (null)
        If sk1 Is Nothing Then
            Return Nothing
        Else
            Try
                ' Nếu khóa có giá trị thì lấy về
                ' Ngược lại trả về null.
                Return DirectCast(sk1.GetValue(KeyName.ToLower()), String)
            Catch e As Exception
                ShowErrorMessage(e, "Đọc registry " + KeyName.ToLower())
                Return Nothing
            End Try
        End If
    End Function

    ' **************************************************************************
    ' * *************************************************************************


    ''' <summary>
    ''' Ghi giá trị một registry key.
    ''' input: KeyName (string) , Value (object)
    ''' output: true or false
    ''' </summary>
    Public Function Ghi(ByVal KeyName As String, ByVal Value As Object) As Boolean
        Try
            ' Đặt
            Dim rk As RegistryKey = m_baseRegistryKey
            ' Tạo SubKey
            ' Tạo hoặc mở nếu tồn tại,
            ' '
            Dim sk1 As RegistryKey = rk.CreateSubKey(m_subKey)
            ' Lưu giá trị
            sk1.SetValue(KeyName.ToLower(), Value)

            Return True
        Catch e As Exception
            ShowErrorMessage(e, "Ghi registry " + KeyName.ToLower())
            Return False
        End Try
    End Function

    ' **************************************************************************
    ' * *************************************************************************


    ''' <summary>
    ''' Xóa một giá trị registry key.
    ''' input: KeyName (string)
    ''' output: true or false
    ''' </summary>
    Public Function XoaKey(ByVal KeyName As String) As Boolean
        Try
            ' Đặt 
            Dim rk As RegistryKey = m_baseRegistryKey
            Dim sk1 As RegistryKey = rk.CreateSubKey(m_subKey)
            ' If the RegistrySubKey doesn't exists -> (true)
            If sk1 Is Nothing Then
                Return True
            Else
                sk1.DeleteValue(KeyName)
            End If

            Return True
        Catch e As Exception
            ShowErrorMessage(e, "Xóa SubKey " + m_subKey)
            Return False
        End Try
    End Function

    ' **************************************************************************
    ' * *************************************************************************


    ''' <summary>
    ''' Xóa sub key và tất cả các con của nó.
    ''' input: void
    ''' output: true or false
    ''' </summary>
    Public Function XoaSubKeyTree() As Boolean
        Try
            ' Khởi tạo
            Dim rk As RegistryKey = m_baseRegistryKey
            Dim sk1 As RegistryKey = rk.OpenSubKey(m_subKey)
            ' Nếu tồn tại thì xóa nó
            If Not sk1 Is Nothing Then
                rk.DeleteSubKeyTree(m_subKey)
            End If

            Return True
        Catch e As Exception
            ShowErrorMessage(e, "Xóa SubKey " + m_subKey)
            Return False
        End Try
    End Function

    ' **************************************************************************
    ' * *************************************************************************


    ''' <summary>
    ''' Nhận số subkeys thuộc key hiện tại.
    ''' input: void
    ''' output: số subkeys
    ''' </summary>
    Public Function SubKeyCount() As Integer
        Try
            ' Khởi tạo
            Dim rk As RegistryKey = m_baseRegistryKey
            Dim sk1 As RegistryKey = rk.OpenSubKey(m_subKey)
            ' Nếu tồn tại
            If Not sk1 Is Nothing Then
                Return sk1.SubKeyCount
            Else
                Return 0
            End If
        Catch e As Exception
            ShowErrorMessage(e, "nhận subkeys của " + m_subKey)
            Return 0
        End Try
    End Function

    ' **************************************************************************
    ' * *************************************************************************


    ''' <summary>
    ''' Nhận về các giá trị của key.
    ''' input: void
    ''' output: Số keys
    ''' </summary>
    Public Function ValueCount() As Integer
        Try
            ' Khởi tạo
            Dim rk As RegistryKey = m_baseRegistryKey
            Dim sk1 As RegistryKey = rk.OpenSubKey(m_subKey)
            ' Nếu tồn tại keys
            If Not sk1 Is Nothing Then
                Return sk1.ValueCount
            Else
                Return 0
            End If
        Catch e As Exception
            ShowErrorMessage(e, "nhận keys của " + m_subKey)
            Return 0
        End Try
    End Function

    ' **************************************************************************
    ' * *************************************************************************


    Private Sub ShowErrorMessage(ByVal e As Exception, ByVal Title As String)
        If m_showError = True Then
            MessageBox.Show(e.Message, Title, MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub
End Class