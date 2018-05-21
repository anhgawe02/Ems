Imports System.Security.Cryptography
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.Ems

Module Mdl_Event_Viewer
#Region "Khai bao bien cho module"


#End Region

#Region "Create_Chi_Tiet_E2"
    Public Function Event_Viewer_Create_Chi_Tiet_E2(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Tong_So As Integer, ByVal Khoi_Luong As Integer) As String
        Try
            Return Id_Duong_Thu.ToString & "_" & Ngay_Dong.ToString & "_" & Loai_Chuyen_Thu & "_" & Chuyen_Thu.ToString & "_" & Tui_So.ToString & "_" & Tong_So.ToString & "_" & Khoi_Luong.ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region

#Region "Create_Chi_Tiet_E1"
    Public Function Event_Viewer_Create_Chi_Tiet_E1(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Ma_E1 As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String) As String
        Try
            Return Id_Duong_Thu.ToString & "_" & Ngay_Dong.ToString & "_" & Loai_Chuyen_Thu & "_" & Chuyen_Thu.ToString & "_" & Tui_So.ToString & "_" & Ma_E1 & "_" & Khoi_Luong.ToString & "_" & Phan_Loai
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region

#Region "Lay loai chuyen thu tu Id_Chuyen_Thu"
    Public Function Get_Loai_Chuyen_Thu_From_Id_Chuyen_Thu(ByVal mId_Chuyen_Thu As String) As String
        'Return mId_Chuyen_Thu.Substring(mId_Chuyen_Thu.Length - 1, 2)
        Return Right(mId_Chuyen_Thu, 2)
    End Function
#End Region

#Region "Lay Ip cua may tinh"
    Public Function Get_Ip_May_Tinh() As String
        Try
            Return System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName).AddressList(0).ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "0.0.0.0"
        End Try
    End Function
#End Region

#Region "Các thao tác với E2"

#Region "Mở tờ E2"
    'Ghi Log khi mở tờ E2 trong chức năng khai thiết lập đi và xác nhận đến
    Public Function Event_Viewer_Open_E2(ByVal mBo_Phan As Integer, ByVal mChi_Tiet_Truoc As String, ByVal mChi_Tiet_Sau As String) As Integer
        Try
            'Khai bao bien
            Dim mEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet
            Dim mEvent_Viewer As New Event_Viewer(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim mDoi_Tuong As Integer = 2   'Su kien doi voi E2
            Dim mSu_Kien As Integer = 1     'Su kien : Mở
            Dim mIp_May_Tinh As String = Get_Ip_May_Tinh()
            'Lay gia tri
            mEvent_Viewer_Chi_Tiet.Bo_Phan = mBo_Phan
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau = mChi_Tiet_Sau
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc = mChi_Tiet_Truoc
            mEvent_Viewer_Chi_Tiet.Doi_Tuong = mDoi_Tuong
            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh = mIp_May_Tinh
            mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien = Gid_Nguoi_Dung
            mEvent_Viewer_Chi_Tiet.Su_Kien = mSu_Kien
            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien = mNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten
            'Them vao bang
            Dim m_Log_Id As Integer
            m_Log_Id = mEvent_Viewer.Event_Viewer_Them(mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                            mEvent_Viewer_Chi_Tiet.Su_Kien, _
                                            mEvent_Viewer_Chi_Tiet.Bo_Phan, _
                                            mEvent_Viewer_Chi_Tiet.Doi_Tuong, _
                                            0, _
                                            0, _
                                            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau, _
                                            0, _
                                            0)

            Return m_Log_Id
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region

#Region "Đóng tờ E2"
    'Ghi Log khi đóng tờ E2 trong chức năng khai thiết lập đi và xác nhận đến
    Public Function Event_Viewer_Close_E2(ByVal m_Log_Id As Integer, ByVal mBo_Phan As Integer, ByVal mChi_Tiet_Sau As String) As Boolean
        Try
            'Khai bao bien
            Dim mEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet
            Dim mEvent_Viewer As New Event_Viewer(GConnectionString)
            Dim mDoi_Tuong As Integer = 2   'Su kien doi voi E2
            Dim mSu_Kien As Integer = 2     'Su kien : Đóng
            Dim mIp_May_Tinh As String = Get_Ip_May_Tinh()
            'Cập nhật trạng thái đóng E2 vao bang
            mEvent_Viewer.Event_Viewer_Cap_Nhat_Event_Close_E2(m_Log_Id, _
                                                                mSu_Kien, _
                                                                mBo_Phan, _
                                                                mChi_Tiet_Sau)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Sửa tờ E2"
    'Ghi Log sửa thông tin E2 trong chức năng sửa chữa E2
    Public Function Event_Viewer_Edit_E2(ByVal mBo_Phan As Integer, ByVal mChi_Tiet_Truoc As String, ByVal mChi_Tiet_Sau As String) As Boolean
        Try
            'Khai bao bien
            Dim mEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet
            Dim mEvent_Viewer As New Event_Viewer(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim mDoi_Tuong As Integer = 2   'Su kien doi voi E2
            Dim mSu_Kien As Integer = 3     'Su kien : SUA
            Dim mIp_May_Tinh As String = Get_Ip_May_Tinh()
            'Lay gia tri
            mEvent_Viewer_Chi_Tiet.Bo_Phan = mBo_Phan
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau = mChi_Tiet_Sau
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc = mChi_Tiet_Truoc
            mEvent_Viewer_Chi_Tiet.Doi_Tuong = mDoi_Tuong
            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh = mIp_May_Tinh
            mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien = Gid_Nguoi_Dung
            mEvent_Viewer_Chi_Tiet.Su_Kien = mSu_Kien
            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien = mNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten
            'Them vao bang
            mEvent_Viewer.Event_Viewer_Them(mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                            mEvent_Viewer_Chi_Tiet.Su_Kien, _
                                            mEvent_Viewer_Chi_Tiet.Bo_Phan, _
                                            mEvent_Viewer_Chi_Tiet.Doi_Tuong, _
                                            0, _
                                            0, _
                                            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau, _
                                            0, _
                                            0)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Xoá tờ E2"
    'Ghi Log khi xoá E2 trong chức năng sửa chữa E2
    Public Function Event_Viewer_Delete_E2(ByVal mBo_Phan As Integer, ByVal mChi_Tiet_Truoc As String, ByVal mChi_Tiet_Sau As String) As Boolean
        Try
            'Khai bao bien
            Dim mEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet
            Dim mEvent_Viewer As New Event_Viewer(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim mDoi_Tuong As Integer = 2   'Su kien doi voi E2
            Dim mSu_Kien As Integer = 4     'Su kien : XOA
            Dim mIp_May_Tinh As String = Get_Ip_May_Tinh()
            'Lay gia tri
            mEvent_Viewer_Chi_Tiet.Bo_Phan = mBo_Phan
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau = mChi_Tiet_Sau
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc = mChi_Tiet_Truoc
            mEvent_Viewer_Chi_Tiet.Doi_Tuong = mDoi_Tuong
            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh = mIp_May_Tinh
            mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien = Gid_Nguoi_Dung
            mEvent_Viewer_Chi_Tiet.Su_Kien = mSu_Kien
            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien = mNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten
            'Them vao bang
            mEvent_Viewer.Event_Viewer_Them(mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                            mEvent_Viewer_Chi_Tiet.Su_Kien, _
                                            mEvent_Viewer_Chi_Tiet.Bo_Phan, _
                                            mEvent_Viewer_Chi_Tiet.Doi_Tuong, _
                                            0, _
                                            0, _
                                            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau, _
                                            0, _
                                            0)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#End Region

#Region "Các thao tác với E1"

#Region "Sửa E1"
    'Ghi Log sửa thông tin E1 trong chức năng khai thiết lập đi và xác nhận đến
    Public Function Event_Viewer_Edit_E1(ByVal mBo_Phan As Integer, ByVal mChi_Tiet_Truoc As String, ByVal mChi_Tiet_Sau As String) As Boolean
        Try
            'Khai bao bien
            Dim mEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet
            Dim mEvent_Viewer As New Event_Viewer(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim mDoi_Tuong As Integer = 1   'Su kien doi voi E1
            Dim mSu_Kien As Integer = 3     'Su kien : SUA
            Dim mIp_May_Tinh As String = Get_Ip_May_Tinh()
            'Lay gia tri
            mEvent_Viewer_Chi_Tiet.Bo_Phan = mBo_Phan
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau = mChi_Tiet_Sau
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc = mChi_Tiet_Truoc
            mEvent_Viewer_Chi_Tiet.Doi_Tuong = mDoi_Tuong
            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh = mIp_May_Tinh
            mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien = Gid_Nguoi_Dung
            mEvent_Viewer_Chi_Tiet.Su_Kien = mSu_Kien
            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien = mNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten
            'Them vao bang
            mEvent_Viewer.Event_Viewer_Them(mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                            mEvent_Viewer_Chi_Tiet.Su_Kien, _
                                            mEvent_Viewer_Chi_Tiet.Bo_Phan, _
                                            mEvent_Viewer_Chi_Tiet.Doi_Tuong, _
                                            0, _
                                            0, _
                                            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau, _
                                            0, _
                                            0)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
#End Region

#Region "Xoá E1"
    'Ghi Log xoá E1 trong chức năng khai thiết lập đi và xác nhận đến
    Public Function Event_Viewer_Delete_E1(ByVal mBo_Phan As Integer, ByVal mChi_Tiet_Truoc As String, ByVal mChi_Tiet_Sau As String) As Boolean
        Try
            'Khai bao bien
            Dim mEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet
            Dim mEvent_Viewer As New Event_Viewer(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim mDoi_Tuong As Integer = 1   'Su kien doi voi E1
            Dim mSu_Kien As Integer = 4     'Su kien : XOA
            Dim mIp_May_Tinh As String = Get_Ip_May_Tinh()
            'Lay gia tri
            mEvent_Viewer_Chi_Tiet.Bo_Phan = mBo_Phan
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau = mChi_Tiet_Sau
            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc = mChi_Tiet_Truoc
            mEvent_Viewer_Chi_Tiet.Doi_Tuong = mDoi_Tuong
            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh = mIp_May_Tinh
            mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien = Gid_Nguoi_Dung
            mEvent_Viewer_Chi_Tiet.Su_Kien = mSu_Kien
            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien = mNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten
            'Them vao bang
            mEvent_Viewer.Event_Viewer_Them(mEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                            mEvent_Viewer_Chi_Tiet.Su_Kien, _
                                            mEvent_Viewer_Chi_Tiet.Bo_Phan, _
                                            mEvent_Viewer_Chi_Tiet.Doi_Tuong, _
                                            0, _
                                            0, _
                                            mEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien, _
                                            mEvent_Viewer_Chi_Tiet.Ip_May_Tinh, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc, _
                                            mEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau, _
                                            0, _
                                            0)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#End Region

#Region "Cắt chuỗi Chi Tiết thành các trường tương ứng phân tách bởi kỹ tự _"
    Public Function Cut_Txt_To_Field(ByVal mChuoi_Chi_Tiet As String, ByVal mKy_Tu_Phan_Tach As String, ByVal mVi_Tri As Integer) As String
        Dim mVi_Tri_Tmp As Integer
        Dim i As Integer
        'Cat dan chuoi theo vi tri dau (_)
        For i = 1 To mVi_Tri - 1
            'Lay vi tri dau (_)
            mVi_Tri_Tmp = mChuoi_Chi_Tiet.IndexOf("_")
            If mVi_Tri_Tmp > 0 Then   'Neu tim thay dau (_)
                'Cat doan con lai bat dau tu vi tri tim thay
                mChuoi_Chi_Tiet = mChuoi_Chi_Tiet.Substring(mVi_Tri_Tmp + 1, mChuoi_Chi_Tiet.Length - mVi_Tri_Tmp - 1)
            Else  'Khong tim thay => Da het chuoi
                Return ""  'tra ve ""
            End If
        Next
        'Chuoi con lai sau khi da cat
        'Lay vi tri dau (_)  -- Vi tri dau (_) sau vi tri can tim
        mVi_Tri_Tmp = mChuoi_Chi_Tiet.IndexOf("_")
        If mVi_Tri_Tmp > 0 Then   'Neu tim thay 
            'Cat tu dau den vi tri dau (_) tiep theo
            Return mChuoi_Chi_Tiet.Substring(0, mVi_Tri_Tmp).Trim
        Else  'Khong tim thay => Da het chuoi
            Return mChuoi_Chi_Tiet.Trim
        End If
    End Function
#End Region

End Module
