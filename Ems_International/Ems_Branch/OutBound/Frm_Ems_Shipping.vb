Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.Math
Imports System.Threading
Imports System.Data
Imports Infragistics.Win
Imports System.Diagnostics
Imports System
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Ems_International_Logic.EMS
Imports Ems_International_Logic


Public Class Frm_Ems_Shipping
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbDV_Cong_Them As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCuoc_E1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCuoc_DV As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCuoc_Chinh As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnHang_Nhe As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbLoai_Hang_Hoa As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtKhoi_Luong_QD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtKhoi_Luong As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSo_Hieu_E1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGio_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpNgay_Gui As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optThoa_Thuan As System.Windows.Forms.RadioButton
    Friend WithEvents optBinh_Thuong As System.Windows.Forms.RadioButton
    Friend WithEvents gbPhan_Loai As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optHang_Hoa As System.Windows.Forms.RadioButton
    Friend WithEvents optTai_Lieu As System.Windows.Forms.RadioButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbKhach_Hang As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDien_Thoai_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtHo_Ten_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbNuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbBuuCuc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPostcode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDien_Thoai_Nhan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtHo_Ten_Nhan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbMa_Quay As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblMa_Quay As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnThem_Vao_Tui As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtInfor As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnClose As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtGio_Dinh_Dang As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents btnPhan_Huong As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbDuongThuDi_PH As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtInfor_E1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabPhanHuong As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents tabQuanLy As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents dgE1_Chua_PH As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgE1_Da_PH As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cbDV_Gia_Tang As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbLua_Chon_In As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbBuu_Cuc_CH As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkChuyen_Hoan_Bc As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnIn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbLua_Chon_In_PH As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGia_Tri_Hang As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkKhai_Gia As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtThong_Tin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents btnQuanLyIn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnkeys As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVung_Xa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents optSu_Vu As System.Windows.Forms.RadioButton
    Friend WithEvents txtDia_Chi_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDia_Chi_Nhan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNoi_Dung_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents optChuyen_Hoan As System.Windows.Forms.RadioButton
    Friend WithEvents optHuy As System.Windows.Forms.RadioButton
    Friend WithEvents chkVungXaTN As System.Windows.Forms.CheckBox
    Friend WithEvents lblBcTra As System.Windows.Forms.Label
    Friend WithEvents lblNuocTra As System.Windows.Forms.Label
    Friend WithEvents btnVung_Xa_TN As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview_PH As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBrowse As Infragistics.Win.Misc.UltraButton
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnBaoCao As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkMaKH_BC As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbMaKH_BC As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dgE1_Chua_PH_XLS As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkDoc_Exel As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtsoban As System.Windows.Forms.NumericUpDown
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSua_Chua As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbNuoc_Nhan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSo_Hieu_CP1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbMa_Nuoc_E1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnDelete As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtThue_Hai_Quan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents prbTien_Trinh As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents chkGiay_A5_Co_San As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Exel", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F1")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F2", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F3")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F4")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F5")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F6")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F7")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F8")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F9")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F10")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F11")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F12")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F13")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F14")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F15")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat_Hanh")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_QD")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Gia_Tang")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPXD")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostCode")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPVX")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_DV")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Giam")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_E1")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kien_So")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_CH")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Trang_Thai")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK_VAT")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat_Hanh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_QD")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Gia_Tang")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPXD")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostCode")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPVX")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_DV")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Giam")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_E1")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kien_So")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_CH")
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Trang_Thai")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK_VAT")
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Ems_Shipping))
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("cbLua_Chon_In", -1)
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_In")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_In")
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DV_Gia_Tang", -1)
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dich_Vu")
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DV_Cong_Them", -1)
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dich_Vu")
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai_Hang_Hoa", -1)
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Buu_Cuc", -1)
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khach_Hang", -1)
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Khach_Hang")
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Khoi_Tao")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Ket_Thuc")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fax")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_So_Thue")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vat")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khach_Hang_Toan_Quoc")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tiem_Nang")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dai_dien")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuc_vu")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tai_khoan")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngan_hang")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_chi_IP")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("User_VPN")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pass_VPN")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC_QL")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_dv")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chiet_khau")
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nuoc_Nhan", -1)
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nuoc_Nhan", -1)
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Quay_Giao_Dich", -1)
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Quay_Giao_Dich")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quay")
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Quay")
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khach_Hang", -1)
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Khach_Hang")
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Khoi_Tao")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Ket_Thuc")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fax")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_So_Thue")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vat")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khach_Hang_Toan_Quoc")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tiem_Nang")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dai_dien")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuc_vu")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tai_khoan")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngan_hang")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_chi_IP")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("User_VPN")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pass_VPN")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC_QL")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_dv")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chiet_khau")
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand17 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("cbLua_Chon_In", -1)
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_In")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_In")
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance248 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.chkAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgE1_Chua_PH_XLS = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgE1_Chua_PH = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgE1_Da_PH = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.prbTien_Trinh = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btnDelete = New Infragistics.Win.Misc.UltraButton
        Me.txtsoban = New System.Windows.Forms.NumericUpDown
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        Me.btnkeys = New Infragistics.Win.Misc.UltraButton
        Me.txtThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.cbLua_Chon_In = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnThem_Vao_Tui = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel
        Me.txtThue_Hai_Quan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnVung_Xa_TN = New Infragistics.Win.Misc.UltraButton
        Me.chkVungXaTN = New System.Windows.Forms.CheckBox
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel
        Me.chkKhai_Gia = New System.Windows.Forms.CheckBox
        Me.txtGia_Tri_Hang = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDV_Gia_Tang = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDV_Cong_Them = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel
        Me.txtCuoc_E1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.txtCuoc_DV = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        Me.txtCuoc_Chinh = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnHang_Nhe = New Infragistics.Win.Misc.UltraButton
        Me.cbLoai_Hang_Hoa = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.txtKhoi_Luong_QD = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtKhoi_Luong = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.txtGio_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.dtpNgay_Gui = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkChuyen_Hoan_Bc = New System.Windows.Forms.CheckBox
        Me.cbBuu_Cuc_CH = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.optHuy = New System.Windows.Forms.RadioButton
        Me.optChuyen_Hoan = New System.Windows.Forms.RadioButton
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtNoi_Dung_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox
        Me.optSu_Vu = New System.Windows.Forms.RadioButton
        Me.optThoa_Thuan = New System.Windows.Forms.RadioButton
        Me.optBinh_Thuong = New System.Windows.Forms.RadioButton
        Me.gbPhan_Loai = New Infragistics.Win.Misc.UltraGroupBox
        Me.optHang_Hoa = New System.Windows.Forms.RadioButton
        Me.optTai_Lieu = New System.Windows.Forms.RadioButton
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtDia_Chi_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbKhach_Hang = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.txtDien_Thoai_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtHo_Ten_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbNuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.lblBcTra = New System.Windows.Forms.Label
        Me.txtDia_Chi_Nhan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnVung_Xa = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.cbBuuCuc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.txtPostcode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.txtDien_Thoai_Nhan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtHo_Ten_Nhan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblNuocTra = New System.Windows.Forms.Label
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox
        Me.cbMa_Nuoc_E1 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDuongThuDi_PH = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel
        Me.txtSo_Hieu_CP1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbNuoc_Nhan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbMa_Quay = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.txtSo_Hieu_E1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel
        Me.lblMa_Quay = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnSua_Chua = New Infragistics.Win.Misc.UltraButton
        Me.chkDoc_Exel = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbMaKH_BC = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.chkMaKH_BC = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btnBaoCao = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnBrowse = New Infragistics.Win.Misc.UltraButton
        Me.label4 = New System.Windows.Forms.Label
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.btnPreview_PH = New Infragistics.Win.Misc.UltraButton
        Me.btnQuanLyIn = New Infragistics.Win.Misc.UltraButton
        Me.cbLua_Chon_In_PH = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnIn = New Infragistics.Win.Misc.UltraButton
        Me.tabQuanLy = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.btnPhan_Huong = New Infragistics.Win.Misc.UltraButton
        Me.txtInfor = New Infragistics.Win.Misc.UltraLabel
        Me.btnClose = New Infragistics.Win.Misc.UltraButton
        Me.txtGio_Dinh_Dang = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtInfor_E1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.tabPhanHuong = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.chkGiay_A5_Co_San = New System.Windows.Forms.CheckBox
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dgE1_Chua_PH_XLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Chua_PH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.dgE1_Da_PH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txtsoban, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLua_Chon_In, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.txtThue_Hai_Quan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGia_Tri_Hang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDV_Gia_Tang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDV_Cong_Them, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuoc_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuoc_DV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuoc_Chinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.cbLoai_Hang_Hoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKhoi_Luong_QD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKhoi_Luong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txtGio_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgay_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.cbBuu_Cuc_CH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.txtNoi_Dung_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.gbPhan_Loai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPhan_Loai.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtDia_Chi_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKhach_Hang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDien_Thoai_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHo_Ten_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.cbNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDia_Chi_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDien_Thoai_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHo_Ten_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.cbMa_Nuoc_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuDi_PH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Hieu_CP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNuoc_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Quay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Hieu_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.cbMaKH_BC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLua_Chon_In_PH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabQuanLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabQuanLy.SuspendLayout()
        CType(Me.tabPhanHuong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPhanHuong.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAll
        '
        Me.chkAll.Location = New System.Drawing.Point(8, 488)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(80, 20)
        Me.chkAll.TabIndex = 132
        Me.chkAll.Text = "Chọn tất"
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.DateTime = New Date(2008, 8, 24, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(24, 40)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 25)
        Me.dtpNgayDinhDang.TabIndex = 108
        Me.dtpNgayDinhDang.Value = New Date(2008, 8, 24, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.Visible = False
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dgE1_Chua_PH_XLS)
        Me.UltraTabPageControl3.Controls.Add(Me.dgE1_Chua_PH)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(2, 26)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(748, 364)
        '
        'dgE1_Chua_PH_XLS
        '
        Me.dgE1_Chua_PH_XLS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgE1_Chua_PH_XLS.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.EditorControl = Me.chkAll
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn1.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn1.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(15, 0)
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance2
        UltraGridColumn2.Header.Caption = "Branch Code"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance3
        UltraGridColumn3.Header.Caption = "Company Name"
        UltraGridColumn3.Header.VisiblePosition = 2
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance4
        UltraGridColumn4.Header.Caption = "Company Address1"
        UltraGridColumn4.Header.VisiblePosition = 3
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance5
        UltraGridColumn5.Header.Caption = "Company Address2"
        UltraGridColumn5.Header.VisiblePosition = 4
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance6
        UltraGridColumn6.Header.Caption = "Company Address3"
        UltraGridColumn6.Header.VisiblePosition = 5
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance7
        UltraGridColumn7.Header.Caption = "County/Province"
        UltraGridColumn7.Header.VisiblePosition = 6
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance8
        UltraGridColumn8.Header.Caption = "Contact name"
        UltraGridColumn8.Header.VisiblePosition = 7
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance9
        UltraGridColumn9.Header.Caption = "Contact Job Title"
        UltraGridColumn9.Header.VisiblePosition = 8
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance10
        UltraGridColumn10.Header.Caption = "Telephone Area Code"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(117, 0)
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance11
        UltraGridColumn11.Header.Caption = "Telephone Subscriber"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(117, 0)
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance12
        UltraGridColumn12.Header.Caption = "Fax Area Code"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance13
        UltraGridColumn13.Header.Caption = "Fax Subscriber"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance14
        UltraGridColumn14.Header.Caption = "Company Postal Code"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(120, 0)
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance15
        UltraGridColumn15.Header.Caption = "Contact Email"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance16
        UltraGridColumn16.Header.Caption = "Industry"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgE1_Chua_PH_XLS.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgE1_Chua_PH_XLS.DisplayLayout.InterBandSpacing = 10
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.CardAreaAppearance = Appearance17
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.ForeColor = System.Drawing.Color.Black
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance18.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance19.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.RowAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.RowSelectorAppearance = Appearance20
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance21.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Chua_PH_XLS.DisplayLayout.Override.SelectedRowAppearance = Appearance21
        Me.dgE1_Chua_PH_XLS.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Chua_PH_XLS.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Chua_PH_XLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Chua_PH_XLS.Location = New System.Drawing.Point(2, 0)
        Me.dgE1_Chua_PH_XLS.Name = "dgE1_Chua_PH_XLS"
        Me.dgE1_Chua_PH_XLS.Size = New System.Drawing.Size(744, 360)
        Me.dgE1_Chua_PH_XLS.TabIndex = 9
        Me.dgE1_Chua_PH_XLS.Text = "Danh sách E1 xuất từ Exel"
        '
        'dgE1_Chua_PH
        '
        Me.dgE1_Chua_PH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgE1_Chua_PH.DisplayLayout.AddNewBox.Prompt = " "
        Appearance22.BackColor = System.Drawing.Color.White
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Chua_PH.DisplayLayout.Appearance = Appearance22
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance23
        UltraGridColumn17.Header.Caption = "Id E1"
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance24
        UltraGridColumn18.Header.Caption = "ID Đường Thư"
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance25
        UltraGridColumn19.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance26
        UltraGridColumn20.Header.Caption = "ID_E2"
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance27
        UltraGridColumn21.Header.Caption = "ID Ca"
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Hidden = True
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn22.Header.Appearance = Appearance28
        UltraGridColumn22.Header.Caption = "Bưu Cục Khai Thác"
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance29
        UltraGridColumn23.Header.Caption = "Mã E1"
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.MaskInput = ""
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Width = 13
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.CellAppearance = Appearance30
        UltraGridColumn24.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn24.EditorControl = Me.dtpNgayDinhDang
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance31
        UltraGridColumn24.Header.Caption = "Ngày Phát Hành"
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn24.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn24.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.UseEditorMaskSettings = True
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.CellAppearance = Appearance32
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance33
        UltraGridColumn25.Header.Caption = "Giờ Phát Hành"
        UltraGridColumn25.Header.VisiblePosition = 8
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.UseEditorMaskSettings = True
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.CellAppearance = Appearance34
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.Header.Appearance = Appearance35
        UltraGridColumn26.Header.Caption = "Ngày Đóng"
        UltraGridColumn26.Header.VisiblePosition = 9
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn26.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn26.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.CellAppearance = Appearance36
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.Header.Appearance = Appearance37
        UltraGridColumn27.Header.Caption = "Giờ Đóng"
        UltraGridColumn27.Header.VisiblePosition = 10
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.UseEditorMaskSettings = True
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.CellAppearance = Appearance38
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.Header.Appearance = Appearance39
        UltraGridColumn28.Header.Caption = "Ngày Nhận"
        UltraGridColumn28.Header.VisiblePosition = 11
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn28.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn28.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn29.CellAppearance = Appearance40
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn29.Header.Appearance = Appearance41
        UltraGridColumn29.Header.Caption = "Giờ Nhận"
        UltraGridColumn29.Header.VisiblePosition = 12
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.UseEditorMaskSettings = True
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.Header.Appearance = Appearance42
        UltraGridColumn30.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn30.Header.VisiblePosition = 13
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.Header.Appearance = Appearance43
        UltraGridColumn31.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn31.Header.VisiblePosition = 14
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance44.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn32.Header.Appearance = Appearance44
        UltraGridColumn32.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn32.Header.VisiblePosition = 15
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance45
        UltraGridColumn33.Header.Caption = "Nước Nhận"
        UltraGridColumn33.Header.VisiblePosition = 16
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance46.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.Header.Appearance = Appearance46
        UltraGridColumn34.Header.Caption = "Nước Trả"
        UltraGridColumn34.Header.VisiblePosition = 17
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance47.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance47
        UltraGridColumn35.Header.Caption = "Khối Lượng"
        UltraGridColumn35.Header.VisiblePosition = 18
        UltraGridColumn35.MaskInput = ""
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Width = 8
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance48.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance48
        UltraGridColumn36.Header.Caption = "Phân Loại"
        UltraGridColumn36.Header.VisiblePosition = 19
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance49.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance49
        UltraGridColumn37.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn37.Header.VisiblePosition = 20
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.Header.Appearance = Appearance50
        UltraGridColumn38.Header.Caption = "Khối Lượng QD"
        UltraGridColumn38.Header.VisiblePosition = 21
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance51
        UltraGridColumn39.Header.Caption = "Loại"
        UltraGridColumn39.Header.VisiblePosition = 22
        UltraGridColumn39.MaskInput = "9"
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Width = 100
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance52
        UltraGridColumn40.Header.Caption = "Dv Cộng Thêm"
        UltraGridColumn40.Header.VisiblePosition = 23
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn41.Header.Appearance = Appearance53
        UltraGridColumn41.Header.Caption = "Dv Gia Tăng"
        UltraGridColumn41.Header.VisiblePosition = 24
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance54.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn42.Header.Appearance = Appearance54
        UltraGridColumn42.Header.Caption = "PP Xăng Dầu"
        UltraGridColumn42.Header.VisiblePosition = 25
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn43.Header.Appearance = Appearance55
        UltraGridColumn43.Header.Caption = "Cước PP Xăng Dầu"
        UltraGridColumn43.Header.VisiblePosition = 26
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance56
        UltraGridColumn44.Header.VisiblePosition = 27
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance57
        UltraGridColumn45.Header.Caption = "Cước PP Vùng Xa"
        UltraGridColumn45.Header.VisiblePosition = 28
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance58
        UltraGridColumn46.Header.Caption = "Thuế VAT"
        UltraGridColumn46.Header.VisiblePosition = 29
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.Header.Appearance = Appearance59
        UltraGridColumn47.Header.Caption = "Dv COD"
        UltraGridColumn47.Header.VisiblePosition = 30
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn48.Header.Appearance = Appearance60
        UltraGridColumn48.Header.Caption = "Giá Trị Hàng"
        UltraGridColumn48.Header.VisiblePosition = 31
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance61.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.Header.Appearance = Appearance61
        UltraGridColumn49.Header.Caption = "Cước COD"
        UltraGridColumn49.Header.VisiblePosition = 32
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.Header.Appearance = Appearance62
        UltraGridColumn50.Header.Caption = "Cước DV"
        UltraGridColumn50.Header.VisiblePosition = 33
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.Header.Appearance = Appearance63
        UltraGridColumn51.Header.Caption = "Cước Chính"
        UltraGridColumn51.Header.VisiblePosition = 34
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.Header.Appearance = Appearance64
        UltraGridColumn52.Header.Caption = "Cước Giảm"
        UltraGridColumn52.Header.VisiblePosition = 35
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn53.Header.Appearance = Appearance65
        UltraGridColumn53.Header.Caption = "Cước E1"
        UltraGridColumn53.Header.VisiblePosition = 36
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn54.Header.Appearance = Appearance66
        UltraGridColumn54.Header.Caption = "Kiện Số"
        UltraGridColumn54.Header.VisiblePosition = 37
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn55.Header.Appearance = Appearance67
        UltraGridColumn55.Header.VisiblePosition = 38
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(29, 0)
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn56.Header.Appearance = Appearance68
        UltraGridColumn56.Header.Caption = "Mã KH"
        UltraGridColumn56.Header.VisiblePosition = 39
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn57.Header.Appearance = Appearance69
        UltraGridColumn57.Header.Caption = "Người Gửi"
        UltraGridColumn57.Header.VisiblePosition = 40
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance70.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn58.Header.Appearance = Appearance70
        UltraGridColumn58.Header.Caption = "Người Nhận"
        UltraGridColumn58.Header.VisiblePosition = 41
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn59.Header.Appearance = Appearance71
        UltraGridColumn59.Header.Caption = "Địa Chỉ Gửi"
        UltraGridColumn59.Header.VisiblePosition = 42
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 60
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.Header.Appearance = Appearance72
        UltraGridColumn60.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn60.Header.VisiblePosition = 43
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance73.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn61.Header.Appearance = Appearance73
        UltraGridColumn61.Header.Caption = "ĐT Gửi"
        UltraGridColumn61.Header.VisiblePosition = 44
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.Header.Appearance = Appearance74
        UltraGridColumn62.Header.Caption = "ĐT Nhận"
        UltraGridColumn62.Header.VisiblePosition = 45
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance75.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.Header.Appearance = Appearance75
        UltraGridColumn63.Header.Caption = "HH Phát Hành"
        UltraGridColumn63.Header.VisiblePosition = 46
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance76.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn64.Header.Appearance = Appearance76
        UltraGridColumn64.Header.Caption = "HH Phát Trả"
        UltraGridColumn64.Header.VisiblePosition = 47
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance77.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn65.Header.Appearance = Appearance77
        UltraGridColumn65.Header.Caption = "BC Chuyển hoàn"
        UltraGridColumn65.Header.VisiblePosition = 48
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance78.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn66.Header.Appearance = Appearance78
        UltraGridColumn66.Header.Caption = "ID Người Dùng"
        UltraGridColumn66.Header.VisiblePosition = 49
        UltraGridColumn66.Hidden = True
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn67.Header.Caption = "ID Trạng Thái"
        UltraGridColumn67.Header.VisiblePosition = 50
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance79.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn68.Header.Appearance = Appearance79
        UltraGridColumn68.Header.Caption = "Ghi Chú"
        UltraGridColumn68.Header.VisiblePosition = 51
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 62
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn69.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance80.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn69.Header.Appearance = Appearance80
        UltraGridColumn69.Header.VisiblePosition = 52
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn69.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn69.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn69.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn70.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance81.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn70.Header.Appearance = Appearance81
        UltraGridColumn70.Header.VisiblePosition = 53
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn70.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn70.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn70.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn71.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance82.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn71.Header.Appearance = Appearance82
        UltraGridColumn71.Header.VisiblePosition = 54
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn71.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn71.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn71.RowLayoutColumnInfo.SpanY = 2
        Appearance83.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.CellAppearance = Appearance83
        Appearance84.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.Header.Appearance = Appearance84
        UltraGridColumn72.Header.Caption = "Chọn"
        UltraGridColumn72.Header.VisiblePosition = 55
        UltraGridColumn72.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn72.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn72.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(36, 0)
        UltraGridColumn72.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn72.RowLayoutColumnInfo.SpanY = 2
        Appearance85.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.CellAppearance = Appearance85
        Appearance86.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.Header.Appearance = Appearance86
        UltraGridColumn73.Header.Caption = "Số TKHQ"
        UltraGridColumn73.Header.VisiblePosition = 56
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn73.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn73.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn73.RowLayoutColumnInfo.SpanY = 2
        Appearance87.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn74.CellAppearance = Appearance87
        Appearance88.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn74.Header.Appearance = Appearance88
        UltraGridColumn74.Header.Caption = "Số biên lai"
        UltraGridColumn74.Header.VisiblePosition = 57
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn74.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn74.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn74.RowLayoutColumnInfo.SpanY = 2
        Appearance89.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.CellAppearance = Appearance89
        Appearance90.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.Header.Appearance = Appearance90
        UltraGridColumn75.Header.Caption = "Lệ phí HQ"
        UltraGridColumn75.Header.VisiblePosition = 58
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn75.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn75.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn75.RowLayoutColumnInfo.SpanY = 2
        Appearance91.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.CellAppearance = Appearance91
        Appearance92.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.Header.Appearance = Appearance92
        UltraGridColumn76.Header.Caption = "Thuế NK"
        UltraGridColumn76.Header.VisiblePosition = 59
        UltraGridColumn76.Hidden = True
        UltraGridColumn76.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn76.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn76.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn76.RowLayoutColumnInfo.SpanY = 2
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.CellAppearance = Appearance93
        Appearance94.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.Header.Appearance = Appearance94
        UltraGridColumn77.Header.Caption = "Thuế VAT"
        UltraGridColumn77.Header.VisiblePosition = 60
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn77.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn77.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn77.RowLayoutColumnInfo.SpanY = 2
        Appearance95.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.CellAppearance = Appearance95
        Appearance96.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.Header.Appearance = Appearance96
        UltraGridColumn78.Header.Caption = "Thuế NK VAT"
        UltraGridColumn78.Header.VisiblePosition = 61
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn78.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn78.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn78.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78})
        UltraGridBand2.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgE1_Chua_PH.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgE1_Chua_PH.DisplayLayout.InterBandSpacing = 10
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Chua_PH.DisplayLayout.Override.CardAreaAppearance = Appearance97
        Me.dgE1_Chua_PH.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance98.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance98.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance98.ForeColor = System.Drawing.Color.Black
        Appearance98.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance98.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Chua_PH.DisplayLayout.Override.HeaderAppearance = Appearance98
        Me.dgE1_Chua_PH.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance99.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Chua_PH.DisplayLayout.Override.RowAppearance = Appearance99
        Appearance100.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance100.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Chua_PH.DisplayLayout.Override.RowSelectorAppearance = Appearance100
        Me.dgE1_Chua_PH.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Chua_PH.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance101.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance101.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance101.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Chua_PH.DisplayLayout.Override.SelectedRowAppearance = Appearance101
        Me.dgE1_Chua_PH.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Chua_PH.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Chua_PH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Chua_PH.Location = New System.Drawing.Point(0, 0)
        Me.dgE1_Chua_PH.Name = "dgE1_Chua_PH"
        Me.dgE1_Chua_PH.Size = New System.Drawing.Size(744, 360)
        Me.dgE1_Chua_PH.TabIndex = 8
        Me.dgE1_Chua_PH.Text = "Danh sách E1 chưa đang chờ phân hướng"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.dgE1_Da_PH)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(748, 364)
        '
        'dgE1_Da_PH
        '
        Me.dgE1_Da_PH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgE1_Da_PH.DisplayLayout.AddNewBox.Prompt = " "
        Appearance102.BackColor = System.Drawing.Color.White
        Appearance102.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Da_PH.DisplayLayout.Appearance = Appearance102
        UltraGridColumn79.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance103.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn79.Header.Appearance = Appearance103
        UltraGridColumn79.Header.Caption = "Id E1"
        UltraGridColumn79.Header.VisiblePosition = 0
        UltraGridColumn79.Hidden = True
        UltraGridColumn79.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn79.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn79.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn79.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn80.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance104.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn80.Header.Appearance = Appearance104
        UltraGridColumn80.Header.Caption = "ID Đường Thư"
        UltraGridColumn80.Header.VisiblePosition = 1
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn80.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn80.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn80.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance105.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn81.Header.Appearance = Appearance105
        UltraGridColumn81.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn81.Header.VisiblePosition = 2
        UltraGridColumn81.Hidden = True
        UltraGridColumn81.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn81.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn81.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn81.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn82.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance106.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn82.Header.Appearance = Appearance106
        UltraGridColumn82.Header.Caption = "ID_E2"
        UltraGridColumn82.Header.VisiblePosition = 3
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn82.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn82.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn82.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance107.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn83.Header.Appearance = Appearance107
        UltraGridColumn83.Header.Caption = "ID Ca"
        UltraGridColumn83.Header.VisiblePosition = 4
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn83.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn83.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn83.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance108.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn84.Header.Appearance = Appearance108
        UltraGridColumn84.Header.Caption = "Bưu Cục Khai Thác"
        UltraGridColumn84.Header.VisiblePosition = 5
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn84.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn84.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn84.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn85.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance109.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn85.Header.Appearance = Appearance109
        UltraGridColumn85.Header.Caption = "Mã E1"
        UltraGridColumn85.Header.VisiblePosition = 6
        UltraGridColumn85.MaskInput = ""
        UltraGridColumn85.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn85.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn85.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn85.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn85.Width = 13
        UltraGridColumn86.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance110.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.CellAppearance = Appearance110
        UltraGridColumn86.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn86.EditorControl = Me.dtpNgayDinhDang
        Appearance111.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.Header.Appearance = Appearance111
        UltraGridColumn86.Header.Caption = "Ngày Phát Hành"
        UltraGridColumn86.Header.VisiblePosition = 7
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn86.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn86.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn86.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn86.UseEditorMaskSettings = True
        UltraGridColumn87.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance112.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.CellAppearance = Appearance112
        Appearance113.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.Header.Appearance = Appearance113
        UltraGridColumn87.Header.Caption = "Giờ Phát Hành"
        UltraGridColumn87.Header.VisiblePosition = 8
        UltraGridColumn87.Hidden = True
        UltraGridColumn87.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn87.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn87.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn87.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn87.UseEditorMaskSettings = True
        UltraGridColumn88.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance114.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.CellAppearance = Appearance114
        Appearance115.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance115
        UltraGridColumn88.Header.Caption = "Ngày Đóng"
        UltraGridColumn88.Header.VisiblePosition = 9
        UltraGridColumn88.Hidden = True
        UltraGridColumn88.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn88.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn88.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn88.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn88.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn88.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn88.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn89.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance116.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn89.CellAppearance = Appearance116
        Appearance117.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn89.Header.Appearance = Appearance117
        UltraGridColumn89.Header.Caption = "Giờ Đóng"
        UltraGridColumn89.Header.VisiblePosition = 10
        UltraGridColumn89.Hidden = True
        UltraGridColumn89.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn89.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn89.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn89.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn89.UseEditorMaskSettings = True
        UltraGridColumn90.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance118.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.CellAppearance = Appearance118
        Appearance119.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.Header.Appearance = Appearance119
        UltraGridColumn90.Header.Caption = "Ngày Nhận"
        UltraGridColumn90.Header.VisiblePosition = 11
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn90.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn90.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn90.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn90.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn90.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn90.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn91.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance120.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.CellAppearance = Appearance120
        Appearance121.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.Header.Appearance = Appearance121
        UltraGridColumn91.Header.Caption = "Giờ Nhận"
        UltraGridColumn91.Header.VisiblePosition = 12
        UltraGridColumn91.Hidden = True
        UltraGridColumn91.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn91.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn91.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn91.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn91.UseEditorMaskSettings = True
        UltraGridColumn92.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance122.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.Header.Appearance = Appearance122
        UltraGridColumn92.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn92.Header.VisiblePosition = 13
        UltraGridColumn92.Hidden = True
        UltraGridColumn92.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn92.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn92.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn92.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance123.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn93.Header.Appearance = Appearance123
        UltraGridColumn93.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn93.Header.VisiblePosition = 14
        UltraGridColumn93.Hidden = True
        UltraGridColumn93.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn93.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn93.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn93.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance124.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn94.Header.Appearance = Appearance124
        UltraGridColumn94.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn94.Header.VisiblePosition = 15
        UltraGridColumn94.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn94.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn94.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn94.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance125.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn95.Header.Appearance = Appearance125
        UltraGridColumn95.Header.Caption = "Nước Nhận"
        UltraGridColumn95.Header.VisiblePosition = 16
        UltraGridColumn95.Hidden = True
        UltraGridColumn95.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn95.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn95.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn95.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn96.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance126.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn96.Header.Appearance = Appearance126
        UltraGridColumn96.Header.Caption = "Nước Trả"
        UltraGridColumn96.Header.VisiblePosition = 17
        UltraGridColumn96.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn96.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn96.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn96.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn97.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance127.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn97.Header.Appearance = Appearance127
        UltraGridColumn97.Header.Caption = "Khối Lượng"
        UltraGridColumn97.Header.VisiblePosition = 18
        UltraGridColumn97.MaskInput = ""
        UltraGridColumn97.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn97.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn97.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn97.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn97.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn97.Width = 8
        UltraGridColumn98.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance128.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn98.Header.Appearance = Appearance128
        UltraGridColumn98.Header.Caption = "Phân Loại"
        UltraGridColumn98.Header.VisiblePosition = 19
        UltraGridColumn98.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn98.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn98.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn98.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn98.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance129.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn99.Header.Appearance = Appearance129
        UltraGridColumn99.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn99.Header.VisiblePosition = 20
        UltraGridColumn99.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn99.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn99.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn99.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn99.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance130.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn100.Header.Appearance = Appearance130
        UltraGridColumn100.Header.Caption = "Khối Lượng QD"
        UltraGridColumn100.Header.VisiblePosition = 21
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn100.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn100.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn100.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn101.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance131.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn101.Header.Appearance = Appearance131
        UltraGridColumn101.Header.Caption = "Loại"
        UltraGridColumn101.Header.VisiblePosition = 22
        UltraGridColumn101.MaskInput = "9"
        UltraGridColumn101.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn101.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn101.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn101.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn101.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn101.Width = 100
        UltraGridColumn102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance132.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn102.Header.Appearance = Appearance132
        UltraGridColumn102.Header.Caption = "Dv Cộng Thêm"
        UltraGridColumn102.Header.VisiblePosition = 23
        UltraGridColumn102.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn102.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn102.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn102.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn103.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance133.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn103.Header.Appearance = Appearance133
        UltraGridColumn103.Header.Caption = "Dv Gia Tăng"
        UltraGridColumn103.Header.VisiblePosition = 24
        UltraGridColumn103.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn103.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn103.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn103.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn104.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance134.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn104.Header.Appearance = Appearance134
        UltraGridColumn104.Header.Caption = "PP Xăng Dầu"
        UltraGridColumn104.Header.VisiblePosition = 25
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn104.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn104.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn104.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn105.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance135.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn105.Header.Appearance = Appearance135
        UltraGridColumn105.Header.Caption = "Cước PP Xăng Dầu"
        UltraGridColumn105.Header.VisiblePosition = 26
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn105.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn105.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn105.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn106.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance136.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn106.Header.Appearance = Appearance136
        UltraGridColumn106.Header.VisiblePosition = 27
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn106.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn106.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn106.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance137.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn107.Header.Appearance = Appearance137
        UltraGridColumn107.Header.Caption = "Cước PP Vùng Xa"
        UltraGridColumn107.Header.VisiblePosition = 28
        UltraGridColumn107.Hidden = True
        UltraGridColumn107.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn107.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn107.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn107.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn108.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance138.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn108.Header.Appearance = Appearance138
        UltraGridColumn108.Header.Caption = "Thuế VAT"
        UltraGridColumn108.Header.VisiblePosition = 29
        UltraGridColumn108.Hidden = True
        UltraGridColumn108.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn108.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn108.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn108.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn109.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance139.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn109.Header.Appearance = Appearance139
        UltraGridColumn109.Header.Caption = "Dv COD"
        UltraGridColumn109.Header.VisiblePosition = 30
        UltraGridColumn109.Hidden = True
        UltraGridColumn109.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn109.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn109.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn109.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn110.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance140.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn110.Header.Appearance = Appearance140
        UltraGridColumn110.Header.Caption = "Giá Trị Hàng"
        UltraGridColumn110.Header.VisiblePosition = 31
        UltraGridColumn110.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn110.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn110.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn110.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn111.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance141.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn111.Header.Appearance = Appearance141
        UltraGridColumn111.Header.Caption = "Cước COD"
        UltraGridColumn111.Header.VisiblePosition = 32
        UltraGridColumn111.Hidden = True
        UltraGridColumn111.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn111.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn111.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn111.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance142.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn112.Header.Appearance = Appearance142
        UltraGridColumn112.Header.Caption = "Cước DV"
        UltraGridColumn112.Header.VisiblePosition = 33
        UltraGridColumn112.Hidden = True
        UltraGridColumn112.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn112.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn112.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn112.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn113.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance143.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.Header.Appearance = Appearance143
        UltraGridColumn113.Header.Caption = "Cước Chính"
        UltraGridColumn113.Header.VisiblePosition = 34
        UltraGridColumn113.Hidden = True
        UltraGridColumn113.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn113.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn113.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn113.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn114.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance144.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn114.Header.Appearance = Appearance144
        UltraGridColumn114.Header.Caption = "Cước Giảm"
        UltraGridColumn114.Header.VisiblePosition = 35
        UltraGridColumn114.Hidden = True
        UltraGridColumn114.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn114.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn114.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn114.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn115.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance145.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn115.Header.Appearance = Appearance145
        UltraGridColumn115.Header.Caption = "Cước E1"
        UltraGridColumn115.Header.VisiblePosition = 36
        UltraGridColumn115.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn115.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn115.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn115.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn115.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance146.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn116.Header.Appearance = Appearance146
        UltraGridColumn116.Header.Caption = "Kiện Số"
        UltraGridColumn116.Header.VisiblePosition = 37
        UltraGridColumn116.Hidden = True
        UltraGridColumn116.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn116.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn116.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn116.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn117.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance147.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn117.Header.Appearance = Appearance147
        UltraGridColumn117.Header.Caption = "Mã KH"
        UltraGridColumn117.Header.VisiblePosition = 39
        UltraGridColumn117.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn117.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn117.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn117.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn118.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance148.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn118.Header.Appearance = Appearance148
        UltraGridColumn118.Header.Caption = "Người Gửi"
        UltraGridColumn118.Header.VisiblePosition = 40
        UltraGridColumn118.Hidden = True
        UltraGridColumn118.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn118.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn118.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn118.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance149.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn119.Header.Appearance = Appearance149
        UltraGridColumn119.Header.Caption = "Người Nhận"
        UltraGridColumn119.Header.VisiblePosition = 41
        UltraGridColumn119.Hidden = True
        UltraGridColumn119.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn119.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn119.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn119.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn120.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance150.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn120.Header.Appearance = Appearance150
        UltraGridColumn120.Header.Caption = "Địa Chỉ Gửi"
        UltraGridColumn120.Header.VisiblePosition = 42
        UltraGridColumn120.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn120.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn120.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn120.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn121.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance151.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn121.Header.Appearance = Appearance151
        UltraGridColumn121.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn121.Header.VisiblePosition = 43
        UltraGridColumn121.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn121.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn121.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn121.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn122.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance152.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn122.Header.Appearance = Appearance152
        UltraGridColumn122.Header.Caption = "ĐT Gửi"
        UltraGridColumn122.Header.VisiblePosition = 44
        UltraGridColumn122.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn122.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn122.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn122.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn123.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance153.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn123.Header.Appearance = Appearance153
        UltraGridColumn123.Header.Caption = "ĐT Nhận"
        UltraGridColumn123.Header.VisiblePosition = 45
        UltraGridColumn123.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn123.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn123.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn123.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn124.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance154.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn124.Header.Appearance = Appearance154
        UltraGridColumn124.Header.Caption = "HH Phát Hành"
        UltraGridColumn124.Header.VisiblePosition = 46
        UltraGridColumn124.Hidden = True
        UltraGridColumn124.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn124.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn124.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn124.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn125.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance155.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn125.Header.Appearance = Appearance155
        UltraGridColumn125.Header.Caption = "HH Phát Trả"
        UltraGridColumn125.Header.VisiblePosition = 47
        UltraGridColumn125.Hidden = True
        UltraGridColumn125.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn125.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn125.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn125.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn126.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance156.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn126.Header.Appearance = Appearance156
        UltraGridColumn126.Header.Caption = "BC Chuyển hoàn"
        UltraGridColumn126.Header.VisiblePosition = 48
        UltraGridColumn126.Hidden = True
        UltraGridColumn126.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn126.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn126.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn126.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn127.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance157.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn127.Header.Appearance = Appearance157
        UltraGridColumn127.Header.Caption = "ID Người Dùng"
        UltraGridColumn127.Header.VisiblePosition = 49
        UltraGridColumn127.Hidden = True
        UltraGridColumn127.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn127.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn127.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn127.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn128.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn128.Header.Caption = "ID Trạng Thái"
        UltraGridColumn128.Header.VisiblePosition = 50
        UltraGridColumn128.Hidden = True
        UltraGridColumn128.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn128.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn128.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn128.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance158.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn129.Header.Appearance = Appearance158
        UltraGridColumn129.Header.Caption = "Ghi Chú"
        UltraGridColumn129.Header.VisiblePosition = 51
        UltraGridColumn129.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn129.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn129.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn129.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn130.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance159.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn130.Header.Appearance = Appearance159
        UltraGridColumn130.Header.VisiblePosition = 52
        UltraGridColumn130.Hidden = True
        UltraGridColumn130.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn130.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn130.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn130.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn131.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance160.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn131.Header.Appearance = Appearance160
        UltraGridColumn131.Header.VisiblePosition = 53
        UltraGridColumn131.Hidden = True
        UltraGridColumn131.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn131.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn131.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn131.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance161.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn132.Header.Appearance = Appearance161
        UltraGridColumn132.Header.VisiblePosition = 54
        UltraGridColumn132.Hidden = True
        UltraGridColumn132.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn132.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn132.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn132.RowLayoutColumnInfo.SpanY = 2
        Appearance162.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn133.CellAppearance = Appearance162
        Appearance163.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn133.Header.Appearance = Appearance163
        UltraGridColumn133.Header.Caption = "Chọn"
        UltraGridColumn133.Header.VisiblePosition = 55
        UltraGridColumn133.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn133.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn133.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(40, 0)
        UltraGridColumn133.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn133.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn134.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance164.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn134.Header.Appearance = Appearance164
        UltraGridColumn134.Header.VisiblePosition = 38
        UltraGridColumn134.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn134.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn134.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(32, 0)
        UltraGridColumn134.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn134.RowLayoutColumnInfo.SpanY = 2
        Appearance165.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn135.Header.Appearance = Appearance165
        UltraGridColumn135.Header.Caption = "Số TKHQ"
        UltraGridColumn135.Header.VisiblePosition = 56
        UltraGridColumn135.Hidden = True
        UltraGridColumn135.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn135.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn135.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn135.RowLayoutColumnInfo.SpanY = 2
        Appearance166.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn136.Header.Appearance = Appearance166
        UltraGridColumn136.Header.Caption = "Số biên lai"
        UltraGridColumn136.Header.VisiblePosition = 57
        UltraGridColumn136.Hidden = True
        UltraGridColumn136.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn136.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn136.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn136.RowLayoutColumnInfo.SpanY = 2
        Appearance167.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn137.Header.Appearance = Appearance167
        UltraGridColumn137.Header.Caption = "Lệ phí HQ"
        UltraGridColumn137.Header.VisiblePosition = 58
        UltraGridColumn137.Hidden = True
        UltraGridColumn137.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn137.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn137.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn137.RowLayoutColumnInfo.SpanY = 2
        Appearance168.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn138.Header.Appearance = Appearance168
        UltraGridColumn138.Header.Caption = "Thuế NK"
        UltraGridColumn138.Header.VisiblePosition = 59
        UltraGridColumn138.Hidden = True
        UltraGridColumn138.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn138.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn138.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn138.RowLayoutColumnInfo.SpanY = 2
        Appearance169.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn139.Header.Appearance = Appearance169
        UltraGridColumn139.Header.Caption = "Thuế VAT"
        UltraGridColumn139.Header.VisiblePosition = 60
        UltraGridColumn139.Hidden = True
        UltraGridColumn139.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn139.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn139.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn139.RowLayoutColumnInfo.SpanY = 2
        Appearance170.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn140.Header.Appearance = Appearance170
        UltraGridColumn140.Header.Caption = "Thuế NK VAT"
        UltraGridColumn140.Header.VisiblePosition = 61
        UltraGridColumn140.Hidden = True
        UltraGridColumn140.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn140.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn140.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn140.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140})
        UltraGridBand3.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.dgE1_Da_PH.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgE1_Da_PH.DisplayLayout.InterBandSpacing = 10
        Appearance171.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Da_PH.DisplayLayout.Override.CardAreaAppearance = Appearance171
        Me.dgE1_Da_PH.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance172.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance172.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance172.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance172.ForeColor = System.Drawing.Color.Black
        Appearance172.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance172.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Da_PH.DisplayLayout.Override.HeaderAppearance = Appearance172
        Me.dgE1_Da_PH.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance173.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Da_PH.DisplayLayout.Override.RowAppearance = Appearance173
        Appearance174.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance174.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Da_PH.DisplayLayout.Override.RowSelectorAppearance = Appearance174
        Me.dgE1_Da_PH.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Da_PH.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance175.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance175.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance175.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance175.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Da_PH.DisplayLayout.Override.SelectedRowAppearance = Appearance175
        Me.dgE1_Da_PH.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Da_PH.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Da_PH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Da_PH.Location = New System.Drawing.Point(0, -2)
        Me.dgE1_Da_PH.Name = "dgE1_Da_PH"
        Me.dgE1_Da_PH.Size = New System.Drawing.Size(744, 362)
        Me.dgE1_Da_PH.TabIndex = 9
        Me.dgE1_Da_PH.Text = "Danh sách E1 đã được phân hướng"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.prbTien_Trinh)
        Me.UltraTabPageControl1.Controls.Add(Me.btnDelete)
        Me.UltraTabPageControl1.Controls.Add(Me.txtsoban)
        Me.UltraTabPageControl1.Controls.Add(Me.btnPreview)
        Me.UltraTabPageControl1.Controls.Add(Me.btnkeys)
        Me.UltraTabPageControl1.Controls.Add(Me.txtThong_Tin)
        Me.UltraTabPageControl1.Controls.Add(Me.cbLua_Chon_In)
        Me.UltraTabPageControl1.Controls.Add(Me.btnThoat)
        Me.UltraTabPageControl1.Controls.Add(Me.btnThem_Vao_Tui)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox11)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox12)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox13)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel21)
        Me.UltraTabPageControl1.Controls.Add(Me.chkGiay_A5_Co_San)
        Me.UltraTabPageControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UltraTabPageControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 26)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(764, 604)
        '
        'prbTien_Trinh
        '
        Me.prbTien_Trinh.Location = New System.Drawing.Point(8, 568)
        Me.prbTien_Trinh.Name = "prbTien_Trinh"
        Me.prbTien_Trinh.Size = New System.Drawing.Size(744, 32)
        Me.prbTien_Trinh.TabIndex = 20
        Me.prbTien_Trinh.Text = "[Formatted]"
        '
        'btnDelete
        '
        Appearance176.FontData.BoldAsString = "True"
        Appearance176.Image = CType(resources.GetObject("Appearance176.Image"), Object)
        Me.btnDelete.Appearance = Appearance176
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnDelete.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(312, 528)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 32)
        Me.btnDelete.TabIndex = 14
        '
        'txtsoban
        '
        Me.txtsoban.Location = New System.Drawing.Point(120, 523)
        Me.txtsoban.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtsoban.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtsoban.Name = "txtsoban"
        Me.txtsoban.Size = New System.Drawing.Size(40, 23)
        Me.txtsoban.TabIndex = 12
        Me.txtsoban.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'btnPreview
        '
        Appearance177.FontData.BoldAsString = "True"
        Appearance177.Image = CType(resources.GetObject("Appearance177.Image"), Object)
        Me.btnPreview.Appearance = Appearance177
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview.Location = New System.Drawing.Point(376, 528)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(56, 32)
        Me.btnPreview.TabIndex = 15
        '
        'btnkeys
        '
        Appearance178.Image = CType(resources.GetObject("Appearance178.Image"), Object)
        Appearance178.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance178.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnkeys.Appearance = Appearance178
        Me.btnkeys.Enabled = False
        Me.btnkeys.Location = New System.Drawing.Point(440, 528)
        Me.btnkeys.Name = "btnkeys"
        Me.btnkeys.Size = New System.Drawing.Size(32, 32)
        Me.btnkeys.TabIndex = 16
        '
        'txtThong_Tin
        '
        Appearance179.BackColor = System.Drawing.Color.Black
        Appearance179.ForeColor = System.Drawing.Color.Lime
        Appearance179.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance179.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.txtThong_Tin.Appearance = Appearance179
        Me.txtThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance180.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance180.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.txtThong_Tin.HotTrackAppearance = Appearance180
        Me.txtThong_Tin.Location = New System.Drawing.Point(560, 528)
        Me.txtThong_Tin.Name = "txtThong_Tin"
        Me.txtThong_Tin.Size = New System.Drawing.Size(200, 32)
        Me.txtThong_Tin.TabIndex = 18
        '
        'cbLua_Chon_In
        '
        Me.cbLua_Chon_In.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn141.Header.VisiblePosition = 0
        UltraGridColumn141.Hidden = True
        Appearance181.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn142.Header.Appearance = Appearance181
        UltraGridColumn142.Header.Caption = "Lựa chọn in"
        UltraGridColumn142.Header.VisiblePosition = 1
        UltraGridColumn142.Width = 250
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn141, UltraGridColumn142})
        UltraGridBand4.Header.Caption = "Mã Đường Thư"
        Me.cbLua_Chon_In.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance182.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance182.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance182.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance182.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance182.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbLua_Chon_In.DisplayLayout.Override.HeaderAppearance = Appearance182
        Me.cbLua_Chon_In.DisplayMember = "Ten_In"
        Me.cbLua_Chon_In.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbLua_Chon_In.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLua_Chon_In.Location = New System.Drawing.Point(8, 523)
        Me.cbLua_Chon_In.Name = "cbLua_Chon_In"
        Me.cbLua_Chon_In.Size = New System.Drawing.Size(56, 21)
        Me.cbLua_Chon_In.TabIndex = 10
        Me.cbLua_Chon_In.ValueMember = "Ma_In"
        Me.cbLua_Chon_In.Visible = False
        '
        'btnThoat
        '
        Appearance183.Image = CType(resources.GetObject("Appearance183.Image"), Object)
        Me.btnThoat.Appearance = Appearance183
        Me.btnThoat.Location = New System.Drawing.Point(480, 528)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(72, 32)
        Me.btnThoat.TabIndex = 17
        Me.btnThoat.Text = "&Thoát"
        '
        'btnThem_Vao_Tui
        '
        Appearance184.Image = CType(resources.GetObject("Appearance184.Image"), Object)
        Me.btnThem_Vao_Tui.Appearance = Appearance184
        Me.btnThem_Vao_Tui.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem_Vao_Tui.Location = New System.Drawing.Point(168, 528)
        Me.btnThem_Vao_Tui.Name = "btnThem_Vao_Tui"
        Me.btnThem_Vao_Tui.Size = New System.Drawing.Size(136, 32)
        Me.btnThem_Vao_Tui.TabIndex = 13
        Me.btnThem_Vao_Tui.Text = "F3 - &Ghi và In E1"
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel27)
        Me.UltraGroupBox11.Controls.Add(Me.txtThue_Hai_Quan)
        Me.UltraGroupBox11.Controls.Add(Me.btnVung_Xa_TN)
        Me.UltraGroupBox11.Controls.Add(Me.chkVungXaTN)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox11.Controls.Add(Me.chkKhai_Gia)
        Me.UltraGroupBox11.Controls.Add(Me.txtGia_Tri_Hang)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox11.Controls.Add(Me.cbDV_Gia_Tang)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox11.Controls.Add(Me.cbDV_Cong_Them)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox11.Controls.Add(Me.txtCuoc_E1)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox11.Controls.Add(Me.txtCuoc_DV)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox11.Controls.Add(Me.txtCuoc_Chinh)
        Me.UltraGroupBox11.Enabled = False
        Me.UltraGroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox11.Location = New System.Drawing.Point(384, 336)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(376, 184)
        Me.UltraGroupBox11.SupportThemes = False
        Me.UltraGroupBox11.TabIndex = 9
        Me.UltraGroupBox11.Text = "9.Cước:"
        '
        'UltraLabel27
        '
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(176, 157)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel27.TabIndex = 15
        Me.UltraLabel27.Text = "Thuế & lệ phí HQ:"
        '
        'txtThue_Hai_Quan
        '
        Me.txtThue_Hai_Quan.Location = New System.Drawing.Point(272, 152)
        Me.txtThue_Hai_Quan.Name = "txtThue_Hai_Quan"
        Me.txtThue_Hai_Quan.ReadOnly = True
        Me.txtThue_Hai_Quan.Size = New System.Drawing.Size(96, 21)
        Me.txtThue_Hai_Quan.TabIndex = 16
        Me.txtThue_Hai_Quan.Text = "0"
        '
        'btnVung_Xa_TN
        '
        Me.btnVung_Xa_TN.Enabled = False
        Me.btnVung_Xa_TN.Location = New System.Drawing.Point(344, 51)
        Me.btnVung_Xa_TN.Name = "btnVung_Xa_TN"
        Me.btnVung_Xa_TN.Size = New System.Drawing.Size(24, 21)
        Me.btnVung_Xa_TN.TabIndex = 14
        Me.btnVung_Xa_TN.Text = ">"
        '
        'chkVungXaTN
        '
        Me.chkVungXaTN.Enabled = False
        Me.chkVungXaTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVungXaTN.Location = New System.Drawing.Point(240, 56)
        Me.chkVungXaTN.Name = "chkVungXaTN"
        Me.chkVungXaTN.Size = New System.Drawing.Size(96, 16)
        Me.chkVungXaTN.TabIndex = 13
        Me.chkVungXaTN.Text = "Vùng xa"
        '
        'UltraLabel23
        '
        Me.UltraLabel23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(232, 120)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(104, 24)
        Me.UltraLabel23.TabIndex = 10
        Me.UltraLabel23.Text = "( Giá trị hàng )"
        '
        'chkKhai_Gia
        '
        Me.chkKhai_Gia.Enabled = False
        Me.chkKhai_Gia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKhai_Gia.Location = New System.Drawing.Point(112, 120)
        Me.chkKhai_Gia.Name = "chkKhai_Gia"
        Me.chkKhai_Gia.Size = New System.Drawing.Size(20, 16)
        Me.chkKhai_Gia.TabIndex = 8
        '
        'txtGia_Tri_Hang
        '
        Me.txtGia_Tri_Hang.Location = New System.Drawing.Point(136, 120)
        Me.txtGia_Tri_Hang.Name = "txtGia_Tri_Hang"
        Me.txtGia_Tri_Hang.ReadOnly = True
        Me.txtGia_Tri_Hang.Size = New System.Drawing.Size(92, 21)
        Me.txtGia_Tri_Hang.TabIndex = 9
        Me.txtGia_Tri_Hang.Text = "0"
        '
        'UltraLabel22
        '
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(8, 120)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(96, 24)
        Me.UltraLabel22.TabIndex = 7
        Me.UltraLabel22.Text = "Giá trị hàng"
        '
        'cbDV_Gia_Tang
        '
        Me.cbDV_Gia_Tang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance185.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn143.CellAppearance = Appearance185
        Appearance186.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn143.Header.Appearance = Appearance186
        UltraGridColumn143.Header.Caption = "Mã dịch vụ"
        UltraGridColumn143.Header.VisiblePosition = 0
        Appearance187.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn144.CellAppearance = Appearance187
        Appearance188.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn144.Header.Appearance = Appearance188
        UltraGridColumn144.Header.Caption = "Tên dịch vụ"
        UltraGridColumn144.Header.VisiblePosition = 1
        Appearance189.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn145.CellAppearance = Appearance189
        Appearance190.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn145.Header.Appearance = Appearance190
        UltraGridColumn145.Header.Caption = "Phân loại"
        UltraGridColumn145.Header.VisiblePosition = 2
        UltraGridColumn145.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn143, UltraGridColumn144, UltraGridColumn145})
        UltraGridBand5.Header.Caption = "Mã Đường Thư"
        Me.cbDV_Gia_Tang.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance191.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance191.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance191.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance191.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDV_Gia_Tang.DisplayLayout.Override.HeaderAppearance = Appearance191
        Me.cbDV_Gia_Tang.DisplayMember = ""
        Me.cbDV_Gia_Tang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDV_Gia_Tang.Location = New System.Drawing.Point(136, 88)
        Me.cbDV_Gia_Tang.Name = "cbDV_Gia_Tang"
        Me.cbDV_Gia_Tang.ReadOnly = True
        Me.cbDV_Gia_Tang.Size = New System.Drawing.Size(96, 21)
        Me.cbDV_Gia_Tang.TabIndex = 5
        Me.cbDV_Gia_Tang.ValueMember = ""
        '
        'UltraLabel20
        '
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(8, 88)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel20.TabIndex = 4
        Me.UltraLabel20.Text = "Cước DV Gia tăng:"
        '
        'cbDV_Cong_Them
        '
        Me.cbDV_Cong_Them.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance192.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn146.CellAppearance = Appearance192
        Appearance193.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn146.Header.Appearance = Appearance193
        UltraGridColumn146.Header.Caption = "Mã dịch vụ"
        UltraGridColumn146.Header.VisiblePosition = 0
        Appearance194.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn147.CellAppearance = Appearance194
        Appearance195.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn147.Header.Appearance = Appearance195
        UltraGridColumn147.Header.Caption = "Tên dịch vụ"
        UltraGridColumn147.Header.VisiblePosition = 1
        Appearance196.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn148.CellAppearance = Appearance196
        Appearance197.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn148.Header.Appearance = Appearance197
        UltraGridColumn148.Header.Caption = "Phân loại"
        UltraGridColumn148.Header.VisiblePosition = 2
        UltraGridColumn148.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn146, UltraGridColumn147, UltraGridColumn148})
        UltraGridBand6.Header.Caption = "Mã Đường Thư"
        Me.cbDV_Cong_Them.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance198.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance198.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance198.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance198.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance198.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDV_Cong_Them.DisplayLayout.Override.HeaderAppearance = Appearance198
        Me.cbDV_Cong_Them.DisplayMember = ""
        Me.cbDV_Cong_Them.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDV_Cong_Them.Location = New System.Drawing.Point(136, 56)
        Me.cbDV_Cong_Them.Name = "cbDV_Cong_Them"
        Me.cbDV_Cong_Them.ReadOnly = True
        Me.cbDV_Cong_Them.Size = New System.Drawing.Size(96, 21)
        Me.cbDV_Cong_Them.TabIndex = 3
        Me.cbDV_Cong_Them.ValueMember = ""
        '
        'UltraLabel18
        '
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(8, 157)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel18.TabIndex = 11
        Me.UltraLabel18.Text = "Tổng cước:"
        '
        'txtCuoc_E1
        '
        Me.txtCuoc_E1.Location = New System.Drawing.Point(72, 152)
        Me.txtCuoc_E1.Name = "txtCuoc_E1"
        Me.txtCuoc_E1.ReadOnly = True
        Me.txtCuoc_E1.Size = New System.Drawing.Size(96, 21)
        Me.txtCuoc_E1.TabIndex = 12
        Me.txtCuoc_E1.Text = "0"
        '
        'UltraLabel17
        '
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(8, 56)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(112, 24)
        Me.UltraLabel17.TabIndex = 2
        Me.UltraLabel17.Text = "Cước DV cộng thêm:"
        '
        'txtCuoc_DV
        '
        Me.txtCuoc_DV.Location = New System.Drawing.Point(240, 88)
        Me.txtCuoc_DV.Name = "txtCuoc_DV"
        Me.txtCuoc_DV.ReadOnly = True
        Me.txtCuoc_DV.Size = New System.Drawing.Size(96, 21)
        Me.txtCuoc_DV.TabIndex = 6
        Me.txtCuoc_DV.Text = "0"
        '
        'UltraLabel16
        '
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel16.TabIndex = 0
        Me.UltraLabel16.Text = "Cước chính:"
        '
        'txtCuoc_Chinh
        '
        Me.txtCuoc_Chinh.Location = New System.Drawing.Point(136, 20)
        Me.txtCuoc_Chinh.Name = "txtCuoc_Chinh"
        Me.txtCuoc_Chinh.ReadOnly = True
        Me.txtCuoc_Chinh.Size = New System.Drawing.Size(96, 21)
        Me.txtCuoc_Chinh.TabIndex = 1
        Me.txtCuoc_Chinh.Text = "0"
        '
        'UltraGroupBox12
        '
        Me.UltraGroupBox12.Controls.Add(Me.btnHang_Nhe)
        Me.UltraGroupBox12.Controls.Add(Me.cbLoai_Hang_Hoa)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox12.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox12.Controls.Add(Me.txtKhoi_Luong_QD)
        Me.UltraGroupBox12.Controls.Add(Me.txtKhoi_Luong)
        Me.UltraGroupBox12.Enabled = False
        Me.UltraGroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox12.Location = New System.Drawing.Point(384, 256)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(376, 80)
        Me.UltraGroupBox12.SupportThemes = False
        Me.UltraGroupBox12.TabIndex = 8
        Me.UltraGroupBox12.Text = "8.Khối lượng (Gram):"
        '
        'btnHang_Nhe
        '
        Me.btnHang_Nhe.Enabled = False
        Me.btnHang_Nhe.Location = New System.Drawing.Point(344, 48)
        Me.btnHang_Nhe.Name = "btnHang_Nhe"
        Me.btnHang_Nhe.Size = New System.Drawing.Size(24, 21)
        Me.btnHang_Nhe.TabIndex = 5
        Me.btnHang_Nhe.Text = ">"
        '
        'cbLoai_Hang_Hoa
        '
        Me.cbLoai_Hang_Hoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance199.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn149.Header.Appearance = Appearance199
        UltraGridColumn149.Header.Caption = "Mã loại"
        UltraGridColumn149.Header.VisiblePosition = 0
        UltraGridColumn149.Hidden = True
        Appearance200.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn150.Header.Appearance = Appearance200
        UltraGridColumn150.Header.Caption = "Tên loại"
        UltraGridColumn150.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn149, UltraGridColumn150})
        UltraGridBand7.Header.Caption = "Mã Đường Thư"
        Me.cbLoai_Hang_Hoa.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance201.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance201.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance201.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance201.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance201.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbLoai_Hang_Hoa.DisplayLayout.Override.HeaderAppearance = Appearance201
        Me.cbLoai_Hang_Hoa.DisplayMember = "Ten_Loai"
        Me.cbLoai_Hang_Hoa.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbLoai_Hang_Hoa.Enabled = False
        Me.cbLoai_Hang_Hoa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_Hang_Hoa.Location = New System.Drawing.Point(136, 48)
        Me.cbLoai_Hang_Hoa.Name = "cbLoai_Hang_Hoa"
        Me.cbLoai_Hang_Hoa.ReadOnly = True
        Me.cbLoai_Hang_Hoa.Size = New System.Drawing.Size(96, 21)
        Me.cbLoai_Hang_Hoa.TabIndex = 3
        Me.cbLoai_Hang_Hoa.ValueMember = "Ma_Loai"
        '
        'UltraLabel15
        '
        Me.UltraLabel15.Enabled = False
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(8, 53)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel15.TabIndex = 2
        Me.UltraLabel15.Text = "Loại / Khối lượng QĐ:"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(184, 24)
        Me.UltraLabel14.TabIndex = 0
        Me.UltraLabel14.Text = "Khối lượng thực tế:"
        '
        'txtKhoi_Luong_QD
        '
        Me.txtKhoi_Luong_QD.Enabled = False
        Me.txtKhoi_Luong_QD.Location = New System.Drawing.Point(240, 48)
        Me.txtKhoi_Luong_QD.Name = "txtKhoi_Luong_QD"
        Me.txtKhoi_Luong_QD.ReadOnly = True
        Me.txtKhoi_Luong_QD.Size = New System.Drawing.Size(72, 21)
        Me.txtKhoi_Luong_QD.TabIndex = 4
        Me.txtKhoi_Luong_QD.Text = "0"
        '
        'txtKhoi_Luong
        '
        Me.txtKhoi_Luong.Location = New System.Drawing.Point(240, 16)
        Me.txtKhoi_Luong.Name = "txtKhoi_Luong"
        Me.txtKhoi_Luong.ReadOnly = True
        Me.txtKhoi_Luong.Size = New System.Drawing.Size(96, 21)
        Me.txtKhoi_Luong.TabIndex = 1
        Me.txtKhoi_Luong.Text = "0"
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox6.Controls.Add(Me.txtGio_Gui)
        Me.UltraGroupBox6.Controls.Add(Me.dtpNgay_Gui)
        Me.UltraGroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 472)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(384, 48)
        Me.UltraGroupBox6.SupportThemes = False
        Me.UltraGroupBox6.TabIndex = 7
        Me.UltraGroupBox6.Text = "7.Ngày giờ gửi"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(144, 26)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel7.TabIndex = 2
        Me.UltraLabel7.Text = "Ngày :"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 26)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel6.TabIndex = 0
        Me.UltraLabel6.Text = "Lúc :"
        '
        'txtGio_Gui
        '
        Me.txtGio_Gui.Location = New System.Drawing.Point(64, 21)
        Me.txtGio_Gui.Name = "txtGio_Gui"
        Me.txtGio_Gui.ReadOnly = True
        Me.txtGio_Gui.Size = New System.Drawing.Size(56, 21)
        Me.txtGio_Gui.TabIndex = 1
        '
        'dtpNgay_Gui
        '
        Me.dtpNgay_Gui.DateTime = New Date(2008, 11, 21, 0, 0, 0, 0)
        Me.dtpNgay_Gui.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgay_Gui.Location = New System.Drawing.Point(200, 21)
        Me.dtpNgay_Gui.Name = "dtpNgay_Gui"
        Me.dtpNgay_Gui.ReadOnly = True
        Me.dtpNgay_Gui.Size = New System.Drawing.Size(96, 21)
        Me.dtpNgay_Gui.TabIndex = 3
        Me.dtpNgay_Gui.Value = New Date(2008, 11, 21, 0, 0, 0, 0)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.chkChuyen_Hoan_Bc)
        Me.UltraGroupBox5.Controls.Add(Me.cbBuu_Cuc_CH)
        Me.UltraGroupBox5.Enabled = False
        Me.UltraGroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 416)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(384, 56)
        Me.UltraGroupBox5.SupportThemes = False
        Me.UltraGroupBox5.TabIndex = 6
        Me.UltraGroupBox5.Text = "6.Bưu phẩm chuyển hoàn / COD:"
        '
        'chkChuyen_Hoan_Bc
        '
        Me.chkChuyen_Hoan_Bc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChuyen_Hoan_Bc.Location = New System.Drawing.Point(48, 24)
        Me.chkChuyen_Hoan_Bc.Name = "chkChuyen_Hoan_Bc"
        Me.chkChuyen_Hoan_Bc.Size = New System.Drawing.Size(184, 16)
        Me.chkChuyen_Hoan_Bc.TabIndex = 0
        Me.chkChuyen_Hoan_Bc.Text = "Bưu cục chuyển hoàn"
        '
        'cbBuu_Cuc_CH
        '
        Me.cbBuu_Cuc_CH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn151.Header.VisiblePosition = 0
        UltraGridColumn152.Header.VisiblePosition = 1
        UltraGridColumn152.Width = 250
        UltraGridColumn153.Header.VisiblePosition = 2
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn151, UltraGridColumn152, UltraGridColumn153})
        Me.cbBuu_Cuc_CH.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Appearance202.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance202.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance202.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance202.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbBuu_Cuc_CH.DisplayLayout.Override.HeaderAppearance = Appearance202
        Me.cbBuu_Cuc_CH.DisplayMember = ""
        Me.cbBuu_Cuc_CH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuu_Cuc_CH.Location = New System.Drawing.Point(240, 24)
        Me.cbBuu_Cuc_CH.Name = "cbBuu_Cuc_CH"
        Me.cbBuu_Cuc_CH.Size = New System.Drawing.Size(88, 21)
        Me.cbBuu_Cuc_CH.TabIndex = 1
        Me.cbBuu_Cuc_CH.ValueMember = ""
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.optHuy)
        Me.UltraGroupBox4.Controls.Add(Me.optChuyen_Hoan)
        Me.UltraGroupBox4.Enabled = False
        Me.UltraGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 352)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(384, 56)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 5
        Me.UltraGroupBox4.Text = "5.Chỉ dẫn của người gửi khi không phát được"
        '
        'optHuy
        '
        Me.optHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHuy.Location = New System.Drawing.Point(200, 24)
        Me.optHuy.Name = "optHuy"
        Me.optHuy.Size = New System.Drawing.Size(112, 16)
        Me.optHuy.TabIndex = 1
        Me.optHuy.Text = "Huỷ (F2)"
        '
        'optChuyen_Hoan
        '
        Me.optChuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optChuyen_Hoan.Location = New System.Drawing.Point(48, 24)
        Me.optChuyen_Hoan.Name = "optChuyen_Hoan"
        Me.optChuyen_Hoan.Size = New System.Drawing.Size(120, 16)
        Me.optChuyen_Hoan.TabIndex = 0
        Me.optChuyen_Hoan.Text = "Chuyển hoàn (F2)"
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.txtNoi_Dung_Gui)
        Me.UltraGroupBox3.Enabled = False
        Me.UltraGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 280)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(384, 64)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 4
        Me.UltraGroupBox3.Text = "4.Nội dung/Content:"
        '
        'txtNoi_Dung_Gui
        '
        Me.txtNoi_Dung_Gui.Location = New System.Drawing.Point(48, 24)
        Me.txtNoi_Dung_Gui.Multiline = True
        Me.txtNoi_Dung_Gui.Name = "txtNoi_Dung_Gui"
        Me.txtNoi_Dung_Gui.ReadOnly = True
        Me.txtNoi_Dung_Gui.Size = New System.Drawing.Size(320, 32)
        Me.txtNoi_Dung_Gui.TabIndex = 0
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox8)
        Me.UltraGroupBox2.Controls.Add(Me.gbPhan_Loai)
        Me.UltraGroupBox2.Enabled = False
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 208)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(384, 72)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 3
        Me.UltraGroupBox2.Text = "3.Loại hàng gửi:"
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.optSu_Vu)
        Me.UltraGroupBox8.Controls.Add(Me.optThoa_Thuan)
        Me.UltraGroupBox8.Controls.Add(Me.optBinh_Thuong)
        Me.UltraGroupBox8.Enabled = False
        Me.UltraGroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox8.Location = New System.Drawing.Point(184, 16)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(184, 56)
        Me.UltraGroupBox8.SupportThemes = False
        Me.UltraGroupBox8.TabIndex = 1
        '
        'optSu_Vu
        '
        Me.optSu_Vu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSu_Vu.Location = New System.Drawing.Point(120, 8)
        Me.optSu_Vu.Name = "optSu_Vu"
        Me.optSu_Vu.Size = New System.Drawing.Size(56, 16)
        Me.optSu_Vu.TabIndex = 2
        Me.optSu_Vu.Text = "Sự vụ"
        '
        'optThoa_Thuan
        '
        Me.optThoa_Thuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optThoa_Thuan.Location = New System.Drawing.Point(16, 32)
        Me.optThoa_Thuan.Name = "optThoa_Thuan"
        Me.optThoa_Thuan.Size = New System.Drawing.Size(96, 16)
        Me.optThoa_Thuan.TabIndex = 1
        Me.optThoa_Thuan.Text = "EMS T.Thuận"
        '
        'optBinh_Thuong
        '
        Me.optBinh_Thuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBinh_Thuong.Location = New System.Drawing.Point(16, 8)
        Me.optBinh_Thuong.Name = "optBinh_Thuong"
        Me.optBinh_Thuong.Size = New System.Drawing.Size(96, 16)
        Me.optBinh_Thuong.TabIndex = 0
        Me.optBinh_Thuong.Text = "EMS thường"
        '
        'gbPhan_Loai
        '
        Me.gbPhan_Loai.Controls.Add(Me.optHang_Hoa)
        Me.gbPhan_Loai.Controls.Add(Me.optTai_Lieu)
        Me.gbPhan_Loai.Enabled = False
        Me.gbPhan_Loai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPhan_Loai.Location = New System.Drawing.Point(32, 16)
        Me.gbPhan_Loai.Name = "gbPhan_Loai"
        Me.gbPhan_Loai.Size = New System.Drawing.Size(144, 56)
        Me.gbPhan_Loai.SupportThemes = False
        Me.gbPhan_Loai.TabIndex = 0
        '
        'optHang_Hoa
        '
        Me.optHang_Hoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHang_Hoa.Location = New System.Drawing.Point(16, 32)
        Me.optHang_Hoa.Name = "optHang_Hoa"
        Me.optHang_Hoa.Size = New System.Drawing.Size(80, 16)
        Me.optHang_Hoa.TabIndex = 1
        Me.optHang_Hoa.Text = "Mẫu hàng"
        '
        'optTai_Lieu
        '
        Me.optTai_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTai_Lieu.Location = New System.Drawing.Point(16, 8)
        Me.optTai_Lieu.Name = "optTai_Lieu"
        Me.optTai_Lieu.Size = New System.Drawing.Size(80, 16)
        Me.optTai_Lieu.TabIndex = 0
        Me.optTai_Lieu.Text = "Tài liệu"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txtDia_Chi_Gui)
        Me.UltraGroupBox1.Controls.Add(Me.cbKhach_Hang)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txtDien_Thoai_Gui)
        Me.UltraGroupBox1.Controls.Add(Me.txtHo_Ten_Gui)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox1.Enabled = False
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 64)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(384, 144)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "1.Họ tên, địa chỉ người gửi"
        '
        'txtDia_Chi_Gui
        '
        Me.txtDia_Chi_Gui.Location = New System.Drawing.Point(48, 48)
        Me.txtDia_Chi_Gui.Multiline = True
        Me.txtDia_Chi_Gui.Name = "txtDia_Chi_Gui"
        Me.txtDia_Chi_Gui.ReadOnly = True
        Me.txtDia_Chi_Gui.Size = New System.Drawing.Size(320, 56)
        Me.txtDia_Chi_Gui.TabIndex = 4
        '
        'cbKhach_Hang
        '
        Me.cbKhach_Hang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance203.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn154.Header.Appearance = Appearance203
        UltraGridColumn154.Header.Caption = "Mã KH"
        UltraGridColumn154.Header.VisiblePosition = 0
        Appearance204.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn155.Header.Appearance = Appearance204
        UltraGridColumn155.Header.Caption = "Tên KH"
        UltraGridColumn155.Header.VisiblePosition = 1
        UltraGridColumn155.Width = 350
        UltraGridColumn156.Header.VisiblePosition = 2
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 3
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 4
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 5
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 6
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 7
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.VisiblePosition = 8
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 9
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 10
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 11
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 12
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 13
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 14
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 15
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 16
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 17
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 18
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 19
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 20
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 21
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 22
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 23
        UltraGridColumn177.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177})
        UltraGridBand9.Header.Caption = "Mã Đường Thư"
        Me.cbKhach_Hang.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Appearance205.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance205.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance205.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance205.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance205.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbKhach_Hang.DisplayLayout.Override.HeaderAppearance = Appearance205
        Me.cbKhach_Hang.DisplayMember = ""
        Me.cbKhach_Hang.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKhach_Hang.Location = New System.Drawing.Point(48, 24)
        Me.cbKhach_Hang.Name = "cbKhach_Hang"
        Me.cbKhach_Hang.ReadOnly = True
        Me.cbKhach_Hang.Size = New System.Drawing.Size(80, 21)
        Me.cbKhach_Hang.TabIndex = 1
        Me.cbKhach_Hang.ValueMember = ""
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(8, 112)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(40, 24)
        Me.UltraLabel5.TabIndex = 5
        Me.UltraLabel5.Text = "ĐT:"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 48)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 40)
        Me.UltraLabel4.TabIndex = 3
        Me.UltraLabel4.Text = "Đ/C :"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Mã KH"
        '
        'txtDien_Thoai_Gui
        '
        Me.txtDien_Thoai_Gui.Location = New System.Drawing.Point(48, 112)
        Me.txtDien_Thoai_Gui.Name = "txtDien_Thoai_Gui"
        Me.txtDien_Thoai_Gui.ReadOnly = True
        Me.txtDien_Thoai_Gui.Size = New System.Drawing.Size(320, 21)
        Me.txtDien_Thoai_Gui.TabIndex = 6
        '
        'txtHo_Ten_Gui
        '
        Me.txtHo_Ten_Gui.Location = New System.Drawing.Point(160, 24)
        Me.txtHo_Ten_Gui.Name = "txtHo_Ten_Gui"
        Me.txtHo_Ten_Gui.ReadOnly = True
        Me.txtHo_Ten_Gui.Size = New System.Drawing.Size(208, 21)
        Me.txtHo_Ten_Gui.TabIndex = 2
        '
        'UltraLabel28
        '
        Me.UltraLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(130, 24)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(46, 24)
        Me.UltraLabel28.TabIndex = 7
        Me.UltraLabel28.Text = "Tên"
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.Label1)
        Me.UltraGroupBox13.Controls.Add(Me.cbNuoc)
        Me.UltraGroupBox13.Controls.Add(Me.lblBcTra)
        Me.UltraGroupBox13.Controls.Add(Me.txtDia_Chi_Nhan)
        Me.UltraGroupBox13.Controls.Add(Me.btnVung_Xa)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox13.Controls.Add(Me.cbBuuCuc)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox13.Controls.Add(Me.txtPostcode)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox13.Controls.Add(Me.txtDien_Thoai_Nhan)
        Me.UltraGroupBox13.Controls.Add(Me.txtHo_Ten_Nhan)
        Me.UltraGroupBox13.Controls.Add(Me.lblNuocTra)
        Me.UltraGroupBox13.Enabled = False
        Me.UltraGroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox13.Location = New System.Drawing.Point(384, 64)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(376, 192)
        Me.UltraGroupBox13.SupportThemes = False
        Me.UltraGroupBox13.TabIndex = 2
        Me.UltraGroupBox13.Text = "2.Họ tên, địa chỉ người nhận"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(240, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nhập 0 : gửi đi Quốc Tế"
        '
        'cbNuoc
        '
        Me.cbNuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn178.Header.Caption = "Mã nước"
        UltraGridColumn178.Header.VisiblePosition = 0
        UltraGridColumn179.Header.Caption = "Tên nước"
        UltraGridColumn179.Header.VisiblePosition = 1
        Appearance206.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn180.Header.Appearance = Appearance206
        UltraGridColumn180.Header.Caption = "Mã khu vực"
        UltraGridColumn180.Header.VisiblePosition = 2
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 3
        UltraGridColumn181.Hidden = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181})
        UltraGridBand10.Header.Caption = "Mã Đường Thư"
        Me.cbNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Appearance207.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance207.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance207.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance207.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance207.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbNuoc.DisplayLayout.Override.HeaderAppearance = Appearance207
        Me.cbNuoc.DisplayMember = ""
        Me.cbNuoc.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbNuoc.Enabled = False
        Me.cbNuoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNuoc.Location = New System.Drawing.Point(56, 136)
        Me.cbNuoc.Name = "cbNuoc"
        Me.cbNuoc.ReadOnly = True
        Me.cbNuoc.Size = New System.Drawing.Size(104, 21)
        Me.cbNuoc.TabIndex = 7
        Me.cbNuoc.ValueMember = ""
        '
        'lblBcTra
        '
        Me.lblBcTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBcTra.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBcTra.Location = New System.Drawing.Point(168, 112)
        Me.lblBcTra.Name = "lblBcTra"
        Me.lblBcTra.Size = New System.Drawing.Size(64, 20)
        Me.lblBcTra.TabIndex = 13
        Me.lblBcTra.Text = "Ma_Bc_Tra"
        '
        'txtDia_Chi_Nhan
        '
        Me.txtDia_Chi_Nhan.Location = New System.Drawing.Point(56, 48)
        Me.txtDia_Chi_Nhan.Multiline = True
        Me.txtDia_Chi_Nhan.Name = "txtDia_Chi_Nhan"
        Me.txtDia_Chi_Nhan.ReadOnly = True
        Me.txtDia_Chi_Nhan.Size = New System.Drawing.Size(304, 56)
        Me.txtDia_Chi_Nhan.TabIndex = 3
        '
        'btnVung_Xa
        '
        Me.btnVung_Xa.Enabled = False
        Me.btnVung_Xa.Location = New System.Drawing.Point(344, 160)
        Me.btnVung_Xa.Name = "btnVung_Xa"
        Me.btnVung_Xa.Size = New System.Drawing.Size(24, 21)
        Me.btnVung_Xa.TabIndex = 12
        Me.btnVung_Xa.Text = ">"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(8, 136)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(56, 24)
        Me.UltraLabel8.TabIndex = 6
        Me.UltraLabel8.Text = "Nước trả:"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(8, 112)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel9.TabIndex = 4
        Me.UltraLabel9.Text = "B.Cục:"
        '
        'cbBuuCuc
        '
        Me.cbBuuCuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance208.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn182.CellAppearance = Appearance208
        Appearance209.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn182.Header.Appearance = Appearance209
        UltraGridColumn182.Header.Caption = "Mã tỉnh"
        UltraGridColumn182.Header.VisiblePosition = 0
        UltraGridColumn182.Width = 70
        Appearance210.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn183.CellAppearance = Appearance210
        Appearance211.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn183.Header.Appearance = Appearance211
        UltraGridColumn183.Header.Caption = "Tên tỉnh"
        UltraGridColumn183.Header.VisiblePosition = 1
        UltraGridColumn183.Width = 180
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn182, UltraGridColumn183})
        UltraGridBand11.Header.Caption = "Mã Đường Thư"
        Me.cbBuuCuc.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Appearance212.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance212.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance212.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance212.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbBuuCuc.DisplayLayout.Override.HeaderAppearance = Appearance212
        Me.cbBuuCuc.DisplayMember = "Ten_Tinh"
        Me.cbBuuCuc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuuCuc.Location = New System.Drawing.Point(56, 112)
        Me.cbBuuCuc.Name = "cbBuuCuc"
        Me.cbBuuCuc.ReadOnly = True
        Me.cbBuuCuc.Size = New System.Drawing.Size(104, 21)
        Me.cbBuuCuc.TabIndex = 5
        Me.cbBuuCuc.Tag = "nhập 0 : nếu là gửi đi Quốc Tế"
        Me.cbBuuCuc.ValueMember = "Ma_Tinh"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(168, 160)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(72, 24)
        Me.UltraLabel10.TabIndex = 10
        Me.UltraLabel10.Text = "Postal code:"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(240, 160)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.ReadOnly = True
        Me.txtPostcode.Size = New System.Drawing.Size(96, 21)
        Me.txtPostcode.TabIndex = 11
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(8, 160)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(40, 24)
        Me.UltraLabel11.TabIndex = 8
        Me.UltraLabel11.Text = "ĐT:"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(8, 48)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(40, 40)
        Me.UltraLabel12.TabIndex = 2
        Me.UltraLabel12.Text = "Đ/C :"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(40, 24)
        Me.UltraLabel13.TabIndex = 0
        Me.UltraLabel13.Text = "Tên:"
        '
        'txtDien_Thoai_Nhan
        '
        Me.txtDien_Thoai_Nhan.Location = New System.Drawing.Point(56, 160)
        Me.txtDien_Thoai_Nhan.Name = "txtDien_Thoai_Nhan"
        Me.txtDien_Thoai_Nhan.ReadOnly = True
        Me.txtDien_Thoai_Nhan.Size = New System.Drawing.Size(104, 21)
        Me.txtDien_Thoai_Nhan.TabIndex = 9
        '
        'txtHo_Ten_Nhan
        '
        Me.txtHo_Ten_Nhan.Location = New System.Drawing.Point(56, 24)
        Me.txtHo_Ten_Nhan.Name = "txtHo_Ten_Nhan"
        Me.txtHo_Ten_Nhan.ReadOnly = True
        Me.txtHo_Ten_Nhan.Size = New System.Drawing.Size(304, 21)
        Me.txtHo_Ten_Nhan.TabIndex = 1
        '
        'lblNuocTra
        '
        Me.lblNuocTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuocTra.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNuocTra.Location = New System.Drawing.Point(168, 136)
        Me.lblNuocTra.Name = "lblNuocTra"
        Me.lblNuocTra.Size = New System.Drawing.Size(200, 20)
        Me.lblNuocTra.TabIndex = 13
        Me.lblNuocTra.Text = "Nuoc_Tra"
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.cbMa_Nuoc_E1)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel29)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel19)
        Me.UltraGroupBox7.Controls.Add(Me.cbDuongThuDi_PH)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox7.Controls.Add(Me.txtSo_Hieu_CP1)
        Me.UltraGroupBox7.Controls.Add(Me.cbNuoc_Nhan)
        Me.UltraGroupBox7.Controls.Add(Me.cbMa_Quay)
        Me.UltraGroupBox7.Controls.Add(Me.txtSo_Hieu_E1)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox7.Controls.Add(Me.lblMa_Quay)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(760, 64)
        Me.UltraGroupBox7.SupportThemes = False
        Me.UltraGroupBox7.TabIndex = 0
        '
        'cbMa_Nuoc_E1
        '
        Me.cbMa_Nuoc_E1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance213.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cbMa_Nuoc_E1.DisplayLayout.Appearance = Appearance213
        Appearance214.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn184.CellAppearance = Appearance214
        Appearance215.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn184.Header.Appearance = Appearance215
        UltraGridColumn184.Header.Caption = "Mã nước"
        UltraGridColumn184.Header.VisiblePosition = 0
        UltraGridColumn184.Width = 80
        Appearance216.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn185.Header.Appearance = Appearance216
        UltraGridColumn185.Header.Caption = "Tên nước"
        UltraGridColumn185.Header.VisiblePosition = 1
        UltraGridColumn185.Width = 150
        UltraGridColumn186.Header.VisiblePosition = 2
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 3
        UltraGridColumn187.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187})
        Me.cbMa_Nuoc_E1.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Appearance217.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance217.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance217.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance217.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance217.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Nuoc_E1.DisplayLayout.Override.HeaderAppearance = Appearance217
        Me.cbMa_Nuoc_E1.DisplayMember = "Ma_Nuoc"
        Me.cbMa_Nuoc_E1.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbMa_Nuoc_E1.LimitToList = True
        Me.cbMa_Nuoc_E1.Location = New System.Drawing.Point(472, 8)
        Me.cbMa_Nuoc_E1.Name = "cbMa_Nuoc_E1"
        Me.cbMa_Nuoc_E1.Size = New System.Drawing.Size(64, 21)
        Me.cbMa_Nuoc_E1.TabIndex = 7
        Me.cbMa_Nuoc_E1.ValueMember = "Ma_Nuoc"
        '
        'UltraLabel29
        '
        Me.UltraLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel29.Location = New System.Drawing.Point(400, 10)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel29.TabIndex = 6
        Me.UltraLabel29.Text = "Mã nước E1"
        '
        'UltraLabel19
        '
        Me.UltraLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(8, 32)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel19.TabIndex = 4
        Me.UltraLabel19.Text = "Đường thư"
        '
        'cbDuongThuDi_PH
        '
        Me.cbDuongThuDi_PH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance218.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cbDuongThuDi_PH.DisplayLayout.Appearance = Appearance218
        UltraGridColumn188.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn188.Header.VisiblePosition = 0
        UltraGridColumn189.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn189.Header.VisiblePosition = 1
        UltraGridColumn189.Width = 250
        UltraGridColumn190.Header.VisiblePosition = 2
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn191.Header.VisiblePosition = 3
        UltraGridColumn191.Hidden = True
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191})
        UltraGridBand13.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDi_PH.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Appearance219.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance219.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance219.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance219.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance219.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDuongThuDi_PH.DisplayLayout.Override.HeaderAppearance = Appearance219
        Me.cbDuongThuDi_PH.DisplayMember = "Ten_Duong_Thu"
        Me.cbDuongThuDi_PH.Enabled = False
        Me.cbDuongThuDi_PH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDi_PH.LimitToList = True
        Me.cbDuongThuDi_PH.Location = New System.Drawing.Point(72, 32)
        Me.cbDuongThuDi_PH.Name = "cbDuongThuDi_PH"
        Me.cbDuongThuDi_PH.ReadOnly = True
        Me.cbDuongThuDi_PH.Size = New System.Drawing.Size(280, 21)
        Me.cbDuongThuDi_PH.TabIndex = 5
        Me.cbDuongThuDi_PH.ValueMember = "Id_Duong_Thu"
        '
        'UltraLabel26
        '
        Me.UltraLabel26.Location = New System.Drawing.Point(8, 10)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(56, 24)
        Me.UltraLabel26.TabIndex = 0
        Me.UltraLabel26.Text = "Số CP1 :"
        '
        'txtSo_Hieu_CP1
        '
        Me.txtSo_Hieu_CP1.Location = New System.Drawing.Point(72, 8)
        Me.txtSo_Hieu_CP1.MaxLength = 13
        Me.txtSo_Hieu_CP1.Name = "txtSo_Hieu_CP1"
        Me.txtSo_Hieu_CP1.Size = New System.Drawing.Size(144, 21)
        Me.txtSo_Hieu_CP1.TabIndex = 1
        '
        'cbNuoc_Nhan
        '
        Me.cbNuoc_Nhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance220.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cbNuoc_Nhan.DisplayLayout.Appearance = Appearance220
        Appearance221.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn192.CellAppearance = Appearance221
        Appearance222.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn192.Header.Appearance = Appearance222
        UltraGridColumn192.Header.Caption = "Mã nước"
        UltraGridColumn192.Header.VisiblePosition = 0
        UltraGridColumn192.Width = 80
        Appearance223.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn193.Header.Appearance = Appearance223
        UltraGridColumn193.Header.Caption = "Tên nước"
        UltraGridColumn193.Header.VisiblePosition = 1
        UltraGridColumn193.Width = 150
        UltraGridColumn194.Header.VisiblePosition = 2
        UltraGridColumn194.Hidden = True
        UltraGridColumn195.Header.VisiblePosition = 3
        UltraGridColumn195.Hidden = True
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195})
        Me.cbNuoc_Nhan.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Appearance224.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance224.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance224.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance224.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance224.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbNuoc_Nhan.DisplayLayout.Override.HeaderAppearance = Appearance224
        Me.cbNuoc_Nhan.DisplayMember = "Ma_Nuoc"
        Me.cbNuoc_Nhan.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbNuoc_Nhan.Enabled = False
        Me.cbNuoc_Nhan.LimitToList = True
        Me.cbNuoc_Nhan.Location = New System.Drawing.Point(288, 8)
        Me.cbNuoc_Nhan.Name = "cbNuoc_Nhan"
        Me.cbNuoc_Nhan.ReadOnly = True
        Me.cbNuoc_Nhan.Size = New System.Drawing.Size(64, 21)
        Me.cbNuoc_Nhan.TabIndex = 3
        Me.cbNuoc_Nhan.ValueMember = "Ma_Nuoc"
        '
        'cbMa_Quay
        '
        Me.cbMa_Quay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance225.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cbMa_Quay.DisplayLayout.Appearance = Appearance225
        UltraGridColumn196.Header.VisiblePosition = 0
        UltraGridColumn196.Hidden = True
        Appearance226.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn197.CellAppearance = Appearance226
        Appearance227.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn197.Header.Appearance = Appearance227
        UltraGridColumn197.Header.Caption = "Quầy"
        UltraGridColumn197.Header.VisiblePosition = 1
        UltraGridColumn197.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate
        UltraGridColumn197.Width = 40
        Appearance228.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn198.Header.Appearance = Appearance228
        UltraGridColumn198.Header.Caption = "Tên quầy"
        UltraGridColumn198.Header.VisiblePosition = 2
        UltraGridColumn198.Width = 150
        Appearance229.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn199.Header.Appearance = Appearance229
        UltraGridColumn199.Header.Caption = "Điện thoại"
        UltraGridColumn199.Header.VisiblePosition = 3
        UltraGridColumn199.Hidden = True
        UltraGridColumn199.Width = 90
        UltraGridColumn200.Header.VisiblePosition = 4
        UltraGridColumn200.Hidden = True
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200})
        Me.cbMa_Quay.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Appearance230.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance230.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance230.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance230.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance230.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Quay.DisplayLayout.Override.HeaderAppearance = Appearance230
        Me.cbMa_Quay.DisplayMember = "Ma_Quay"
        Me.cbMa_Quay.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbMa_Quay.Enabled = False
        Me.cbMa_Quay.LimitToList = True
        Me.cbMa_Quay.Location = New System.Drawing.Point(472, 32)
        Me.cbMa_Quay.Name = "cbMa_Quay"
        Me.cbMa_Quay.ReadOnly = True
        Me.cbMa_Quay.Size = New System.Drawing.Size(144, 21)
        Me.cbMa_Quay.TabIndex = 11
        Me.cbMa_Quay.ValueMember = "Ma_Quay"
        '
        'txtSo_Hieu_E1
        '
        Me.txtSo_Hieu_E1.Location = New System.Drawing.Point(592, 8)
        Me.txtSo_Hieu_E1.Name = "txtSo_Hieu_E1"
        Me.txtSo_Hieu_E1.ReadOnly = True
        Me.txtSo_Hieu_E1.Size = New System.Drawing.Size(152, 21)
        Me.txtSo_Hieu_E1.TabIndex = 9
        '
        'UltraLabel25
        '
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(224, 10)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel25.TabIndex = 2
        Me.UltraLabel25.Text = "Nước nhận:"
        '
        'lblMa_Quay
        '
        Me.lblMa_Quay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMa_Quay.Location = New System.Drawing.Point(400, 35)
        Me.lblMa_Quay.Name = "lblMa_Quay"
        Me.lblMa_Quay.Size = New System.Drawing.Size(48, 16)
        Me.lblMa_Quay.TabIndex = 10
        Me.lblMa_Quay.Text = "Quầy"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(544, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(56, 24)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Mã E1 :"
        '
        'UltraLabel21
        '
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(64, 528)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(58, 16)
        Me.UltraLabel21.TabIndex = 11
        Me.UltraLabel21.Text = "Số bản in"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UltraTabPageControl2.Controls.Add(Me.btnSua_Chua)
        Me.UltraTabPageControl2.Controls.Add(Me.chkDoc_Exel)
        Me.UltraTabPageControl2.Controls.Add(Me.cbMaKH_BC)
        Me.UltraTabPageControl2.Controls.Add(Me.chkMaKH_BC)
        Me.UltraTabPageControl2.Controls.Add(Me.btnBaoCao)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl2.Controls.Add(Me.dtpDen_Ngay)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel24)
        Me.UltraTabPageControl2.Controls.Add(Me.dtpTu_Ngay)
        Me.UltraTabPageControl2.Controls.Add(Me.btnBrowse)
        Me.UltraTabPageControl2.Controls.Add(Me.label4)
        Me.UltraTabPageControl2.Controls.Add(Me.txtPath)
        Me.UltraTabPageControl2.Controls.Add(Me.btnPreview_PH)
        Me.UltraTabPageControl2.Controls.Add(Me.btnQuanLyIn)
        Me.UltraTabPageControl2.Controls.Add(Me.cbLua_Chon_In_PH)
        Me.UltraTabPageControl2.Controls.Add(Me.btnIn)
        Me.UltraTabPageControl2.Controls.Add(Me.chkAll)
        Me.UltraTabPageControl2.Controls.Add(Me.tabQuanLy)
        Me.UltraTabPageControl2.Controls.Add(Me.btnPhan_Huong)
        Me.UltraTabPageControl2.Controls.Add(Me.txtInfor)
        Me.UltraTabPageControl2.Controls.Add(Me.btnClose)
        Me.UltraTabPageControl2.Controls.Add(Me.dtpNgayDinhDang)
        Me.UltraTabPageControl2.Controls.Add(Me.txtGio_Dinh_Dang)
        Me.UltraTabPageControl2.Controls.Add(Me.txtInfor_E1)
        Me.UltraTabPageControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(764, 604)
        '
        'btnSua_Chua
        '
        Appearance231.Image = CType(resources.GetObject("Appearance231.Image"), Object)
        Me.btnSua_Chua.Appearance = Appearance231
        Me.btnSua_Chua.Location = New System.Drawing.Point(384, 480)
        Me.btnSua_Chua.Name = "btnSua_Chua"
        Me.btnSua_Chua.Size = New System.Drawing.Size(56, 32)
        Me.btnSua_Chua.TabIndex = 160
        Me.btnSua_Chua.Text = "&Sửa"
        '
        'chkDoc_Exel
        '
        Me.chkDoc_Exel.Location = New System.Drawing.Point(328, 520)
        Me.chkDoc_Exel.Name = "chkDoc_Exel"
        Me.chkDoc_Exel.Size = New System.Drawing.Size(80, 20)
        Me.chkDoc_Exel.TabIndex = 158
        Me.chkDoc_Exel.Text = "Đọc Exel"
        '
        'cbMaKH_BC
        '
        Me.cbMaKH_BC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance232.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn201.Header.Appearance = Appearance232
        UltraGridColumn201.Header.Caption = "Mã KH"
        UltraGridColumn201.Header.VisiblePosition = 0
        Appearance233.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn202.Header.Appearance = Appearance233
        UltraGridColumn202.Header.Caption = "Tên KH"
        UltraGridColumn202.Header.VisiblePosition = 1
        UltraGridColumn202.Width = 350
        UltraGridColumn203.Header.VisiblePosition = 2
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 3
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 4
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 5
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 6
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 7
        UltraGridColumn208.Hidden = True
        UltraGridColumn209.Header.VisiblePosition = 8
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 9
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 10
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 11
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 12
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.VisiblePosition = 13
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 14
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 15
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 16
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 17
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 18
        UltraGridColumn219.Hidden = True
        UltraGridColumn220.Header.VisiblePosition = 19
        UltraGridColumn220.Hidden = True
        UltraGridColumn221.Header.VisiblePosition = 20
        UltraGridColumn221.Hidden = True
        UltraGridColumn222.Header.VisiblePosition = 21
        UltraGridColumn222.Hidden = True
        UltraGridColumn223.Header.VisiblePosition = 22
        UltraGridColumn223.Hidden = True
        UltraGridColumn224.Header.VisiblePosition = 23
        UltraGridColumn224.Hidden = True
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224})
        UltraGridBand16.Header.Caption = "Mã Đường Thư"
        Me.cbMaKH_BC.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Appearance234.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance234.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance234.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance234.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance234.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMaKH_BC.DisplayLayout.Override.HeaderAppearance = Appearance234
        Me.cbMaKH_BC.DisplayMember = ""
        Me.cbMaKH_BC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaKH_BC.Location = New System.Drawing.Point(512, 520)
        Me.cbMaKH_BC.Name = "cbMaKH_BC"
        Me.cbMaKH_BC.Size = New System.Drawing.Size(88, 21)
        Me.cbMaKH_BC.TabIndex = 157
        Me.cbMaKH_BC.ValueMember = ""
        '
        'chkMaKH_BC
        '
        Me.chkMaKH_BC.Location = New System.Drawing.Point(440, 520)
        Me.chkMaKH_BC.Name = "chkMaKH_BC"
        Me.chkMaKH_BC.Size = New System.Drawing.Size(64, 20)
        Me.chkMaKH_BC.TabIndex = 156
        Me.chkMaKH_BC.Text = "Mã KH"
        '
        'btnBaoCao
        '
        Appearance235.FontData.BoldAsString = "True"
        Appearance235.Image = CType(resources.GetObject("Appearance235.Image"), Object)
        Me.btnBaoCao.Appearance = Appearance235
        Me.btnBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnBaoCao.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnBaoCao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBaoCao.Location = New System.Drawing.Point(640, 512)
        Me.btnBaoCao.Name = "btnBaoCao"
        Me.btnBaoCao.Size = New System.Drawing.Size(120, 32)
        Me.btnBaoCao.TabIndex = 155
        Me.btnBaoCao.Text = "Xem và in"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel2.Location = New System.Drawing.Point(600, 488)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel2.TabIndex = 154
        Me.UltraLabel2.Text = "Đến ngày"
        '
        'dtpDen_Ngay
        '
        Me.dtpDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDen_Ngay.Location = New System.Drawing.Point(664, 488)
        Me.dtpDen_Ngay.Name = "dtpDen_Ngay"
        Me.dtpDen_Ngay.Size = New System.Drawing.Size(96, 25)
        Me.dtpDen_Ngay.TabIndex = 152
        '
        'UltraLabel24
        '
        Me.UltraLabel24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel24.Location = New System.Drawing.Point(440, 488)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel24.TabIndex = 153
        Me.UltraLabel24.Text = "Từ ngày"
        '
        'dtpTu_Ngay
        '
        Me.dtpTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtpTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTu_Ngay.Location = New System.Drawing.Point(496, 488)
        Me.dtpTu_Ngay.Name = "dtpTu_Ngay"
        Me.dtpTu_Ngay.Size = New System.Drawing.Size(96, 25)
        Me.dtpTu_Ngay.TabIndex = 151
        Me.dtpTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'btnBrowse
        '
        Appearance236.Image = CType(resources.GetObject("Appearance236.Image"), Object)
        Me.btnBrowse.Appearance = Appearance236
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(264, 510)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(64, 32)
        Me.btnBrowse.TabIndex = 141
        Me.btnBrowse.Text = "Chọn"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 514)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(80, 23)
        Me.label4.TabIndex = 139
        Me.label4.Text = "Đường &dẫn:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(96, 514)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(160, 23)
        Me.txtPath.TabIndex = 140
        Me.txtPath.Text = ""
        '
        'btnPreview_PH
        '
        Appearance237.FontData.BoldAsString = "True"
        Appearance237.Image = CType(resources.GetObject("Appearance237.Image"), Object)
        Me.btnPreview_PH.Appearance = Appearance237
        Me.btnPreview_PH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPreview_PH.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPreview_PH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview_PH.Location = New System.Drawing.Point(248, 480)
        Me.btnPreview_PH.Name = "btnPreview_PH"
        Me.btnPreview_PH.Size = New System.Drawing.Size(40, 32)
        Me.btnPreview_PH.TabIndex = 138
        '
        'btnQuanLyIn
        '
        Appearance238.Image = CType(resources.GetObject("Appearance238.Image"), Object)
        Me.btnQuanLyIn.Appearance = Appearance238
        Me.btnQuanLyIn.Location = New System.Drawing.Point(288, 480)
        Me.btnQuanLyIn.Name = "btnQuanLyIn"
        Me.btnQuanLyIn.Size = New System.Drawing.Size(96, 32)
        Me.btnQuanLyIn.TabIndex = 137
        Me.btnQuanLyIn.Text = "&Quản lý in"
        '
        'cbLua_Chon_In_PH
        '
        Me.cbLua_Chon_In_PH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn225.Header.VisiblePosition = 0
        UltraGridColumn225.Hidden = True
        Appearance239.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn226.Header.Appearance = Appearance239
        UltraGridColumn226.Header.Caption = "Lựa chọn in"
        UltraGridColumn226.Header.VisiblePosition = 1
        UltraGridColumn226.Width = 250
        UltraGridBand17.Columns.AddRange(New Object() {UltraGridColumn225, UltraGridColumn226})
        UltraGridBand17.Header.Caption = "Mã Đường Thư"
        Me.cbLua_Chon_In_PH.DisplayLayout.BandsSerializer.Add(UltraGridBand17)
        Appearance240.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Appearance240.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance240.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance240.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance240.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbLua_Chon_In_PH.DisplayLayout.Override.HeaderAppearance = Appearance240
        Me.cbLua_Chon_In_PH.DisplayMember = "Ten_In"
        Me.cbLua_Chon_In_PH.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbLua_Chon_In_PH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLua_Chon_In_PH.Location = New System.Drawing.Point(96, 488)
        Me.cbLua_Chon_In_PH.Name = "cbLua_Chon_In_PH"
        Me.cbLua_Chon_In_PH.Size = New System.Drawing.Size(72, 21)
        Me.cbLua_Chon_In_PH.TabIndex = 134
        Me.cbLua_Chon_In_PH.ValueMember = "Ma_In"
        '
        'btnIn
        '
        Appearance241.Image = CType(resources.GetObject("Appearance241.Image"), Object)
        Me.btnIn.Appearance = Appearance241
        Me.btnIn.Location = New System.Drawing.Point(176, 480)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(72, 32)
        Me.btnIn.TabIndex = 133
        Me.btnIn.Text = "P&rinter"
        '
        'tabQuanLy
        '
        Me.tabQuanLy.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tabQuanLy.Controls.Add(Me.UltraTabPageControl3)
        Me.tabQuanLy.Controls.Add(Me.UltraTabPageControl4)
        Me.tabQuanLy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabQuanLy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabQuanLy.Location = New System.Drawing.Point(8, 88)
        Me.tabQuanLy.Name = "tabQuanLy"
        Me.tabQuanLy.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tabQuanLy.Size = New System.Drawing.Size(752, 392)
        Me.tabQuanLy.TabIndex = 131
        Me.tabQuanLy.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab1.Key = "0"
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Bưu phẩm chưa phân hướng"
        UltraTab2.Key = "1"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Bưu phẩm đã phân hướng"
        Me.tabQuanLy.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(748, 364)
        '
        'btnPhan_Huong
        '
        Me.btnPhan_Huong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhan_Huong.Location = New System.Drawing.Point(328, 8)
        Me.btnPhan_Huong.Name = "btnPhan_Huong"
        Me.btnPhan_Huong.Size = New System.Drawing.Size(72, 72)
        Me.btnPhan_Huong.TabIndex = 127
        Me.btnPhan_Huong.Text = "&Phân hướng"
        '
        'txtInfor
        '
        Appearance242.BackColor = System.Drawing.Color.Black
        Appearance242.ForeColor = System.Drawing.Color.Aqua
        Me.txtInfor.Appearance = Appearance242
        Me.txtInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfor.Location = New System.Drawing.Point(16, 8)
        Me.txtInfor.Name = "txtInfor"
        Me.txtInfor.Size = New System.Drawing.Size(304, 72)
        Me.txtInfor.TabIndex = 114
        '
        'btnClose
        '
        Appearance243.Image = CType(resources.GetObject("Appearance243.Image"), Object)
        Appearance243.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnClose.Appearance = Appearance243
        Me.btnClose.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsXPCommandButton
        Appearance244.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnClose.HotTrackAppearance = Appearance244
        Me.btnClose.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnClose.Location = New System.Drawing.Point(704, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(48, 72)
        Me.btnClose.TabIndex = 112
        '
        'txtGio_Dinh_Dang
        '
        Me.txtGio_Dinh_Dang.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtGio_Dinh_Dang.DisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtGio_Dinh_Dang.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtGio_Dinh_Dang.InputMask = "##:##"
        Me.txtGio_Dinh_Dang.Location = New System.Drawing.Point(152, 40)
        Me.txtGio_Dinh_Dang.Name = "txtGio_Dinh_Dang"
        Me.txtGio_Dinh_Dang.Size = New System.Drawing.Size(88, 23)
        Me.txtGio_Dinh_Dang.TabIndex = 109
        Me.txtGio_Dinh_Dang.Text = ":"
        Me.txtGio_Dinh_Dang.Visible = False
        '
        'txtInfor_E1
        '
        Appearance245.BackColor = System.Drawing.Color.Black
        Appearance245.ForeColor = System.Drawing.Color.Aqua
        Me.txtInfor_E1.Appearance = Appearance245
        Me.txtInfor_E1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtInfor_E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfor_E1.Location = New System.Drawing.Point(408, 8)
        Me.txtInfor_E1.Name = "txtInfor_E1"
        Me.txtInfor_E1.Size = New System.Drawing.Size(288, 72)
        Me.txtInfor_E1.TabIndex = 113
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(764, 604)
        '
        'tabPhanHuong
        '
        Me.tabPhanHuong.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabPhanHuong.Controls.Add(Me.UltraTabPageControl1)
        Me.tabPhanHuong.Controls.Add(Me.UltraTabPageControl2)
        Me.tabPhanHuong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabPhanHuong.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPhanHuong.Location = New System.Drawing.Point(0, 0)
        Me.tabPhanHuong.Name = "tabPhanHuong"
        Me.tabPhanHuong.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabPhanHuong.Size = New System.Drawing.Size(768, 632)
        Me.tabPhanHuong.TabIndex = 0
        Me.tabPhanHuong.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        Appearance246.BackColor2 = System.Drawing.SystemColors.InactiveCaptionText
        UltraTab3.Appearance = Appearance246
        UltraTab3.Key = "0"
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Tạo số hiệu vận đơn thay thế"
        Appearance247.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        UltraTab4.ActiveAppearance = Appearance247
        Appearance248.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        UltraTab4.Appearance = Appearance248
        UltraTab4.Key = "1"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Quản lý E1 phân hướng"
        Me.tabPhanHuong.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        '
        'mnuMenu
        '
        Me.mnuMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTimKiem})
        '
        'mnuTimKiem
        '
        Me.mnuTimKiem.Index = 0
        Me.mnuTimKiem.Text = "Tìm kiếm"
        '
        'chkGiay_A5_Co_San
        '
        Me.chkGiay_A5_Co_San.Location = New System.Drawing.Point(8, 544)
        Me.chkGiay_A5_Co_San.Name = "chkGiay_A5_Co_San"
        Me.chkGiay_A5_Co_San.Size = New System.Drawing.Size(168, 24)
        Me.chkGiay_A5_Co_San.TabIndex = 22
        Me.chkGiay_A5_Co_San.Text = "In trên mẫu A5 có sẵn"
        '
        'Frm_Ems_Shipping
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(770, 639)
        Me.Controls.Add(Me.tabPhanHuong)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Ems_Shipping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tạo số hiệu vận đơn điện tử thay thế cho vận đơn đầu mã CP"
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.dgE1_Chua_PH_XLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Chua_PH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.dgE1_Da_PH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.txtsoban, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLua_Chon_In, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        CType(Me.txtThue_Hai_Quan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGia_Tri_Hang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDV_Gia_Tang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDV_Cong_Them, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuoc_E1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuoc_DV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuoc_Chinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        CType(Me.cbLoai_Hang_Hoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKhoi_Luong_QD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKhoi_Luong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.txtGio_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgay_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.cbBuu_Cuc_CH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.txtNoi_Dung_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.gbPhan_Loai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPhan_Loai.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txtDia_Chi_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKhach_Hang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDien_Thoai_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHo_Ten_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.cbNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDia_Chi_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDien_Thoai_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHo_Ten_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.cbMa_Nuoc_E1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuDi_PH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Hieu_CP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNuoc_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Quay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Hieu_E1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.cbMaKH_BC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLua_Chon_In_PH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabQuanLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabQuanLy.ResumeLayout(False)
        CType(Me.tabPhanHuong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPhanHuong.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "=========Not Used=========="
#Region "Tao_Bang_Lua_Chon_In_PH"
    'Private Sub Tao_Bang_Lua_Chon_In_PH()
    '    Dim dataTable As New dataTable("Lua_Chon_In_PH")

    '    Dim colWork As DataColumn = New DataColumn("Ma_In", GetType(Integer))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("Ten_In", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    Dim row As DataRow = dataTable.NewRow()
    '    row("Ma_In") = 0
    '    row("Ten_In") = "In E1"
    '    dataTable.Rows.Add(row)

    '    cbLua_Chon_In_PH.DataSource = dataTable
    '    cbLua_Chon_In_PH.DataBind()
    '    If cbLua_Chon_In_PH.Rows.Count > 0 Then
    '        cbLua_Chon_In_PH.Value = cbLua_Chon_In_PH.Rows(0).Cells("Ma_In").Value
    '    End If
    'End Sub
#End Region
#Region "Tao_Bang_In_E1"
    'Function Tao_Bang_In_E1(ByVal nguoi_gui As String, ByVal dia_chi_gui As String, ByVal dien_thoai_gui As String, ByVal D As String, ByVal M As String, ByVal CH As String, ByVal Gio_Phat_Hanh As String, ByVal Ngay_Phat_Hanh As Date, ByVal nguoi_nhan As String, ByVal dia_chi_nhan As String, ByVal dien_thoai_nhan As String, ByVal khoi_luong As Integer, ByVal khoi_luong_qd As Integer, ByVal cuoc_chinh As Integer, ByVal dv_cong_them As Integer, ByVal cuoc_e1 As Integer, ByVal PostCode As String, ByVal Ma_E1 As String, ByVal Noi_Dung As String, ByVal Huy As String, ByVal Ma_KH As String)
    '    Dim dataTable As New dataTable("In_E1")

    '    Dim colWork As DataColumn = New DataColumn("nguoi_gui", GetType(String))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("dia_chi_gui", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("dien_thoai_gui", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("D", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("M", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("CH", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Gio_Phat_Hanh", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ngay_Phat_Hanh", GetType(Date))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("nguoi_nhan", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("dia_chi_nhan", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("dien_thoai_nhan", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("khoi_luong", GetType(Double))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("khoi_luong_qd", GetType(Double))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("cuoc_chinh", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("dv_cong_them", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("cuoc_e1", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("PostCode", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_E1", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Noi_Dung", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Huy", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_KH", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    Dim row As DataRow = dataTable.NewRow()
    '    row("nguoi_gui") = nguoi_gui
    '    row("dia_chi_gui") = dia_chi_gui
    '    row("dien_thoai_gui") = dien_thoai_gui
    '    row("D") = D
    '    row("M") = M
    '    row("CH") = CH
    '    row("Gio_Phat_Hanh") = Gio_Phat_Hanh
    '    row("Ngay_Phat_Hanh") = Ngay_Phat_Hanh
    '    row("nguoi_nhan") = nguoi_nhan
    '    row("dia_chi_nhan") = dia_chi_nhan
    '    row("dien_thoai_nhan") = dien_thoai_nhan
    '    row("khoi_luong") = khoi_luong / 1000
    '    row("khoi_luong_qd") = khoi_luong_qd / 1000
    '    row("cuoc_chinh") = cuoc_e1 / 1.1 - dv_cong_them
    '    row("dv_cong_them") = dv_cong_them
    '    row("cuoc_e1") = cuoc_e1
    '    row("PostCode") = PostCode
    '    row("Ma_E1") = Ma_E1
    '    row("Noi_Dung") = Noi_Dung
    '    row("Huy") = Huy
    '    row("Ma_KH") = IIf(Ma_KH.Trim = "", "", "Mã KH: " & Ma_KH)
    '    dataTable.Rows.Add(row)

    '    Return dataTable
    'End Function
#End Region
#Region "Tạo bảng E1"
    'Private Function Tao_Bang_E1() As DataTable
    '    Dim dataTable As New dataTable("E1")

    '    Dim colWork As DataColumn = New DataColumn("Id_E1", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Id_Duong_Thu", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Id_Chuyen_Thu", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Id_E2", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Id_Ca", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_Bc_Khai_Thac", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_E1", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ngay_Phat_Hanh", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Gio_Phat_Hanh", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ngay_Dong", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Gio_Dong", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ngay_Nhan", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Gio_Nhan", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_Don_Vi", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_Bc_Goc", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_Bc_Tra", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Nuoc_Nhan", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Nuoc_Tra", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Khoi_Luong", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Phan_Loai", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Loai_Hang_Hoa", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Khoi_Luong_QD", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Loai", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Dv_Cong_Them", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Dv_Gia_Tang", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("PPXD", GetType(Double))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Cuoc_PPXD", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("PostCode", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Cuoc_PPVX", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("VAT", GetType(Double))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("COD", GetType(Boolean))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Gia_Tri_Hang", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Cuoc_COD", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Cuoc_DV", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Cuoc_Chinh", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Cuoc_Giam", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Cuoc_E1", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Kien_So", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("STT", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_KH", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Nguoi_Gui", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Nguoi_Nhan", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Dia_Chi_Gui", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Dia_Chi_Nhan", GetType(String))
    '    dataTable.Columns.Add(colWork)


    '    colWork = New DataColumn("Dien_Thoai_Gui", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Dien_Thoai_Nhan", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("HH_Phat_Hanh", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("HH_Phat_Tra", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ma_Bc_CH", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Id_Nguoi_Dung", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Id_Trang_Thai", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ghi_Chu", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Truyen_Khai_Thac", GetType(Boolean))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Truyen_Doi_Soat", GetType(Boolean))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Ngay_He_Thong", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Chot_SL", GetType(Boolean))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("So_TKHQ", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("So_Bien_Lai", GetType(String))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Le_Phi_HQ", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Thue_NK", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Thue_VAT", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("Thue_NK_VAT", GetType(Integer))
    '    dataTable.Columns.Add(colWork)

    '    Dim row As DataRow
    '    For i = 0 To dgE1_Chua_PH.Rows.Count - 1
    '        If dgE1_Chua_PH.Rows(i).Cells("Chon").Text = "True" Then
    '            row = dataTable.NewRow()
    '            row("Id_E1") = dgE1_Chua_PH.Rows(i).Cells("Id_E1").Text
    '            row("Id_Duong_Thu") = dgE1_Chua_PH.Rows(i).Cells("Id_Duong_Thu").Text
    '            row("Id_Chuyen_Thu") = dgE1_Chua_PH.Rows(i).Cells("Id_Chuyen_Thu").Text
    '            row("Id_E2") = dgE1_Chua_PH.Rows(i).Cells("Id_E2").Text
    '            row("Id_Ca") = dgE1_Chua_PH.Rows(i).Cells("Id_Ca").Text
    '            row("Ma_Bc_Khai_Thac") = dgE1_Chua_PH.Rows(i).Cells("Ma_Bc_Khai_Thac").Text
    '            row("Ma_E1") = dgE1_Chua_PH.Rows(i).Cells("Ma_E1").Text
    '            row("Ngay_Phat_Hanh") = Ham_Dung_Chung.ConvertDateToInt(dgE1_Chua_PH.Rows(i).Cells("Ngay_Phat_Hanh").Value)
    '            row("Gio_Phat_Hanh") = dgE1_Chua_PH.Rows(i).Cells("Gio_Phat_Hanh").Text.Replace(":", "")
    '            row("Ngay_Dong") = dgE1_Chua_PH.Rows(i).Cells("Ngay_Dong").Value
    '            row("Gio_Dong") = dgE1_Chua_PH.Rows(i).Cells("Gio_Dong").Text.Replace(":", "")
    '            row("Ngay_Nhan") = dgE1_Chua_PH.Rows(i).Cells("Ngay_Nhan").Value
    '            row("Gio_Nhan") = dgE1_Chua_PH.Rows(i).Cells("Gio_Nhan").Text.Replace(":", "")
    '            row("Ma_Don_Vi") = dgE1_Chua_PH.Rows(i).Cells("Ma_Don_Vi").Text
    '            row("Ma_Bc_Goc") = dgE1_Chua_PH.Rows(i).Cells("Ma_Bc_Goc").Text
    '            row("Ma_Bc_Tra") = dgE1_Chua_PH.Rows(i).Cells("Ma_Bc_Tra").Text
    '            row("Nuoc_Nhan") = dgE1_Chua_PH.Rows(i).Cells("Nuoc_Nhan").Text
    '            row("Nuoc_Tra") = dgE1_Chua_PH.Rows(i).Cells("Nuoc_Tra").Text
    '            row("Khoi_Luong") = dgE1_Chua_PH.Rows(i).Cells("Khoi_Luong").Text
    '            row("Phan_Loai") = dgE1_Chua_PH.Rows(i).Cells("Phan_Loai").Text
    '            row("Loai_Hang_Hoa") = dgE1_Chua_PH.Rows(i).Cells("Loai_Hang_Hoa").Text
    '            row("Khoi_Luong_QD") = dgE1_Chua_PH.Rows(i).Cells("Khoi_Luong_QD").Text
    '            row("Loai") = dgE1_Chua_PH.Rows(i).Cells("Loai").Text
    '            row("Dv_Cong_Them") = dgE1_Chua_PH.Rows(i).Cells("Dv_Cong_Them").Text
    '            row("Dv_Gia_Tang") = dgE1_Chua_PH.Rows(i).Cells("Dv_Gia_Tang").Text
    '            row("PPXD") = dgE1_Chua_PH.Rows(i).Cells("PPXD").Text
    '            row("Cuoc_PPXD") = dgE1_Chua_PH.Rows(i).Cells("Cuoc_PPXD").Text
    '            row("PostCode") = dgE1_Chua_PH.Rows(i).Cells("PostCode").Text
    '            row("Cuoc_PPVX") = dgE1_Chua_PH.Rows(i).Cells("Cuoc_PPVX").Text
    '            row("VAT") = dgE1_Chua_PH.Rows(i).Cells("VAT").Text
    '            row("COD") = dgE1_Chua_PH.Rows(i).Cells("COD").Text
    '            row("Gia_Tri_Hang") = dgE1_Chua_PH.Rows(i).Cells("Gia_Tri_Hang").Text
    '            row("Cuoc_COD") = dgE1_Chua_PH.Rows(i).Cells("Cuoc_COD").Text
    '            row("Cuoc_DV") = dgE1_Chua_PH.Rows(i).Cells("Cuoc_DV").Text
    '            row("Cuoc_Chinh") = dgE1_Chua_PH.Rows(i).Cells("Cuoc_Chinh").Text
    '            row("Cuoc_Giam") = dgE1_Chua_PH.Rows(i).Cells("Cuoc_Giam").Text
    '            row("Cuoc_E1") = dgE1_Chua_PH.Rows(i).Cells("Cuoc_E1").Text
    '            row("Kien_So") = dgE1_Chua_PH.Rows(i).Cells("Kien_So").Text
    '            row("STT") = dgE1_Chua_PH.Rows(i).Cells("STT").Text
    '            row("Ma_KH") = dgE1_Chua_PH.Rows(i).Cells("Ma_KH").Text
    '            row("Nguoi_Gui") = dgE1_Chua_PH.Rows(i).Cells("Nguoi_Gui").Text
    '            row("Nguoi_Nhan") = dgE1_Chua_PH.Rows(i).Cells("Nguoi_Nhan").Text
    '            row("Dia_Chi_Gui") = dgE1_Chua_PH.Rows(i).Cells("Dia_Chi_Gui").Text
    '            row("Dia_Chi_Nhan") = dgE1_Chua_PH.Rows(i).Cells("Dia_Chi_Nhan").Text
    '            row("Dien_Thoai_Gui") = dgE1_Chua_PH.Rows(i).Cells("Dien_Thoai_Gui").Text
    '            row("Dien_Thoai_Nhan") = dgE1_Chua_PH.Rows(i).Cells("Dien_Thoai_Nhan").Text
    '            row("HH_Phat_Hanh") = dgE1_Chua_PH.Rows(i).Cells("HH_Phat_Hanh").Text
    '            row("HH_Phat_Tra") = dgE1_Chua_PH.Rows(i).Cells("HH_Phat_Tra").Text
    '            row("Ma_Bc_CH") = dgE1_Chua_PH.Rows(i).Cells("Ma_Bc_CH").Text
    '            row("Id_Nguoi_Dung") = dgE1_Chua_PH.Rows(i).Cells("Id_Nguoi_Dung").Text
    '            row("Id_Trang_Thai") = dgE1_Chua_PH.Rows(i).Cells("Id_Trang_Thai").Text
    '            row("Ghi_Chu") = dgE1_Chua_PH.Rows(i).Cells("Ghi_Chu").Text
    '            row("Truyen_Khai_Thac") = dgE1_Chua_PH.Rows(i).Cells("Truyen_Khai_Thac").Text
    '            row("Truyen_Doi_Soat") = dgE1_Chua_PH.Rows(i).Cells("Truyen_Doi_Soat").Text
    '            row("Ngay_He_Thong") = Ham_Dung_Chung.ConvertDateToInt(Now)
    '            row("Chot_SL") = dgE1_Chua_PH.Rows(i).Cells("Chot_SL").Text
    '            'Lệ phí Hải quan
    '            row("So_TKHQ") = dgE1_Chua_PH.Rows(i).Cells("So_TKHQ").Text
    '            row("So_Bien_Lai") = dgE1_Chua_PH.Rows(i).Cells("So_Bien_Lai").Text
    '            row("Le_Phi_HQ") = CInt(dgE1_Chua_PH.Rows(i).Cells("Le_Phi_HQ").Text)
    '            row("Thue_NK") = CInt(dgE1_Chua_PH.Rows(i).Cells("Thue_NK").Text)
    '            row("Thue_VAT") = CInt(dgE1_Chua_PH.Rows(i).Cells("Thue_VAT").Text)
    '            row("Thue_NK_VAT") = CInt(dgE1_Chua_PH.Rows(i).Cells("Thue_NK_VAT").Text)
    '            dataTable.Rows.Add(row)
    '        End If

    '    Next

    '    Return dataTable
    'End Function
#End Region
#Region "Datagrid"
#Region "DataGridE1_Chua_PH"
    'Private Sub DataGridE1_Chua_PH(ByVal Id_Ca As String)
    '    dgE1_Chua_PH.DataSource = myE1_Den_Tam.E1_Den_Tam_Chua_Phan_Huong(Id_Ca).Tables(0)
    '    dgE1_Chua_PH.DataBind()
    'End Sub
#End Region
#Region "DataGridE1_Da_PH"
    'Private Sub DataGridE1_Da_PH(ByVal Id_Ca As String)
    '    dgE1_Da_PH.DataSource = myE1_Den_Tam.E1_Den_Tam_Da_Phan_Huong(Id_Ca).Tables(0)
    '    dgE1_Da_PH.DataBind()
    'End Sub
#End Region
#Region "DataCombo_Quay_Giao_Dich"
    'Private Sub DataCombo_Quay_Giao_Dich()
    '    cbMa_Quay.DataSource = myQuayGiaoDich.Lay_Boi_Ma_BC_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
    '    cbMa_Quay.DataBind()
    '    If cbMa_Quay.Rows.Count > 0 Then
    '        cbMa_Quay.Value = cbMa_Quay.Rows(0).Cells("Ma_Quay").Value
    '    End If
    'End Sub
#End Region
#Region "DatagridKhach_Hang"
    'Private Sub DatagridKhach_Hang()
    '    cbKhach_Hang.DataSource = myKhachHang.Danh_Sach_Hieu_Luc(GBuu_Cuc_Khai_Thac).Tables(0)
    '    cbKhach_Hang.DataBind()
    '    cbKhach_Hang.Value = GMa_KH
    '    txtHo_Ten_Gui.Text = myKhachHang.Lay(cbKhach_Hang.Value).Ten_Khach_Hang
    '    txtDia_Chi_Gui.Text = myKhachHang.Lay(cbKhach_Hang.Value).Dia_Chi
    '    txtDien_Thoai_Gui.Text = myKhachHang.Lay(cbKhach_Hang.Value).Dien_Thoai
    'End Sub
#End Region
#End Region
#Region "Validated"
    Private Sub chkKhai_Gia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkKhai_Gia.Validated
        'Try
        '    If chkKhai_Gia.Checked Then
        '        Me.txtGia_Tri_Hang.Select()
        '    Else
        '        Me.btnThem_Vao_Tui.Select()
        '    End If
        'Catch ex As Exception
        '    CMessageBox.Show(ex.ToString(), "Thông báo")
        'End Try
    End Sub
    Private Sub cbLoai_Hang_Hoa_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLoai_Hang_Hoa.Validated
        'Try
        '    If cbLoai_Hang_Hoa.Value = 1 Then
        '        txtKhoi_Luong_QD.Enabled = True
        '        btnHang_Nhe.Enabled = True
        '        txtKhoi_Luong_QD.Focus()
        '    Else
        '        txtKhoi_Luong_QD.Value = txtKhoi_Luong.Value
        '        txtKhoi_Luong_QD.Enabled = False
        '        btnHang_Nhe.Enabled = False
        '        If txtSo_Hieu_E1.Text.Trim = "" Then
        '            Me.cbKhach_Hang.Select()
        '        Else
        '            If cbNuoc.Text = "VN" Then
        '                Me.cbDV_Cong_Them.Select()
        '            Else
        '                Me.btnThem_Vao_Tui.Select()
        '            End If
        '        End If
        '    End If
        '    Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
        'Catch ex As Exception
        '    CMessageBox.Show(ex.ToString(), "Thông báo")
        'End Try
    End Sub
    Private Sub cbDV_Cong_Them_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDV_Cong_Them.Validated
        'Try
        '    If Kiem_Tra_Dich_Vu_Cong_Them(cbDV_Cong_Them.Text, CInt(cbBuuCuc.Value), cbNuoc.Text) = False Then
        '        CMessageBox.Show("Hãy kiểm tra lại Dịch vụ cộng thêm." & vbNewLine & "Dịch vụ chỉ áp dụng cho E trong nước hoặc E đi quốc tế", "Thông báo", MessageBoxButtons.OK)
        '        cbDV_Cong_Them.Select()
        '        Exit Sub
        '    End If
        '    Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
        '    If dvct_check = True Then
        '        Me.btnThem_Vao_Tui.Select()
        '    End If
        '    If cbDV_Cong_Them.Text.Trim <> "" And cbDV_Cong_Them.Text.IndexOf("EMSC") >= 0 Then
        '        If cbKhach_Hang.Text.Trim = "" Then
        '            CMessageBox.Show("Sử dụng dịch vụ EMSC sẽ phải nhập khách hàng toàn quốc vào !!!", "Thông báo")
        '            cbKhach_Hang.Focus()
        '            Exit Sub
        '        End If
        '    End If
        'Catch ex As Exception
        '    CMessageBox.Show(ex.ToString)
        'End Try
    End Sub
    Private Sub cbDV_Gia_Tang_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDV_Gia_Tang.Validated
        'Try
        '    Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
        '    If dvgt_check = True Then
        '        Me.btnThem_Vao_Tui.Select()
        '    End If
        'Catch ex As Exception
        '    CMessageBox.Show(ex.ToString)
        'End Try
    End Sub
    Private Sub cbDuongThuDi_PH_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDuongThuDi_PH.Validated
        'If IsNumeric(cbDuongThuDi_PH.Value) = False Or cbDuongThuDi_PH.Text = "" Then
        '    CMessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    cbDuongThuDi_PH.Focus()
        '    Exit Sub
        'Else
        '    Lay_TT_Duong_Thu()
        '    If cbNuoc.Text = "VN" Then
        '        If myDuong_Thu_Di_Chi_Tiet.Ma_Bc = 101000 Or myDuong_Thu_Di_Chi_Tiet.Ma_Bc = 100916 Then
        '            cbBuuCuc.Value = 100000
        '        ElseIf myDuong_Thu_Di_Chi_Tiet.Ma_Bc = 550100 Or myDuong_Thu_Di_Chi_Tiet.Ma_Bc = 550915 Then
        '            cbBuuCuc.Value = 550000
        '        ElseIf myDuong_Thu_Di_Chi_Tiet.Ma_Bc = 701000 Or myDuong_Thu_Di_Chi_Tiet.Ma_Bc = 700916 Then
        '            cbBuuCuc.Value = 700000
        '        End If
        '    End If
        '    Me.cbKhach_Hang.Select()
        'End If
    End Sub
    Private Sub cbMa_Quay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMa_Quay.Validated
        'If cbMa_Quay.Text.Trim = "" Then
        '    CMessageBox.Show("Thông tin về Quầy giao dịch không được để trống " & vbNewLine & "Hãy vào phần các bảng danh mục để thêm Mã Quầy giao dịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    cbMa_Quay.Focus()
        '    Exit Sub
        'Else
        '    myMaQuay = CInt(cbMa_Quay.Value)
        'End If
    End Sub
    Private Sub cbBuu_Cuc_CH_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBuu_Cuc_CH.Validated
        'cbBuu_Cuc_CH.Text = FormatMaBc(cbBuu_Cuc_CH.Text)
        'If IsNumeric(cbBuu_Cuc_CH.Text) = False And cbBuu_Cuc_CH.Text <> "" Then
        '    CMessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    cbBuu_Cuc_CH.Focus()
        '    Exit Sub
        'ElseIf cbBuu_Cuc_CH.Text = "000000" Then
        '    chkChuyen_Hoan_Bc.Checked = False
        '    cbBuu_Cuc_CH.Enabled = False
        '    optChuyen_Hoan.Checked = False
        'End If
    End Sub
    Private Sub txtGia_Tri_Hang_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGia_Tri_Hang.Validated
        'Try
        '    If IsNumeric(txtGia_Tri_Hang.Text) = False And txtGia_Tri_Hang.Text <> "" Then
        '        CMessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        txtGia_Tri_Hang.Focus()
        '        Exit Sub
        '    End If
        '    Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
        '    If txtGia_Tri_Hang.Value = 0 Then
        '        chkKhai_Gia.CheckState = CheckState.Unchecked
        '    End If
        '    Me.btnThem_Vao_Tui.Select()
        'Catch ex As Exception
        '    CMessageBox.Show(ex.ToString(), "Thông báo")
        'End Try
    End Sub
    Private Sub txtDien_Thoai_Nhan_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDien_Thoai_Nhan.Validated, optTai_Lieu.Validated, optBinh_Thuong.Validated, optThoa_Thuan.Validated, cbBuu_Cuc_CH.Validated
        'Me.txtKhoi_Luong.Select()
    End Sub
    Private Sub btnThem_Vao_Tui_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem_Vao_Tui.Validated
        'Me.cbKhach_Hang.Select()
    End Sub
    Private Sub txtDien_Thoai_Gui_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDien_Thoai_Gui.Validated
        'Me.txtHo_Ten_Nhan.Select()
    End Sub
    Private Sub optHang_Hoa_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles optHang_Hoa.Validated
        'Me.cbLoai_Hang_Hoa.Select()
    End Sub
#End Region
#Region "CheckedChanged"
    'Private Sub optBinh_Thuong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBinh_Thuong.CheckedChanged, optThoa_Thuan.CheckedChanged, optSu_Vu.CheckedChanged
    '    Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
    'End Sub

    'Private Sub chkChuyen_Hoan_Bc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChuyen_Hoan_Bc.CheckedChanged
    '    If chkChuyen_Hoan_Bc.Checked Then
    '        cbBuu_Cuc_CH.Enabled = True
    '        cbBuu_Cuc_CH.DataSource = myBuuCuc.Danh_Sach_Rut_Gon
    '        cbBuu_Cuc_CH.DataBind()
    '        If cbBuu_Cuc_CH.Rows.Count > 0 Then
    '            cbBuu_Cuc_CH.Value = GBuu_Cuc_Khai_Thac 'cbBuu_Cuc_CH.Rows(0).Cells("Ma_BC").Value
    '        End If
    '    Else
    '        cbBuu_Cuc_CH.Enabled = False
    '        cbBuu_Cuc_CH.Value = 0
    '    End If
    'End Sub
    'Private Sub optTai_Lieu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTai_Lieu.CheckedChanged, optHang_Hoa.CheckedChanged
    '    Try
    '        If optTai_Lieu.Checked Then
    '            cbLoai_Hang_Hoa.Enabled = False
    '        Else
    '            cbLoai_Hang_Hoa.Enabled = True
    '        End If
    '        Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
    '    Catch ex As Exception
    '        CMessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
    '    Dim i As Integer
    '    If tabQuanLy.Tabs("0").Active = True Then
    '        For i = 0 To dgE1_Chua_PH.Rows.Count - 1
    '            dgE1_Chua_PH.Rows(i).Cells("Chon").Value = chkAll.Checked
    '        Next
    '        ReCalculate_Summary(dgE1_Chua_PH)
    '    ElseIf tabQuanLy.Tabs("1").Active = True Then
    '        For i = 0 To dgE1_Da_PH.Rows.Count - 1
    '            dgE1_Da_PH.Rows(i).Cells("Chon").Value = chkAll.Checked
    '        Next
    '        ReCalculate_Summary(dgE1_Da_PH)
    '    End If
    'End Sub
    'Private Sub chkKhai_Gia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKhai_Gia.CheckedChanged
    '    If chkKhai_Gia.Checked Then
    '        txtGia_Tri_Hang.Enabled = True
    '        txtGia_Tri_Hang.Focus()
    '    Else
    '        txtGia_Tri_Hang.Enabled = False
    '        txtGia_Tri_Hang.Value = 0
    '        Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
    '    End If
    'End Sub
#End Region
#Region "ItemNotInList"
    '#Region "cbDV_Cong_Them_ItemNotInList"
    '    Private Sub cbDV_Cong_Them_ItemNotInList(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs) Handles cbDV_Cong_Them.ItemNotInList
    '        If (cbDV_Cong_Them.Text = "" Or cbDV_Cong_Them.Text = "0") Then
    '            cbDV_Cong_Them.Text = ""
    '            dvct_check = True
    '        ElseIf (cbDV_Cong_Them.LimitToList = False) Then
    '            cbDV_Cong_Them.Select()
    '            dvct_check = False
    '        Else
    '            cbDV_Cong_Them.Text = ""
    '            dvct_check = True
    '        End If
    '    End Sub
    '#End Region
    '#Region "cbDV_Gia_Tang_ItemNotInList"
    '    Private Sub cbDV_Gia_Tang_ItemNotInList(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs) Handles cbDV_Gia_Tang.ItemNotInList
    '        If (cbDV_Gia_Tang.Text = "" Or cbDV_Gia_Tang.Text = "0") Then
    '            cbDV_Gia_Tang.Text = ""
    '            dvgt_check = True
    '        ElseIf (cbDV_Gia_Tang.LimitToList = False) Then
    '            cbDV_Gia_Tang.Select()
    '            dvgt_check = False
    '        Else
    '            cbDV_Gia_Tang.Text = ""
    '            dvgt_check = True
    '        End If
    '    End Sub
    '#End Region
#End Region
#Region "InitializeLayout"
    '#Region "dgE1_Chua_PH_InitializeLayout"
    '    Private Sub dgE1_Chua_PH_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Chua_PH.InitializeLayout
    '        dgE1_Chua_PH.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
    '        dgE1_Chua_PH.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    '    End Sub

    '    Private Sub dgE1_Chua_PH_XLS_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Chua_PH_XLS.InitializeLayout
    '        dgE1_Chua_PH_XLS.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
    '        dgE1_Chua_PH_XLS.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    '    End Sub
    '#End Region
    '#Region "dgE1_Da_PH_InitializeLayout"
    '    Private Sub dgE1_Da_PH_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Da_PH.InitializeLayout
    '        dgE1_Da_PH.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
    '        dgE1_Da_PH.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    '    End Sub
    '#End Region
#End Region
#Region "AfterRowActivate"
    '#Region "dgE1_Chua_PH_AfterRowActivate"
    '    Private Sub dgE1_Chua_PH_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Chua_PH.AfterRowActivate

    '    End Sub
    '#End Region
    '#Region "dgE1_Da_PH_AfterRowActivate"
    '    Private Sub dgE1_Da_PH_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Da_PH.AfterRowActivate
    '        ReCalculate_Summary(dgE1_Da_PH)
    '    End Sub
    '#End Region
#End Region
#Region "Function"
    '#Region "Enable_Control"
    '    Private Sub Enable_Control(ByVal Value As Boolean)
    '        txtGio_Gui.Enabled = Value
    '        dtpNgay_Gui.Enabled = Value
    '        txtPostcode.Enabled = Value
    '        btnVung_Xa.Enabled = Value

    '        cbDuongThuDi_PH.Enabled = Not Value
    '        cbMa_Quay.Enabled = Not Value

    '        If GUserAdmin = True Then
    '            txtCuoc_Chinh.Enabled = Not Value
    '            txtCuoc_DV.Enabled = Not Value
    '            txtCuoc_E1.Enabled = Not Value
    '        Else
    '            txtCuoc_Chinh.Enabled = Value
    '            txtCuoc_DV.Enabled = Value
    '            txtCuoc_E1.Enabled = Value
    '        End If
    '    End Sub
    '#End Region
    '#Region "Update_Cuoc"
    '    Private Sub Update_Cuoc(ByVal Ma_E1 As String)
    '        If Ma_E1.Length <> 13 Then
    '            Exit Sub
    '        End If
    '        Dim myCo_Dich_Cuoc As Boolean = False
    '        Dim Ngay_Phat_Hanh As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgay_Gui.Value)
    '        Dim Cuoc_E1 As Double
    '        Dim Cuoc_DVCT As Double
    '        Dim Cuoc_DVGT As Double
    '        Dim Cuoc_DVKG As Double
    '        Dim myMa_Bc_Goc As Integer = GBuu_Cuc_Khai_Thac 'Tim_Danh_Muc_BC_TuE1(Ma_E1).Ma_BC
    '        Dim myMa_Nuoc_Nhan As String = TimNuocNhanTuE1(Ma_E1)
    '        Dim myKhoi_Luong As Integer = IIf(CInt(txtKhoi_Luong_QD.Text) > CInt(txtKhoi_Luong.Text), CInt(txtKhoi_Luong_QD.Text), CInt(txtKhoi_Luong.Text))
    '        Dim myMa_Bc_Tra As Integer = CInt(cbBuuCuc.Value)
    '        Dim myMa_Nuoc_Tra As String = CStr(cbNuoc.Text.Trim)
    '        Dim myPhan_Loai As String = IIf(optTai_Lieu.Checked, "D", "M")
    '        Dim myLoai As Integer = IIf(optBinh_Thuong.Checked = True, 0, IIf(optSu_Vu.Checked = True, 1, 2))
    '        Dim myCuocPPXD As Integer = CInt(IIf(chkVungXaTN.Checked, 1, 0))
    '        'Tính cước dịch vụ cộng thêm và dịch vụ gia tăng
    '        If GIsCPN = 0 Then
    '            Cuoc_E1 = Round(myTinh_Cuoc.Cuoc_Chinh_E1(myMa_Bc_Goc, _
    '                        myMa_Nuoc_Nhan, _
    '                        myMa_Bc_Tra, _
    '                        myMa_Nuoc_Tra, _
    '                        txtPostcode.Text.Trim, _
    '                        myPhan_Loai, _
    '                        myKhoi_Luong, _
    '                        Ngay_Phat_Hanh, _
    '                        myLoai, myCuocPPXD) + 0.0005)
    '        Else
    '            Cuoc_E1 = Round(myTinh_Cuoc.Cuoc_Chinh_E1_CPN(myMa_Bc_Goc, _
    '            myMa_Nuoc_Nhan, _
    '            myMa_Bc_Tra, _
    '            myMa_Nuoc_Tra, _
    '            txtPostcode.Text.Trim, _
    '            myPhan_Loai, _
    '            myKhoi_Luong, _
    '            Ngay_Phat_Hanh, _
    '            myLoai, myCuocPPXD, cbKhach_Hang.Text) + 0.0005)
    '        End If


    '        txtCuoc_Chinh.Text = Cuoc_E1

    '        If cbLoai_Hang_Hoa.Value = 2 Then 'Hàng kồng kềnh
    '            Cuoc_E1 = Cuoc_E1 * 1.5
    '            txtCuoc_Chinh.Value = Round(Cuoc_E1 + 0.0005)
    '        End If

    '        Cuoc_DVCT = Round(myTinh_Cuoc.Cuoc_DV_Cong_Them(cbDV_Cong_Them.Text, _
    '                            Ngay_Phat_Hanh, cbNuoc.Value) + 0.0005)

    '        Cuoc_DVGT = Round(myTinh_Cuoc.Cuoc_DV_Gia_Tang(myMa_Bc_Goc, _
    '            myMa_Bc_Tra, _
    '            cbDV_Gia_Tang.Text, _
    '            IIf(CInt(txtKhoi_Luong_QD.Text) > CInt(txtKhoi_Luong.Text), _
    '            CInt(txtKhoi_Luong_QD.Text), _
    '            CInt(txtKhoi_Luong.Text)), _
    '            Ngay_Phat_Hanh) + 0.0005)

    '        Cuoc_DVKG = Round(myTinh_Cuoc.Cuoc_DV_Khai_Gia(txtGia_Tri_Hang.Value, Ngay_Phat_Hanh) + 0.0005)
    '        'HSXT
    '        If myCuoc_Dv_Cong_Them.Co_Dinh_Cuoc(cbDV_Cong_Them.Text, Ngay_Phat_Hanh) = True Then
    '            myCo_Dich_Cuoc = True
    '            Cuoc_E1 = Round(myTinh_Cuoc.Cuoc_DV_Cong_Them(cbDV_Cong_Them.Text, _
    '                            Ngay_Phat_Hanh, cbNuoc.Value) + 0.0005)
    '            txtCuoc_Chinh.Value = Cuoc_E1
    '            Cuoc_DVCT = 0
    '            Cuoc_DVGT = 0
    '            Cuoc_DVKG = 0
    '        End If

    '        txtCuoc_DV.Value = Cuoc_DVCT + Cuoc_DVGT + Cuoc_DVKG

    '        myHHPhatTra = myTinh_Cuoc.HH_Phat_Tra(myMa_Bc_Goc, _
    '                            myMa_Nuoc_Nhan, _
    '                            myMa_Bc_Tra, _
    '                            myMa_Nuoc_Tra, _
    '                            myKhoi_Luong, _
    '                            myLoai, _
    '                            Ngay_Phat_Hanh)
    '        myHHPhatHanh = myTinh_Cuoc.HH_Phat_Hanh(myMa_Bc_Goc, _
    '                            myMa_Bc_Tra, _
    '                            myLoai, _
    '                            Ngay_Phat_Hanh) * (Cuoc_E1 + Cuoc_DVCT + Cuoc_DVGT + Cuoc_DVKG)

    '        If myMa_Nuoc_Tra <> "VN" Then
    '            If GIsCPN = 1 Then
    '                Cuoc_E1 = Round(Cuoc_E1 * (1 + GVat) + 0.0005)
    '                Cuoc_E1 = Round(Cuoc_E1 / 100) * 100
    '            Else
    '                Cuoc_E1 = Round(Cuoc_E1 * (1 + GVat) + 0.0005)
    '            End If

    '        Else
    '            Cuoc_E1 = Round(Cuoc_E1 * (1 + GVat) + 0.0005)
    '        End If
    '        Cuoc_DVCT = Round(Cuoc_DVCT * (1 + GVat) + 0.0005)
    '        Cuoc_DVGT = Round(Cuoc_DVGT * (1 + GVat) + 0.0005)
    '        Cuoc_DVKG = Round(Cuoc_DVKG * (1 + GVat) + 0.0005)
    '        If myCo_Dich_Cuoc = True Then
    '            txtCuoc_E1.Value = Cuoc_E1
    '        Else
    '            txtCuoc_E1.Value = Cuoc_E1 + Cuoc_DVCT + Cuoc_DVGT + Cuoc_DVKG
    '        End If

    '    End Sub
    '#End Region
    '#Region "Kiểm tra thông tin"
    '    Private Function Check_Infor() As Boolean
    '        'Kiểm tra ngày ca kế toán
    '        If GId_Ca = "" Then
    '            If CMessageBox.Show("Hiện tại bạn không làm việc trong bất cứ ca làm việc nào!!!" & vbNewLine _
    '                              & "   Bạn phải thoát khỏi chương trình rồi vào lại     ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.No Then
    '                Return False
    '                Exit Function
    '            Else
    '                Me.Dispose()
    '                Me.Close()
    '                Dim frm As New FrmLogin
    '                frm.ShowDialog()
    '            End If
    '        End If

    '        'Kiểm tra thông tin về đường thư
    '        If cbDuongThuDi_PH.Text.Trim = "" Then
    '            CMessageBox.Show("Thông tin về đường thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            cbDuongThuDi_PH.Focus()
    '            Return False
    '            Exit Function
    '        End If
    '        'Kiểm tra thông tin về Quầy giao dịch
    '        If cbMa_Quay.Text.Trim = "" Then
    '            CMessageBox.Show("Thông tin về Quầy giao dịch không được để trống " & vbNewLine & "Hãy vào phần các bảng danh mục để thêm Mã Quầy giao dịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            cbMa_Quay.Focus()
    '            Return False
    '            Exit Function
    '        End If
    '        'Kiểm tra thông tin về E1
    '        If txtSo_Hieu_E1.Text.Trim = "" Then
    '            CMessageBox.Show("Thông tin về E1 không được để trống " & vbNewLine & "Hãy nhập số hiệu E1 đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            cbKhach_Hang.Focus()
    '            Return False
    '            Exit Function
    '        End If
    '        'Thông tin được xác nhận dúng
    '        Return True
    '    End Function
    '#End Region
    '#Region "Lay_TT_Duong_Thu"
    '    Private Sub Lay_TT_Duong_Thu()
    '        Dim myDataTable As DataTable
    '        myE2Date = dtpNgay_Gui.Value
    '        myIdCa = GId_Ca
    '        'Lấy thông tin đường thư chi tiết
    '        myDataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi_PH.Value))
    '        If myDataTable.Rows.Count > 0 And cbDuongThuDi_PH.IsItemInList = True Then
    '            myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
    '            myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
    '            myDuong_Thu_Di_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
    '            myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
    '            myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
    '            myIdDuongThu = myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu
    '        Else
    '            cbDuongThuDi_PH.Focus()
    '        End If
    '    End Sub
    '#End Region
    '#Region "Lay_TT_Ngay_Thang"
    '    Private Sub Lay_TT_Ngay_Thang(ByVal E2_Date As Integer)
    '        If E2_Date <> 0 Then
    '            If myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 1 Or myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 0 Then  'Đường Thư Nội Tỉnh,Bưu tá: Chuyến Thư tăng theo Tháng
    '                myStart_Date = (E2_Date \ 100) * 100
    '                myEnd_Date = (E2_Date \ 100) * 100 + 99
    '            ElseIf myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 2 Or myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 3 Or myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 4 Or myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5 Or myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6 Then    'Đường Thư Liên Tỉnh,Liền kề, Quốc tê, Lưu kho, Vô thừa nhận: Chuyến Thư tăng theo Năm
    '                myStart_Date = (E2_Date \ 10000) * 10000
    '                myEnd_Date = (E2_Date \ 10000) * 10000 + 9999
    '            Else 'Chưa tồn tại phân loại đường thư này
    '                CMessageBox.Show("Không tồn tại phân loại đường thư này!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Exit Sub
    '            End If
    '        Else
    '            CMessageBox.Show("Ngày E2 chưa được xác định!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End Sub
    '#End Region
    '#Region "ReCalculate_Summary"
    '    Private Sub ReCalculate_Summary(ByVal Sender As Object)
    '        myGridKeyDown = Sender
    '        Dim i As Integer
    '        Dim Tong_so As Integer
    '        Dim Tong_Khoi_Luong As Integer
    '        Dim Tong_Cuoc_E2 As Integer
    '        Tong_so = 0
    '        Tong_Khoi_Luong = 0
    '        Tong_Cuoc_E2 = 0
    '        If myGridKeyDown.Rows.Count = 0 Then
    '            txtInfor.Text = "Tổng số :    " & Tong_so & vbNewLine & "Khối lượng : " & (CDbl(Tong_Khoi_Luong) / 1000) & " Kg" & vbNewLine & "Tổng cước :  " & Tong_Cuoc_E2
    '            txtInfor_E1.Text = "Khối lượng: 0" & vbNewLine _
    '                                & "Cước: 0"
    '            Exit Sub
    '        End If
    '        For i = 0 To myGridKeyDown.Rows.Count - 1
    '            If myGridKeyDown.Rows(i).Cells("Chon").Text = True Then
    '                Tong_so += 1
    '                Tong_Khoi_Luong += CInt(myGridKeyDown.Rows(i).Cells("Khoi_Luong").Text)
    '                Tong_Cuoc_E2 += CInt(myGridKeyDown.Rows(i).Cells("Cuoc_E1").Text)
    '                'Tong_Cuoc_E2 += (CInt(myGridKeyDown.Rows(i).Cells("Cuoc_Chinh").Text) + CInt(myGridKeyDown.Rows(i).Cells("Cuoc_Dv").Text)) - CInt(myGridKeyDown.Rows(i).Cells("Cuoc_Giam").Text)
    '            End If
    '        Next
    '        txtInfor.Text = "Tổng số :    " & Tong_so & vbNewLine & "Khối lượng : " & (CDbl(Tong_Khoi_Luong) / 1000) & " Kg" & vbNewLine & "Tổng cước :  " & Tong_Cuoc_E2
    '        'Thong tin chi tiet E1
    '        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_KH").Text = "" Then
    '            txtInfor_E1.Text = "Khối lượng: " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text / 1000 & " Kg" & _
    '                                " (" & IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Text = "D", "Tài liệu", "Hàng hoá") & ")" & vbNewLine _
    '                                & "Cước: " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Text & vbNewLine _
    '                                & IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Tra").Value <> 0, "Bưu cục trả : " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Tra").Value & " - " & myBuuCuc.Lay(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Tra").Value).Ten_Buu_Cuc, "Nước trả : " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text)
    '        Else
    '            txtInfor_E1.Text = "Khối lượng: " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text / 1000 & "Kg" & IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Text = "D", " -Tài liệu", " -Hàng hoá") & vbNewLine _
    '                                & "Cước: " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Text & vbNewLine _
    '                                & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_KH").Text & "(Nợ)" & vbNewLine _
    '                                & IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Tra").Value <> 0, "Bưu cục trả : " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Tra").Value & " - " & myBuuCuc.Lay(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Tra").Value).Ten_Buu_Cuc, "Bưu cục trả : " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text)
    '        End If
    '    End Sub
    '#End Region
#End Region
#Region "In_BC01"
    'Private Sub In_BC01()
    '    Dim frm As New FrmBC01
    '    If cbKhach_Hang.Text <> "" Then
    '        frm.strMaKH = CStr(cbKhach_Hang.Value)
    '        frm.strGiaTri = myE1_Den_Tam.Lay_Theo_Ma_KH(cbKhach_Hang.Value, GId_Ca).Tong_Cuoc_E1
    '    Else
    '        frm.strDiaChi = txtDia_Chi_Gui.Text
    '        frm.strHoTen = txtHo_Ten_Gui.Text
    '        frm.strGiaTri = CInt(txtCuoc_E1.Value)
    '    End If
    '    frm.ShowDialog()
    'End Sub
#End Region
#Region "Button click"
    '#Region "In_Du_Lieu"
    '    Private Sub In_Du_Lieu(ByVal Sender As Object, ByVal da_phan_huong As Boolean, ByVal Preview As Boolean)
    '        Dim i As Integer
    '        myGridKeyDown = Sender
    '        If da_phan_huong = True Then
    '            myGridKeyDown = dgE1_Da_PH
    '        Else
    '            myGridKeyDown = dgE1_Chua_PH
    '        End If
    '        Dim kiem_tra_chon As Boolean = False
    '        If myGridKeyDown.Rows.Count = 0 Then
    '            CMessageBox.Show("Không có dữ liệu để in !!!", "Thông báo")
    '            Exit Sub
    '        End If
    '        If cbLua_Chon_In_PH.Value = 0 Then 'In vận đơn E1
    '            'In E1
    '            For i = 0 To myGridKeyDown.Rows.Count - 1
    '                If myGridKeyDown.Rows(i).Cells("Chon").Value = True Then
    '                    In_E1(myGridKeyDown.Rows(i).Cells("Ma_E1").Text, Preview)
    '                    kiem_tra_chon = True
    '                End If
    '            Next
    '            If kiem_tra_chon = False Then
    '                CMessageBox.Show("Bạn chưa chọn mã E1 nào để in cả !!!", "Thông báo")
    '                Exit Sub
    '            End If
    '        End If
    '    End Sub
    '#End Region
    '#Region "btnIn_Click"
    '    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
    '        Try
    '            If tabQuanLy.Tabs("0").Active = True Then
    '                In_Du_Lieu(dgE1_Chua_PH, False, False)
    '            ElseIf tabQuanLy.Tabs("1").Active = True Then
    '                In_Du_Lieu(dgE1_Da_PH, True, False)
    '            End If
    '        Catch ex As Exception
    '            CMessageBox.Show("Không kết nối được với máy in, Xin hãy kiểm tra lại kết nối với máy in", "Thông báo", MessageBoxButtons.OK)
    '        End Try
    '    End Sub
    '#End Region
    '#Region "btnSua_Chua_Click"
    '    Private Sub btnSua_Chua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua_Chua.Click
    '        Try
    '            If tabQuanLy.Tabs("0").Active = True Then 'Tại tab khi dữ liêu chưa phân hướng
    '                If dgE1_Chua_PH.Rows.Count = 0 Then
    '                    CMessageBox.Show("Không có dữ liệu để sửa chữa !!!", "Thông báo")
    '                    Exit Sub
    '                End If
    '                If dgE1_Chua_PH.Rows(dgE1_Chua_PH.ActiveRow.Index).Cells("Chon").Value = True Then
    '                    tabPhanHuong.SelectedTab = tabPhanHuong.Tabs("0")
    '                    Kiem_Tra_Sua_Chua = True
    '                    btnThem_Vao_Tui.Text = "Sửa chữa và in E1"
    '                    'Hiển thị dữ liệu cần sửa trên form
    '                    myE1_Den_Tam_Chi_Tiet = myE1_Den_Tam.Lay(dgE1_Chua_PH.Rows(dgE1_Chua_PH.ActiveRow.Index).Cells("Id_E1").Text)
    '                    myMaE1 = myE1_Den_Tam_Chi_Tiet.Ma_E1
    '                    txtSo_Hieu_E1.Text = myE1_Den_Tam_Chi_Tiet.Ma_E1
    '                    cbDuongThuDi_PH.Value = myDuong_Thu_Di.Lay(myE1_Den_Tam_Chi_Tiet.Id_Duong_Thu).Ma_Bc
    '                    cbMa_Quay.Value = myE1_Den_Tam_Chi_Tiet.Ma_Quay
    '                    cbKhach_Hang.Value = myE1_Den_Tam_Chi_Tiet.Ma_KH
    '                    txtHo_Ten_Gui.Text = myE1_Den_Tam_Chi_Tiet.Nguoi_Gui
    '                    txtDia_Chi_Gui.Text = myE1_Den_Tam_Chi_Tiet.Dia_Chi_Gui
    '                    txtDien_Thoai_Gui.Text = myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Gui
    '                    txtHo_Ten_Nhan.Text = myE1_Den_Tam_Chi_Tiet.Nguoi_Nhan
    '                    txtDia_Chi_Nhan.Text = myE1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan
    '                    txtDien_Thoai_Nhan.Text = myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan
    '                    cbBuuCuc.Value = myE1_Den_Tam_Chi_Tiet.Ma_Bc_Tra
    '                    cbNuoc.Value = myE1_Den_Tam_Chi_Tiet.Nuoc_Tra
    '                    txtPostcode.Text = myE1_Den_Tam_Chi_Tiet.PostCode
    '                    optTai_Lieu.Checked = IIf(myE1_Den_Tam_Chi_Tiet.Phan_Loai = "D", True, False)
    '                    optHang_Hoa.Checked = IIf(myE1_Den_Tam_Chi_Tiet.Phan_Loai = "M", True, False)
    '                    optBinh_Thuong.Checked = IIf(myE1_Den_Tam_Chi_Tiet.Loai = 0, True, False)
    '                    optThoa_Thuan.Checked = IIf(myE1_Den_Tam_Chi_Tiet.Loai = 2, True, False)
    '                    optSu_Vu.Checked = IIf(myE1_Den_Tam_Chi_Tiet.Loai = 1, True, False)
    '                    txtNoi_Dung_Gui.Text = myE1_Den_Tam_Chi_Tiet.Ghi_Chu
    '                    chkChuyen_Hoan_Bc.Checked = IIf(myE1_Den_Tam_Chi_Tiet.Ma_Bc_CH <> 0, True, False)
    '                    cbBuu_Cuc_CH.Value = myE1_Den_Tam_Chi_Tiet.Ma_Bc_CH
    '                    txtGio_Gui.Value = Ham_Dung_Chung.ConvertIntToTime(myE1_Den_Tam_Chi_Tiet.Gio_Phat_Hanh)
    '                    dtpNgay_Gui.Value = Ham_Dung_Chung.ConvertIntToDate(myE1_Den_Tam_Chi_Tiet.Ngay_Phat_Hanh)
    '                    txtKhoi_Luong.Text = myE1_Den_Tam_Chi_Tiet.Khoi_Luong
    '                    txtKhoi_Luong_QD.Text = myE1_Den_Tam_Chi_Tiet.Khoi_Luong_QD
    '                    cbLoai_Hang_Hoa.Value = myE1_Den_Tam_Chi_Tiet.Loai_Hang_Hoa
    '                    txtCuoc_Chinh.Text = myE1_Den_Tam_Chi_Tiet.Cuoc_Chinh
    '                    cbDV_Cong_Them.Text = myE1_Den_Tam_Chi_Tiet.Dv_Cong_Them
    '                    cbDV_Gia_Tang.Text = myE1_Den_Tam_Chi_Tiet.Dv_Gia_Tang
    '                    chkKhai_Gia.Checked = IIf(myE1_Den_Tam_Chi_Tiet.Gia_Tri_Hang = 0, False, True)
    '                    txtGia_Tri_Hang.Value = myE1_Den_Tam_Chi_Tiet.Gia_Tri_Hang
    '                    txtCuoc_DV.Text = myE1_Den_Tam_Chi_Tiet.Cuoc_DV
    '                    txtCuoc_E1.Text = myE1_Den_Tam_Chi_Tiet.Cuoc_E1
    '                    txtSo_Hieu_E1.Focus()
    '                Else
    '                    CMessageBox.Show("Bạn chưa chọn mã E1 nào để sửa cả !!!", "Thông báo")
    '                    Kiem_Tra_Sua_Chua = False
    '                    Exit Sub
    '                End If
    '            ElseIf tabQuanLy.Tabs("1").Active = True Then 'Tại tab khi dữ liệu đã được phân hướng
    '                If dgE1_Da_PH.Rows.Count = 0 Then
    '                    CMessageBox.Show("Không có dữ liệu để sửa chữa !!!", "Thông báo")
    '                    Exit Sub
    '                End If
    '            End If
    '        Catch ex As Exception
    '            CMessageBox.Show(ex.ToString(), "Thông báo")
    '        End Try
    '    End Sub
    '#End Region
    '#Region "btnClose_Click"
    '    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    '        Try
    '            Close()
    '        Catch ex As Exception
    '            CMessageBox.Show(ex.ToString(), "Thông báo")
    '        End Try
    '    End Sub
    '#End Region
    '#Region "btnPhan_Huong_Click"
    '    Private Sub btnPhan_Huong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhan_Huong.Click
    '        Try
    '            If dgE1_Chua_PH.Rows.Count = 0 Then
    '                CMessageBox.Show("Hiện tại chưa có dữ liệu cần phân hướng!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Exit Sub
    '            End If

    '            Dim frm As New FrmThongTinPH
    '            frm.myDataTruyen = Tao_Bang_E1()
    '            frm.myMa_Quay = cbMa_Quay.Value
    '            frm.ShowDialog()
    '            'load lai
    '            DataGridE1_Chua_PH(GId_Ca)
    '            DataGridE1_Da_PH(GId_Ca)
    '        Catch ex As Exception
    '            CMessageBox.Show(ex.ToString(), "Thông báo")
    '        End Try
    '    End Sub
    '#End Region
    '#Region "btnHang_Nhe_Click"
    '    Private Sub btnHang_Nhe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHang_Nhe.Click
    '        Try
    '            Dim Frm As New FrmTinh_Hang_Nhe
    '            Frm.ShowDialog()
    '            If Frm.txtKet_Qua.Text <> 0 Then
    '                IIf(txtKhoi_Luong_QD.Value Is System.DBNull.Value Or txtKhoi_Luong_QD.Text = "0" Or txtKhoi_Luong_QD.Value Is Nothing, CInt(Frm.txtKet_Qua.Text), CInt(txtKhoi_Luong.Text.Trim))
    '                txtKhoi_Luong_QD.Value = CInt(Frm.txtKet_Qua.Text)
    '            End If
    '            If CInt(txtKhoi_Luong.Value) > CInt(txtKhoi_Luong_QD.Value) Then
    '                txtKhoi_Luong_QD.Value = txtKhoi_Luong.Value
    '            End If
    '            cbDV_Cong_Them.Select()
    '        Catch ex As Exception
    '            CMessageBox.Show(ex.ToString(), "Thông báo")
    '        End Try
    '    End Sub
    '#End Region
    '#Region "btnQuanLyIn_Click"
    '    Private Sub btnQuanLyIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuanLyIn.Click
    '        Dim frm As New FrmQuanLyInBanKe
    '        frm.ShowDialog()
    '    End Sub
    '#End Region
    '#Region "btnkeys_Click"
    '    Private Sub btnkeys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeys.Click
    '        'Dim frm As New FrmVietTat
    '        'frm.ShowDialog()
    '        'txtHo_Ten_Nhan.Text = GTen_Viet_Tat
    '        'txtDia_Chi_Nhan.Text = GGhi_Chu
    '        'txtDien_Thoai_Nhan.Text = GMa_Viet_Tat
    '    End Sub
    '#End Region
#End Region
#Region "Tìm kiếm"
    '#Region "Match Function"
    '    Private Function Match(ByVal userString As String, ByVal cellValue As String) As Boolean
    '        If userString.Length > cellValue.Length Then
    '            Match = False
    '            Exit Function
    '        ElseIf userString.Length = cellValue.Length Then
    '            If userString.ToLower = cellValue.ToLower Then Match = True Else Match = False
    '            Exit Function
    '        Else
    '            Dim i As Integer
    '            For i = 0 To (cellValue.Length - userString.Length) - 0
    '                If userString.ToLower = cellValue.ToLower.Substring(i, userString.Length) Then
    '                    Match = True
    '                    Exit Function
    '                End If
    '            Next
    '            Match = False
    '            Exit Function
    '        End If
    '    End Function
    '#End Region
    '#Region "MatchText Function"
    '    Private Function MatchText(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal oRow As Infragistics.Win.UltraWinGrid.UltraGridRow, ByVal _myString As String) As Boolean
    '        If oRow Is Nothing Then
    '            MatchText = False
    '            Exit Function
    '        End If
    '        Dim oCol As Infragistics.Win.UltraWinGrid.UltraGridColumn
    '        Dim strCellValue As String = ""
    '        For Each oCol In _myGrid.DisplayLayout.Bands(0).Columns
    '            If Not oRow.Cells(oCol.Key).Value Is System.DBNull.Value Then
    '                If Me.Match(_myString, oRow.Cells(oCol.Key).Value) Then
    '                    MatchText = True
    '                    Me.myColumn = oCol
    '                    Exit Function
    '                End If
    '            End If
    '        Next
    '    End Function
    '#End Region
    '#Region "Search - Tìm kiếm"
    '    Public Sub Search(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal _myString As String)
    '        Dim oRow As Infragistics.Win.UltraWinGrid.UltraGridRow
    '        oRow = _myGrid.ActiveRow
    '        If oRow Is Nothing Then oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)

    '        While Not oRow Is Nothing
    '            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
    '            If Me.MatchText(_myGrid, oRow, _myString) Then
    '                _myGrid.ActiveRow = oRow
    '                If Not Me.myColumn Is Nothing Then
    '                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
    '                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
    '                End If
    '                Exit Sub
    '            End If
    '        End While
    '        oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)
    '        While Not oRow Is Nothing
    '            If Me.MatchText(_myGrid, oRow, _myString) Then
    '                _myGrid.ActiveRow = oRow
    '                If Not Me.myColumn Is Nothing Then
    '                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
    '                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
    '                End If
    '                Exit Sub
    '            End If
    '            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
    '        End While
    '        CMessageBox.Show("Đã tìm kiếm hết danh sách rồi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
    '    End Sub
    '#End Region
    '#Region "mnuTimKiem_Click tìm kiếm trong DataGrid"
    '    Private Sub mnuTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTimKiem.Click
    '        Try
    '            If Me.FrmTK Is Nothing Then
    '                Me.FrmTK = New FrmTimKiemDanhMuc
    '            End If

    '            Me.FrmTK.ShowMe(Me, myGridKeyDown, "")
    '        Catch ex As Exception
    '            CMessageBox.Show(ex.ToString(), "Thông báo")
    '        End Try
    '    End Sub
    '#End Region
#End Region
#Region "KeyDown"
    'Private Sub dgE1_Chua_PH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_Chua_PH.KeyDown
    '    If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
    '    myGridKeyDown = sender
    '    If Not myCell Is Nothing And (e.KeyValue <> Keys.Escape) Then
    '        e.Handled = True
    '        myGridKeyDown.ActiveCell = myCell
    '        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
    '        myCell = Nothing
    '    End If
    '    Select Case e.KeyValue
    '        Case Keys.Right
    '            myCell = Nothing
    '            myGridKeyDown.PerformAction(ExitEditMode, False, False)
    '            e.Handled = True
    '            myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
    '        Case Keys.Enter
    '            myGridKeyDown.PerformAction(ExitEditMode, False, False)
    '            myGridKeyDown.PerformAction(NextCellByTab, False, False)
    '            e.Handled = True
    '            myGridKeyDown.PerformAction(EnterEditMode, False, False)
    '        Case Keys.F8
    '            If myGridKeyDown.Name = dgE1_Chua_PH.Name Then
    '                If CMessageBox.Show("Bạn có thực sự muốn xóa mã E1 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                    myE1_Den_Tam.Xoa(dgE1_Chua_PH.Rows(dgE1_Chua_PH.ActiveRow.Index).Cells("Id_E1").Text)
    '                    dgE1_Chua_PH.ActiveRow.Delete(False)
    '                    CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            End If
    '            e.Handled = True
    '        Case Keys.F1
    '    End Select
    'End Sub
    'Private Sub dgE1_Da_PH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_Da_PH.KeyDown
    '    If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
    '    myGridKeyDown = sender
    '    If Not myCell Is Nothing And (e.KeyValue <> Keys.Escape) Then
    '        e.Handled = True
    '        myGridKeyDown.ActiveCell = myCell
    '        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
    '        myCell = Nothing
    '    End If
    '    Select Case e.KeyValue
    '        Case Keys.Right
    '            myCell = Nothing
    '            myGridKeyDown.PerformAction(ExitEditMode, False, False)
    '            e.Handled = True
    '            myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
    '        Case Keys.Enter
    '            myGridKeyDown.PerformAction(ExitEditMode, False, False)
    '            myGridKeyDown.PerformAction(NextCellByTab, False, False)
    '            e.Handled = True
    '            myGridKeyDown.PerformAction(EnterEditMode, False, False)
    '        Case Keys.F8
    '            If myGridKeyDown.Name = dgE1_Da_PH.Name Then
    '                If CMessageBox.Show("Bạn có thực sự muốn xóa mã E1 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                    myE1_Den_Tam.Xoa(dgE1_Da_PH.Rows(dgE1_Da_PH.ActiveRow.Index).Cells("Id_E1").Text)
    '                    dgE1_Da_PH.ActiveRow.Delete(False)
    '                    CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            End If
    '            e.Handled = True
    '        Case Keys.F1
    '    End Select
    'End Sub
#End Region
#Region "MouseDown"
    'Private Sub dgE1_Chua_PH_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgE1_Chua_PH.MouseDown, dgE1_Da_PH.MouseDown
    '    myGridKeyDown = sender
    '    If e.Button = MouseButtons.Right Then

    '        Dim oHeaderUI As Infragistics.Win.UltraWinGrid.HeaderUIElement
    '        Dim oUIElement As Infragistics.Win.UIElement
    '        Dim point As point = New point(e.X, e.Y)

    '        oUIElement = Me.myGridKeyDown.DisplayLayout.UIElement.ElementFromPoint(point)
    '        If oUIElement Is Nothing Then Exit Sub
    '        oUIElement = oUIElement.GetAncestor(GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement))
    '        If oUIElement Is Nothing Then
    '            Return
    '        End If
    '        If Not oUIElement.GetType() Is GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement) Then Exit Sub
    '        oHeaderUI = oUIElement
    '        Dim oColHeader As Infragistics.Win.UltraWinGrid.ColumnHeader = Nothing
    '        Me.myColumn = Nothing
    '        oColHeader = oHeaderUI.SelectableItem
    '        Me.myColumn = oColHeader.Column
    '        If Me.myColumn Is Nothing Then Exit Sub

    '        Me.mnuMenu.Show(Me.myGridKeyDown, point)
    '    End If
    'End Sub
#End Region
#Region "Color"
    'Private Sub txtSo_Hieu_E1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_E1.Leave
    '    txtSo_Hieu_E1.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub cbLua_Chon_In_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLua_Chon_In.GotFocus
    '    cbLua_Chon_In.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub cbLua_Chon_In_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLua_Chon_In.Leave
    '    cbLua_Chon_In.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub cbKhach_Hang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbKhach_Hang.GotFocus
    '    txtHo_Ten_Gui.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub txtHo_Ten_Nhan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHo_Ten_Nhan.GotFocus
    '    txtHo_Ten_Nhan.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub txtHo_Ten_Nhan_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHo_Ten_Nhan.Leave

    '    txtHo_Ten_Nhan.BackColor = System.Drawing.Color.White
    '    txtDia_Chi_Nhan_GotFocus(sender, e)
    'End Sub

    'Private Sub txtDien_Thoai_Nhan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDien_Thoai_Nhan.GotFocus
    '    txtDien_Thoai_Nhan.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub txtDien_Thoai_Nhan_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDien_Thoai_Nhan.Leave
    '    txtDien_Thoai_Nhan.BackColor = System.Drawing.Color.White
    '    txtKhoi_Luong_GotFocus(sender, e)
    'End Sub

    'Private Sub cbBuuCuc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBuuCuc.GotFocus
    '    cbBuuCuc.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub cbBuuCuc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBuuCuc.Leave
    '    cbBuuCuc.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub cbNuoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNuoc.GotFocus
    '    cbNuoc.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub cbNuoc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNuoc.Leave
    '    cbNuoc.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub txtPostcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPostcode.GotFocus
    '    txtPostcode.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub txtPostcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPostcode.Leave
    '    txtPostcode.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub txtKhoi_Luong_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKhoi_Luong.GotFocus
    '    txtKhoi_Luong.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub txtKhoi_Luong_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKhoi_Luong.Leave
    '    txtKhoi_Luong.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub cbLoai_Hang_Hoa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoai_Hang_Hoa.GotFocus
    '    cbLoai_Hang_Hoa.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub cbLoai_Hang_Hoa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoai_Hang_Hoa.Leave
    '    cbLoai_Hang_Hoa.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub txtKhoi_Luong_QD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKhoi_Luong_QD.GotFocus
    '    txtKhoi_Luong_QD.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub txtKhoi_Luong_QD_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKhoi_Luong_QD.Leave
    '    txtKhoi_Luong_QD.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub cbDV_Cong_Them_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDV_Cong_Them.GotFocus
    '    cbDV_Cong_Them.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub cbDV_Cong_Them_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDV_Cong_Them.Leave
    '    cbDV_Cong_Them.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub cbDV_Gia_Tang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDV_Gia_Tang.GotFocus
    '    cbDV_Gia_Tang.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub cbDV_Gia_Tang_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDV_Gia_Tang.Leave
    '    cbDV_Gia_Tang.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub txtGia_Tri_Hang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGia_Tri_Hang.GotFocus
    '    txtGia_Tri_Hang.BackColor = System.Drawing.Color.Turquoise
    'End Sub

    'Private Sub txtGia_Tri_Hang_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGia_Tri_Hang.Leave
    '    txtGia_Tri_Hang.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub txtDia_Chi_Gui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia_Chi_Gui.GotFocus
    '    txtDia_Chi_Gui.BackColor = System.Drawing.Color.Turquoise
    '    txtDia_Chi_Gui.SelectAll()
    '    txtDia_Chi_Gui.Focus()
    'End Sub

    'Private Sub txtDia_Chi_Nhan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia_Chi_Nhan.GotFocus
    '    txtDia_Chi_Nhan.BackColor = System.Drawing.Color.Turquoise
    '    txtDia_Chi_Nhan.SelectAll()
    '    txtDia_Chi_Nhan.Focus()
    'End Sub

    'Private Sub txtDia_Chi_Nhan_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia_Chi_Nhan.Leave

    '    txtDia_Chi_Nhan.BackColor = System.Drawing.Color.White
    'End Sub

    'Private Sub txtNoi_Dung_Gui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoi_Dung_Gui.GotFocus
    '    txtNoi_Dung_Gui.BackColor = System.Drawing.Color.Turquoise
    '    txtNoi_Dung_Gui.SelectAll()
    '    txtNoi_Dung_Gui.Focus()
    'End Sub

    'Private Sub txtNoi_Dung_Gui_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoi_Dung_Gui.Leave
    '    txtNoi_Dung_Gui.BackColor = System.Drawing.Color.White
    'End Sub
#End Region
#Region "txtDia_Chi_Gui_KeyDown"
    'Private Sub txtDia_Chi_Gui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDia_Chi_Gui.KeyDown, txtDia_Chi_Nhan.KeyDown, txtNoi_Dung_Gui.KeyDown
    '    Select Case e.KeyValue
    '        Case Keys.F5
    '            Dim str As String
    '            str = sender.text
    '            str = Xu_Ly_Viet_Tat(str)
    '            sender.text = str
    '            sender.SelectionStart = sender.text.length
    '    End Select
    'End Sub
#End Region
#Region "chkVungXaTN_CheckedChanged"
    'Private Sub chkVungXaTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVungXaTN.CheckedChanged
    '    If GBuu_Cuc_Vung_Xa = True Then
    '        chkVungXaTN.Checked = True
    '    End If
    '    btnVung_Xa_TN.Enabled = chkVungXaTN.Checked
    '    Update_Cuoc(txtSo_Hieu_E1.Text.Trim)
    'End Sub
#End Region
#Region "dgE1_Chua_PH_BeforeRowDeactivate"
    'Private Sub dgE1_Chua_PH_BeforeRowDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1_Chua_PH.BeforeRowDeactivate
    '    ReCalculate_Summary(dgE1_Chua_PH)
    'End Sub
#End Region
#Region "btnVung_Xa_TN_Click"
    'Private Sub btnVung_Xa_TN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVung_Xa_TN.Click
    '    Try
    '        Dim Frm As New FrmDanh_Muc_Cuoc_Vung_Xa_TN
    '        Frm.myMaTinh_Default = CInt(cbBuuCuc.Value)
    '        Frm.ShowDialog()
    '    Catch ex As Exception
    '        CMessageBox.Show(ex.ToString(), "Thông báo")
    '    End Try
    'End Sub
#End Region
#Region "btnPreview_PH_Click"
    'Private Sub btnPreview_PH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview_PH.Click
    '    Try
    '        If tabQuanLy.Tabs("0").Active = True Then
    '            In_Du_Lieu(dgE1_Chua_PH, False, True)
    '        ElseIf tabQuanLy.Tabs("1").Active = True Then
    '            In_Du_Lieu(dgE1_Da_PH, True, True)
    '        End If
    '    Catch ex As Exception
    '        CMessageBox.Show(ex.ToString(), "Thông báo")
    '    End Try
    'End Sub
#End Region
#Region "btnBrowse_Click"
    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
    '    Dim myStream As Stream = Nothing
    '    Dim openFileDialog1 As New OpenFileDialog

    '    openFileDialog1.InitialDirectory = "c:\"
    '    openFileDialog1.Filter = "Chỉ hiển thị Files Exel (*.xls)|*.xls|Hiển thị tất các file (*.*)|*.*"       '"Dạng file (*.xls)|Tất các file (*.*)"
    '    openFileDialog1.FilterIndex = 1
    '    openFileDialog1.RestoreDirectory = True
    '    If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
    '        Try
    '            myStream = openFileDialog1.OpenFile()
    '            txtPath.Text = openFileDialog1.FileName
    '        Catch Ex As Exception
    '            CMessageBox.Show("Không thể đọc được định dạng file này ", "Thông báo")
    '            Exit Sub
    '        End Try
    '    End If
    'End Sub
#End Region
#Region "Reading File"
    'Private Sub ReadingFile(ByVal Path As String)
    '    Dim objConn As OleDbConnection
    '    Try
    '        Dim myDataTable As DataTable = New DataTable
    '        Dim sConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Path & ";" & "Extended Properties=Excel 8.0;"
    '        objConn = New OleDbConnection(sConnectionString)
    '        objConn.Open()
    '        Dim objCmdSelect As OleDbCommand
    '        objCmdSelect = New OleDbCommand("SELECT false as Chon,F1,F2,F3,F4,F5,F6,F7,F8,F9,F10,F11,F12,F13,F14,F15 FROM [Custlist$] WHERE F1 <> null", objConn)
    '        objCmdSelect.CommandType = CommandType.TableDirect
    '        Dim objAdapter1 As OleDbDataAdapter = New OleDbDataAdapter
    '        objAdapter1.SelectCommand = objCmdSelect
    '        Dim objDataset1 As DataSet = New DataSet
    '        objAdapter1.Fill(objDataset1, "Customers")
    '        If objDataset1.Tables("Customers").Rows.Count = 0 Then
    '            MessageBox.Show("Không có dữ liệu khách hàng trong file " & Path)
    '            Exit Sub
    '        End If
    '        dgE1_Chua_PH_XLS.DataSource = objDataset1
    '        dgE1_Chua_PH_XLS.DataBind()
    '    Catch ex As Exception
    '        Console.Write(ex.ToString)
    '    End Try
    'End Sub
#End Region
#Region "cbKhach_Hang_Validated"
    'Private Sub cbKhach_Hang_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbKhach_Hang.Validated
    '    Try
    '        If cbKhach_Hang.Text.Trim = "" Or cbKhach_Hang.Text.Trim = "0" Then
    '            txtHo_Ten_Gui.Enabled = True
    '            txtDia_Chi_Gui.Enabled = True
    '            txtDien_Thoai_Gui.Enabled = True
    '            cbKhach_Hang.Value = ""
    '            Me.txtHo_Ten_Gui.Select()
    '        ElseIf myKhachHang.Chk_Ma_KH(cbKhach_Hang.Text.Trim, GBuu_Cuc_Khai_Thac, Ham_Dung_Chung.ConvertDateToInt(Now)) = False Then
    '            CMessageBox.Show("Không tìm thấy Khách hàng này trong dữ liệu", "Thông báo", MessageBoxButtons.OK)
    '            cbKhach_Hang.Select()
    '            Exit Sub
    '        Else
    '            txtHo_Ten_Gui.Text = myKhachHang.Lay(cbKhach_Hang.Value).Ten_Khach_Hang
    '            txtDia_Chi_Gui.Text = myKhachHang.Lay(cbKhach_Hang.Value).Dia_Chi
    '            txtDien_Thoai_Gui.Text = myKhachHang.Lay(cbKhach_Hang.Value).Dien_Thoai

    '            txtHo_Ten_Gui.Enabled = False
    '            txtDia_Chi_Gui.Enabled = False
    '            txtDien_Thoai_Gui.Enabled = False
    '            Me.txtHo_Ten_Nhan.Select()
    '        End If
    '    Catch ex As Exception
    '        CMessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
#End Region
#Region "btnBaoCao_Click"
    'Private Sub btnBaoCao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaoCao.Click
    '    Dim _pThamSo As New ParameterDiscreteValue
    '    Dim mydata As DataTable
    '    Dim rptbaophatchitietphat As New RptE1_Den_Tam_Tu_Ngay_Den_Ngay
    '    Dim pvCollection As New ParameterValues
    '    Dim FrmView As New FrmViewReports
    '    Try
    '        If chkMaKH_BC.Checked Then
    '            If cbMaKH_BC.Text.Trim = "" Then
    '                Exit Sub
    '            End If
    '            mydata = myE1_Den_Tam.Lay_Boi_Tu_Ngay_Den_Ngay_Ma_KH(Ham_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value), cbMaKH_BC.Value).Tables(0)
    '        Else
    '            mydata = myE1_Den_Tam.Lay_Boi_Tu_Ngay_Den_Ngay(Ham_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value)).Tables(0)
    '        End If
    '        _pThamSo.Value = GBuu_Cuc_Khai_Thac.ToString + " - " + GTen_Buu_Cuc_Khai_Thac
    '        pvCollection.Add(_pThamSo)
    '        rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
    '        pvCollection.Clear()
    '        _pThamSo.Value = "DANH SÁCH MÃ BƯU PHẨM"
    '        pvCollection.Add(_pThamSo)
    '        rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
    '        pvCollection.Clear()
    '        If chkMaKH_BC.Checked Then
    '            _pThamSo.Value = " theo Mã KH : " & cbMaKH_BC.Value & " - " & myKhachHang.Lay(cbMaKH_BC.Value).Ten_Khach_Hang
    '            pvCollection.Add(_pThamSo)
    '            rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
    '            pvCollection.Clear()
    '        Else
    '            _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
    '            pvCollection.Add(_pThamSo)
    '            rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
    '            pvCollection.Clear()
    '        End If
    '        _pThamSo.Value = "( từ ngày " & dtpTu_Ngay.Text & " đến ngày " & dtpDen_Ngay.Text & " )"
    '        pvCollection.Add(_pThamSo)
    '        rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
    '        pvCollection.Clear()
    '        _pThamSo.Value = GTen_Dang_Nhap
    '        pvCollection.Add(_pThamSo)
    '        rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
    '        pvCollection.Clear()
    '        _pThamSo.Value = GrptNgay_Thang_Nam
    '        pvCollection.Add(_pThamSo)
    '        rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
    '        pvCollection.Clear()
    '        If mydata.Rows.Count > 0 Then
    '            rptbaophatchitietphat.SetDataSource(mydata)
    '            FrmView.CrystalReportViewer1.ReportSource = rptbaophatchitietphat
    '            Cursor.Current = Cursors.Default
    '            FrmView.ShowDialog()
    '        Else
    '            CMessageBox.Show("Không có thông tin dữ liệu về mã bưu phẩm này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Catch ex As Exception
    '        CMessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
#End Region
#Region "chkMaKH_BC_CheckedChanged"
    'Private Sub chkMaKH_BC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMaKH_BC.CheckedChanged
    '    cbMaKH_BC.Enabled = chkMaKH_BC.Checked
    '    If chkMaKH_BC.Checked Then
    '        cbMaKH_BC.DataSource = myKhachHang.Danh_Sach_Hien_Thi(GBuu_Cuc_Khai_Thac)
    '        cbMaKH_BC.DataBind()
    '    End If
    'End Sub
#End Region
#Region "chkDoc_Exel_CheckedChanged"
    'Private Sub chkDoc_Exel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDoc_Exel.CheckedChanged
    '    dgE1_Chua_PH_XLS.Visible = chkDoc_Exel.Checked
    '    'Hiển thị dữ liệu trên lưới
    '    If txtPath.Text.Trim <> "" Then
    '        'MessageBox.Show("Đang phát triển module này ", "Thông báo")
    '        ReadingFile(txtPath.Text)
    '    End If
    'End Sub
#End Region
#Region "dgE1_Chua_PH_XLS_DoubleClick"
    'Private Sub dgE1_Chua_PH_XLS_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Chua_PH_XLS.DoubleClick
    '    myGridKeyDown = sender
    '    If myGridKeyDown.ActiveRow Is Nothing Then
    '        Exit Sub
    '    End If
    '    tabPhanHuong.SelectedTab = tabPhanHuong.Tabs("0")
    '    'Hiển thị dữ liệu cần sửa trên form
    '    txtHo_Ten_Nhan.Text = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F7").Text.Trim
    '    txtDia_Chi_Nhan.Text = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F3").Text.Trim & " - " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F4").Text.Trim & " - " & _
    '                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F5").Text.Trim & " - " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F6").Text.Trim
    '    txtDien_Thoai_Nhan.Text = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F9").Text.Trim & " " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F10").Text.Trim & "  Fax : " & _
    '                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F11").Text.Trim & " " & myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F12").Text.Trim
    '    txtNoi_Dung_Gui.Text = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("F15").Text.Trim
    'End Sub
#End Region
#End Region

#Region "Khai báo các biến trong form"
    'E_Shipping
    Dim myE1_Auto_Gen As New E1_Auto_Gen(GConnectionString_E_Shiping)
    Dim myE1_Autogeneration_Chi_Tiet As New E1_Autogeneration_Chi_Tiet
    Dim myE1_Den_Tam As New Ems_Shipping_E1_Den_Tam(GConnectionString_E_Shiping)
    Dim myE1_Den_Tam_Chi_Tiet As New Ems_Shipping_E1_Den_Tam_Chi_Tiet

    'E_International
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myNuoc As New Ma_Nuoc(GConnectionString)
    Dim myMaTinh As New Ma_Tinh(GConnectionString)
    Dim myKhach_Hang_Client As New Ems_Shipping_Khach_Hang(GConnectionString)
    Dim myKhach_Hang_Client_Chi_Tiet As New Ems_Shipping_Khach_Hang_Chi_Tiet
    Dim myCaSanXuat As New Ca_San_Xuat(GConnectionString)
    Dim myCaSanXuatChiTiet As New Ca_San_Xuat_Chi_Tiet
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
    Dim myE1_Le_Phi_Den As New E1_Le_Phi_Den(GConnectionString)
    Dim myE1_Den_E_Shipping As New E1_Den_E_Shipping(GConnectionString)
    Dim myE1_Den_E_Shipping_Chi_Tiet As New E1_Den_E_Shipping_Chi_Tiet
    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    Dim myMaE1 As String
    Dim GMa_KH_Outbound As String
    Dim myTaoMoi As Boolean = True

#End Region

#Region "TabControl"

#Region "Frm_Ems_Shipping_Load"
    Private Sub Frm_Ems_Shipping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Kiem tra ket noi may chu E_Shipping
        If Not TestConnection_E_Shiping(GConnectionString_E_Shiping) Then
            MessageBox.Show("Không thể kết nối tới máy chủ E_Shipping!!! Kiểm tra lại thông tin cấu hình CSDL" & vbNewLine & "Nếu vẫn không kết nối được hãy báo cho bộ phận tin học - phòng Nghiệ vụ , Tin học.", "Lỗi kết nối đến máy chủ E_Shipping", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
            Exit Sub
        End If
        'Ket noi thanh cong - lay thong tin ma_kh mac dinh
        If myKhach_Hang_Client.Ems_Shipping_Khach_Hang_Danh_Sach.Tables(0).Rows.Count > 0 Then
            GMa_KH_Outbound = myKhach_Hang_Client.Ems_Shipping_Khach_Hang_Danh_Sach.Tables(0).Rows(0).Item("Ma_KH")
            myKhach_Hang_Client_Chi_Tiet = myKhach_Hang_Client.Ems_Shipping_Khach_Hang_Lay(GMa_KH_Outbound)
        Else
            MessageBox.Show("Bạn không có mã khách hàng để lấy vận đơn điện tử. Hãy báo cho bộ phận Tin học - Phòng Nghiệp vụ, Tin học về lỗi này.", "Lỗi hệ thống lấy vận đơn điện tử", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
            Exit Sub
        End If
        dtpNgay_Gui.Value = Now.Date()
        txtGio_Gui.Text = IIf(Now.Hour.ToString.Length = 1, "0" & Now.Hour.ToString, Now.Hour.ToString) & ":" & IIf(Now.Minute.ToString.Length = 1, "0" & Now.Minute.ToString, Now.Minute.ToString)
        Load_Data()
        Gan_Thong_Tin_Mac_Dinh_Vao_Form()
        txtSo_Hieu_CP1.Select()
        myTaoMoi = True
        Enable_Control(False)
    End Sub
#End Region
#Region "Validated"
    Private Sub cbNuoc_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNuoc.Validated
        Try
            lblNuocTra.Text = cbNuoc.ActiveRow.Cells("Ten_Nuoc").Text
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub cbBuuCuc_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBuuCuc.Validated
        Try
            cbBuuCuc.Value = FormatMaBc(cbBuuCuc.Value)
            If cbBuuCuc.Value <> "000000" Then
                lblBcTra.Text = cbBuuCuc.Value
            Else
                lblBcTra.Text = ""
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub txtKhoi_Luong_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKhoi_Luong.Validated
        Try
            If txtKhoi_Luong.Text = "" Then
                CMessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                txtKhoi_Luong.Focus()
                Exit Sub
            ElseIf IsNumeric(txtKhoi_Luong.Text) = False Then 'Kiểm tra định dạng
                CMessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK)
                txtKhoi_Luong.Focus()
                Exit Sub
            Else
                txtKhoi_Luong_QD.Value = txtKhoi_Luong.Value
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString(), "Thông báo")
        End Try
    End Sub
    Private Sub txtKhoi_Luong_QD_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKhoi_Luong_QD.Validated
        Try
            If txtKhoi_Luong_QD.Text = "" Then
                CMessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                txtKhoi_Luong.Focus()
                Exit Sub
            ElseIf IsNumeric(txtKhoi_Luong_QD.Text) = False Then 'Kiểm tra định dạng
                CMessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK)
                txtKhoi_Luong_QD.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString(), "Thông báo")
        End Try
    End Sub
    Private Sub txtSo_Hieu_E1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_E1.TextChanged
        If (txtSo_Hieu_E1.Text.StartsWith("Ê") Or txtSo_Hieu_E1.Text.StartsWith("ê")) Then
            txtSo_Hieu_E1.Text = "EE" & txtSo_Hieu_E1.Text.Substring(1, txtSo_Hieu_E1.Text.Length - 1)
            txtSo_Hieu_E1.SelectionStart = txtSo_Hieu_E1.TextLength
        End If
    End Sub
    Private Sub txtSo_Hieu_E1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_E1.Validated
        If txtSo_Hieu_E1.Text <> "" Then
            Try
                'Kiểm tra Ma E1
                txtSo_Hieu_E1.Value = GetCorrectMAE1(txtSo_Hieu_E1.Text.Trim, IIf(TimNuocNhanTuE1(txtSo_Hieu_E1.Text.Trim) = "", "VN", TimNuocNhanTuE1(txtSo_Hieu_E1.Text.Trim)), GBuu_Cuc_Khai_Thac, "EE000000000VN")
                If txtSo_Hieu_E1.Text = "" Or txtSo_Hieu_E1.Text = "EE000000000VN" Then
                    Exit Sub
                End If
                If Ham_Dung_Chung.Check_E1(txtSo_Hieu_E1.Text) = False Then
                    CMessageBox.Show("Mã E1 sai, không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnThem_Vao_Tui.Select()
                    Exit Sub
                Else
                    txtGio_Gui.Text = IIf(Now.Hour.ToString.Length = 1, "0" & Now.Hour.ToString, Now.Hour.ToString) & ":" & IIf(Now.Minute.ToString.Length = 1, "0" & Now.Minute.ToString, Now.Minute.ToString)
                    dtpNgay_Gui.Value = Date.Now
                    myMaE1 = CStr(txtSo_Hieu_E1.Text.Trim)
                    txtThong_Tin.Text = myMaE1
                End If
            Catch ex As Exception
                CMessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
#End Region
#Region "GotFocus"
#Region "txtSo_Hieu_CP1_GotFocus"
    Private Sub txtSo_Hieu_CP1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_CP1.GotFocus
        'txtSo_Hieu_CP1.SelectionStart = 0
        'txtSo_Hieu_CP1.SelectionLength = txtSo_Hieu_CP1.Text.Length
    End Sub
#End Region
#End Region
#Region "SelectedTabChanged"
#Region "tabPhanHuong_SelectedTabChanged"
    Private Sub tabPhanHuong_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabPhanHuong.SelectedTabChanged
        Try
            If tabPhanHuong.Tabs("0").Active = True Then
                Me.txtSo_Hieu_CP1.Select()
            ElseIf tabPhanHuong.Tabs("1").Active = True Then
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString(), "Thông báo")
        End Try
    End Sub
#End Region
#Region "tabQuanLy_SelectedTabChanged"
    Private Sub tabQuanLy_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabQuanLy.SelectedTabChanged
        Try
            'If tabQuanLy.Tabs("0").Active = True Then
            '    DataGridE1_Chua_PH(GId_Ca)
            '    ReCalculate_Summary(dgE1_Chua_PH)
            'ElseIf tabQuanLy.Tabs("1").Active = True Then
            '    DataGridE1_Da_PH(GId_Ca)
            '    ReCalculate_Summary(dgE1_Da_PH)
            'End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString(), "Thông báo")
        End Try
    End Sub
#End Region
#End Region
#Region "btnThem_Vao_Tui_Click"
    Private Sub btnThem_Vao_Tui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem_Vao_Tui.Click
        Try
            'Neu khong phai la tao moi (chi cho phep in)
            If Not myTaoMoi Then
                Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                prbTien_Trinh.Maximum = 1
                prbTien_Trinh.Step = 1
                prbTien_Trinh.Value = 0
                prbTien_Trinh.Refresh()
                'In E1
                In_E1(chkGiay_A5_Co_San.Checked, txtSo_Hieu_CP1.Text.Trim, False)
                prbTien_Trinh.PerformStep()
                'cập nhật trạng thái
                txtThong_Tin.Text = "ĐÃ IN"
                'Set form ve trang thai mac dinh
                Enable_Control(False)
                Gan_Thong_Tin_Mac_Dinh_Vao_Form()
                Me.ActiveForm.Cursor.Current = Cursors.Default
                txtSo_Hieu_CP1.Select()
                Exit Sub
            End If
            'Neu la tao moi (thuc hien cac buoc tuan tu)
            prbTien_Trinh.Maximum = 5
            prbTien_Trinh.Step = 1
            prbTien_Trinh.Value = 0
            prbTien_Trinh.Refresh()

            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            '=========  STEP 1  =======================================
            'Thông tin E1 Gen trên máy chủ
            myE1_Autogeneration_Chi_Tiet = myE1_Auto_Gen.E1_Autogeneration(GMa_KH_Outbound, GBuu_Cuc_Khai_Thac, cbMa_Nuoc_E1.Value)
            txtSo_Hieu_E1.Text = myE1_Autogeneration_Chi_Tiet.Ma_E1
            myMaE1 = CStr(txtSo_Hieu_E1.Text.Trim)
            prbTien_Trinh.PerformStep()
            Me.ActiveForm.Cursor.Current = Cursors.Default
            'Gan vao bien
            If txtSo_Hieu_E1.Text <> "" Or txtSo_Hieu_E1.Text <> "EE000000000VN" Then
                If CMessageBox.Show("Số hiệu vận đơn điện tử vừa tạo là: " & myMaE1 & vbNewLine & "Bạn có thực sự muốn thực hiện việc thay thế mã CP bằng mã E1 này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    If myMaE1 <> "" Then  'Nếu dòng có dữ liệu                        
                        With myE1_Den_Tam_Chi_Tiet
                            .Id_E1 = Tao_Id_E1_Trong_E1_Den_Tam_E_Shipping(txtSo_Hieu_CP1.Text.Trim, GId_Ca)
                            .Ma_E1 = myMaE1.ToUpper
                            .Id_Duong_Thu = Convert_Id_Duong_Thu_Tu_International_Sang_E_Shipping(myE1_Den_Chi_Tiet.Id_Duong_Thu)
                            .Id_Chuyen_Thu = ""
                            .Id_E2 = ""
                            .Id_Ca = GId_Ca
                            .Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
                            .Ma_Quay = myE1_Den_Chi_Tiet.Ma_Quay
                            .Ngay_Phat_Hanh = Ham_Dung_Chung.ConvertDateToInt(dtpNgay_Gui.Value)
                            .Gio_Phat_Hanh = Ham_Dung_Chung.ConvertTimeToInt(txtGio_Gui.Value)
                            .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(dtpNgay_Gui.Value)
                            .Gio_Dong = Ham_Dung_Chung.ConvertTimeToInt(txtGio_Gui.Value)
                            .Ngay_Nhan = Ham_Dung_Chung.ConvertDateToInt(dtpNgay_Gui.Value)
                            .Gio_Nhan = Ham_Dung_Chung.ConvertTimeToInt(txtGio_Gui.Value)
                            .Ma_Don_Vi = myE1_Den_Chi_Tiet.Ma_Don_Vi
                            .Id_Nguoi_Dung = Gid_Nguoi_Dung
                            .Ma_Bc_Goc = myE1_Den_Chi_Tiet.Ma_Bc_Goc
                            .Ma_Bc_Tra = myE1_Den_Chi_Tiet.Ma_Bc_Tra
                            .Nuoc_Nhan = myE1_Den_Chi_Tiet.Nuoc_Nhan
                            .Nuoc_Tra = myE1_Den_Chi_Tiet.Nuoc_Tra
                            .Khoi_Luong = myE1_Den_Chi_Tiet.Khoi_Luong
                            .Phan_Loai = myE1_Den_Chi_Tiet.Phan_Loai
                            .Loai_Hang_Hoa = myE1_Den_Chi_Tiet.Loai_Hang_Hoa
                            .Khoi_Luong_QD = myE1_Den_Chi_Tiet.Khoi_Luong_QD
                            .Loai = myE1_Den_Chi_Tiet.Loai
                            .Dv_Cong_Them = myE1_Den_Chi_Tiet.Dv_Cong_Them
                            .Dv_Gia_Tang = myE1_Den_Chi_Tiet.Dv_Gia_Tang
                            .PPXD = myE1_Den_Chi_Tiet.PPXD
                            .Cuoc_PPXD = myE1_Den_Chi_Tiet.Cuoc_PPXD
                            .PostCode = myE1_Den_Chi_Tiet.PostCode
                            .Cuoc_PPVX = myE1_Den_Chi_Tiet.Cuoc_PPVX
                            .VAT = myE1_Den_Chi_Tiet.VAT
                            .COD = myE1_Den_Chi_Tiet.COD
                            'luu gia tri Thue va le phi vao day
                            If IsNumeric(txtThue_Hai_Quan.Value) Then
                                .Gia_Tri_Hang = txtThue_Hai_Quan.Value
                            Else
                                .Gia_Tri_Hang = 0
                            End If
                            .Cuoc_COD = myE1_Den_Chi_Tiet.Cuoc_COD
                            .Cuoc_DV = myE1_Den_Chi_Tiet.Cuoc_DV
                            .Cuoc_Chinh = myE1_Den_Chi_Tiet.Cuoc_Chinh
                            .Cuoc_Giam = myE1_Den_Chi_Tiet.Cuoc_Giam
                            .Cuoc_E1 = myE1_Den_Chi_Tiet.Cuoc_E1
                            .Kien_So = myE1_Den_Chi_Tiet.Kien_So
                            .STT = myE1_Den_Chi_Tiet.STT
                            .Ma_KH = GMa_KH_Outbound
                            '.Nguoi_Gui = myE1_Den_Chi_Tiet.Nguoi_Gui
                            .Nguoi_Gui = txtHo_Ten_Gui.Text
                            .Nguoi_Nhan = myE1_Den_Chi_Tiet.Nguoi_Nhan
                            '.Dia_Chi_Gui = myE1_Den_Chi_Tiet.Dia_Chi_Gui
                            .Dia_Chi_Gui = txtDia_Chi_Gui.Text
                            .Dia_Chi_Nhan = myE1_Den_Chi_Tiet.Dia_Chi_Nhan
                            '.Dien_Thoai_Gui = myE1_Den_Chi_Tiet.Dien_Thoai_Gui
                            .Dien_Thoai_Gui = txtDien_Thoai_Gui.Text
                            .Dien_Thoai_Nhan = myE1_Den_Chi_Tiet.Dien_Thoai_Nhan
                            .HH_Phat_Hanh = myE1_Den_Chi_Tiet.HH_Phat_Hanh
                            .HH_Phat_Tra = myE1_Den_Chi_Tiet.HH_Phat_Tra
                            .Ma_Bc_CH = myE1_Den_Chi_Tiet.Ma_Bc_CH
                            .Id_Trang_Thai = 0
                            'Luu Id_E1 (cua E1_Den trong E_International) vao ghi chu
                            .Ghi_Chu = myE1_Den_Chi_Tiet.Id_E1 & "__" & myE1_Den_Chi_Tiet.Ghi_Chu
                            .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
                            .Truyen_Khai_Thac = 0
                            .Truyen_Doi_Soat = 0
                            .Chot_SL = 0
                        End With
                        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                        '=========  STEP 2  =======================================
                        'Cập nhật lên máy chủ E_Shipping
                        myE1_Den_Tam.E1_Den_Tam_Cap_Nhat_Them_KT(myE1_Den_Tam_Chi_Tiet.Id_E1, _
                                                myE1_Den_Tam_Chi_Tiet.Id_Duong_Thu, _
                                                myE1_Den_Tam_Chi_Tiet.Id_Chuyen_Thu, _
                                                myE1_Den_Tam_Chi_Tiet.Id_E2, _
                                                myE1_Den_Tam_Chi_Tiet.Id_Ca, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_Quay, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_E1, _
                                                myE1_Den_Tam_Chi_Tiet.Ngay_Phat_Hanh, _
                                                myE1_Den_Tam_Chi_Tiet.Gio_Phat_Hanh, _
                                                myE1_Den_Tam_Chi_Tiet.Ngay_Dong, _
                                                myE1_Den_Tam_Chi_Tiet.Gio_Dong, _
                                                myE1_Den_Tam_Chi_Tiet.Ngay_Nhan, _
                                                myE1_Den_Tam_Chi_Tiet.Gio_Nhan, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_Don_Vi, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_Bc_Goc, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_Bc_Tra, _
                                                myE1_Den_Tam_Chi_Tiet.Nuoc_Nhan, _
                                                myE1_Den_Tam_Chi_Tiet.Nuoc_Tra, _
                                                myE1_Den_Tam_Chi_Tiet.Khoi_Luong, _
                                                myE1_Den_Tam_Chi_Tiet.Phan_Loai, _
                                                myE1_Den_Tam_Chi_Tiet.Loai_Hang_Hoa, _
                                                myE1_Den_Tam_Chi_Tiet.Khoi_Luong_QD, _
                                                myE1_Den_Tam_Chi_Tiet.Loai, _
                                                myE1_Den_Tam_Chi_Tiet.Dv_Cong_Them, _
                                                myE1_Den_Tam_Chi_Tiet.Dv_Gia_Tang, _
                                                myE1_Den_Tam_Chi_Tiet.PPXD, _
                                                myE1_Den_Tam_Chi_Tiet.Cuoc_PPXD, _
                                                myE1_Den_Tam_Chi_Tiet.PostCode, _
                                                myE1_Den_Tam_Chi_Tiet.Cuoc_PPVX, _
                                                myE1_Den_Tam_Chi_Tiet.VAT, _
                                                myE1_Den_Tam_Chi_Tiet.COD, _
                                                myE1_Den_Tam_Chi_Tiet.Gia_Tri_Hang, _
                                                myE1_Den_Tam_Chi_Tiet.Cuoc_COD, _
                                                myE1_Den_Tam_Chi_Tiet.Cuoc_DV, _
                                                myE1_Den_Tam_Chi_Tiet.Cuoc_Chinh, _
                                                myE1_Den_Tam_Chi_Tiet.Cuoc_Giam, _
                                                myE1_Den_Tam_Chi_Tiet.Cuoc_E1, _
                                                myE1_Den_Tam_Chi_Tiet.Kien_So, _
                                                myE1_Den_Tam_Chi_Tiet.STT, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_KH, _
                                                myE1_Den_Tam_Chi_Tiet.Nguoi_Gui, _
                                                myE1_Den_Tam_Chi_Tiet.Nguoi_Nhan, _
                                                myE1_Den_Tam_Chi_Tiet.Dia_Chi_Gui, _
                                                myE1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan, _
                                                myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Gui, _
                                                myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan, _
                                                myE1_Den_Tam_Chi_Tiet.HH_Phat_Hanh, _
                                                myE1_Den_Tam_Chi_Tiet.HH_Phat_Tra, _
                                                myE1_Den_Tam_Chi_Tiet.Ma_Bc_CH, _
                                                myE1_Den_Tam_Chi_Tiet.Id_Nguoi_Dung, _
                                                myE1_Den_Tam_Chi_Tiet.Id_Trang_Thai, _
                                                myE1_Den_Tam_Chi_Tiet.Ghi_Chu, _
                                                myE1_Den_Tam_Chi_Tiet.Truyen_Khai_Thac, _
                                                myE1_Den_Tam_Chi_Tiet.Truyen_Doi_Soat, _
                                                myE1_Den_Tam_Chi_Tiet.Chot_SL)
                        prbTien_Trinh.PerformStep()
                        '=========  STEP 3  =======================================
                        'Insert tu E1_Den (International) vao E1_Den_E_Shipping (International)
                        Dim mMa_E1_E_Shipping As String
                        Dim mId_E1_E_Shipping As String
                        Dim mId_E1_Thay_The As String
                        mMa_E1_E_Shipping = myMaE1.ToUpper
                        mId_E1_E_Shipping = myE1_Den_Tam_Chi_Tiet.Id_E1
                        mId_E1_Thay_The = myE1_Den_Chi_Tiet.Id_E1.Replace(txtSo_Hieu_CP1.Text.Trim.ToUpper, mMa_E1_E_Shipping)
                        myE1_Den_E_Shipping.E1_Den_E_Shipping_Cap_Nhat_Them(myE1_Den_Chi_Tiet.Id_E1, _
                                                                            myE1_Den_Chi_Tiet.Id_Duong_Thu, _
                                                                            myE1_Den_Chi_Tiet.Id_Chuyen_Thu, _
                                                                            myE1_Den_Chi_Tiet.Id_E2, _
                                                                            myE1_Den_Chi_Tiet.Id_Ca, _
                                                                            myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                            myE1_Den_Chi_Tiet.Ma_Quay, _
                                                                            myE1_Den_Chi_Tiet.Ma_E1, _
                                                                            myE1_Den_Chi_Tiet.Ngay_Phat_Hanh, _
                                                                            myE1_Den_Chi_Tiet.Gio_Phat_Hanh, _
                                                                            myE1_Den_Chi_Tiet.Ngay_Dong, _
                                                                            myE1_Den_Chi_Tiet.Gio_Dong, _
                                                                            myE1_Den_Chi_Tiet.Ngay_Nhan, _
                                                                            myE1_Den_Chi_Tiet.Gio_Nhan, _
                                                                            myE1_Den_Chi_Tiet.Ma_Don_Vi, _
                                                                            myE1_Den_Chi_Tiet.Ma_Bc_Goc, _
                                                                            myE1_Den_Chi_Tiet.Ma_Bc_Tra, _
                                                                            myE1_Den_Chi_Tiet.Nuoc_Nhan, _
                                                                            myE1_Den_Chi_Tiet.Nuoc_Tra, _
                                                                            myE1_Den_Chi_Tiet.Khoi_Luong, _
                                                                            myE1_Den_Chi_Tiet.Phan_Loai, _
                                                                            myE1_Den_Chi_Tiet.Loai_Hang_Hoa, _
                                                                            myE1_Den_Chi_Tiet.Khoi_Luong_QD, _
                                                                            myE1_Den_Chi_Tiet.Loai, _
                                                                            myE1_Den_Chi_Tiet.Dv_Cong_Them, _
                                                                            myE1_Den_Chi_Tiet.Dv_Gia_Tang, _
                                                                            myE1_Den_Chi_Tiet.PPXD, _
                                                                            myE1_Den_Chi_Tiet.Cuoc_PPXD, _
                                                                            myE1_Den_Chi_Tiet.PostCode, _
                                                                            myE1_Den_Chi_Tiet.Cuoc_PPVX, _
                                                                            myE1_Den_Chi_Tiet.VAT, _
                                                                            myE1_Den_Chi_Tiet.COD, _
                                                                            myE1_Den_Chi_Tiet.Gia_Tri_Hang, _
                                                                            myE1_Den_Chi_Tiet.Cuoc_COD, _
                                                                            myE1_Den_Chi_Tiet.Cuoc_DV, _
                                                                            myE1_Den_Chi_Tiet.Cuoc_Chinh, _
                                                                            myE1_Den_Chi_Tiet.Cuoc_Giam, _
                                                                            myE1_Den_Chi_Tiet.Cuoc_E1, _
                                                                            myE1_Den_Chi_Tiet.Kien_So, _
                                                                            myE1_Den_Chi_Tiet.STT, _
                                                                            myE1_Den_Chi_Tiet.Ma_KH, _
                                                                            myE1_Den_Chi_Tiet.Nguoi_Gui, _
                                                                            myE1_Den_Chi_Tiet.Nguoi_Nhan, _
                                                                            myE1_Den_Chi_Tiet.Dia_Chi_Gui, _
                                                                            myE1_Den_Chi_Tiet.Dia_Chi_Nhan, _
                                                                            myE1_Den_Chi_Tiet.Dien_Thoai_Gui, _
                                                                            myE1_Den_Chi_Tiet.Dien_Thoai_Nhan, _
                                                                            myE1_Den_Chi_Tiet.HH_Phat_Hanh, _
                                                                            myE1_Den_Chi_Tiet.HH_Phat_Tra, _
                                                                            myE1_Den_Chi_Tiet.Ma_Bc_CH, _
                                                                            myE1_Den_Chi_Tiet.Id_Nguoi_Dung, _
                                                                            myE1_Den_Chi_Tiet.Id_Trang_Thai, _
                                                                            myE1_Den_Chi_Tiet.Ghi_Chu, _
                                                                            myE1_Den_Chi_Tiet.Truyen_Khai_Thac, _
                                                                            myE1_Den_Chi_Tiet.Truyen_Doi_Soat, _
                                                                            0, _
                                                                            0, _
                                                                            myE1_Den_Chi_Tiet.Chot_SL, _
                                                                            mMa_E1_E_Shipping, _
                                                                            mId_E1_E_Shipping, _
                                                                            mId_E1_Thay_The)

                        prbTien_Trinh.PerformStep()
                        '=========  STEP 4  =======================================
                        'Cap nhat lai thong tin moi vao E1_Den (thay the van don CP1 = van don dien tu E1)
                        myE1_Den.E1_Den_Cap_Nhat_Id_E1_Ma_E1_E_Shipping(myE1_Den_Chi_Tiet.Id_E1, mMa_E1_E_Shipping, mId_E1_Thay_The)
                        'Cap nhat lai thong tin moi vao E1_Le_Phi_Den (thay the van don CP1 = van don dien tu E1)
                        myE1_Le_Phi_Den.E1_Le_Phi_Den_Cap_Nhat_Id_E1_Ma_E1_E_Shipping(myE1_Den_Chi_Tiet.Id_E1, mMa_E1_E_Shipping, mId_E1_Thay_The)
                        prbTien_Trinh.PerformStep()
                        '=========  STEP 5  =======================================
                        'In E1
                        In_E1(chkGiay_A5_Co_San.Checked, txtSo_Hieu_CP1.Text.Trim, False)
                        'Kiem_Tra_Sua_Chua = False
                        'btnThem_Vao_Tui.Text = "F3 - &Ghi và In E1"
                        'cập nhật trạng thái
                        prbTien_Trinh.PerformStep()
                        Me.ActiveForm.Cursor.Current = Cursors.Default
                        txtThong_Tin.Text = "ĐÃ CẬP NHẬT VÀ IN"
                        Enable_Control(False)
                        Gan_Thong_Tin_Mac_Dinh_Vao_Form()
                        txtSo_Hieu_CP1.Select()
                    Else   'khong cap phat duoc so hieu van don dien tu
                        txtSo_Hieu_CP1.Select()
                        Exit Sub
                    End If
                Else 'Nếu bấm vào không câp nhật
                    Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                    myE1_Auto_Gen.Xoa_Theo_Ma_E1_Ma_KH(myMaE1, GMa_KH_Outbound)
                    txtSo_Hieu_E1.Text = ""
                    txtThong_Tin.Text = "CHƯA CẬP NHẬT"
                    prbTien_Trinh.Maximum = 1
                    prbTien_Trinh.Step = 1
                    prbTien_Trinh.Value = 0
                    prbTien_Trinh.Refresh()
                    Me.ActiveForm.Cursor.Current = Cursors.Default
                    txtSo_Hieu_CP1.Select()
                    Enable_Control(True)
                End If
            Else   'khong cap phat duoc so hieu van don dien tu
                CMessageBox.Show("Chưa cấp phát được số vận đơn điện tử thay thế !!!", "Thông báo", MessageBoxButtons.OK)
                txtSo_Hieu_E1.Text = ""
                txtThong_Tin.Text = "CHƯA CẬP NHẬT"
                prbTien_Trinh.Maximum = 1
                prbTien_Trinh.Step = 1
                prbTien_Trinh.Value = 0
                prbTien_Trinh.Refresh()
                txtSo_Hieu_CP1.Select()
                Enable_Control(True)
                Exit Sub
            End If
        Catch ex As Exception
            CMessageBox.Show("Không kết nối được với máy in, Xin hãy kiểm tra lại kết nối với máy in", "Thông báo", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "btnDelete_Click"
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If myE1_Den_Tam_Chi_Tiet.Id_E1 <> "" And txtSo_Hieu_CP1.Text.Trim <> "" And txtSo_Hieu_CP1.Text.Trim.Length = 13 And txtSo_Hieu_E1.Text.Trim.Length = 13 Then
                If MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin cấp phát vận đơn điện tử cho bưu phẩm: " & txtSo_Hieu_CP1.Text.Trim & " không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Dim mId_E1_E_Shipping As String
                    mId_E1_E_Shipping = myE1_Den_Tam_Chi_Tiet.Ghi_Chu.Split("__").GetValue(0)
                    prbTien_Trinh.Maximum = 3
                    prbTien_Trinh.Step = 1
                    prbTien_Trinh.Value = 0
                    prbTien_Trinh.Refresh()
                    Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                    '=========  STEP 1  ===========================
                    'Cap nhat lai trong bang E1_Den (E_International)
                    Dim mE1_Den_E_Shipping_Chi_Tiet As New E1_Den_E_Shipping_Chi_Tiet
                    mE1_Den_E_Shipping_Chi_Tiet = myE1_Den_E_Shipping.E1_Den_E_Shipping_Lay(mId_E1_E_Shipping)
                    myE1_Den.E1_Den_Cap_Nhat_Id_E1_Ma_E1_E_Shipping(mE1_Den_E_Shipping_Chi_Tiet.Id_E1_Thay_The, _
                                                                    mE1_Den_E_Shipping_Chi_Tiet.Ma_E1, _
                                                                    mE1_Den_E_Shipping_Chi_Tiet.Id_E1)
                    'Cap nhat lai trong bang E1_Le_Phi_Den (E_International)
                    myE1_Le_Phi_Den.E1_Le_Phi_Den_Cap_Nhat_Id_E1_Ma_E1_E_Shipping(mE1_Den_E_Shipping_Chi_Tiet.Id_E1_Thay_The, _
                                                                    mE1_Den_E_Shipping_Chi_Tiet.Ma_E1, _
                                                                    mE1_Den_E_Shipping_Chi_Tiet.Id_E1)
                    prbTien_Trinh.PerformStep()
                    '=========  STEP 2  ===========================
                    'Xoa trong bang moi (E_International)
                    myE1_Den_E_Shipping.E1_Den_E_Shipping_Xoa(mE1_Den_E_Shipping_Chi_Tiet.Id_E1)
                    prbTien_Trinh.PerformStep()
                    '=========  STEP 3  ===========================
                    'Xoa trong E_Shipping
                    myE1_Den_Tam.Xoa(myE1_Den_Tam_Chi_Tiet.Id_E1)
                    prbTien_Trinh.PerformStep()
                    Me.ActiveForm.Cursor.Current = Cursors.Default
                    Gan_Thong_Tin_Mac_Dinh_Vao_Form()
                    MessageBox.Show("Đã xoá thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Gan lai mã CP1 vào ô số hiệu sau khi đã xoá và refresh thông tin
                    txtSo_Hieu_CP1.Text = mE1_Den_E_Shipping_Chi_Tiet.Ma_E1
                    txtSo_Hieu_CP1.Select()
                End If
            Else
                MessageBox.Show("Bạn chưa nhập mã CP cần xoá thông tin hoặc mã CP bạn nhập vào chưa được cấp phát mã số vận đơn điện tử!!!" & vbNewLine & "Xoá thông tin thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSo_Hieu_CP1.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnPreview_Click"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If txtSo_Hieu_CP1.Text.Trim <> "" And myE1_Den_Tam_Chi_Tiet.Id_E1 <> "" Then
            In_E1(chkGiay_A5_Co_San.Checked, txtSo_Hieu_CP1.Text.Trim, True)
            Gan_Thong_Tin_Mac_Dinh_Vao_Form()
            Enable_Control(False)
        Else
            MessageBox.Show("Không có dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSo_Hieu_CP1.Select()
        End If
    End Sub
#End Region
#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Try
            If CMessageBox.Show("Bạn có chắc chắn muốn thoát không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Close()
                Me.Dispose()
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString(), "Thông báo")
        End Try
    End Sub
#End Region
#Region "TabControl_KeyDown"
#Region "Frm_Ems_Shipping_KeyDown"
    Private Sub Frm_Ems_Shipping_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter
                    'Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
                    'Case Keys.F2
                    '    If optChuyen_Hoan.Checked = True Then
                    '        optChuyen_Hoan.Checked = False
                    '        optHuy.Checked = True
                    '    Else
                    '        optHuy.Checked = False
                    '        optChuyen_Hoan.Checked = True
                    '    End If
                Case Keys.F3
                    btnThem_Vao_Tui_Click(sender, e)
                    txtSo_Hieu_CP1.Select()
                Case Keys.Escape
                    'btnThoat_Click(sender, e)
                    'Case Keys.F5 ' Viết tắt
                    'Me.ActiveControl.Text = myVietTat.Lay_Boi_Ma_Bc_Khai_Thac_Ma_Viet_Tat(GBuu_Cuc_Khai_Thac, Me.ActiveControl.Text).Ten_Viet_Tat
            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#Region "txtSo_Hieu_CP1_KeyDown"
    Private Sub txtSo_Hieu_CP1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSo_Hieu_CP1.KeyDown, cbMa_Nuoc_E1.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnThem_Vao_Tui.Select()
        End If
    End Sub
#End Region
#End Region
#Region "txtsoban_Validated"
    Private Sub txtsoban_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsoban.Validated
        If txtsoban.Minimum < txtsoban.Value < txtsoban.Maximum Then
            txtsoban.Value = CInt(txtsoban.Text)
        Else
            CMessageBox.Show("Số bản in phải trong khoảng từ " & txtsoban.Minimum & " đến " & txtsoban.Maximum & " về mã bưu phẩm này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
#Region "txtSo_Hieu_CP1_Validated"
    Private Sub txtSo_Hieu_CP1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_CP1.Validated
        txtSo_Hieu_CP1.Text = txtSo_Hieu_CP1.Text.ToUpper
        If txtSo_Hieu_CP1.Text.Trim <> "" Then
            Dim mId_E1 As String
            'Kiem tra trong E_Shipping
            mId_E1 = Tao_Id_E1_Trong_E1_Den_Tam_E_Shipping(txtSo_Hieu_CP1.Text.Trim, GId_Ca)
            myE1_Den_Tam_Chi_Tiet = myE1_Den_Tam.Lay(mId_E1)
            If myE1_Den_Tam_Chi_Tiet.Ma_E1 <> "" Then   'Neu da ton tai
                If MessageBox.Show("Số hiệu bưu phẩm CP này đã được cấp phát số vận đơn điện tử thay thế!!! Bạn có muốn mở để in lại ấn phẩm E1 không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Gan_Thong_Tin_Tu_E_Shipping_Vao_Form(myE1_Den_Tam_Chi_Tiet)
                    myTaoMoi = False
                    Enable_Control(True)
                    btnThem_Vao_Tui.Select()
                Else
                    Gan_Thong_Tin_Mac_Dinh_Vao_Form()
                    myTaoMoi = True
                    Enable_Control(False)
                    txtSo_Hieu_CP1.Select()
                    Exit Sub
                End If
            Else    'Neu chua ton tai
                myTaoMoi = True
                'Kiem tra trong Xac nhan den (E1_Den)
                If Kiem_Tra_Thong_Tin_Xac_Nhan_Den(txtSo_Hieu_CP1.Text.Trim, GId_Ca, myE1_Den_Chi_Tiet) Then    'Neu ton tai
                    Gan_Thong_Tin_Tu_E_International_Vao_Form(myE1_Den_Chi_Tiet)
                    Enable_Control(True)
                Else        'Neu khong ton tai
                    MessageBox.Show("Chưa có thông tin xác nhận đến tại 915 của bưu phẩm: " & txtSo_Hieu_CP1.Text.Trim & ", trong ca này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Gan_Thong_Tin_Mac_Dinh_Vao_Form()
                    txtSo_Hieu_CP1.Select()
                    Enable_Control(False)
                End If
            End If
        End If
    End Sub
#End Region

#End Region

#Region "Hàm người dùng"
#Region "Tạo bảng"
#Region "Tao_Bang_Lua_Chon_In"
    Private Sub Tao_Bang_Lua_Chon_In()
        Dim dataTable As New dataTable("Lua_Chon_In")

        Dim colWork As DataColumn = New DataColumn("Ma_In", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_In", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_In") = 0
        row("Ten_In") = "In E1"
        dataTable.Rows.Add(row)

        cbLua_Chon_In.DataSource = dataTable
        cbLua_Chon_In.DataBind()
        If cbLua_Chon_In.Rows.Count > 0 Then
            cbLua_Chon_In.Value = cbLua_Chon_In.Rows(0).Cells("Ma_In").Value
        End If
    End Sub
#End Region
#Region "Tạo bảng To_Hop_Ma_DV_Cong_Them"
    Private Sub To_Hop_Ma_DV_Cong_Them()
        Dim myDichVu As New Dich_Vu(GConnectionString)
        cbDV_Cong_Them.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(0)
        cbDV_Cong_Them.DataBind()
    End Sub
#End Region
#Region "Tạo bảng To_Hop_Ma_DV_Gia_Tang"
    Private Sub To_Hop_Ma_DV_Gia_Tang()
        Dim myDichVu As New Dich_Vu(GConnectionString)
        cbDV_Gia_Tang.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(1)
        cbDV_Gia_Tang.DataBind()
    End Sub
#End Region
#Region "Tạo bảng Loại Hàng Hóa"
    Private Sub Tao_Bang_Loai_Hang_Hoa()
        Dim dataTable As New dataTable("Loai_Hang_Hoa")

        Dim colWork As DataColumn = New DataColumn("Ma_Loai", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Loai") = 0
        row("Ten_Loai") = "EMS"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = 1
        row("Ten_Loai") = "Hàng Nhẹ"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = 2
        row("Ten_Loai") = "Hàng cồng kềnh"
        dataTable.Rows.Add(row)

        cbLoai_Hang_Hoa.DataSource = dataTable
        cbLoai_Hang_Hoa.DataBind()
        'If cbLoai_Hang_Hoa.Rows.Count > 0 Then
        '    cbLoai_Hang_Hoa.Value = cbLoai_Hang_Hoa.Rows(0).Cells("Ma_Loai").Value
        'End If
    End Sub
#End Region
#End Region
#Region "DanhsachDuongThu"
    Private Sub DanhsachDuongThu()
        cbDuongThuDi_PH.DataSource = myDuong_Thu_Den.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Trong_E_Shipping(GBuu_Cuc_Khai_Thac)
        cbDuongThuDi_PH.DataBind()
    End Sub
#End Region
#Region "DataBinding"
    Private Sub DataBinding()
        Try
            'Nuoc tra
            cbNuoc.DataSource = myNuoc.Danh_Sach
            cbNuoc.DataBind()
            If cbNuoc.Rows.Count > 0 Then
                cbNuoc.Value = "VN"
            End If
            'Nuoc nhan
            cbNuoc_Nhan.DataSource = myNuoc.Danh_Sach
            cbNuoc_Nhan.DataBind()
            If cbNuoc_Nhan.Rows.Count > 0 Then
                cbNuoc_Nhan.Value = "US"
            End If
            'Nuoc tao van don dien tu
            cbMa_Nuoc_E1.DataSource = myNuoc.Danh_Sach
            cbMa_Nuoc_E1.DataBind()
            If cbMa_Nuoc_E1.Rows.Count > 0 Then
                cbMa_Nuoc_E1.Value = "US"
            End If
            'Buu cuc tra
            cbBuuCuc.DataSource = myMaTinh.Danh_Sach_Rut_Gon.Tables(0)
            cbBuuCuc.DataBind()
            'If cbBuuCuc.Rows.Count > 0 Then
            '    cbBuuCuc.Value = cbBuuCuc.Rows(0).Cells("Ma_Tinh").Value
            'End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#Region "Load_Data"
    Private Sub Load_Data()
        DataBinding()
        DanhsachDuongThu()
        To_Hop_Ma_DV_Cong_Them()
        To_Hop_Ma_DV_Gia_Tang()
        Tao_Bang_Lua_Chon_In()
        'Tao_Bang_Lua_Chon_In_PH()
        Tao_Bang_Loai_Hang_Hoa()
        'Lay_TT_Duong_Thu()
    End Sub
#End Region
#Region "In_E1"
    Private Sub In_E1(ByVal In_Tren_A5_Co_San As Boolean, ByVal Ma_E1 As String, ByVal Preview As Boolean)
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mydata As DataTable
        Dim myRow As DataRow
        Dim myrptE1 As ReportClass
        'Dim myrptE1 As New rptE1_KH
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        Dim mId_E1 As String
        Dim mSo_Ban As Integer
        Dim idx As Integer
        Try
            If In_Tren_A5_Co_San Then
                myrptE1 = New rptE1_KH_A5_Short
            Else
                myrptE1 = New rptE1_KH
            End If
            mId_E1 = Tao_Id_E1_Trong_E1_Den_Tam_E_Shipping(Ma_E1, GId_Ca)
            mydata = myE1_Den_Tam.E1_Theo_Id_E1_Id_Ca_Dung_Trong_Chuc_Nang_Thay_The_Ma_CP(mId_E1, GId_Ca).Tables(0)
            _pThamSo.Value = "*" & mydata.Rows(0).Item("Ma_E1") & "*"
            pvCollection.Add(_pThamSo)
            myrptE1.DataDefinition.ParameterFields("E1_Barcode").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            If mydata.Rows.Count > 0 Then
                If Not IsNumeric(txtsoban.Value) Then
                    mSo_Ban = 1
                Else
                    mSo_Ban = CInt(txtsoban.Value)
                End If
                For idx = 1 To mSo_Ban - 1
                    myRow = mydata.NewRow()
                    myRow("nguoi_gui") = mydata.Rows(0).Item("nguoi_gui")
                    myRow("dia_chi_gui") = mydata.Rows(0).Item("dia_chi_gui")
                    myRow("dien_thoai_gui") = mydata.Rows(0).Item("dien_thoai_gui")
                    myRow("D") = mydata.Rows(0).Item("D")
                    myRow("M") = mydata.Rows(0).Item("M")
                    myRow("CH") = mydata.Rows(0).Item("CH")
                    myRow("Gio_Phat_Hanh") = mydata.Rows(0).Item("Gio_Phat_Hanh")
                    myRow("Ngay_Phat_Hanh") = mydata.Rows(0).Item("Ngay_Phat_Hanh")
                    myRow("nguoi_nhan") = mydata.Rows(0).Item("nguoi_nhan")
                    myRow("dia_chi_nhan") = mydata.Rows(0).Item("dia_chi_nhan")
                    myRow("dien_thoai_nhan") = mydata.Rows(0).Item("dien_thoai_nhan")
                    myRow("khoi_luong") = mydata.Rows(0).Item("khoi_luong")
                    myRow("khoi_luong_qd") = mydata.Rows(0).Item("khoi_luong_qd")
                    myRow("cuoc_chinh") = mydata.Rows(0).Item("cuoc_chinh")
                    myRow("dv_cong_them") = mydata.Rows(0).Item("dv_cong_them")
                    myRow("Ten_Dich_Vu") = mydata.Rows(0).Item("Ten_Dich_Vu")
                    myRow("cuoc_e1") = mydata.Rows(0).Item("cuoc_e1")
                    myRow("PostCode") = mydata.Rows(0).Item("PostCode")
                    myRow("Ma_E1") = mydata.Rows(0).Item("Ma_E1")
                    myRow("Noi_Dung") = mydata.Rows(0).Item("Noi_Dung")
                    myRow("Huy") = mydata.Rows(0).Item("Huy")
                    myRow("Ma_KH") = mydata.Rows(0).Item("Ma_KH")
                    mydata.Rows.Add(myRow)
                Next
                mydata.Rows(0).Item("Noi_Dung") = mydata.Rows(0).Item("Noi_Dung") & vbNewLine & Ma_E1
                mydata.TableName = "E1"
                'Dim myDataSet As New DataSet
                'myDataSet.Tables.Add(mydata.Copy)
                'myDataSet.Tables.Add(AddImageToCrystal.Copy)
                myrptE1.SetDataSource(mydata)
                FrmView.CrystalReportViewer1.ReportSource = myrptE1
                Cursor.Current = Cursors.Default
                If Preview = True Then
                    FrmView.ShowDialog()
                Else
                    'Dim oPS As New System.Drawing.Printing.PrinterSettings
                    'myrptE1.PrintOptions.PrinterName = oPS.PrinterName
                    myrptE1.PrintToPrinter(1, True, 0, 0)
                End If
            Else
                CMessageBox.Show("Không có thông tin dữ liệu về mã bưu phẩm này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#Region "SetNullValue"
    Public Function SetNullValue(ByVal String_In As String, ByVal DefaultString As String) As String
        If String_In Is Nothing Then
            Return DefaultString
        ElseIf String_In = "" Then
            Return DefaultString
        Else
            Return String_In
        End If
    End Function
#End Region
#Region "Tao_Id_E1_Trong_E1_Den_Tam_E_Shipping"
    Private Function Tao_Id_E1_Trong_E1_Den_Tam_E_Shipping(ByVal Ma_E1 As String, ByVal Id_Ca As String) As String
        Try
            Return Ma_E1 & Id_Ca
        Catch ex As Exception
            Return ""
        End Try
    End Function

#End Region
#Region "Enable_Control"
    Private Sub Enable_Control(ByVal mBolControl As Boolean)
        cbLua_Chon_In.Enabled = mBolControl
        btnThem_Vao_Tui.Enabled = mBolControl
        btnDelete.Enabled = mBolControl
        If myE1_Den_Tam_Chi_Tiet.Ma_E1 <> "" And Not myTaoMoi Then
            btnPreview.Enabled = mBolControl
        Else
            btnPreview.Enabled = False
        End If
    End Sub

#End Region
#Region "Kiem_Tra_Thong_Tin_Xac_Nhan_Den"
    Private Function Kiem_Tra_Thong_Tin_Xac_Nhan_Den(ByVal mMa_CP1 As String, ByVal mId_Ca As String, ByRef mE1_Den_Chi_Tiet As E1_Den_Chi_Tiet) As Boolean
        Try
            mE1_Den_Chi_Tiet = myE1_Den.Lay_Theo_Ma_E1_Id_Ca_Ma_Bc_Khai_Thac_Trong_E_Shipping(mMa_CP1, mId_Ca, GBuu_Cuc_Khai_Thac)
            If mE1_Den_Chi_Tiet.Id_E1 <> "" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region
#Region "Gan_Thong_Tin_Tu_E_Shipping_Vao_Form"
    Private Sub Gan_Thong_Tin_Tu_E_Shipping_Vao_Form(ByVal mEms_Shipping_E1_Den_Tam_Chi_Tiet As Ems_Shipping_E1_Den_Tam_Chi_Tiet)
        Try
            txtSo_Hieu_E1.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Ma_E1
            cbNuoc_Nhan.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Nuoc_Nhan
            cbDuongThuDi_PH.Value = Convert_Id_Duong_Thu_Den_Tu_E_Shipping_Sang_International(mEms_Shipping_E1_Den_Tam_Chi_Tiet.Id_Duong_Thu)
            cbMa_Nuoc_E1.Value = Mid(mEms_Shipping_E1_Den_Tam_Chi_Tiet.Ma_E1.Trim, 12, 2)
            cbKhach_Hang.Value = GMa_KH_Outbound
            txtHo_Ten_Gui.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Nguoi_Gui
            txtDia_Chi_Gui.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Dia_Chi_Gui
            txtDien_Thoai_Gui.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Dien_Thoai_Gui
            txtHo_Ten_Nhan.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Nguoi_Nhan
            txtDia_Chi_Nhan.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan
            cbBuuCuc.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Ma_Bc_Tra
            cbBuuCuc_Validated(cbBuuCuc, Nothing)
            cbNuoc.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Nuoc_Tra
            cbNuoc_Validated(cbNuoc, Nothing)
            txtDien_Thoai_Nhan.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan
            txtPostcode.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.PostCode
            optTai_Lieu.Checked = IIf(mEms_Shipping_E1_Den_Tam_Chi_Tiet.Phan_Loai = "D", True, False)
            optHang_Hoa.Checked = Not optTai_Lieu.Checked
            Select Case mEms_Shipping_E1_Den_Tam_Chi_Tiet.Loai
                Case 0   'BT
                    optBinh_Thuong.Checked = True
                    optSu_Vu.Checked = False
                    optThoa_Thuan.Checked = False
                Case 1   'SV
                    optBinh_Thuong.Checked = False
                    optSu_Vu.Checked = True
                    optThoa_Thuan.Checked = False
                Case 2   'TT
                    optBinh_Thuong.Checked = False
                    optSu_Vu.Checked = False
                    optThoa_Thuan.Checked = True
                Case Else   'BT
                    optBinh_Thuong.Checked = True
                    optSu_Vu.Checked = False
                    optThoa_Thuan.Checked = False
            End Select
            txtNoi_Dung_Gui.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Ghi_Chu.Split("__").GetValue(1)
            chkChuyen_Hoan_Bc.Checked = False
            dtpNgay_Gui.Value = myHam_Dung_Chung.ConvertIntToDate(mEms_Shipping_E1_Den_Tam_Chi_Tiet.Ngay_Dong)
            txtGio_Gui.Text = myHam_Dung_Chung.ConvertIntToTime(mEms_Shipping_E1_Den_Tam_Chi_Tiet.Gio_Dong)
            txtKhoi_Luong.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Khoi_Luong
            txtKhoi_Luong.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Khoi_Luong_QD
            txtCuoc_Chinh.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Cuoc_Chinh
            txtCuoc_DV.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Cuoc_DV
            txtGia_Tri_Hang.Value = 0
            txtCuoc_E1.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Cuoc_E1
            txtThue_Hai_Quan.Value = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Gia_Tri_Hang
            txtThong_Tin.Text = mEms_Shipping_E1_Den_Tam_Chi_Tiet.Ma_E1
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#Region "Gan_Thong_Tin_Tu_E_International_Vao_Form"
    Private Sub Gan_Thong_Tin_Tu_E_International_Vao_Form(ByVal mE1_Den_Chi_Tiet As E1_Den_Chi_Tiet)
        Try
            Dim mE1_Le_Phi_Den As New E1_Le_Phi_Den(GConnectionString)
            Dim mE1_Le_Phi_Den_Chi_Tiet As New E1_Le_Phi_Den_Chi_Tiet
            'txtSo_Hieu_CP1.Text = ""
            cbNuoc_Nhan.Value = mE1_Den_Chi_Tiet.Nuoc_Nhan
            cbDuongThuDi_PH.Value = mE1_Den_Chi_Tiet.Id_Duong_Thu
            mE1_Le_Phi_Den_Chi_Tiet = mE1_Le_Phi_Den.Lay(mE1_Den_Chi_Tiet.Id_E1)
            Dim mTong_Tien_Thue_Le_Phi As Integer
            mTong_Tien_Thue_Le_Phi = mE1_Le_Phi_Den_Chi_Tiet.Thue_NK_VAT + _
                                     mE1_Le_Phi_Den_Chi_Tiet.Le_Phi_DV + _
                                     mE1_Le_Phi_Den_Chi_Tiet.Le_Phi_HQ + _
                                     mE1_Le_Phi_Den_Chi_Tiet.Le_Phi_TV + _
                                     mE1_Le_Phi_Den_Chi_Tiet.Le_Phi_VH + _
                                     mE1_Le_Phi_Den_Chi_Tiet.Le_Phi_YT + _
                                     mE1_Le_Phi_Den_Chi_Tiet.Le_Phi_Khac
            If mTong_Tien_Thue_Le_Phi > 0 Then
                cbMa_Nuoc_E1.Value = "US"
            Else
                cbMa_Nuoc_E1.Value = "VN"
            End If
            cbKhach_Hang.Value = GMa_KH_Outbound
            'txtHo_Ten_Gui.Text = mE1_Den_Chi_Tiet.Nguoi_Gui
            txtHo_Ten_Gui.Text = myKhach_Hang_Client_Chi_Tiet.Ten_Khach_Hang
            'txtDia_Chi_Gui.Text = mE1_Den_Chi_Tiet.Dia_Chi_Gui
            txtDia_Chi_Gui.Text = myKhach_Hang_Client_Chi_Tiet.Dia_Chi
            'txtDien_Thoai_Gui.Text = mE1_Den_Chi_Tiet.Dien_Thoai_Gui
            txtDien_Thoai_Gui.Text = myKhach_Hang_Client_Chi_Tiet.Dien_Thoai & "    Fax: " & myKhach_Hang_Client_Chi_Tiet.Fax
            txtHo_Ten_Nhan.Text = mE1_Den_Chi_Tiet.Nguoi_Nhan
            txtDia_Chi_Nhan.Text = mE1_Den_Chi_Tiet.Dia_Chi_Nhan
            cbBuuCuc.Value = mE1_Den_Chi_Tiet.Ma_Bc_Tra
            cbBuuCuc_Validated(cbBuuCuc, Nothing)
            cbNuoc.Value = mE1_Den_Chi_Tiet.Nuoc_Tra
            cbNuoc_Validated(cbNuoc, Nothing)
            txtDien_Thoai_Nhan.Text = mE1_Den_Chi_Tiet.Dien_Thoai_Nhan
            txtPostcode.Text = mE1_Den_Chi_Tiet.PostCode
            optTai_Lieu.Checked = IIf(mE1_Den_Chi_Tiet.Phan_Loai = "D", True, False)
            optHang_Hoa.Checked = Not optTai_Lieu.Checked
            Select Case mE1_Den_Chi_Tiet.Loai
                Case 0   'BT
                    optBinh_Thuong.Checked = True
                    optSu_Vu.Checked = False
                    optThoa_Thuan.Checked = False
                Case 1   'SV
                    optBinh_Thuong.Checked = False
                    optSu_Vu.Checked = True
                    optThoa_Thuan.Checked = False
                Case 2   'TT
                    optBinh_Thuong.Checked = False
                    optSu_Vu.Checked = False
                    optThoa_Thuan.Checked = True
                Case Else   'BT
                    optBinh_Thuong.Checked = True
                    optSu_Vu.Checked = False
                    optThoa_Thuan.Checked = False
            End Select
            txtNoi_Dung_Gui.Text = mE1_Den_Chi_Tiet.Ghi_Chu
            chkChuyen_Hoan_Bc.Checked = False
            dtpNgay_Gui.Value = Now.Date()
            txtGio_Gui.Text = IIf(Now.Hour.ToString.Length = 1, "0" & Now.Hour.ToString, Now.Hour.ToString) & ":" & IIf(Now.Minute.ToString.Length = 1, "0" & Now.Minute.ToString, Now.Minute.ToString)
            txtKhoi_Luong.Value = mE1_Den_Chi_Tiet.Khoi_Luong
            txtKhoi_Luong_Validated(txtKhoi_Luong, Nothing)
            txtCuoc_Chinh.Value = mE1_Den_Chi_Tiet.Cuoc_Chinh
            txtCuoc_DV.Value = mE1_Den_Chi_Tiet.Cuoc_DV
            txtGia_Tri_Hang.Value = mE1_Den_Chi_Tiet.Gia_Tri_Hang
            txtCuoc_E1.Value = mE1_Den_Chi_Tiet.Cuoc_E1
            txtThue_Hai_Quan.Value = mE1_Le_Phi_Den_Chi_Tiet.Thue_NK_VAT
            txtThong_Tin.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#Region "Gan_Thong_Tin_Mac_Dinh_Vao_Form"
    Private Sub Gan_Thong_Tin_Mac_Dinh_Vao_Form()
        Try
            myE1_Den_Chi_Tiet = myE1_Den.Lay("0")
            myE1_Den_Tam_Chi_Tiet = myE1_Den_Tam.Lay("0")
            txtSo_Hieu_CP1.Text = ""
            'cbNuoc_Nhan.Value = "US"
            'cbDuongThuDi_PH.Value = ""
            'cbMa_Nuoc_E1.Value = "US"
            'txtSo_Hieu_E1.Value = ""
            txtSo_Hieu_E1.Text = ""
            'cbKhach_Hang.Value = GMa_KH_Outbound
            txtHo_Ten_Gui.Text = ""
            txtDia_Chi_Gui.Text = ""
            txtDien_Thoai_Gui.Text = ""
            txtHo_Ten_Nhan.Text = ""
            txtDia_Chi_Nhan.Text = ""
            'cbBuuCuc.Value = DBNull.Value
            lblBcTra.Text = ""
            cbNuoc.Value = "VN"
            cbNuoc_Validated(cbNuoc, Nothing)
            txtDien_Thoai_Nhan.Text = ""
            txtPostcode.Text = ""
            optHang_Hoa.Checked = True
            optBinh_Thuong.Checked = True
            txtNoi_Dung_Gui.Text = ""
            chkChuyen_Hoan_Bc.Checked = False
            dtpNgay_Gui.Value = Now.Date()
            txtGio_Gui.Text = IIf(Now.Hour.ToString.Length = 1, "0" & Now.Hour.ToString, Now.Hour.ToString) & ":" & IIf(Now.Minute.ToString.Length = 1, "0" & Now.Minute.ToString, Now.Minute.ToString)
            txtKhoi_Luong.Value = 0
            txtKhoi_Luong_Validated(txtKhoi_Luong, Nothing)
            txtCuoc_Chinh.Value = 0
            txtCuoc_DV.Value = 0
            txtGia_Tri_Hang.Value = 0
            txtCuoc_E1.Value = 0
            txtThue_Hai_Quan.Value = 0
            txtThong_Tin.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Convert_Id_Duong_Thu_Den_Tu_International_Sang_E_Shipping"
    Private Function Convert_Id_Duong_Thu_Tu_International_Sang_E_Shipping(ByVal mId_Duong_Thu As String) As String
        Dim mMa_Bc As Integer
        Dim mMa_Bc_Khai_Thac As Integer
        Try
            If mId_Duong_Thu.Trim.Length = 14 Then
                mMa_Bc = CInt(Mid(mId_Duong_Thu.Trim, 1, 7))
                mMa_Bc_Khai_Thac = CInt(Mid(mId_Duong_Thu.Trim, 8, 7))
                Return mMa_Bc.ToString("000000") & mMa_Bc_Khai_Thac.ToString("000000")
            Else
                Return mId_Duong_Thu
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

#End Region

#Region "Convert_Id_Duong_Thu_Den_Tu_E_Shipping_Sang_International"
    Private Function Convert_Id_Duong_Thu_Den_Tu_E_Shipping_Sang_International(ByVal mId_Duong_Thu As String) As String
        Dim mMa_Bc As Integer
        Dim mMa_Bc_Khai_Thac As Integer
        Try
            If mId_Duong_Thu.Trim.Length = 12 Then
                mMa_Bc = CInt(Mid(mId_Duong_Thu.Trim, 1, 6))
                mMa_Bc_Khai_Thac = CInt(Mid(mId_Duong_Thu.Trim, 7, 6))
                Return mMa_Bc.ToString("0000000") & mMa_Bc_Khai_Thac.ToString("0000000")
            Else
                Return mId_Duong_Thu
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

#End Region

#End Region


End Class
