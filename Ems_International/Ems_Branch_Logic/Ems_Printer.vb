Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.ComponentModel
Imports System.Drawing.Printing
Public Class Ems_Printer
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> _
            Friend Structure structPrinterDefaults
        <MarshalAs(UnmanagedType.LPTStr)> _
        Public pDatatype As String
        Public pDevMode As IntPtr
        <MarshalAs(UnmanagedType.I4)> _
        Public DesiredAccess As Integer
    End Structure
    <DllImport("winspool.Drv", EntryPoint:="OpenPrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
            Friend Shared Function OpenPrinter(<MarshalAs(UnmanagedType.LPTStr)> ByVal printerName As String, ByRef phPrinter As IntPtr, ByRef pd As structPrinterDefaults) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function ClosePrinter(ByVal phPrinter As IntPtr) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> _
    Friend Structure structSize
        Public width As Int32
        Public height As Int32
    End Structure
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> _
        Friend Structure structRect
        Public left As Int32
        Public top As Int32
        Public right As Int32
        Public bottom As Int32
    End Structure

    <StructLayout(LayoutKind.Explicit, CharSet:=CharSet.Unicode)> _
    Friend Structure FormInfo1
        <FieldOffset(0), MarshalAs(UnmanagedType.I4)> _
        Public Flags As Integer
        <FieldOffset(4), MarshalAs(UnmanagedType.LPWStr)> _
        Public pName As String
        <FieldOffset(8)> _
        Public Size As structSize
        <FieldOffset(16)> _
        Public ImageableArea As structRect
    End Structure

    ' changed from CharSet=CharSet.Auto
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Friend Structure structDevMode
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)> _
        Public dmDeviceName As String
        <MarshalAs(UnmanagedType.U2)> _
        Public dmSpecVersion As Short
        <MarshalAs(UnmanagedType.U2)> _
        Public dmDriverVersion As Short
        <MarshalAs(UnmanagedType.U2)> _
        Public dmSize As Short
        <MarshalAs(UnmanagedType.U2)> _
        Public dmDriverExtra As Short
        <MarshalAs(UnmanagedType.U4)> _
        Public dmFields As Integer
        <MarshalAs(UnmanagedType.I2)> _
        Public dmOrientation As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmPaperSize As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmPaperLength As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmPaperWidth As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmScale As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmCopies As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmDefaultSource As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmPrintQuality As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmColor As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmDuplex As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmYResolution As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmTTOption As Short
        <MarshalAs(UnmanagedType.I2)> _
        Public dmCollate As Short
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)> _
        Public dmFormName As String
        <MarshalAs(UnmanagedType.U2)> _
        Public dmLogPixels As Short
        <MarshalAs(UnmanagedType.U4)> _
        Public dmBitsPerPel As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmPelsWidth As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmPelsHeight As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmNup As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmDisplayFrequency As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmICMMethod As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmICMIntent As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmMediaType As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmDitherType As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmReserved1 As Integer
        <MarshalAs(UnmanagedType.U4)> _
        Public dmReserved2 As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> _
    Friend Structure PRINTER_INFO_9
        Public pDevMode As IntPtr
    End Structure

    <DllImport("winspool.Drv", EntryPoint:="AddFormW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function AddForm(ByVal phPrinter As IntPtr, <MarshalAs(UnmanagedType.I4)> ByVal level As Integer, ByRef form As FormInfo1) As Boolean
    End Function

    ' This method is not used
    ' [DllImport("winspool.Drv", EntryPoint="SetForm", SetLastError=true,
    ' CharSet=CharSet.Unicode, ExactSpelling=false,
    ' CallingConvention=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()]
    ' internal static extern bool SetForm(IntPtr phPrinter, string paperName,
    ' [MarshalAs(UnmanagedType.I4)] int level, ref FormInfo1 form);
    '

    <DllImport("winspool.Drv", EntryPoint:="DeleteForm", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function DeleteForm(ByVal phPrinter As IntPtr, <MarshalAs(UnmanagedType.LPTStr)> ByVal pName As String) As Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="GetLastError", SetLastError:=False, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function GetLastError() As Int32
    End Function

    <DllImport("GDI32.dll", EntryPoint:="CreateDC", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function CreateDC(<MarshalAs(UnmanagedType.LPTStr)> ByVal pDrive As String, <MarshalAs(UnmanagedType.LPTStr)> ByVal pName As String, <MarshalAs(UnmanagedType.LPTStr)> ByVal pOutput As String, ByRef pDevMode As structDevMode) As IntPtr
    End Function

    <DllImport("GDI32.dll", EntryPoint:="ResetDC", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function ResetDC(ByVal hDC As IntPtr, ByRef pDevMode As structDevMode) As IntPtr
    End Function

    <DllImport("GDI32.dll", EntryPoint:="DeleteDC", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function DeleteDC(ByVal hDC As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="SetPrinterA", SetLastError:=True, CharSet:=CharSet.Auto, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall), SuppressUnmanagedCodeSecurityAttribute()> _
    Friend Shared Function SetPrinter(ByVal hPrinter As IntPtr, <MarshalAs(UnmanagedType.I4)> ByVal level As Integer, ByVal pPrinter As IntPtr, <MarshalAs(UnmanagedType.I4)> ByVal command As Integer) As Boolean
    End Function

    '
    ' LONG DocumentProperties(
    ' HWND hWnd, // handle to parent window
    ' HANDLE hPrinter, // handle to printer object
    ' LPTSTR pDeviceName, // device name
    ' PDEVMODE pDevModeOutput, // modified device mode
    ' PDEVMODE pDevModeInput, // original device mode
    ' DWORD fMode // mode options
    ' );
    '

    ' changed from String to string
    <DllImport("winspool.Drv", EntryPoint:="DocumentPropertiesA", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function DocumentProperties(ByVal hwnd As IntPtr, ByVal hPrinter As IntPtr, <MarshalAs(UnmanagedType.LPStr)> ByVal pDeviceName As String, ByVal pDevModeOutput As IntPtr, ByVal pDevModeInput As IntPtr, ByVal fMode As Integer) As Integer
    End Function

    ' changed type from Int32
    ' chagned from Int32
    <DllImport("winspool.Drv", EntryPoint:="GetPrinterA", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetPrinter(ByVal hPrinter As IntPtr, ByVal dwLevel As Integer, ByVal pPrinter As IntPtr, ByVal dwBuf As Integer, ByRef dwNeeded As Integer) As Boolean
    End Function
    ' changed from Int32
    ' SendMessageTimeout tools
    <Flags()> _
    Public Enum SendMessageTimeoutFlags As Integer
        SMTO_NORMAL = &H0
        SMTO_BLOCK = &H1
        SMTO_ABORTIFHUNG = &H2
        SMTO_NOTIMEOUTIFNOTHUNG = &H8
    End Enum
    Const WM_SETTINGCHANGE As Integer = &H1A
    Const HWND_BROADCAST As Integer = &HFFFF

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function SendMessageTimeout(ByVal windowHandle As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr, ByVal flags As SendMessageTimeoutFlags, ByVal timeout As Integer, ByRef result As IntPtr) As IntPtr
    End Function

    Public Shared Sub AddMjm80MmPaperSizeToDefaultPrinter()
        AddCustomPaperSizeToDefaultPrinter("MJM 80mm * Receipt Length", 80.1F, 4003.9F)
    End Sub

    Public Shared Sub AddMjm104MmPaperSizeToDefaultPrinter()
        AddCustomPaperSizeToDefaultPrinter("MJM 104mm * Receipt Length", 104.1F, 4003.9F)
    End Sub
    Public Shared Sub AddCustomPaperSizeToDefaultPrinter(ByVal paperName As String, ByVal widthMm As Single, ByVal heightMm As Single)
        Dim pd As New PrintDocument
        Dim sPrinterName As String = pd.PrinterSettings.PrinterName
        AddCustomPaperSize(sPrinterName, paperName, widthMm, heightMm)
    End Sub




    Public Shared Sub AddCustomPaperSize(ByVal printerName As String, ByVal paperName As String, ByVal widthMm As Single, ByVal heightMm As Single)
        If PlatformID.Win32NT = Environment.OSVersion.Platform Then
            ' The code to add a custom paper size is different for Windows NT then it is
            ' for previous versions of windows

            Const PRINTER_ACCESS_USE As Integer = &H8
            Const PRINTER_ACCESS_ADMINISTER As Integer = &H4
            Const FORM_PRINTER As Integer = &H2
            Const STANDARD_RIGHTS_REQUIRED As Integer = &HF0000

            Dim defaults As New structPrinterDefaults
            defaults.pDatatype = Nothing
            defaults.pDevMode = IntPtr.Zero
            defaults.DesiredAccess = PRINTER_ACCESS_ADMINISTER Or PRINTER_ACCESS_USE

            Dim hPrinter As IntPtr = IntPtr.Zero

            ' Open the printer.
            If OpenPrinter(printerName, hPrinter, defaults) Then
                Try
                    ' delete the form incase it already exists
                    DeleteForm(hPrinter, paperName)
                    ' create and initialize the FORM_INFO_1 structure
                    Dim formInfo As New FormInfo1
                    formInfo.Flags = 0
                    formInfo.pName = paperName
                    ' all sizes in 1000ths of millimeters
                    formInfo.Size.width = CInt((widthMm * 1000.0))
                    formInfo.Size.height = CInt((heightMm * 1000.0))
                    formInfo.ImageableArea.left = 0
                    formInfo.ImageableArea.right = formInfo.Size.width
                    formInfo.ImageableArea.top = 0
                    formInfo.ImageableArea.bottom = formInfo.Size.height
                    If Not AddForm(hPrinter, 1, formInfo) Then
                        Dim strBuilder As New StringBuilder
                        strBuilder.AppendFormat("Failed to add the custom paper size {0} to the printer {1}, System error number: {2}", paperName, printerName, GetLastError())
                        Throw New ApplicationException(strBuilder.ToString())
                    End If

                    ' INIT
                    Const DM_OUT_BUFFER As Integer = 2
                    Const DM_IN_BUFFER As Integer = 8
                    Dim devMode As New structDevMode
                    Dim hPrinterInfo As IntPtr, hDummy As IntPtr
                    Dim printerInfo As PRINTER_INFO_9
                    printerInfo.pDevMode = IntPtr.Zero
                    Dim iPrinterInfoSize As Integer, iDummyInt As Integer


                    ' GET THE SIZE OF THE DEV_MODE BUFFER
                    Dim iDevModeSize As Integer = DocumentProperties(IntPtr.Zero, hPrinter, printerName, IntPtr.Zero, IntPtr.Zero, 0)

                    If iDevModeSize < 0 Then
                        Throw New ApplicationException("Cannot get the size of the DEVMODE structure.")
                    End If

                    ' ALLOCATE THE BUFFER
                    Dim hDevMode As IntPtr = Marshal.AllocCoTaskMem(iDevModeSize + 100)

                    ' GET A POINTER TO THE DEV_MODE BUFFER
                    Dim iRet As Integer = DocumentProperties(IntPtr.Zero, hPrinter, printerName, hDevMode, IntPtr.Zero, DM_OUT_BUFFER)

                    If iRet < 0 Then
                        Throw New ApplicationException("Cannot get the DEVMODE structure.")
                    End If

                    ' FILL THE DEV_MODE STRUCTURE
                    devMode = DirectCast(Marshal.PtrToStructure(hDevMode, devMode.[GetType]()), structDevMode)

                    ' SET THE FORM NAME FIELDS TO INDICATE THAT THIS FIELD WILL BE MODIFIED
                    devMode.dmFields = &H10000
                    ' DM_FORMNAME
                    ' SET THE FORM NAME
                    devMode.dmFormName = paperName

                    ' PUT THE DEV_MODE STRUCTURE BACK INTO THE POINTER
                    Marshal.StructureToPtr(devMode, hDevMode, True)

                    ' MERGE THE NEW CHAGES WITH THE OLD
                    iRet = DocumentProperties(IntPtr.Zero, hPrinter, printerName, printerInfo.pDevMode, printerInfo.pDevMode, DM_IN_BUFFER Or DM_OUT_BUFFER)

                    If iRet < 0 Then
                        Throw New ApplicationException("Unable to set the orientation setting for this printer.")
                    End If

                    ' GET THE PRINTER INFO SIZE
                    GetPrinter(hPrinter, 9, IntPtr.Zero, 0, iPrinterInfoSize)
                    If iPrinterInfoSize = 0 Then
                        Throw New ApplicationException("GetPrinter failed. Couldn't get the # bytes needed for shared PRINTER_INFO_9 structure")
                    End If

                    ' ALLOCATE THE BUFFER
                    hPrinterInfo = Marshal.AllocCoTaskMem(iPrinterInfoSize + 100)

                    ' GET A POINTER TO THE PRINTER INFO BUFFER
                    Dim bSuccess As Boolean = GetPrinter(hPrinter, 9, hPrinterInfo, iPrinterInfoSize, iDummyInt)

                    If Not bSuccess Then
                        Throw New ApplicationException("GetPrinter failed. Couldn't get the shared PRINTER_INFO_9 structure")
                    End If

                    ' FILL THE PRINTER INFO STRUCTURE
                    printerInfo = DirectCast(Marshal.PtrToStructure(hPrinterInfo, printerInfo.[GetType]()), PRINTER_INFO_9)
                    printerInfo.pDevMode = hDevMode

                    ' GET A POINTER TO THE PRINTER INFO STRUCTURE
                    Marshal.StructureToPtr(printerInfo, hPrinterInfo, True)

                    ' SET THE PRINTER SETTINGS
                    bSuccess = SetPrinter(hPrinter, 9, hPrinterInfo, 0)

                    If Not bSuccess Then
                        Throw New Win32Exception(Marshal.GetLastWin32Error(), "SetPrinter() failed. Couldn't set the printer settings")
                    End If

                    ' Tell all open programs that this change occurred.
                    SendMessageTimeout(New IntPtr(HWND_BROADCAST), WM_SETTINGCHANGE, IntPtr.Zero, IntPtr.Zero, Ems_Printer.SendMessageTimeoutFlags.SMTO_NORMAL, 1000, _
                    hDummy)
                Finally
                    ClosePrinter(hPrinter)
                End Try
            Else
                Dim strBuilder As New StringBuilder
                strBuilder.AppendFormat("Failed to open the {0} printer, System error number: {1}", printerName, GetLastError())
                Throw New ApplicationException(strBuilder.ToString())
            End If
        Else
            Dim pDevMode As New structDevMode
            Dim hDC As IntPtr = CreateDC(Nothing, printerName, Nothing, pDevMode)
            If Not hDC.Equals(IntPtr.Zero) Then
                Const DM_PAPERSIZE As Long = 2L
                Const DM_PAPERLENGTH As Long = 4L
                Const DM_PAPERWIDTH As Long = 8L
                pDevMode.dmFields = CInt((DM_PAPERSIZE Or DM_PAPERWIDTH Or DM_PAPERLENGTH))
                pDevMode.dmPaperSize = 256
                pDevMode.dmPaperWidth = CShort((widthMm * 1000.0))
                pDevMode.dmPaperLength = CShort((heightMm * 1000.0))
                ResetDC(hDC, pDevMode)
                DeleteDC(hDC)
            End If
        End If
    End Sub
End Class
