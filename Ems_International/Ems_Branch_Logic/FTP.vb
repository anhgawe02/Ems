Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Collections
Imports System.Net.Dns

Imports System.Data
Imports System.Data.SqlClient

Namespace EMS
#Region "FTP_Table_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp FTP_Table_Chi_Tiet
    ' tương ứng với mộ trường của bảng FTP trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class FTP_Table_Chi_Tiet
        Public SERVER As String 'Ip server
        Public USERNAME As String
        Public PASSWORD As String
        Public UPLOAD As String 'Thư mục Upload
        Public DOWNLOAD As String 'Thư mục Download
    End Class
#End Region

#Region "FTP_Table"
    Public Class FTP_Table
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "FTP_Cap_Nhat"
        Public Function FTP_Cap_Nhat(ByVal SERVER As String, ByVal USERNAME As String, ByVal PASSWORD As String, ByVal UPLOAD As String, ByVal DOWNLOAD As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "FTP_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pSERVER As SqlParameter = New SqlParameter("@SERVER", SqlDbType.VarChar, 50)
                pSERVER.Value = SERVER
                MyCommand.Parameters.Add(pSERVER)

                Dim pUSERNAME As SqlParameter = New SqlParameter("@USERNAME", SqlDbType.VarChar, 50)
                pUSERNAME.Value = USERNAME
                MyCommand.Parameters.Add(pUSERNAME)

                Dim pPASSWORD As SqlParameter = New SqlParameter("@PASSWORD", SqlDbType.VarChar, 50)
                pPASSWORD.Value = PASSWORD
                MyCommand.Parameters.Add(pPASSWORD)

                Dim pUPLOAD As SqlParameter = New SqlParameter("@UPLOAD", SqlDbType.VarChar, 50)
                pUPLOAD.Value = UPLOAD
                MyCommand.Parameters.Add(pUPLOAD)

                Dim pDOWNLOAD As SqlParameter = New SqlParameter("@DOWNLOAD", SqlDbType.VarChar, 50)
                pDOWNLOAD.Value = DOWNLOAD
                MyCommand.Parameters.Add(pDOWNLOAD)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

            Catch ex As Exception
                ' Call the exception handler
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region

#Region "FTP_Cap_Nhat_Them"
        Public Function FTP_Cap_Nhat_Them(ByVal SERVER As String, ByVal USERNAME As String, ByVal PASSWORD As String, ByVal UPLOAD As String, ByVal DOWNLOAD As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "FTP_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pSERVER As SqlParameter = New SqlParameter("@SERVER", SqlDbType.VarChar, 50)
                pSERVER.Value = SERVER
                MyCommand.Parameters.Add(pSERVER)

                Dim pUSERNAME As SqlParameter = New SqlParameter("@USERNAME", SqlDbType.VarChar, 50)
                pUSERNAME.Value = USERNAME
                MyCommand.Parameters.Add(pUSERNAME)

                Dim pPASSWORD As SqlParameter = New SqlParameter("@PASSWORD", SqlDbType.VarChar, 50)
                pPASSWORD.Value = PASSWORD
                MyCommand.Parameters.Add(pPASSWORD)

                Dim pUPLOAD As SqlParameter = New SqlParameter("@UPLOAD", SqlDbType.VarChar, 50)
                pUPLOAD.Value = UPLOAD
                MyCommand.Parameters.Add(pUPLOAD)

                Dim pDOWNLOAD As SqlParameter = New SqlParameter("@DOWNLOAD", SqlDbType.VarChar, 50)
                pDOWNLOAD.Value = DOWNLOAD
                MyCommand.Parameters.Add(pDOWNLOAD)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

            Catch ex As Exception
                ' Call the exception handler
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region

#Region "FTP_Danh_Sach"
        Public Function FTP_Danh_Sach() As DataSet
            ' The procedure returns these columns:
            ' SERVER
            ' USERNAME
            ' PASSWORD
            ' UPLOAD
            ' DOWNLOAD


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "FTP_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "FTP_Lay"
        Public Function FTP_Lay(ByVal SERVER As String) As FTP_Table_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "FTP_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myFTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pSERVER As SqlParameter = New SqlParameter("@SERVER", SqlDbType.VarChar, 50)
                pSERVER.Value = SERVER
                MyCommand.Parameters.Add(pSERVER)

                Dim pUSERNAME As SqlParameter = New SqlParameter("@USERNAME", SqlDbType.VarChar, 50)
                pUSERNAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUSERNAME)

                Dim pPASSWORD As SqlParameter = New SqlParameter("@PASSWORD", SqlDbType.VarChar, 50)
                pPASSWORD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPASSWORD)

                Dim pUPLOAD As SqlParameter = New SqlParameter("@UPLOAD", SqlDbType.VarChar, 50)
                pUPLOAD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUPLOAD)

                Dim pDOWNLOAD As SqlParameter = New SqlParameter("@DOWNLOAD", SqlDbType.VarChar, 50)
                pDOWNLOAD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDOWNLOAD)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myFTP_Table_Chi_Tiet.SERVER = SERVER
                myFTP_Table_Chi_Tiet.USERNAME = pUSERNAME.Value
                myFTP_Table_Chi_Tiet.PASSWORD = pPASSWORD.Value
                myFTP_Table_Chi_Tiet.UPLOAD = pUPLOAD.Value
                myFTP_Table_Chi_Tiet.DOWNLOAD = pDOWNLOAD.Value

                Return myFTP_Table_Chi_Tiet
                'Return myFTP_Chi_Tiet

            Catch ex As Exception
                ' Call the exception handler
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region

#Region "FTP_Them"
        Public Function FTP_Them(ByVal SERVER As String, ByVal USERNAME As String, ByVal PASSWORD As String, ByVal UPLOAD As String, ByVal DOWNLOAD As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "FTP_Them"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pSERVER As SqlParameter = New SqlParameter("@SERVER", SqlDbType.VarChar, 50)
                pSERVER.Value = SERVER
                MyCommand.Parameters.Add(pSERVER)

                Dim pUSERNAME As SqlParameter = New SqlParameter("@USERNAME", SqlDbType.VarChar, 50)
                pUSERNAME.Value = USERNAME
                MyCommand.Parameters.Add(pUSERNAME)

                Dim pPASSWORD As SqlParameter = New SqlParameter("@PASSWORD", SqlDbType.VarChar, 50)
                pPASSWORD.Value = PASSWORD
                MyCommand.Parameters.Add(pPASSWORD)

                Dim pUPLOAD As SqlParameter = New SqlParameter("@UPLOAD", SqlDbType.VarChar, 50)
                pUPLOAD.Value = UPLOAD
                MyCommand.Parameters.Add(pUPLOAD)

                Dim pDOWNLOAD As SqlParameter = New SqlParameter("@DOWNLOAD", SqlDbType.VarChar, 50)
                pDOWNLOAD.Value = DOWNLOAD
                MyCommand.Parameters.Add(pDOWNLOAD)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

            Catch ex As Exception
                ' Call the exception handler
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region

#Region "FTP_Xoa"
        Public Function FTP_Xoa(ByVal SERVER As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "FTP_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pSERVER As SqlParameter = New SqlParameter("@SERVER", SqlDbType.VarChar, 50)
                pSERVER.Value = SERVER
                MyCommand.Parameters.Add(pSERVER)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

            Catch ex As Exception
                ' Call the exception handler
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region

#Region "FTP_Lay_Dong_Dau_Tien"
        Public Function FTP_Lay_Dong_Dau_Tien() As FTP_Table_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "FTP_Lay_Dong_Dau_Tien"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myFTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pSERVER As SqlParameter = New SqlParameter("@SERVER", SqlDbType.VarChar, 50)
                pSERVER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSERVER)

                Dim pUSERNAME As SqlParameter = New SqlParameter("@USERNAME", SqlDbType.VarChar, 50)
                pUSERNAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUSERNAME)

                Dim pPASSWORD As SqlParameter = New SqlParameter("@PASSWORD", SqlDbType.VarChar, 50)
                pPASSWORD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPASSWORD)

                Dim pUPLOAD As SqlParameter = New SqlParameter("@UPLOAD", SqlDbType.VarChar, 50)
                pUPLOAD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUPLOAD)

                Dim pDOWNLOAD As SqlParameter = New SqlParameter("@DOWNLOAD", SqlDbType.VarChar, 50)
                pDOWNLOAD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDOWNLOAD)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myFTP_Table_Chi_Tiet.SERVER = pSERVER.Value
                myFTP_Table_Chi_Tiet.USERNAME = pUSERNAME.Value
                myFTP_Table_Chi_Tiet.PASSWORD = pPASSWORD.Value
                myFTP_Table_Chi_Tiet.UPLOAD = pUPLOAD.Value
                myFTP_Table_Chi_Tiet.DOWNLOAD = pDOWNLOAD.Value

                Return myFTP_Table_Chi_Tiet
                'Return myFTP_Chi_Tiet

            Catch ex As Exception
                ' Call the exception handler
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region

    End Class
#End Region

#Region "FTP_Chi_Tiet"
    Public Class FTP

#Region "Public Variables"

        Public server As String
        Public user As String
        Public pass As String
        Public port As Integer
        Public timeout As Integer

#End Region

#Region "Private Variables"

        Private m_messages As String
        Private responseStr As String
        Private passive_mode As Boolean
        Private bytes_total As Long
        Private file_size As Long
        Private main_sock As Socket
        Private main_ipEndPoint As IPEndPoint
        Private listening_sock As Socket
        Private data_sock As Socket
        Private data_ipEndPoint As IPEndPoint
        Private file As FileStream
        Private response As Integer
        Private bucket As String

#End Region

#Region "Constructors"
        Public Sub New()
            server = Nothing
            user = Nothing
            pass = Nothing
            port = 21
            passive_mode = True
            main_sock = Nothing
            main_ipEndPoint = Nothing
            listening_sock = Nothing
            data_sock = Nothing
            data_ipEndPoint = Nothing
            file = Nothing
            bucket = ""
            bytes_total = 0
            timeout = 10000 ' 10 seconds
            m_messages = ""
        End Sub
        Public Sub New(ByVal server As String, ByVal user As String, ByVal pass As String)
            server = server
            user = user
            pass = pass
            port = 21
            passive_mode = True
            ' #######################################
            main_sock = Nothing
            main_ipEndPoint = Nothing
            listening_sock = Nothing
            data_sock = Nothing
            data_ipEndPoint = Nothing
            file = Nothing
            bucket = ""
            bytes_total = 0
            timeout = 10000
            ' 10 seconds
            m_messages = ""
        End Sub
        ''' <summary>
        ''' Constructor
        ''' </summary>
        ''' <param name="server">Server to connect to</param>
        ''' <param name="port">Port server is listening on</param>
        ''' <param name="user">Account to login as</param>
        ''' <param name="pass">Account password</param>
        Public Sub New(ByVal server As String, ByVal port As Integer, ByVal user As String, ByVal pass As String)
            server = server
            user = user
            pass = pass
            port = port
            passive_mode = True
            ' #######################################
            main_sock = Nothing
            main_ipEndPoint = Nothing
            listening_sock = Nothing
            data_sock = Nothing
            data_ipEndPoint = Nothing
            file = Nothing
            bucket = ""
            bytes_total = 0
            timeout = 10000 ' 10 seconds
            m_messages = ""
        End Sub

#End Region

        ''' <summary>
        ''' Connection status to the server
        ''' </summary>


        Public ReadOnly Property IsConnected() As Boolean
            Get
                If Not main_sock Is Nothing Then
                    Return (main_sock.Connected)
                End If
                Return (False)
            End Get
        End Property


        ''' <summary>
        ''' Returns true if the message buffer has data in it
        ''' </summary>
        Public ReadOnly Property MessagesAvailable() As Boolean
            Get
                If m_messages.Length > 0 Then
                    Return (True)
                End If
                Return (False)
            End Get
        End Property
        ''' <summary>
        ''' Server messages if any, buffer is cleared after you access this property
        ''' </summary>
        Public ReadOnly Property Messages() As String
            Get
                Dim tmp As String = m_messages
                m_messages = ""
                Return (tmp)
            End Get
        End Property
        ''' <summary>
        Public ReadOnly Property ResponseString() As String
            Get
                Return (responseStr)
            End Get
        End Property
        ''' <summary>
        ''' The total number of bytes sent/recieved in a transfer
        ''' </summary>
        Public ReadOnly Property BytesTotal() As Long
            ' #######################################
            Get
                Return (bytes_total)
            End Get
        End Property
        ''' <summary>
        ''' The size of the file being downloaded/uploaded (Can possibly be 0 if no size is available)
        ''' </summary>
        Public ReadOnly Property FileSize() As Long
            ' #######################################
            Get
                Return (file_size)
            End Get
        End Property
        ''' <summary>
        ''' True: Passive mode [default]
        ''' False: Active Mode
        ''' </summary>
        Public Property PassiveMode() As Boolean
            ' #######################################
            Get
                Return (passive_mode)
            End Get
            Set(ByVal value As Boolean)
                passive_mode = value
            End Set
        End Property

        Private Sub Fail()
            Disconnect()
            Throw (New Exception(responseStr))
        End Sub


        Private Sub SetBinaryMode(ByVal mode As Boolean)
            If mode Then
                SendCommand("TYPE I")
            Else
                SendCommand("TYPE A")
            End If

            ReadResponse()
            If response <> 200 Then
                Fail()
            End If
        End Sub


        Private Sub SendCommand(ByVal command As String)
            Try
                Dim cmd As [Byte]() = Encoding.ASCII.GetBytes((command & vbCr & vbLf).ToCharArray())

#If (FTP_DEBUG) Then
             If command.Length > 3 AndAlso command.Substring(0, 4) = "PASS" Then
       Console.WriteLine(vbCr & "PASS xxx")
       Else()
       Console.WriteLine(vbCr & Command())
            End If
#End If

                main_sock.Send(cmd, cmd.Length, 0)
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
            
        End Sub


        Private Sub FillBucket()
            Dim bytes As [Byte]() = New [Byte](511) {}
            Dim bytesgot As Long
            Dim msecs_passed As Integer = 0
            ' #######################################
            While (main_sock.Available < 1)
                System.Threading.Thread.Sleep(50)
                msecs_passed += 50
                ' this code is just a fail safe option
                ' so the code doesn't hang if there is
                ' no data comming.
                If msecs_passed > timeout Then
                    Disconnect()
                    Throw (New Exception("Timed out waiting on server to respond."))
                End If
            End While
            bucket = ""
            While (main_sock.Available > 0)
                bytesgot = main_sock.Receive(bytes, 512, 0)
                bucket += Encoding.ASCII.GetString(bytes, 0, CInt(bytesgot))
                ' this may not be needed, gives any more data that hasn't arrived
                ' just yet a small chance to get there.
                System.Threading.Thread.Sleep(100)
            End While
        End Sub



        Private Function GetLineFromBucket() As String
            Dim i As Integer
            Dim buf As String = ""

            If (i = bucket.IndexOf(vbLf)) = 0 Then
                While (i = 0)
                    FillBucket()
                    i = bucket.IndexOf(vbLf)
                End While
            End If

            buf = bucket.Substring(0, i)
            bucket = bucket.Substring(0, i)
            Return (buf)
        End Function


        Private Sub ReadResponse()
            Dim buf As String
            m_messages = ""

            While (True)
                'buf = GetLineFromBucket();
                buf = GetLineFromBucket()
#If (FTP_DEBUG) Then
       Console.WriteLine(buf)
#End If

                If Regex.Match(buf, "(\d\d\d)").Success Then
                    responseStr = buf
                    response = Int32.Parse(buf.Substring(0, 3))
                    bucket = ""
                    Exit While
                Else
                    m_messages += Regex.Replace(buf, "(\d\d\d)", "") & vbLf
                End If
            End While
        End Sub

        Private Sub OpenDataSocket()
            If passive_mode Then
                Dim pasv As String()
                Dim server As String
                Dim port As Integer

                Connect()
                SendCommand("PASV")
                ReadResponse()
                If response <> 227 Then
                    Fail()
                End If

                Try
                    Dim i1 As Integer, i2 As Integer

                    i1 = responseStr.IndexOf("(") + 1
                    i2 = responseStr.IndexOf(")") - i1
                    pasv = responseStr.Substring(i1, i2).Split(",")
                Catch generatedExceptionName As Exception
                    Disconnect()
                    Throw (New Exception("Malformed PASV response: " & responseStr))
                End Try

                If pasv.Length < 6 Then
                    Disconnect()
                    Throw (New Exception("Malformed PASV response: " & responseStr))
                End If

                server = [String].Format("{0}.{1}.{2}.{3}", pasv(0), pasv(1), pasv(2), pasv(3))
                port = (Integer.Parse(pasv(4)) << 8) + Integer.Parse(pasv(5))

                Try
#If (FTP_DEBUG) Then
            Console.WriteLine("Data socket: {0}:{1}", server, port)
#End If
                    CloseDataSocket()

#If (FTP_DEBUG) Then
            Console.WriteLine("Creating socket...")
#End If
                    data_sock = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

#If (FTP_DEBUG) Then
            Console.WriteLine("Resolving host")
#End If
                    'data_ipEndPoint = new IPEndPoint(Dns.GetHostEntry(server).AddressList[0], port);
                    'data_ipEndPoint = New IPEndPoint(Dns.GetHostAddress(server)(0), port)
                    data_ipEndPoint = New IPEndPoint(Dns.Resolve(server).AddressList(0), port)


#If (FTP_DEBUG) Then
            Console.WriteLine("Connecting..")
#End If
                    data_sock.Connect(data_ipEndPoint)

#If (FTP_DEBUG) Then
#End If
                    Console.WriteLine("Connected.")
                Catch ex As Exception
                    Throw (New Exception("Failed to connect for data transfer: " & ex.Message))
                End Try
            Else

                Connect()

                Try
#If (FTP_DEBUG) Then
            Console.WriteLine("Data socket (active mode)")
#End If
                    CloseDataSocket()

#If (FTP_DEBUG) Then
           Console.WriteLine("Creating listening socket...")
#End If
                    listening_sock = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

#If (FTP_DEBUG) Then
           Console.WriteLine("Binding it to local address/port")
#End If
                    Dim sLocAddr As String = main_sock.LocalEndPoint.ToString()
                    Dim ix As Integer = sLocAddr.IndexOf(":")
                    If ix < 0 Then
                        Throw (New Exception("Failed to parse the local address: " & sLocAddr))
                    End If
                    Dim sIPAddr As String = sLocAddr.Substring(0, ix)
                    ' let the system automatically assign a port number (setting port = 0)
                    Dim localEP As System.Net.IPEndPoint = New IPEndPoint(IPAddress.Parse(sIPAddr), 0)

                    listening_sock.Bind(localEP)
                    sLocAddr = listening_sock.LocalEndPoint.ToString()
                    ix = sLocAddr.IndexOf(":")
                    If ix < 0 Then
                        Throw (New Exception("Failed to parse the local address: " & sLocAddr))
                    End If
                    Dim nPort As Integer = Integer.Parse(sLocAddr.Substring(ix + 1))
#If (FTP_DEBUG) Then
            Console.WriteLine("Listening on {0}:{1}", sIPAddr, nPort)
#End If
                    ' start to listen for a connection request from the host (note that
                    ' Listen is not blocking) and send the PORT command
                    listening_sock.Listen(1)
                    Dim sPortCmd As String = String.Format("PORT {0},{1},{2}", sIPAddr.Replace(".", ","), nPort / 256, nPort Mod 256)
                    SendCommand(sPortCmd)
                    ReadResponse()
                    If response <> 200 Then
                        Fail()
                    End If
                Catch ex As Exception
                    Throw (New Exception("Failed to connect for data transfer: " & ex.Message))
                End Try
            End If
        End Sub
        Private Sub ConnectDataSocket()
            If Not data_sock Is Nothing Then
                Exit Sub
            End If
            Try
#If (FTP_DEBUG) Then
        Console.WriteLine("Accepting the data connection.")
#End If
                data_sock = listening_sock.Accept()
                listening_sock.Close()
                listening_sock = Nothing

                If data_sock Is Nothing Then
                    Throw (New Exception("Winsock error: " & System.Convert.ToString(System.Runtime.InteropServices.Marshal.GetLastWin32Error())))
                End If
#If (FTP_DEBUG) Then
#End If
                Console.WriteLine("Connected.")
            Catch ex As Exception
                Throw (New Exception("Failed to connect for data transfer: " & ex.Message))
            End Try
        End Sub
        Private Sub CloseDataSocket()
#If (FTP_DEBUG) Then
       Console.WriteLine("Attempting to close data channel socket...")
#End If
            If Not data_sock Is Nothing Then
                If data_sock.Connected Then
#If (FTP_DEBUG) Then
                Console.WriteLine("Closing data channel socket!")
#End If
                    data_sock.Close()
#If (FTP_DEBUG) Then
#End If
                    Console.WriteLine("Data channel socket closed!")
                End If
                data_sock = Nothing
            End If

            data_ipEndPoint = Nothing
        End Sub
        Public Sub Disconnect()
            CloseDataSocket()

            If Not main_sock Is Nothing Then
                If main_sock.Connected Then
                    SendCommand("QUIT")
                    main_sock.Close()
                End If
                main_sock = Nothing
            End If

            If Not file Is Nothing Then
                file.Close()
            End If

            main_ipEndPoint = Nothing
            file = Nothing
        End Sub
        Public Sub Connect(ByVal m_server As String, ByVal m_port As Integer, ByVal m_user As String, ByVal m_pass As String)
            server = m_server
            user = m_user
            pass = m_pass
            port = m_port

            Connect()
        End Sub
        Public Sub Connect(ByVal m_server As String, ByVal m_user As String, ByVal m_pass As String)
            server = m_server
            user = m_user
            pass = m_pass

            Connect()
        End Sub
        Public Sub Connect()
            If server Is Nothing Then
                Throw (New Exception("Thiếu thông tin Server."))
            End If

            If user Is Nothing Then
                Throw (New Exception("Thiếu thông tin UserName."))
            End If

            'If Not main_sock Is Nothing Then
            '    If main_sock.Connected Then
            '        Exit Sub
            '    End If
            'End If

            main_sock = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            'main_ipEndPoint = New IPEndPoint(Dns.Resolve(server).AddressList(0), port)
            Dim main_IpHostEntry As IPHostEntry = Dns.Resolve(server)
            main_ipEndPoint = New IPEndPoint(Dns.Resolve(server).AddressList(0), port)

            Try
                main_sock.Connect(main_ipEndPoint)
            Catch ex As Exception
                Throw (New Exception(ex.Message))
            End Try

            ReadResponse()
            If response <> 220 Then
                Fail()
            End If

            SendCommand("USER " & user)
            ReadResponse()

            Select Case response
                Case (331)
                    If pass Is Nothing Then
                        Disconnect()
                        Throw (New Exception("Thiếu thông tin Password."))
                    End If
                    SendCommand("PASS " & pass)
                    ReadResponse()
                    If response <> 230 Then
                        Fail()
                    End If
                    Exit Select
                Case (230)
                    Exit Select
            End Select

            Exit Sub
        End Sub
        Public Function List() As ArrayList
            Dim bytes As [Byte]() = New [Byte](511) {}
            Dim file_list As String = ""
            Dim bytesgot As Long = 0
            Dim msecs_passed As Integer = 0
            Dim m_list As New ArrayList

            Connect()
            OpenDataSocket()
            SendCommand("LIST")
            ReadResponse()

            Select Case response
                Case 125, 150
                    Exit Select
                Case Else
                    CloseDataSocket()
                    Throw (New Exception(responseStr))
            End Select
            ConnectDataSocket()
            While (data_sock.Available < 1)
                System.Threading.Thread.Sleep(50)
                msecs_passed += 50

                If msecs_passed > (timeout / 10) Then
                    Exit While
                End If
            End While

            While (data_sock.Available > 0)
                bytesgot = data_sock.Receive(bytes, bytes.Length, 0)
                file_list += Encoding.ASCII.GetString(bytes, 0, CInt(bytesgot))
                ' *shrug*, sometimes there is data comming but it isn't there yet.
                System.Threading.Thread.Sleep(50)
            End While

            CloseDataSocket()

            ReadResponse()
            If response <> 226 Then
                Throw (New Exception(responseStr))
            End If

            For Each f As String In file_list.Split(ControlChars.Lf)
                If f.Length > 0 AndAlso Not Regex.Match(f, "^total").Success Then
                    m_list.Add(f.Substring(0, f.Length - 1))
                End If
            Next

            Return (m_list)
        End Function


        Public Function ListFiles() As ArrayList
            Dim list__1 As New ArrayList

            For Each f As String In List()
                'FILIPE MADUREIRA
                'In Windows servers it is identified by <DIR>
                If (f.Length > 0) Then
                    If (f.Substring(0, 1) <> "d") And (f.ToUpper().IndexOf("<DIR>") < 0) Then
                        list__1.Add(f)
                    End If
                End If
            Next

            Return (list__1)
        End Function

        Public Function ListDirectories() As ArrayList
            Dim list__1 As New ArrayList

            For Each f As String In List()
                'FILIPE MADUREIRA
                'In Windows servers it is identified by <DIR>
                If f.Length > 0 Then
                    If (f.Substring(0, 1) = "d") OrElse (f.ToUpper().IndexOf("<DIR>") >= 0) Then
                        list__1.Add(f)
                    End If
                End If
            Next

            Return (list__1)
        End Function
        Public Function GetFileDateRaw(ByVal fileName As String) As String
            Connect()

            SendCommand("MDTM " & fileName)
            ReadResponse()
            If response <> 213 Then
#If (FTP_DEBUG) Then
           Console.Write(vbCr & responseStr)
#End If
                Throw (New Exception(responseStr))
            End If

            Return (Me.responseStr.Substring(4))
        End Function
        Public Function GetFileDate(ByVal fileName As String) As DateTime
            Return (ConvertFTPDateToDateTime(GetFileDateRaw(fileName)))
        End Function

        Private Function ConvertFTPDateToDateTime(ByVal input As String) As DateTime
            If input.Length < 14 Then
                Throw (New ArgumentException("Input Value for ConvertFTPDateToDateTime method was too short."))
            End If

            'YYYYMMDDhhmmss":
            Dim year As Integer = System.Convert.ToInt16(input.Substring(0, 4))
            Dim month As Integer = System.Convert.ToInt16(input.Substring(4, 2))
            Dim day As Integer = System.Convert.ToInt16(input.Substring(6, 2))
            Dim hour As Integer = System.Convert.ToInt16(input.Substring(8, 2))
            Dim min As Integer = System.Convert.ToInt16(input.Substring(10, 2))
            Dim sec As Integer = System.Convert.ToInt16(input.Substring(12, 2))

            Return (New DateTime(year, month, day, hour, min, sec))
        End Function
        Public Function GetWorkingDirectory() As String
            'PWD - print working directory
            Connect()
            SendCommand("PWD")
            ReadResponse()

            If response <> 257 Then
                Throw (New Exception(responseStr))
            End If

            Dim pwd As String
            Try
                pwd = responseStr.Substring(responseStr.IndexOf("""", 0) + 1)
                '5);
                pwd = pwd.Substring(0, pwd.LastIndexOf(""""))

                pwd = pwd.Replace("""""", """")
            Catch ex As Exception
                Throw (New Exception("Uhandled PWD response: " & ex.Message))
            End Try

            Return (pwd)
        End Function
        Public Sub ChangeDir(ByVal path As String)
            Try
                Connect()
                SendCommand("CWD " & path)
                ReadResponse()
                If response <> 250 Then
                    Throw (New Exception(responseStr))
                End If
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
        Public Sub MakeDir(ByVal dir As String)
            Connect()
            SendCommand("MKD " & dir)
            ReadResponse()

            Select Case response
                Case 257, 250
                    Exit Select
                Case Else
#If (FTP_DEBUG) Then
                Console.Write(vbCr & responseStr)
#End If
                    Throw (New Exception(responseStr))
            End Select
        End Sub
        Public Sub RemoveDir(ByVal dir As String)
            Connect()
            SendCommand("RMD " & dir)
            ReadResponse()
            If response <> 250 Then
#If (FTP_DEBUG) Then
            Console.Write(vbCr & responseStr)
#End If
                Throw (New Exception(responseStr))
            End If
        End Sub
        Public Sub RemoveFile(ByVal filename As String)
            Connect()
            SendCommand("DELE " & filename)
            ReadResponse()
            If response <> 250 Then
#If (FTP_DEBUG) Then
           Console.Write(vbCr & responseStr)
#End If
                Throw (New Exception(responseStr))
            End If
        End Sub
        Public Sub RenameFile(ByVal oldfilename As String, ByVal newfilename As String)
            Connect()
            SendCommand("RNFR " & oldfilename)
            ReadResponse()
            If response <> 350 Then
#If (FTP_DEBUG) Then
            Console.Write(vbCr & responseStr)
#End If
                Throw (New Exception(responseStr))
            Else
                SendCommand("RNTO " & newfilename)
                ReadResponse()
                If response <> 250 Then
#If (FTP_DEBUG) Then
            Console.Write(vbCr & responseStr)
#End If
                    Throw (New Exception(responseStr))
                End If
            End If
        End Sub
        Public Function GetFileSize(ByVal filename As String) As Long
            Connect()
            SendCommand("SIZE " & filename)
            ReadResponse()
            If response <> 213 Then
#If (FTP_DEBUG) Then
            Console.Write(vbCr & responseStr)
#End If
                Throw (New Exception(responseStr))
            End If

            Return (Int64.Parse(responseStr.Substring(4)))
        End Function
        Public Sub OpenUpload(ByVal filename As String)
            OpenUpload(filename, filename, False)
        End Sub
        Public Sub OpenUpload(ByVal filename As String, ByVal remotefilename As String)
            OpenUpload(filename, remotefilename, False)
        End Sub
        Public Sub OpenUpload(ByVal filename As String, ByVal m_resume As Boolean)
            OpenUpload(filename, filename, m_resume)
        End Sub
        Public Sub OpenUpload(ByVal filename As String, ByVal remote_filename As String, ByVal m_resume As Boolean)
            Connect()
            SetBinaryMode(True)
            OpenDataSocket()

            bytes_total = 0

            Try
                file = New FileStream(filename, FileMode.Open)
            Catch ex As Exception
                file = Nothing
                Throw (New Exception(ex.Message))
            End Try

            file_size = file.Length

            If m_resume Then
                Dim size As Long = GetFileSize(remote_filename)
                SendCommand("REST " & size)
                ReadResponse()
                If response = 350 Then
                    file.Seek(size, SeekOrigin.Begin)
                End If
            End If

            SendCommand("STOR " & remote_filename)
            ReadResponse()

            Select Case response
                Case 125, 150
                    Exit Select
                Case Else
                    file.Close()
                    file = Nothing
                    Throw (New Exception(responseStr))
            End Select
            ConnectDataSocket()

            Exit Sub
        End Sub
        ''' <summary>
        ''' Download a file with no resume
        ''' </summary>
        ''' <param name="filename">Remote file name</param>
        Public Sub OpenDownload(ByVal filename As String)
            OpenDownload(filename, filename, False)
        End Sub

        Public Sub OpenDownload(ByVal filename As String, ByVal [resume] As Boolean)
            OpenDownload(filename, filename, [resume])
        End Sub

        Public Sub OpenDownload(ByVal filename As String, ByVal localfilename As String)
            OpenDownload(filename, localfilename, False)
        End Sub

        Public Sub OpenDownload(ByVal remote_filename As String, ByVal local_filename As String, ByVal mresume As Boolean)
            Connect()
            SetBinaryMode(True)

            bytes_total = 0

            Try
                file_size = GetFileSize(remote_filename)
            Catch
                file_size = 0
            End Try

            If mresume And System.IO.File.Exists(local_filename) Then
                Try
                    file = New FileStream(local_filename, FileMode.Open)
                Catch ex As Exception
                    file = Nothing
                    Throw (New Exception(ex.Message))
                End Try

                SendCommand("REST " & file.Length)
                ReadResponse()
                If response <> 350 Then
                    Throw (New Exception(responseStr))
                End If
                file.Seek(file.Length, SeekOrigin.Begin)
                bytes_total = file.Length
            Else
                Try
                    file = New FileStream(local_filename, FileMode.Create)
                Catch ex As Exception
                    file = Nothing
                    Throw (New Exception(ex.Message))
                End Try
            End If

            OpenDataSocket()
            SendCommand("RETR " & remote_filename)
            ReadResponse()

            Select Case response
                Case 125, 150
                    Exit Select
                Case Else
                    file.Close()
                    file = Nothing
                    Throw (New Exception(responseStr))
            End Select
            ConnectDataSocket()
            ' #######################################
            Exit Sub
        End Sub
        ''' <summary>
        ''' Upload the file, to be used in a loop until file is completely uploaded
        ''' </summary>
        ''' <returns>Bytes sent</returns>
        Public Function DoUpload() As Long
            Dim bytes As [Byte]() = New [Byte](511) {}
            Dim bytes_got As Long

            Try
                bytes_got = file.Read(bytes, 0, bytes.Length)
                bytes_total += bytes_got
                data_sock.Send(bytes, CInt(bytes_got), 0)

                If bytes_got <= 0 Then
                    ' the upload is complete or an error occured
                    file.Close()
                    file = Nothing

                    CloseDataSocket()
                    ReadResponse()
                    Select Case response
                        Case 226, 250
                            Exit Select
                        Case Else
                            Throw (New Exception(responseStr))
                    End Select

                    SetBinaryMode(False)
                End If
            Catch ex As Exception
                file.Close()
                file = Nothing
                CloseDataSocket()
                ReadResponse()
                SetBinaryMode(False)
                Throw (ex)
            End Try

            Return (bytes_got)
        End Function
        ''' <summary>
        ''' Download a file, to be used in a loop until the file is completely downloaded
        ''' </summary>
        ''' <returns>Number of bytes recieved</returns>
        Public Function DoDownload() As Long
            Dim bytes As [Byte]() = New [Byte](511) {}
            Dim bytes_got As Long

            Try
                bytes_got = data_sock.Receive(bytes, bytes.Length, 0)

                If bytes_got <= 0 Then
                    ' the download is done or an error occured
                    CloseDataSocket()
                    file.Close()
                    file = Nothing

                    ReadResponse()
                    Select Case response
                        Case 226, 250
                            Exit Select
                        Case Else
                            Throw (New Exception(responseStr))
                    End Select

                    SetBinaryMode(False)

                    Return (bytes_got)
                End If

                file.Write(bytes, 0, CInt(bytes_got))
                bytes_total += bytes_got
            Catch ex As Exception
                CloseDataSocket()
                file.Close()
                file = Nothing
                ReadResponse()
                SetBinaryMode(False)
                Throw (ex)
            End Try

            Return (bytes_got)
        End Function
    End Class
#End Region

End Namespace

