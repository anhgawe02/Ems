Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.Globalization
Public Class FrmCOD
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
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgCODDi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkGuiNhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dtpNgayGui As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ddMaBc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents chkCuoc As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents lblHienThiPhai As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblHienThiTrai As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblHienThiTren As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDuoi As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDinhDangTien As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDuoiTam As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblTrenTam As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblTraiTam As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPhaiTam As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkCuocTam As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dgCODDenTam As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkGuiNhanTam As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dtpNgayDenTam As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnXacNhanDen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblTrenDen As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents lblDuoiDen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblTraiDen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPhaiDen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkCuocDen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dgCODDen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkGuiNhanDen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dtpNgayDen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkNgay As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cbChieu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkBuuCuc As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbBuuCuc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkMaE1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtMaE1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnTimKiem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgTimKiemDi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTimKiemDen As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("CODDI", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1", -1, Nothing, 7500782, 0, 0)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 7500782, 2, 0)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_COD1", -1, Nothing, 7500782, 1, 0)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TT", -1, Nothing, 7500782, 6, 0)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hoa_Don", -1, Nothing, 7500782, 5, 0)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri", -1, Nothing, 7500782, 3, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD", -1, Nothing, 7500799, 2, 0)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_TCT", -1, Nothing, 7500799, 1, 0)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Thu_Ho", -1, Nothing, 7500799, 5, 0)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Nhanh", -1, Nothing, 7500799, 3, 0)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Tiep", -1, Nothing, 7500799, 4, 0)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_EMS", -1, Nothing, 7500799, 0, 0)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMS", -1, Nothing, 7500797, 0, 0)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD", -1, Nothing, 7500797, 1, 0)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nhanh", -1, Nothing, 7500798, 0, 0)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep", -1, Nothing, 7500798, 1, 0)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Gui", -1, Nothing, 7500800, 0, 0)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Gui", -1, Nothing, 7500800, 1, 0)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Nhan", -1, Nothing, 7500800, 2, 0)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Nhan", -1, Nothing, 7500800, 3, 0)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giay_To_Kem_Theo", -1, Nothing, 7500800, 4, 0)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra", -1, Nothing, 7500782, 4, 0)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Chuyen_Tiep", -1, Nothing, 91325876, 0, 0)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui_Nhan_Tien", -1, Nothing, 7500800, 5, 0)
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin COD1", 7500782)
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 7500797)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Hình thức chuyển phiếu", 7500798)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup4 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Tiền cước", 7500799)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup5 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin gửi nhận", 7500800)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup6 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Bưu cục chuyển tiếp", 91325876)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCOD))
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("CODDI", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1", -1, Nothing, 74609844, 0, 0)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 74609844, 2, 0)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_COD1", -1, Nothing, 74609844, 1, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TT", -1, Nothing, 74609844, 6, 0)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hoa_Don", -1, Nothing, 74609844, 5, 0)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri", -1, Nothing, 74609844, 3, 0)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD", -1, Nothing, 74609861, 2, 0)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_TCT", -1, Nothing, 74609861, 1, 0)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Thu_Ho", -1, Nothing, 74609861, 5, 0)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Nhanh", -1, Nothing, 74609861, 3, 0)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Tiep", -1, Nothing, 74609861, 4, 0)
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_EMS", -1, Nothing, 74609861, 0, 0)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMS", -1, Nothing, 74609845, 0, 0)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD", -1, Nothing, 74609845, 1, 0)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nhanh", -1, Nothing, 74609860, 0, 0)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep", -1, Nothing, 74609860, 1, 0)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Gui", -1, Nothing, 74609862, 0, 0)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Gui", -1, Nothing, 74609862, 1, 0)
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Nhan", -1, Nothing, 74609862, 2, 0)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Nhan", -1, Nothing, 74609862, 3, 0)
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giay_To_Kem_Theo", -1, Nothing, 74609862, 4, 0)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc", -1, Nothing, 74609844, 4, 0)
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Chuyen_Tiep", -1, Nothing, 74609863, 0, 0)
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui_Nhan_Tien", -1, Nothing, 74609862, 5, 0)
        Dim UltraGridGroup7 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin COD1", 74609844)
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup8 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 74609845)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup9 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Hình thức chuyển phiếu", 74609860)
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup10 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Tiền cước", 74609861)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup11 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin gửi nhận", 74609862)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup12 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Bưu cục chuyển tiếp", 74609863)
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("CODDI", -1)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1", -1, Nothing, 74609844, 0, 0)
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 74609844, 2, 0)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_COD1", -1, Nothing, 74609844, 1, 0)
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TT", -1, Nothing, 74609844, 6, 0)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hoa_Don", -1, Nothing, 74609844, 5, 0)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri", -1, Nothing, 74609844, 3, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD", -1, Nothing, 74609861, 2, 0)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_TCT", -1, Nothing, 74609861, 1, 0)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Thu_Ho", -1, Nothing, 74609861, 5, 0)
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Nhanh", -1, Nothing, 74609861, 3, 0)
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Tiep", -1, Nothing, 74609861, 4, 0)
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_EMS", -1, Nothing, 74609861, 0, 0)
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMS", -1, Nothing, 74609845, 0, 0)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD", -1, Nothing, 74609845, 1, 0)
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nhanh", -1, Nothing, 74609860, 0, 0)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep", -1, Nothing, 74609860, 1, 0)
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Gui", -1, Nothing, 74609862, 0, 0)
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Gui", -1, Nothing, 74609862, 1, 0)
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Nhan", -1, Nothing, 74609862, 2, 0)
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Nhan", -1, Nothing, 74609862, 3, 0)
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giay_To_Kem_Theo", -1, Nothing, 74609862, 4, 0)
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc", -1, Nothing, 74609844, 4, 0)
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Chuyen_Tiep", -1, Nothing, 74609863, 0, 0)
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui_Nhan_Tien", -1, Nothing, 74609862, 5, 0)
        Dim UltraGridGroup13 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin COD1", 74609844)
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup14 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 74609845)
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup15 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Hình thức chuyển phiếu", 74609860)
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup16 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Tiền cước", 74609861)
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup17 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin gửi nhận", 74609862)
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup18 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Bưu cục chuyển tiếp", 74609863)
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("CODDI", -1)
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1", -1, Nothing, 7500782, 0, 0)
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 7500782, 2, 0)
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_COD1", -1, Nothing, 7500782, 1, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TT", -1, Nothing, 7500782, 6, 0)
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hoa_Don", -1, Nothing, 7500782, 5, 0)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri", -1, Nothing, 7500782, 3, 0)
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD", -1, Nothing, 7500799, 2, 0)
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_TCT", -1, Nothing, 7500799, 1, 0)
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Thu_Ho", -1, Nothing, 7500799, 5, 0)
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Nhanh", -1, Nothing, 7500799, 3, 0)
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Tiep", -1, Nothing, 7500799, 4, 0)
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_EMS", -1, Nothing, 7500799, 0, 0)
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMS", -1, Nothing, 7500797, 0, 0)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD", -1, Nothing, 7500797, 1, 0)
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nhanh", -1, Nothing, 7500798, 0, 0)
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep", -1, Nothing, 7500798, 1, 0)
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Gui", -1, Nothing, 7500800, 0, 0)
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Gui", -1, Nothing, 7500800, 1, 0)
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Nhan", -1, Nothing, 7500800, 2, 0)
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Nhan", -1, Nothing, 7500800, 3, 0)
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giay_To_Kem_Theo", -1, Nothing, 7500800, 4, 0)
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra", -1, Nothing, 7500782, 4, 0)
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Chuyen_Tiep", -1, Nothing, 91325876, 0, 0)
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui_Nhan_Tien", -1, Nothing, 7500800, 5, 0)
        Dim UltraGridGroup19 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin COD1", 7500782)
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup20 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 7500797)
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup21 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Hình thức chuyển phiếu", 7500798)
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup22 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Tiền cước", 7500799)
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup23 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin gửi nhận", 7500800)
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup24 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Bưu cục chuyển tiếp", 91325876)
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc", -1)
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc", -1)
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("CODDI", -1)
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1", -1, Nothing, 74609844, 0, 0)
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 74609844, 2, 0)
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_COD1", -1, Nothing, 74609844, 1, 0)
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TT", -1, Nothing, 74609844, 6, 0)
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hoa_Don", -1, Nothing, 74609844, 5, 0)
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri", -1, Nothing, 74609844, 3, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD", -1, Nothing, 74609861, 2, 0)
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_TCT", -1, Nothing, 74609861, 1, 0)
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Thu_Ho", -1, Nothing, 74609861, 5, 0)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Nhanh", -1, Nothing, 74609861, 3, 0)
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chuyen_Tiep", -1, Nothing, 74609861, 4, 0)
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_EMS", -1, Nothing, 74609861, 0, 0)
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMS", -1, Nothing, 74609845, 0, 0)
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD", -1, Nothing, 74609845, 1, 0)
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nhanh", -1, Nothing, 74609860, 0, 0)
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep", -1, Nothing, 74609860, 1, 0)
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Gui", -1, Nothing, 74609862, 0, 0)
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Gui", -1, Nothing, 74609862, 1, 0)
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten_Nguoi_Nhan", -1, Nothing, 74609862, 2, 0)
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nguoi_Nhan", -1, Nothing, 74609862, 3, 0)
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giay_To_Kem_Theo", -1, Nothing, 74609862, 4, 0)
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc", -1, Nothing, 74609844, 4, 0)
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Chuyen_Tiep", -1, Nothing, 74609863, 0, 0)
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui_Nhan_Tien", -1, Nothing, 74609862, 5, 0)
        Dim UltraGridGroup25 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin COD1", 74609844)
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup26 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 74609845)
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup27 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Hình thức chuyển phiếu", 74609860)
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup28 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Tiền cước", 74609861)
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup29 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Thông tin gửi nhận", 74609862)
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridGroup30 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("Bưu cục chuyển tiếp", 74609863)
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.txtDinhDangTien = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lblDuoi = New Infragistics.Win.Misc.UltraLabel
        Me.lblHienThiTren = New Infragistics.Win.Misc.UltraLabel
        Me.lblHienThiTrai = New Infragistics.Win.Misc.UltraLabel
        Me.lblHienThiPhai = New Infragistics.Win.Misc.UltraLabel
        Me.chkCuoc = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ddMaBc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgCODDi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chkGuiNhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dtpNgayGui = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnXacNhanDen = New Infragistics.Win.Misc.UltraButton
        Me.lblDuoiTam = New Infragistics.Win.Misc.UltraLabel
        Me.lblTrenTam = New Infragistics.Win.Misc.UltraLabel
        Me.lblTraiTam = New Infragistics.Win.Misc.UltraLabel
        Me.lblPhaiTam = New Infragistics.Win.Misc.UltraLabel
        Me.chkCuocTam = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dgCODDenTam = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chkGuiNhanTam = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dtpNgayDenTam = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lblDuoiDen = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.lblTraiDen = New Infragistics.Win.Misc.UltraLabel
        Me.lblPhaiDen = New Infragistics.Win.Misc.UltraLabel
        Me.chkCuocDen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dgCODDen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chkGuiNhanDen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dtpNgayDen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgTimKiemDi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMaE1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.chkMaE1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btnTimKiem = New Infragistics.Win.Misc.UltraButton
        Me.cbBuuCuc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbChieu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.chkNgay = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkBuuCuc = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dgTimKiemDen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lblTrenDen = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        CType(Me.txtDinhDangTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ddMaBc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCODDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayGui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.dgCODDenTam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayDenTam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.dgCODDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayDen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dgTimKiemDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaE1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTimKiemDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTrenDen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblTrenDen.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDinhDangTien
        '
        Me.txtDinhDangTien.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.txtDinhDangTien.Location = New System.Drawing.Point(140, 55)
        Me.txtDinhDangTien.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtDinhDangTien.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtDinhDangTien.MaskInput = "n,nnn,nnn,nnn"
        Me.txtDinhDangTien.Name = "txtDinhDangTien"
        Me.txtDinhDangTien.Size = New System.Drawing.Size(83, 21)
        Me.txtDinhDangTien.TabIndex = 87
        Me.txtDinhDangTien.Visible = False
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txtDinhDangTien)
        Me.UltraTabPageControl1.Controls.Add(Me.lblDuoi)
        Me.UltraTabPageControl1.Controls.Add(Me.lblHienThiTren)
        Me.UltraTabPageControl1.Controls.Add(Me.lblHienThiTrai)
        Me.UltraTabPageControl1.Controls.Add(Me.lblHienThiPhai)
        Me.UltraTabPageControl1.Controls.Add(Me.chkCuoc)
        Me.UltraTabPageControl1.Controls.Add(Me.ddMaBc)
        Me.UltraTabPageControl1.Controls.Add(Me.dgCODDi)
        Me.UltraTabPageControl1.Controls.Add(Me.chkGuiNhan)
        Me.UltraTabPageControl1.Controls.Add(Me.dtpNgayGui)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(642, 459)
        '
        'lblDuoi
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.lblDuoi.Appearance = Appearance1
        Me.lblDuoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoi.Location = New System.Drawing.Point(320, 76)
        Me.lblDuoi.Name = "lblDuoi"
        Me.lblDuoi.Size = New System.Drawing.Size(313, 21)
        Me.lblDuoi.TabIndex = 86
        Me.lblDuoi.Text = "Người gửi phải trả"
        '
        'lblHienThiTren
        '
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.lblHienThiTren.Appearance = Appearance2
        Me.lblHienThiTren.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHienThiTren.Location = New System.Drawing.Point(320, 7)
        Me.lblHienThiTren.Name = "lblHienThiTren"
        Me.lblHienThiTren.Size = New System.Drawing.Size(313, 21)
        Me.lblHienThiTren.TabIndex = 85
        Me.lblHienThiTren.Text = "Thông tin cước"
        '
        'lblHienThiTrai
        '
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance3.FontData.BoldAsString = "True"
        Me.lblHienThiTrai.Appearance = Appearance3
        Me.lblHienThiTrai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHienThiTrai.Location = New System.Drawing.Point(320, 28)
        Me.lblHienThiTrai.Name = "lblHienThiTrai"
        Me.lblHienThiTrai.Size = New System.Drawing.Size(160, 48)
        Me.lblHienThiTrai.TabIndex = 84
        '
        'lblHienThiPhai
        '
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance4.FontData.BoldAsString = "True"
        Me.lblHienThiPhai.Appearance = Appearance4
        Me.lblHienThiPhai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHienThiPhai.Location = New System.Drawing.Point(480, 28)
        Me.lblHienThiPhai.Name = "lblHienThiPhai"
        Me.lblHienThiPhai.Size = New System.Drawing.Size(153, 48)
        Me.lblHienThiPhai.TabIndex = 83
        '
        'chkCuoc
        '
        Me.chkCuoc.Location = New System.Drawing.Point(173, 7)
        Me.chkCuoc.Name = "chkCuoc"
        Me.chkCuoc.Size = New System.Drawing.Size(147, 21)
        Me.chkCuoc.TabIndex = 61
        Me.chkCuoc.Text = "Hiện thông tin cước"
        '
        'ddMaBc
        '
        Me.ddMaBc.Cursor = System.Windows.Forms.Cursors.Default
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaBc.DisplayLayout.Appearance = Appearance5
        UltraGridColumn1.Header.Caption = "Mã BC"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên BC"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Mã Tỉnh"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ddMaBc.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaBc.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.ddMaBc.DisplayMember = ""
        Me.ddMaBc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaBc.Location = New System.Drawing.Point(287, 250)
        Me.ddMaBc.Name = "ddMaBc"
        Me.ddMaBc.Size = New System.Drawing.Size(208, 128)
        Me.ddMaBc.TabIndex = 60
        Me.ddMaBc.ValueMember = ""
        Me.ddMaBc.Visible = False
        '
        'dgCODDi
        '
        Me.dgCODDi.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCODDi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCODDi.DisplayLayout.Appearance = Appearance7
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Mã E1"
        UltraGridColumn5.Width = 131
        UltraGridColumn6.Header.Caption = "Số COD1"
        UltraGridColumn6.Width = 77
        UltraGridColumn7.Header.Caption = "Số TT trả tiền"
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Caption = "Số HĐ hàng hóa"
        UltraGridColumn8.Width = 118
        UltraGridColumn9.EditorControl = Me.txtDinhDangTien
        UltraGridColumn9.Header.Caption = "Giá trị"
        UltraGridColumn9.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn9.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn9.Width = 104
        UltraGridColumn10.EditorControl = Me.txtDinhDangTien
        UltraGridColumn10.Header.Caption = "COD"
        UltraGridColumn10.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn10.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn10.Width = 74
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.EditorControl = Me.txtDinhDangTien
        UltraGridColumn11.Header.Caption = "TCT"
        UltraGridColumn11.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn11.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn11.Width = 74
        UltraGridColumn12.EditorControl = Me.txtDinhDangTien
        UltraGridColumn12.Header.Caption = "Thu hộ"
        UltraGridColumn12.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn12.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn12.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn12.Width = 99
        UltraGridColumn13.EditorControl = Me.txtDinhDangTien
        UltraGridColumn13.Header.Caption = "Chuyển nhanh"
        UltraGridColumn13.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn13.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn13.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn13.Width = 110
        UltraGridColumn14.EditorControl = Me.txtDinhDangTien
        UltraGridColumn14.Header.Caption = "Chuyển tiếp"
        UltraGridColumn14.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn14.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn14.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn14.Width = 92
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.EditorControl = Me.txtDinhDangTien
        UltraGridColumn15.Header.Caption = "EMS"
        UltraGridColumn15.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.Width = 68
        UltraGridColumn16.Width = 49
        UltraGridColumn17.Width = 47
        UltraGridColumn18.Width = 52
        UltraGridColumn19.Header.Caption = "Chuyển tiếp"
        UltraGridColumn19.Width = 106
        UltraGridColumn20.Header.Caption = "Người gửi"
        UltraGridColumn21.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn22.Header.Caption = "Người nhận"
        UltraGridColumn23.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn24.Header.Caption = "Giấy tờ nhận"
        UltraGridColumn25.Header.Caption = "Bc trả"
        UltraGridColumn25.Width = 80
        UltraGridColumn26.Header.Caption = "Bc chuyển tiếp"
        UltraGridColumn27.Header.Caption = "Đã nhận tiền"
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup1.Header.Appearance = Appearance8
        UltraGridGroup1.Key = "Thông tin COD1"
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup2.Header.Appearance = Appearance9
        UltraGridGroup2.Header.Caption = "Người gửi trả cước"
        UltraGridGroup2.Key = "NewGroup1"
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup3.Header.Appearance = Appearance10
        UltraGridGroup3.Key = "Hình thức chuyển phiếu"
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup4.Header.Appearance = Appearance11
        UltraGridGroup4.Header.VisiblePosition = 4
        UltraGridGroup4.Hidden = True
        UltraGridGroup4.Key = "Tiền cước"
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup5.Header.Appearance = Appearance12
        UltraGridGroup5.Header.VisiblePosition = 5
        UltraGridGroup5.Hidden = True
        UltraGridGroup5.Key = "Thông tin gửi nhận"
        UltraGridGroup6.Header.VisiblePosition = 3
        UltraGridGroup6.Hidden = True
        UltraGridGroup6.Key = "Bưu cục chuyển tiếp"
        UltraGridBand2.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3, UltraGridGroup4, UltraGridGroup5, UltraGridGroup6})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgCODDi.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgCODDi.DisplayLayout.InterBandSpacing = 10
        Me.dgCODDi.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.dgCODDi.DisplayLayout.Override.CardAreaAppearance = Appearance13
        Me.dgCODDi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.ForeColor = System.Drawing.Color.Black
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCODDi.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.dgCODDi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance15.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCODDi.DisplayLayout.Override.RowAppearance = Appearance15
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCODDi.DisplayLayout.Override.RowSelectorAppearance = Appearance16
        Me.dgCODDi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCODDi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.ForeColor = System.Drawing.Color.Black
        Me.dgCODDi.DisplayLayout.Override.SelectedRowAppearance = Appearance17
        Me.dgCODDi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCODDi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCODDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCODDi.Location = New System.Drawing.Point(7, 104)
        Me.dgCODDi.Name = "dgCODDi"
        Me.dgCODDi.Size = New System.Drawing.Size(633, 354)
        Me.dgCODDi.TabIndex = 59
        Me.dgCODDi.Text = "COD Đi"
        '
        'chkGuiNhan
        '
        Me.chkGuiNhan.Location = New System.Drawing.Point(173, 28)
        Me.chkGuiNhan.Name = "chkGuiNhan"
        Me.chkGuiNhan.Size = New System.Drawing.Size(140, 21)
        Me.chkGuiNhan.TabIndex = 57
        Me.chkGuiNhan.Text = "Hiện thông tin gửi - nhận"
        '
        'dtpNgayGui
        '
        Me.dtpNgayGui.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayGui.Location = New System.Drawing.Point(73, 7)
        Me.dtpNgayGui.Name = "dtpNgayGui"
        Me.dtpNgayGui.Size = New System.Drawing.Size(89, 21)
        Me.dtpNgayGui.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Ngày gửi"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.btnXacNhanDen)
        Me.UltraTabPageControl4.Controls.Add(Me.lblDuoiTam)
        Me.UltraTabPageControl4.Controls.Add(Me.lblTrenTam)
        Me.UltraTabPageControl4.Controls.Add(Me.lblTraiTam)
        Me.UltraTabPageControl4.Controls.Add(Me.lblPhaiTam)
        Me.UltraTabPageControl4.Controls.Add(Me.chkCuocTam)
        Me.UltraTabPageControl4.Controls.Add(Me.dgCODDenTam)
        Me.UltraTabPageControl4.Controls.Add(Me.chkGuiNhanTam)
        Me.UltraTabPageControl4.Controls.Add(Me.dtpNgayDenTam)
        Me.UltraTabPageControl4.Controls.Add(Me.Label1)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-8333, -8667)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(642, 459)
        '
        'btnXacNhanDen
        '
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Me.btnXacNhanDen.Appearance = Appearance18
        Me.btnXacNhanDen.Location = New System.Drawing.Point(7, 62)
        Me.btnXacNhanDen.Name = "btnXacNhanDen"
        Me.btnXacNhanDen.Size = New System.Drawing.Size(153, 32)
        Me.btnXacNhanDen.TabIndex = 96
        Me.btnXacNhanDen.Text = "Xác nhận COD đến"
        '
        'lblDuoiTam
        '
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Center
        Me.lblDuoiTam.Appearance = Appearance19
        Me.lblDuoiTam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoiTam.Location = New System.Drawing.Point(318, 75)
        Me.lblDuoiTam.Name = "lblDuoiTam"
        Me.lblDuoiTam.Size = New System.Drawing.Size(314, 20)
        Me.lblDuoiTam.TabIndex = 95
        Me.lblDuoiTam.Text = "Người gửi phải trả"
        '
        'lblTrenTam
        '
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance20.FontData.BoldAsString = "True"
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        Me.lblTrenTam.Appearance = Appearance20
        Me.lblTrenTam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrenTam.Location = New System.Drawing.Point(318, 5)
        Me.lblTrenTam.Name = "lblTrenTam"
        Me.lblTrenTam.Size = New System.Drawing.Size(314, 21)
        Me.lblTrenTam.TabIndex = 94
        Me.lblTrenTam.Text = "Thông tin cước"
        '
        'lblTraiTam
        '
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance21.FontData.BoldAsString = "True"
        Me.lblTraiTam.Appearance = Appearance21
        Me.lblTraiTam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTraiTam.Location = New System.Drawing.Point(318, 26)
        Me.lblTraiTam.Name = "lblTraiTam"
        Me.lblTraiTam.Size = New System.Drawing.Size(160, 49)
        Me.lblTraiTam.TabIndex = 93
        '
        'lblPhaiTam
        '
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance22.FontData.BoldAsString = "True"
        Me.lblPhaiTam.Appearance = Appearance22
        Me.lblPhaiTam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhaiTam.Location = New System.Drawing.Point(478, 26)
        Me.lblPhaiTam.Name = "lblPhaiTam"
        Me.lblPhaiTam.Size = New System.Drawing.Size(154, 49)
        Me.lblPhaiTam.TabIndex = 92
        '
        'chkCuocTam
        '
        Me.chkCuocTam.Location = New System.Drawing.Point(172, 5)
        Me.chkCuocTam.Name = "chkCuocTam"
        Me.chkCuocTam.Size = New System.Drawing.Size(146, 21)
        Me.chkCuocTam.TabIndex = 91
        Me.chkCuocTam.Text = "Hiện thông tin cước"
        '
        'dgCODDenTam
        '
        Me.dgCODDenTam.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCODDenTam.DisplayLayout.AddNewBox.Prompt = " "
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCODDenTam.DisplayLayout.Appearance = Appearance23
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.Caption = "Mã E1"
        UltraGridColumn29.Width = 131
        UltraGridColumn30.Header.Caption = "Số COD1"
        UltraGridColumn30.Width = 77
        UltraGridColumn31.Header.Caption = "Số TT trả tiền"
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.Caption = "Số HĐ hàng hóa"
        UltraGridColumn32.Width = 118
        UltraGridColumn33.EditorControl = Me.txtDinhDangTien
        UltraGridColumn33.Header.Caption = "Giá trị"
        UltraGridColumn33.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn33.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn33.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn33.Width = 104
        UltraGridColumn34.EditorControl = Me.txtDinhDangTien
        UltraGridColumn34.Header.Caption = "COD"
        UltraGridColumn34.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn34.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn34.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn34.Width = 74
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.EditorControl = Me.txtDinhDangTien
        UltraGridColumn35.Header.Caption = "TCT"
        UltraGridColumn35.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn35.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn35.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn35.Width = 74
        UltraGridColumn36.EditorControl = Me.txtDinhDangTien
        UltraGridColumn36.Header.Caption = "Thu hộ"
        UltraGridColumn36.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn36.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn36.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn36.Width = 99
        UltraGridColumn37.EditorControl = Me.txtDinhDangTien
        UltraGridColumn37.Header.Caption = "Chuyển nhanh"
        UltraGridColumn37.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.Width = 110
        UltraGridColumn38.EditorControl = Me.txtDinhDangTien
        UltraGridColumn38.Header.Caption = "Chuyển tiếp"
        UltraGridColumn38.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.Width = 92
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.EditorControl = Me.txtDinhDangTien
        UltraGridColumn39.Header.Caption = "EMS"
        UltraGridColumn39.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn39.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn39.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn39.Width = 68
        UltraGridColumn40.Width = 49
        UltraGridColumn41.Width = 47
        UltraGridColumn42.Width = 52
        UltraGridColumn43.Header.Caption = "Chuyển tiếp"
        UltraGridColumn43.Width = 106
        UltraGridColumn44.Header.Caption = "Người gửi"
        UltraGridColumn45.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn46.Header.Caption = "Người nhận"
        UltraGridColumn47.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn48.Header.Caption = "Giấy tờ nhận"
        UltraGridColumn49.Header.Caption = "Mã bưu cục gốc"
        UltraGridColumn50.Header.Caption = "Bc chuyển tiếp"
        UltraGridColumn51.Header.Caption = "Đã nhận tiền"
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51})
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup7.Header.Appearance = Appearance24
        UltraGridGroup7.Key = "Thông tin COD1"
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup8.Header.Appearance = Appearance25
        UltraGridGroup8.Header.Caption = "Người gửi trả cước"
        UltraGridGroup8.Key = "NewGroup1"
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup9.Header.Appearance = Appearance26
        UltraGridGroup9.Key = "Hình thức chuyển phiếu"
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup10.Header.Appearance = Appearance27
        UltraGridGroup10.Header.VisiblePosition = 4
        UltraGridGroup10.Hidden = True
        UltraGridGroup10.Key = "Tiền cước"
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup11.Header.Appearance = Appearance28
        UltraGridGroup11.Header.VisiblePosition = 5
        UltraGridGroup11.Hidden = True
        UltraGridGroup11.Key = "Thông tin gửi nhận"
        UltraGridGroup12.Header.VisiblePosition = 3
        UltraGridGroup12.Hidden = True
        UltraGridGroup12.Key = "Bưu cục chuyển tiếp"
        UltraGridBand3.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup7, UltraGridGroup8, UltraGridGroup9, UltraGridGroup10, UltraGridGroup11, UltraGridGroup12})
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgCODDenTam.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgCODDenTam.DisplayLayout.InterBandSpacing = 10
        Me.dgCODDenTam.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.dgCODDenTam.DisplayLayout.Override.CardAreaAppearance = Appearance29
        Me.dgCODDenTam.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance30.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.ForeColor = System.Drawing.Color.Black
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance30.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCODDenTam.DisplayLayout.Override.HeaderAppearance = Appearance30
        Me.dgCODDenTam.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance31.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCODDenTam.DisplayLayout.Override.RowAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance32.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCODDenTam.DisplayLayout.Override.RowSelectorAppearance = Appearance32
        Me.dgCODDenTam.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCODDenTam.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance33.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.dgCODDenTam.DisplayLayout.Override.SelectedRowAppearance = Appearance33
        Me.dgCODDenTam.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCODDenTam.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCODDenTam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCODDenTam.Location = New System.Drawing.Point(5, 102)
        Me.dgCODDenTam.Name = "dgCODDenTam"
        Me.dgCODDenTam.Size = New System.Drawing.Size(633, 354)
        Me.dgCODDenTam.TabIndex = 90
        Me.dgCODDenTam.Text = "COD Đến chưa xác nhận"
        '
        'chkGuiNhanTam
        '
        Me.chkGuiNhanTam.Location = New System.Drawing.Point(172, 26)
        Me.chkGuiNhanTam.Name = "chkGuiNhanTam"
        Me.chkGuiNhanTam.Size = New System.Drawing.Size(140, 21)
        Me.chkGuiNhanTam.TabIndex = 89
        Me.chkGuiNhanTam.Text = "Hiện thông tin gửi - nhận"
        '
        'dtpNgayDenTam
        '
        Me.dtpNgayDenTam.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDenTam.Location = New System.Drawing.Point(72, 5)
        Me.dtpNgayDenTam.Name = "dtpNgayDenTam"
        Me.dtpNgayDenTam.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayDenTam.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Ngày nhận"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.lblDuoiDen)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl2.Controls.Add(Me.lblTraiDen)
        Me.UltraTabPageControl2.Controls.Add(Me.lblPhaiDen)
        Me.UltraTabPageControl2.Controls.Add(Me.chkCuocDen)
        Me.UltraTabPageControl2.Controls.Add(Me.dgCODDen)
        Me.UltraTabPageControl2.Controls.Add(Me.chkGuiNhanDen)
        Me.UltraTabPageControl2.Controls.Add(Me.dtpNgayDen)
        Me.UltraTabPageControl2.Controls.Add(Me.Label3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-8333, -8667)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(642, 459)
        '
        'lblDuoiDen
        '
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance34.FontData.BoldAsString = "True"
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Center
        Me.lblDuoiDen.Appearance = Appearance34
        Me.lblDuoiDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuoiDen.Location = New System.Drawing.Point(318, 75)
        Me.lblDuoiDen.Name = "lblDuoiDen"
        Me.lblDuoiDen.Size = New System.Drawing.Size(314, 20)
        Me.lblDuoiDen.TabIndex = 105
        Me.lblDuoiDen.Text = "Người gửi phải trả"
        '
        'UltraLabel2
        '
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance35.FontData.BoldAsString = "True"
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraLabel2.Appearance = Appearance35
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(318, 5)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(314, 21)
        Me.UltraLabel2.TabIndex = 104
        Me.UltraLabel2.Text = "Thông tin cước"
        '
        'lblTraiDen
        '
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance36.FontData.BoldAsString = "True"
        Me.lblTraiDen.Appearance = Appearance36
        Me.lblTraiDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTraiDen.Location = New System.Drawing.Point(318, 26)
        Me.lblTraiDen.Name = "lblTraiDen"
        Me.lblTraiDen.Size = New System.Drawing.Size(160, 49)
        Me.lblTraiDen.TabIndex = 103
        '
        'lblPhaiDen
        '
        Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance37.FontData.BoldAsString = "True"
        Me.lblPhaiDen.Appearance = Appearance37
        Me.lblPhaiDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhaiDen.Location = New System.Drawing.Point(478, 26)
        Me.lblPhaiDen.Name = "lblPhaiDen"
        Me.lblPhaiDen.Size = New System.Drawing.Size(154, 49)
        Me.lblPhaiDen.TabIndex = 102
        '
        'chkCuocDen
        '
        Me.chkCuocDen.Location = New System.Drawing.Point(172, 5)
        Me.chkCuocDen.Name = "chkCuocDen"
        Me.chkCuocDen.Size = New System.Drawing.Size(146, 21)
        Me.chkCuocDen.TabIndex = 101
        Me.chkCuocDen.Text = "Hiện thông tin cước"
        '
        'dgCODDen
        '
        Me.dgCODDen.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCODDen.DisplayLayout.AddNewBox.Prompt = " "
        Appearance38.BackColor = System.Drawing.Color.White
        Appearance38.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCODDen.DisplayLayout.Appearance = Appearance38
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.Caption = "Mã E1"
        UltraGridColumn53.Width = 131
        UltraGridColumn54.Header.Caption = "Số COD1"
        UltraGridColumn54.Width = 77
        UltraGridColumn55.Header.Caption = "Số TT trả tiền"
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.Caption = "Số HĐ hàng hóa"
        UltraGridColumn56.Width = 118
        UltraGridColumn57.EditorControl = Me.txtDinhDangTien
        UltraGridColumn57.Header.Caption = "Giá trị"
        UltraGridColumn57.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn57.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn57.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn57.Width = 104
        UltraGridColumn58.EditorControl = Me.txtDinhDangTien
        UltraGridColumn58.Header.Caption = "COD"
        UltraGridColumn58.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn58.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn58.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn58.Width = 74
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn59.EditorControl = Me.txtDinhDangTien
        UltraGridColumn59.Header.Caption = "TCT"
        UltraGridColumn59.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn59.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn59.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn59.Width = 74
        UltraGridColumn60.EditorControl = Me.txtDinhDangTien
        UltraGridColumn60.Header.Caption = "Thu hộ"
        UltraGridColumn60.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn60.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn60.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn60.Width = 99
        UltraGridColumn61.EditorControl = Me.txtDinhDangTien
        UltraGridColumn61.Header.Caption = "Chuyển nhanh"
        UltraGridColumn61.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn61.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn61.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn61.Width = 110
        UltraGridColumn62.EditorControl = Me.txtDinhDangTien
        UltraGridColumn62.Header.Caption = "Chuyển tiếp"
        UltraGridColumn62.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn62.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn62.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn62.Width = 92
        UltraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn63.EditorControl = Me.txtDinhDangTien
        UltraGridColumn63.Header.Caption = "EMS"
        UltraGridColumn63.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn63.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn63.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn63.Width = 68
        UltraGridColumn64.Width = 49
        UltraGridColumn65.Width = 47
        UltraGridColumn66.Width = 52
        UltraGridColumn67.Header.Caption = "Chuyển tiếp"
        UltraGridColumn67.Width = 106
        UltraGridColumn68.Header.Caption = "Người gửi"
        UltraGridColumn69.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn70.Header.Caption = "Người nhận"
        UltraGridColumn71.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn72.Header.Caption = "Giấy tờ nhận"
        UltraGridColumn73.Header.Caption = "Mã bưu cục gốc"
        UltraGridColumn74.Header.Caption = "Bc chuyển tiếp"
        UltraGridColumn75.Header.Caption = "Đã nhận tiền"
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75})
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup13.Header.Appearance = Appearance39
        UltraGridGroup13.Key = "Thông tin COD1"
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup14.Header.Appearance = Appearance40
        UltraGridGroup14.Header.Caption = "Người gửi trả cước"
        UltraGridGroup14.Key = "NewGroup1"
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup15.Header.Appearance = Appearance41
        UltraGridGroup15.Key = "Hình thức chuyển phiếu"
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup16.Header.Appearance = Appearance42
        UltraGridGroup16.Header.VisiblePosition = 4
        UltraGridGroup16.Hidden = True
        UltraGridGroup16.Key = "Tiền cước"
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup17.Header.Appearance = Appearance43
        UltraGridGroup17.Header.VisiblePosition = 5
        UltraGridGroup17.Hidden = True
        UltraGridGroup17.Key = "Thông tin gửi nhận"
        UltraGridGroup18.Header.VisiblePosition = 3
        UltraGridGroup18.Hidden = True
        UltraGridGroup18.Key = "Bưu cục chuyển tiếp"
        UltraGridBand4.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup13, UltraGridGroup14, UltraGridGroup15, UltraGridGroup16, UltraGridGroup17, UltraGridGroup18})
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgCODDen.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgCODDen.DisplayLayout.InterBandSpacing = 10
        Me.dgCODDen.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.dgCODDen.DisplayLayout.Override.CardAreaAppearance = Appearance44
        Me.dgCODDen.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance45.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.ForeColor = System.Drawing.Color.Black
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance45.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCODDen.DisplayLayout.Override.HeaderAppearance = Appearance45
        Me.dgCODDen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance46.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCODDen.DisplayLayout.Override.RowAppearance = Appearance46
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance47.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCODDen.DisplayLayout.Override.RowSelectorAppearance = Appearance47
        Me.dgCODDen.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCODDen.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance48.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance48.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.ForeColor = System.Drawing.Color.Black
        Me.dgCODDen.DisplayLayout.Override.SelectedRowAppearance = Appearance48
        Me.dgCODDen.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCODDen.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCODDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCODDen.Location = New System.Drawing.Point(7, 97)
        Me.dgCODDen.Name = "dgCODDen"
        Me.dgCODDen.Size = New System.Drawing.Size(633, 354)
        Me.dgCODDen.TabIndex = 100
        Me.dgCODDen.Text = "COD Đến "
        '
        'chkGuiNhanDen
        '
        Me.chkGuiNhanDen.Location = New System.Drawing.Point(172, 26)
        Me.chkGuiNhanDen.Name = "chkGuiNhanDen"
        Me.chkGuiNhanDen.Size = New System.Drawing.Size(140, 21)
        Me.chkGuiNhanDen.TabIndex = 99
        Me.chkGuiNhanDen.Text = "Hiện thông tin gửi - nhận"
        '
        'dtpNgayDen
        '
        Me.dtpNgayDen.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDen.Location = New System.Drawing.Point(72, 5)
        Me.dtpNgayDen.Name = "dtpNgayDen"
        Me.dtpNgayDen.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayDen.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Ngày nhận"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dgTimKiemDi)
        Me.UltraTabPageControl3.Controls.Add(Me.Label5)
        Me.UltraTabPageControl3.Controls.Add(Me.txtMaE1)
        Me.UltraTabPageControl3.Controls.Add(Me.chkMaE1)
        Me.UltraTabPageControl3.Controls.Add(Me.btnTimKiem)
        Me.UltraTabPageControl3.Controls.Add(Me.cbBuuCuc)
        Me.UltraTabPageControl3.Controls.Add(Me.cbChieu)
        Me.UltraTabPageControl3.Controls.Add(Me.dtpDenNgay)
        Me.UltraTabPageControl3.Controls.Add(Me.Label4)
        Me.UltraTabPageControl3.Controls.Add(Me.dtpTuNgay)
        Me.UltraTabPageControl3.Controls.Add(Me.chkNgay)
        Me.UltraTabPageControl3.Controls.Add(Me.chkBuuCuc)
        Me.UltraTabPageControl3.Controls.Add(Me.dgTimKiemDen)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-8333, -8667)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(642, 459)
        '
        'dgTimKiemDi
        '
        Me.dgTimKiemDi.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTimKiemDi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance49.BackColor = System.Drawing.Color.White
        Appearance49.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTimKiemDi.DisplayLayout.Appearance = Appearance49
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.Caption = "Mã E1"
        UltraGridColumn77.Width = 131
        UltraGridColumn78.Header.Caption = "Số COD1"
        UltraGridColumn78.Width = 77
        UltraGridColumn79.Header.Caption = "Số TT trả tiền"
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.Caption = "Số HĐ hàng hóa"
        UltraGridColumn80.Width = 118
        UltraGridColumn81.EditorControl = Me.txtDinhDangTien
        UltraGridColumn81.Header.Caption = "Giá trị"
        UltraGridColumn81.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn81.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn81.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn81.Width = 104
        UltraGridColumn82.EditorControl = Me.txtDinhDangTien
        UltraGridColumn82.Header.Caption = "COD"
        UltraGridColumn82.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn82.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn82.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn82.Width = 74
        UltraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn83.EditorControl = Me.txtDinhDangTien
        UltraGridColumn83.Header.Caption = "TCT"
        UltraGridColumn83.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn83.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn83.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn83.Width = 74
        UltraGridColumn84.EditorControl = Me.txtDinhDangTien
        UltraGridColumn84.Header.Caption = "Thu hộ"
        UltraGridColumn84.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn84.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn84.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn84.Width = 99
        UltraGridColumn85.EditorControl = Me.txtDinhDangTien
        UltraGridColumn85.Header.Caption = "Chuyển nhanh"
        UltraGridColumn85.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn85.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn85.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn85.Width = 110
        UltraGridColumn86.EditorControl = Me.txtDinhDangTien
        UltraGridColumn86.Header.Caption = "Chuyển tiếp"
        UltraGridColumn86.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.Width = 92
        UltraGridColumn87.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn87.EditorControl = Me.txtDinhDangTien
        UltraGridColumn87.Header.Caption = "EMS"
        UltraGridColumn87.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn87.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn87.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn87.Width = 68
        UltraGridColumn88.Width = 49
        UltraGridColumn89.Width = 47
        UltraGridColumn90.Width = 52
        UltraGridColumn91.Header.Caption = "Chuyển tiếp"
        UltraGridColumn91.Width = 106
        UltraGridColumn92.Header.Caption = "Người gửi"
        UltraGridColumn93.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn94.Header.Caption = "Người nhận"
        UltraGridColumn95.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn96.Header.Caption = "Giấy tờ nhận"
        UltraGridColumn97.Header.Caption = "Bc trả"
        UltraGridColumn97.Width = 80
        UltraGridColumn98.Header.Caption = "Bc chuyển tiếp"
        UltraGridColumn99.Header.Caption = "Đã nhận tiền"
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99})
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup19.Header.Appearance = Appearance50
        UltraGridGroup19.Key = "Thông tin COD1"
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup20.Header.Appearance = Appearance51
        UltraGridGroup20.Header.Caption = "Người gửi trả cước"
        UltraGridGroup20.Key = "NewGroup1"
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup21.Header.Appearance = Appearance52
        UltraGridGroup21.Key = "Hình thức chuyển phiếu"
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup22.Header.Appearance = Appearance53
        UltraGridGroup22.Header.VisiblePosition = 4
        UltraGridGroup22.Key = "Tiền cước"
        Appearance54.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup23.Header.Appearance = Appearance54
        UltraGridGroup23.Header.VisiblePosition = 5
        UltraGridGroup23.Key = "Thông tin gửi nhận"
        UltraGridGroup24.Header.VisiblePosition = 3
        UltraGridGroup24.Key = "Bưu cục chuyển tiếp"
        UltraGridBand5.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup19, UltraGridGroup20, UltraGridGroup21, UltraGridGroup22, UltraGridGroup23, UltraGridGroup24})
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgTimKiemDi.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgTimKiemDi.DisplayLayout.InterBandSpacing = 10
        Me.dgTimKiemDi.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Me.dgTimKiemDi.DisplayLayout.Override.CardAreaAppearance = Appearance55
        Me.dgTimKiemDi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance56.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance56.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance56.ForeColor = System.Drawing.Color.Black
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance56.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTimKiemDi.DisplayLayout.Override.HeaderAppearance = Appearance56
        Me.dgTimKiemDi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance57.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTimKiemDi.DisplayLayout.Override.RowAppearance = Appearance57
        Appearance58.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance58.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTimKiemDi.DisplayLayout.Override.RowSelectorAppearance = Appearance58
        Me.dgTimKiemDi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTimKiemDi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance59.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance59.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance59.ForeColor = System.Drawing.Color.Black
        Me.dgTimKiemDi.DisplayLayout.Override.SelectedRowAppearance = Appearance59
        Me.dgTimKiemDi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTimKiemDi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTimKiemDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTimKiemDi.Location = New System.Drawing.Point(7, 125)
        Me.dgTimKiemDi.Name = "dgTimKiemDi"
        Me.dgTimKiemDi.Size = New System.Drawing.Size(633, 333)
        Me.dgTimKiemDi.TabIndex = 105
        Me.dgTimKiemDi.Text = "COD Tìm kiếm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(27, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Chiều COD1"
        '
        'txtMaE1
        '
        Me.txtMaE1.Location = New System.Drawing.Point(127, 90)
        Me.txtMaE1.Name = "txtMaE1"
        Me.txtMaE1.Size = New System.Drawing.Size(233, 21)
        Me.txtMaE1.TabIndex = 103
        '
        'chkMaE1
        '
        Me.chkMaE1.Location = New System.Drawing.Point(13, 97)
        Me.chkMaE1.Name = "chkMaE1"
        Me.chkMaE1.Size = New System.Drawing.Size(147, 21)
        Me.chkMaE1.TabIndex = 102
        Me.chkMaE1.Text = "Theo mã E1"
        '
        'btnTimKiem
        '
        Appearance60.Image = CType(resources.GetObject("Appearance60.Image"), Object)
        Me.btnTimKiem.Appearance = Appearance60
        Me.btnTimKiem.Location = New System.Drawing.Point(373, 62)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(140, 49)
        Me.btnTimKiem.TabIndex = 101
        Me.btnTimKiem.Text = "Tìm kiếm"
        '
        'cbBuuCuc
        '
        Me.cbBuuCuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn100.Header.Caption = "Mã bưu cục"
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn101.Header.Caption = "Tên bưu cục"
        UltraGridColumn101.Header.VisiblePosition = 1
        UltraGridColumn102.Header.Caption = "Mã tỉnh"
        UltraGridColumn102.Header.VisiblePosition = 2
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn100, UltraGridColumn101, UltraGridColumn102})
        Me.cbBuuCuc.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.cbBuuCuc.DisplayMember = ""
        Me.cbBuuCuc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuuCuc.Location = New System.Drawing.Point(127, 62)
        Me.cbBuuCuc.Name = "cbBuuCuc"
        Me.cbBuuCuc.Size = New System.Drawing.Size(88, 21)
        Me.cbBuuCuc.TabIndex = 99
        Me.cbBuuCuc.ValueMember = ""
        '
        'cbChieu
        '
        Me.cbChieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn103.Header.Caption = "Mã bưu cục"
        UltraGridColumn103.Header.VisiblePosition = 0
        UltraGridColumn104.Header.Caption = "Tên bưu cục"
        UltraGridColumn104.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn103, UltraGridColumn104})
        Me.cbChieu.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.cbChieu.DisplayMember = ""
        Me.cbChieu.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbChieu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChieu.Location = New System.Drawing.Point(127, 7)
        Me.cbChieu.Name = "cbChieu"
        Me.cbChieu.Size = New System.Drawing.Size(88, 21)
        Me.cbChieu.TabIndex = 97
        Me.cbChieu.ValueMember = ""
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(273, 35)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(89, 21)
        Me.dtpDenNgay.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(220, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "đến ngày"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(127, 35)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(88, 21)
        Me.dtpTuNgay.TabIndex = 93
        '
        'chkNgay
        '
        Me.chkNgay.Location = New System.Drawing.Point(13, 42)
        Me.chkNgay.Name = "chkNgay"
        Me.chkNgay.Size = New System.Drawing.Size(147, 20)
        Me.chkNgay.TabIndex = 92
        Me.chkNgay.Text = "Theo thời gian"
        '
        'chkBuuCuc
        '
        Me.chkBuuCuc.Location = New System.Drawing.Point(13, 69)
        Me.chkBuuCuc.Name = "chkBuuCuc"
        Me.chkBuuCuc.Size = New System.Drawing.Size(147, 21)
        Me.chkBuuCuc.TabIndex = 98
        Me.chkBuuCuc.Text = "Theo bưu cục"
        '
        'dgTimKiemDen
        '
        Me.dgTimKiemDen.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTimKiemDen.DisplayLayout.AddNewBox.Prompt = " "
        Appearance61.BackColor = System.Drawing.Color.White
        Appearance61.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTimKiemDen.DisplayLayout.Appearance = Appearance61
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.Caption = "Mã E1"
        UltraGridColumn106.Width = 131
        UltraGridColumn107.Header.Caption = "Số COD1"
        UltraGridColumn107.Width = 77
        UltraGridColumn108.Header.Caption = "Số TT trả tiền"
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.Caption = "Số HĐ hàng hóa"
        UltraGridColumn109.Width = 118
        UltraGridColumn110.EditorControl = Me.txtDinhDangTien
        UltraGridColumn110.Header.Caption = "Giá trị"
        UltraGridColumn110.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn110.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn110.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn110.Width = 104
        UltraGridColumn111.EditorControl = Me.txtDinhDangTien
        UltraGridColumn111.Header.Caption = "COD"
        UltraGridColumn111.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn111.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn111.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn111.Width = 74
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn112.EditorControl = Me.txtDinhDangTien
        UltraGridColumn112.Header.Caption = "TCT"
        UltraGridColumn112.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn112.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn112.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn112.Width = 74
        UltraGridColumn113.EditorControl = Me.txtDinhDangTien
        UltraGridColumn113.Header.Caption = "Thu hộ"
        UltraGridColumn113.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn113.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn113.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn113.Width = 99
        UltraGridColumn114.EditorControl = Me.txtDinhDangTien
        UltraGridColumn114.Header.Caption = "Chuyển nhanh"
        UltraGridColumn114.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn114.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn114.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn114.Width = 110
        UltraGridColumn115.EditorControl = Me.txtDinhDangTien
        UltraGridColumn115.Header.Caption = "Chuyển tiếp"
        UltraGridColumn115.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn115.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn115.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn115.Width = 92
        UltraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn116.EditorControl = Me.txtDinhDangTien
        UltraGridColumn116.Header.Caption = "EMS"
        UltraGridColumn116.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn116.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn116.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn116.Width = 68
        UltraGridColumn117.Width = 49
        UltraGridColumn118.Width = 47
        UltraGridColumn119.Width = 52
        UltraGridColumn120.Header.Caption = "Chuyển tiếp"
        UltraGridColumn120.Width = 106
        UltraGridColumn121.Header.Caption = "Người gửi"
        UltraGridColumn122.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn123.Header.Caption = "Người nhận"
        UltraGridColumn124.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn125.Header.Caption = "Giấy tờ nhận"
        UltraGridColumn126.Header.Caption = "Mã bưu cục gốc"
        UltraGridColumn127.Header.Caption = "Bc chuyển tiếp"
        UltraGridColumn128.Header.Caption = "Đã nhận tiền"
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128})
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup25.Header.Appearance = Appearance62
        UltraGridGroup25.Key = "Thông tin COD1"
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup26.Header.Appearance = Appearance63
        UltraGridGroup26.Header.Caption = "Người gửi trả cước"
        UltraGridGroup26.Key = "NewGroup1"
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup27.Header.Appearance = Appearance64
        UltraGridGroup27.Key = "Hình thức chuyển phiếu"
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup28.Header.Appearance = Appearance65
        UltraGridGroup28.Header.VisiblePosition = 4
        UltraGridGroup28.Key = "Tiền cước"
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridGroup29.Header.Appearance = Appearance66
        UltraGridGroup29.Header.VisiblePosition = 5
        UltraGridGroup29.Key = "Thông tin gửi nhận"
        UltraGridGroup30.Header.VisiblePosition = 3
        UltraGridGroup30.Key = "Bưu cục chuyển tiếp"
        UltraGridBand8.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup25, UltraGridGroup26, UltraGridGroup27, UltraGridGroup28, UltraGridGroup29, UltraGridGroup30})
        UltraGridBand8.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgTimKiemDen.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.dgTimKiemDen.DisplayLayout.InterBandSpacing = 10
        Me.dgTimKiemDen.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Me.dgTimKiemDen.DisplayLayout.Override.CardAreaAppearance = Appearance67
        Me.dgTimKiemDen.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance68.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance68.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance68.ForeColor = System.Drawing.Color.Black
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance68.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTimKiemDen.DisplayLayout.Override.HeaderAppearance = Appearance68
        Me.dgTimKiemDen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance69.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTimKiemDen.DisplayLayout.Override.RowAppearance = Appearance69
        Appearance70.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance70.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTimKiemDen.DisplayLayout.Override.RowSelectorAppearance = Appearance70
        Me.dgTimKiemDen.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTimKiemDen.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance71.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance71.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance71.ForeColor = System.Drawing.Color.Black
        Me.dgTimKiemDen.DisplayLayout.Override.SelectedRowAppearance = Appearance71
        Me.dgTimKiemDen.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTimKiemDen.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTimKiemDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTimKiemDen.Location = New System.Drawing.Point(5, 125)
        Me.dgTimKiemDen.Name = "dgTimKiemDen"
        Me.dgTimKiemDen.Size = New System.Drawing.Size(633, 333)
        Me.dgTimKiemDen.TabIndex = 106
        Me.dgTimKiemDen.Text = "COD Tìm kiếm "
        '
        'lblTrenDen
        '
        Me.lblTrenDen.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.lblTrenDen.Controls.Add(Me.UltraTabPageControl1)
        Me.lblTrenDen.Controls.Add(Me.UltraTabPageControl2)
        Me.lblTrenDen.Controls.Add(Me.UltraTabPageControl3)
        Me.lblTrenDen.Controls.Add(Me.UltraTabPageControl4)
        Me.lblTrenDen.Location = New System.Drawing.Point(7, 7)
        Me.lblTrenDen.Name = "lblTrenDen"
        Me.lblTrenDen.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.lblTrenDen.Size = New System.Drawing.Size(646, 485)
        Me.lblTrenDen.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "COD Đi"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "COD Xác nhận đến"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "COD Đến"
        UltraTab4.TabPage = Me.UltraTabPageControl3
        UltraTab4.Text = "Tìm kiếm"
        Me.lblTrenDen.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(642, 459)
        '
        'FrmCOD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(659, 492)
        Me.Controls.Add(Me.lblTrenDen)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCOD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phát hàng thu tiền - COD"
        CType(Me.txtDinhDangTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ddMaBc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCODDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayGui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.dgCODDenTam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayDenTam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.dgCODDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayDen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.dgTimKiemDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaE1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTimKiemDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTrenDen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblTrenDen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myCODDi As New COD_Di(GConnectionString)
    Dim myCODDenTam As New COD_Den_Tam(GConnectionString)
    Dim myCODDen As New COD_Den(GConnectionString)
    Dim myDanhMuc As New Danh_Muc_BC(GConnectionString)
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myE1Di As New E1_Di(GConnectionString)
    Dim myE1DiChiTiet As New E1_Di_Chi_Tiet
    Dim myE1Den As New E1_Den(GConnectionString)
    Dim myE1DenChiTiet As New E1_Den_Chi_Tiet
    Dim i, max As Integer
    Dim IsNewRow As Boolean
    Dim myCuocTCT As New Tinh_Cuoc(GConnectionString)
    Dim ThuHo, NguoiGuiTra As Integer
    Dim myCODDiChiTiet As New COD_Di_Chi_Tiet
    Dim myCODDenTamChiTiet As New COD_Den_Tam_Chi_Tiet
    Dim myCODDenChiTiet As New COD_Den_Chi_Tiet
    Private Sub FrmCOD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
        ddMaBc.DataBind()
        DataInitCODDi()
        DataInitCODDenTam()
        Tao_Bang_Id_Phan_Loai()
        'dgCODDi.Rows(dgCODDi.Rows.Count - 1).Cells("Ma_COD1").Value = myCODDi.Lay_Max_Ma_COD1
        'dgCODDi.Rows(dgCODDi.Rows.Count - 1).Cells("Ma_COD1").Activate()
        'BindingDataNull()
        'MessageBox.Show(dgCODDi.Rows(0).Cells("Ma_E1").Text)
    End Sub
#Region "COD_Di"
    Private Sub DataInitCODDi()
        dgCODDi.DataSource = myCODDi.Danh_Sach_Theo_Ngay_Gui(Ham_Dung_Chung.ConvertDateToInt(dtpNgayGui.Value))
        dgCODDi.DataBind()
        AddNewRowCODDi(dgCODDi)
    End Sub
    Private Sub chkGuiNhan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuiNhan.CheckedChanged

        dgCODDi.DisplayLayout.Bands(0).Groups("Thông tin gửi nhận").Hidden = Not chkGuiNhan.Checked

    End Sub

    Private Sub dgCODDi_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCODDi.InitializeLayout
        'Dim cultureVN As CultureInfo = CultureInfo.CreateSpecificCulture("vi-VN")
        'e.Layout.Bands(0).Columns("Gia_Tri").Format = "d"
        'e.Layout.Bands(0).Columns("Gia_Tri").FormatInfo = cultureVN

        dgCODDi.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCODDi.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        dgCODDi.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgCODDi.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Tra").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Tra").ValueList = ddMaBc
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").Style = ColumnStyle.DropDown
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").ValueList = ddMaBc
        End With
    End Sub
    Private Sub DeleteRowCODDi()
        If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_E1").Text.Length <> 0 Then
            If MessageBox.Show("Bạn có thực sự muốn COD1 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myCODDi.Xoa(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Id_E1").Text)
                dgCODDi.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgCODDi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCODDi.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                myCell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                DeleteRowCODDi()
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub
    Private Sub BindingDataNullCODDi()
        'max = 0
        'For i = 0 To dgCODDi.Rows.Count - 1
        '    If Convert.ToInt32(dgCODDi.Rows(i).Cells("Ma_COD1").Text) > max Then
        '        max = Convert.ToInt32(dgCODDi.Rows(i).Cells("Ma_COD1").Text)
        '    End If
        'Next
        For i = 0 To dgCODDi.Rows.Count - 1
            If dgCODDi.Rows(i).Cells("Ma_E1").Text = "" Then
                dgCODDi.Rows(i).Cells("Ma_COD1").Value = myCODDi.Lay_Max_Ma_COD1
                dgCODDi.Rows(i).Cells("So_TT").Value = 0
                dgCODDi.Rows(i).Cells("So_Hoa_Don").Value = ""
                dgCODDi.Rows(i).Cells("Gia_Tri").Value = 0
                dgCODDi.Rows(i).Cells("Cuoc_COD").Value = 0
                dgCODDi.Rows(i).Cells("Cuoc_TCT").Value = 0
                dgCODDi.Rows(i).Cells("Cuoc_Thu_Ho").Value = 0
                dgCODDi.Rows(i).Cells("Cuoc_Chuyen_Nhanh").Value = 0
                dgCODDi.Rows(i).Cells("Cuoc_Chuyen_Tiep").Value = 0
                dgCODDi.Rows(i).Cells("Cuoc_EMS").Value = 0
                dgCODDi.Rows(i).Cells("EMS").Value = True
                dgCODDi.Rows(i).Cells("COD").Value = True
                dgCODDi.Rows(i).Cells("Nhanh").Value = False
                dgCODDi.Rows(i).Cells("Chuyen_Tiep").Value = False
                dgCODDi.Rows(i).Cells("Giay_To_Kem_Theo").Value = ""
                dgCODDi.Rows(i).Cells("Ma_Bc_Tra").Value = 0
                dgCODDi.Rows(i).Cells("Ma_Bc_Chuyen_Tiep").Value = 0
                dgCODDi.Rows(i).Cells("Nguoi_Gui_Nhan_Tien").Value = False

            End If
        Next
    End Sub
    Private Sub AddNewRowCODDi(ByVal sender As Object)
        IsNewRow = True
        For i = 0 To dgCODDi.Rows.Count - 1
            If dgCODDi.Rows(i).Cells("Ma_E1").Text = "" Then
                IsNewRow = False
            End If
        Next
        myGridKeyDown = sender
        If IsNewRow Then
            myGridKeyDown.Rows.Band.AddNew()
        End If
        BindingDataNullCODDi()
        'If myGridKeyDown.Rows.Count > 0 Then
        '    If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).HasNextSibling = False Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If
        'If Not myGridKeyDown.ActiveCell Is Nothing Then
        '    If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If

    End Sub

    Private Sub Tinh_Cuoc_COD_Di()
        myE1DiChiTiet = myE1Di.Lay_Theo_Ma_E1(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_E1").Text, Ham_Dung_Chung.ConvertDateToInt(Convert.ToDateTime(dtpNgayGui.Value).AddDays(-GSo_Ngay_E1_Duoc_Trung)))
        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_TCT").Value = myCuocTCT.Tinh_Cuoc_TCT(Ham_Dung_Chung.ConvertDateToInt(dtpNgayGui.Value), Convert.ToInt32(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Gia_Tri").Value)) * (1 + GVat)
        If Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Nhanh").Value) Then
            dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = myCuocTCT.Tinh_Cuoc(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_E1").Text, "VN", Convert.ToInt32(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_Bc_Tra").Text), 1, myE1DiChiTiet.Phan_Loai, myE1DiChiTiet.PostCode, myE1DiChiTiet.Ngay_Phat_Hanh, myE1DiChiTiet.Loai_Hang_Hoa).Cuoc_Chinh
        Else
            dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = 0
        End If

        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_COD").Value = IIf(0.0075 * Convert.ToInt32(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Gia_Tri").Value) > 7000, 0.0075 * Convert.ToInt32(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Gia_Tri").Value), 7000) * (1 + GVat)
        ThuHo = 0
        If Not Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("EMS").Value) Then
            ThuHo = myE1DiChiTiet.Cuoc_Chinh
        End If
        If Not Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("COD").Value) Then
            ThuHo = ThuHo + dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_COD").Value + dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_TCT").Value
        End If
        NguoiGuiTra = 0
        If Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("EMS").Value) Then
            NguoiGuiTra = myE1DiChiTiet.Cuoc_Chinh
        End If
        If Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("COD").Value) Then
            NguoiGuiTra = NguoiGuiTra + dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_COD").Value + dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_TCT").Value
        End If
        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value = ThuHo
        lblHienThiTrai.Text = "EMS: " & dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_EMS").Value & vbNewLine & "COD: " & dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_COD").Value & vbNewLine & "Chuyển tiếp: " & dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Chuyen_Tiep").Value
        lblHienThiPhai.Text = "TCT: " & dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_TCT").Value & vbNewLine & "Chuyển nhanh: " & dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value & vbNewLine & "Thu hộ: " & dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value
        lblDuoi.Text = "Người gửi phải trả: " + NguoiGuiTra.ToString
    End Sub
    Private Sub dgCODDi_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCODDi.AfterExitEditMode
        Select Case dgCODDi.ActiveCell.Column.Key
            Case "Ma_COD1"
                If dgCODDi.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số COD1 không được để trống !!!", "Thông báo")
                    myCell = dgCODDi.ActiveCell
                    Exit Sub
                End If
            Case "Ma_E1"
                If dgCODDi.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số E1 không được để trống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'myCell = dgCODDi.ActiveCell
                    Exit Sub
                Else
                    'Kiem tra xem co Ma_E1 nay hay khong
                    myE1DiChiTiet = myE1Di.Lay_Theo_Ma_E1(dgCODDi.ActiveCell.Text, Ham_Dung_Chung.ConvertDateToInt(Convert.ToDateTime(dtpNgayGui.Value).AddDays(-GSo_Ngay_E1_Duoc_Trung)))
                    If myE1DiChiTiet.Id_E1 = "" Then
                        CMessageBox.Show("Mã E1 không tồn tại !!!")
                        myCell = dgCODDi.ActiveCell
                        Exit Sub
                    Else
                        myCODDiChiTiet = myCODDi.Lay(myE1DiChiTiet.Id_E1)
                        If myCODDiChiTiet.Ma_E1 <> "" And myCODDiChiTiet.Ngay_Gui <> Ham_Dung_Chung.ConvertDateToInt(dtpNgayGui.Value) Then
                            If CMessageBox.Show("Mã E1 " & dgCODDi.ActiveCell.Text & " đã tồn tại ở ngày " & Ham_Dung_Chung.ConvertIntToDate(myCODDiChiTiet.Ngay_Gui).ToString("dd/MM/yyyy") & " !!!" & vbNewLine & "Bạn có muốn hiệu chỉnh lại COD1 này ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_COD1").Value = myCODDiChiTiet.Ma_COD1
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("So_TT").Value = myCODDiChiTiet.So_TT
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("So_Hoa_Don").Value = myCODDiChiTiet.So_Hoa_Don
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Gia_Tri").Value = myCODDiChiTiet.Gia_Tri
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_COD").Value = myCODDiChiTiet.Cuoc_COD
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_TCT").Value = myCODDiChiTiet.Cuoc_TCT
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value = myCODDiChiTiet.Cuoc_Thu_Ho
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = myCODDiChiTiet.Cuoc_Chuyen_Nhanh
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_Chuyen_Tiep").Value = myCODDiChiTiet.Cuoc_Chuyen_Tiep
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_EMS").Value = myCODDiChiTiet.Cuoc_EMS
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("EMS").Value = myCODDiChiTiet.EMS
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("COD").Value = myCODDiChiTiet.COD
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Nhanh").Value = myCODDiChiTiet.Nhanh
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Chuyen_Tiep").Value = myCODDiChiTiet.Chuyen_Tiep
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Giay_To_Kem_Theo").Value = myCODDiChiTiet.Giay_To_Kem_Theo
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = myCODDiChiTiet.Ma_Bc_Tra
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_Bc_Chuyen_Tiep").Value = myCODDiChiTiet.Ma_Bc_Chuyen_Tiep
                                dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Nguoi_Gui_Nhan_Tien").Value = myCODDiChiTiet.Nguoi_Gui_Nhan_Tien
                            Else
                                myCell = dgCODDi.ActiveCell
                                Exit Sub
                            End If
                        End If
                        'Them moi ngay dong do
                        BindingDataNullCODDi()
                        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Id_E1").Value = myE1DiChiTiet.Id_E1
                        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Cuoc_EMS").Value = myE1DiChiTiet.Cuoc_Chinh
                        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = myE1DiChiTiet.Ma_Bc_Tra
                        Tinh_Cuoc_COD_Di()
                        If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
                            'Cap nhat, them moi nguoi dung
                            With dgCODDi.Rows(dgCODDi.ActiveRow.Index)
                                myCODDi.Cap_Nhat_Them(.Cells("Id_E1").Text, .Cells("Ma_E1").Text, .Cells("Ma_COD1").Text, Gid_Nguoi_Dung, Convert.ToInt32(.Cells("So_TT").Text), .Cells("So_Hoa_Don").Text, Convert.ToInt32(.Cells("Gia_Tri").Value), Convert.ToInt32(.Cells("Cuoc_COD").Value), Convert.ToInt32(.Cells("Cuoc_TCT").Value), Convert.ToInt32(.Cells("Cuoc_Thu_Ho").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Nhanh").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Tiep").Value), Convert.ToInt32(.Cells("Cuoc_EMS").Value), Convert.ToBoolean(.Cells("EMS").Value), Convert.ToBoolean(.Cells("COD").Value), Convert.ToBoolean(.Cells("Nhanh").Value), Convert.ToBoolean(.Cells("Chuyen_Tiep").Value), .Cells("Giay_To_Kem_Theo").Text, Ham_Dung_Chung.ConvertDateToInt(dtpNgayGui.Value), Ham_Dung_Chung.ConvertTimeToInt(dtpNgayGui.Value), 20991231, 0, GBuu_Cuc_Khai_Thac, Convert.ToInt32(.Cells("Ma_Bc_Tra").Text), Convert.ToInt32(.Cells("Ma_Bc_Chuyen_Tiep").Text), Convert.ToBoolean(.Cells("Nguoi_Gui_Nhan_Tien").Value), False)
                            End With
                            AddNewRowCODDi(dgCODDi)
                            'BindingDataNull()
                        End If

                        'AddNewRow(dgCODDi)
                        'BindingDataNull()
                    End If

                    If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("EMS").Value Is System.DBNull.Value Then
                        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("EMS").Value = 1
                    End If
                    If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("COD").Value Is System.DBNull.Value Then
                        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("COD").Value = 1
                    End If
                    If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Nhanh").Value Is System.DBNull.Value Then
                        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Nhanh").Value = 0
                    End If
                    If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Chuyen_Tiep").Value Is System.DBNull.Value Then
                        dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Chuyen_Tiep").Value = 0
                    End If
                End If

            Case "Chuyen_Tiep"
                If Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Chuyen_Tiep").Value) Then
                    dgCODDi.DisplayLayout.Bands(0).Groups("Tiền cước").Hidden = Not Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
                End If
                dgCODDi.DisplayLayout.Bands(0).Groups("Bưu cục chuyển tiếp").Hidden = Not Convert.ToBoolean(dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
                Tinh_Cuoc_COD_Di()
            Case Else
                Tinh_Cuoc_COD_Di()
        End Select
    End Sub

    Private Sub dgCODDi_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCODDi.AfterRowUpdate
        If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
            Exit Sub
        End If
        If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_COD1").Text = "" Then
            Exit Sub
        End If
        If dgCODDi.Rows(dgCODDi.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            'Cap nhat, them moi nguoi dung
            With e.Row
                myCODDi.Cap_Nhat_Them(.Cells("Id_E1").Text, .Cells("Ma_E1").Text, .Cells("Ma_COD1").Text, Gid_Nguoi_Dung, Convert.ToInt32(.Cells("So_TT").Text), .Cells("So_Hoa_Don").Text, Convert.ToInt32(e.Row.Cells("Gia_Tri").Value), Convert.ToInt32(.Cells("Cuoc_COD").Value), Convert.ToInt32(.Cells("Cuoc_TCT").Value), Convert.ToInt32(.Cells("Cuoc_Thu_Ho").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Nhanh").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Tiep").Value), Convert.ToInt32(.Cells("Cuoc_EMS").Value), Convert.ToBoolean(.Cells("EMS").Value), Convert.ToBoolean(.Cells("COD").Value), Convert.ToBoolean(.Cells("Nhanh").Value), Convert.ToBoolean(.Cells("Chuyen_Tiep").Value), .Cells("Giay_To_Kem_Theo").Text, Ham_Dung_Chung.ConvertDateToInt(dtpNgayGui.Value), Ham_Dung_Chung.ConvertTimeToInt(dtpNgayGui.Value), 20991231, 0, GBuu_Cuc_Khai_Thac, Convert.ToInt32(.Cells("Ma_Bc_Tra").Text), Convert.ToInt32(.Cells("Ma_Bc_Chuyen_Tiep").Text), Convert.ToBoolean(.Cells("Nguoi_Gui_Nhan_Tien").Value), False)
            End With
            AddNewRowCODDi(dgCODDi)
            'BindingDataNull()
        End If
    End Sub

    Private Sub dgCODDi_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgCODDi.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Cancel = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            myCell = Nothing
        End If
    End Sub

    Private Sub chkCuoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCuoc.CheckedChanged
        dgCODDi.DisplayLayout.Bands(0).Groups("Tiền cước").Hidden = Not chkCuoc.Checked
    End Sub
    Private Sub dtpNgayGui_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNgayGui.ValueChanged
        DataInitCODDi()
    End Sub
    Private Sub dgCODDi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCODDi.LostFocus
        myCell = Nothing
    End Sub
#End Region
#Region "COD_Den_Tam"
    Private Sub DataInitCODDenTam()
        dgCODDenTam.DataSource = myCODDenTam.Danh_Sach_Theo_Ngay_Nhan(Ham_Dung_Chung.ConvertDateToInt(dtpNgayDenTam.Value))
        dgCODDenTam.DataBind()
        AddNewRowCODDenTam(dgCODDenTam)
    End Sub
    Private Sub chkGuiNhanTam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuiNhanTam.CheckedChanged

        dgCODDenTam.DisplayLayout.Bands(0).Groups("Thông tin gửi nhận").Hidden = Not chkGuiNhanTam.Checked

    End Sub

    Private Sub dgCODDenTam_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCODDenTam.InitializeLayout
        'Dim cultureVN As CultureInfo = CultureInfo.CreateSpecificCulture("vi-VN")
        'e.Layout.Bands(0).Columns("Gia_Tri").Format = "d"
        'e.Layout.Bands(0).Columns("Gia_Tri").FormatInfo = cultureVN

        dgCODDenTam.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCODDenTam.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCODDenTam.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Goc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Goc").ValueList = ddMaBc
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").Style = ColumnStyle.DropDown
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").ValueList = ddMaBc
        End With
    End Sub
    Private Sub DeleteRowCODDenTam()
        If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_E1").Text.Length <> 0 Then
            If MessageBox.Show("Bạn có thực sự muốn COD1 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myCODDenTam.Xoa(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Id_E1").Text)
                dgCODDenTam.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgCODDenTam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCODDenTam.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                myCell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                DeleteRowCODDenTam()
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub
    Private Sub BindingDataNullCODDenTam()
        'max = 0
        'For i = 0 To dgCODDenTam.Rows.Count - 1
        '    If Convert.ToInt32(dgCODDenTam.Rows(i).Cells("Ma_COD1").Text) > max Then
        '        max = Convert.ToInt32(dgCODDenTam.Rows(i).Cells("Ma_COD1").Text)
        '    End If
        'Next
        For i = 0 To dgCODDenTam.Rows.Count - 1
            If dgCODDenTam.Rows(i).Cells("Ma_E1").Text = "" Then
                dgCODDenTam.Rows(i).Cells("Ma_COD1").Value = ""
                dgCODDenTam.Rows(i).Cells("So_TT").Value = 0
                dgCODDenTam.Rows(i).Cells("So_Hoa_Don").Value = ""
                dgCODDenTam.Rows(i).Cells("Gia_Tri").Value = 0
                dgCODDenTam.Rows(i).Cells("Cuoc_COD").Value = 0
                dgCODDenTam.Rows(i).Cells("Cuoc_TCT").Value = 0
                dgCODDenTam.Rows(i).Cells("Cuoc_Thu_Ho").Value = 0
                dgCODDenTam.Rows(i).Cells("Cuoc_Chuyen_Nhanh").Value = 0
                dgCODDenTam.Rows(i).Cells("Cuoc_Chuyen_Tiep").Value = 0
                dgCODDenTam.Rows(i).Cells("Cuoc_EMS").Value = 0
                dgCODDenTam.Rows(i).Cells("EMS").Value = True
                dgCODDenTam.Rows(i).Cells("COD").Value = True
                dgCODDenTam.Rows(i).Cells("Nhanh").Value = False
                dgCODDenTam.Rows(i).Cells("Chuyen_Tiep").Value = False
                dgCODDenTam.Rows(i).Cells("Giay_To_Kem_Theo").Value = ""
                dgCODDenTam.Rows(i).Cells("Ma_Bc_Goc").Value = 0
                dgCODDenTam.Rows(i).Cells("Ma_Bc_Chuyen_Tiep").Value = 0
                dgCODDenTam.Rows(i).Cells("Nguoi_Gui_Nhan_Tien").Value = False

            End If
        Next
    End Sub
    Private Sub AddNewRowCODDenTam(ByVal sender As Object)
        IsNewRow = True
        For i = 0 To dgCODDenTam.Rows.Count - 1
            If dgCODDenTam.Rows(i).Cells("Ma_E1").Text = "" Then
                IsNewRow = False
            End If
        Next
        myGridKeyDown = sender
        If IsNewRow Then
            myGridKeyDown.Rows.Band.AddNew()
        End If
        BindingDataNullCODDenTam()
        'If myGridKeyDown.Rows.Count > 0 Then
        '    If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).HasNextSibling = False Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If
        'If Not myGridKeyDown.ActiveCell Is Nothing Then
        '    If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If

    End Sub

    Private Sub Tinh_Cuoc_COD_Den_Tam()
        myE1DenChiTiet = myE1Den.Lay_Theo_Ma_E1(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_E1").Text, Ham_Dung_Chung.ConvertDateToInt(Convert.ToDateTime(dtpNgayDenTam.Value).AddDays(-GSo_Ngay_E1_Duoc_Trung)))
        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_TCT").Value = myCuocTCT.Tinh_Cuoc_TCT(Ham_Dung_Chung.ConvertDateToInt(dtpNgayDenTam.Value), Convert.ToInt32(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Gia_Tri").Value)) * (1 + GVat)
        If Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Nhanh").Value) Then
            dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = myCuocTCT.Tinh_Cuoc(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_E1").Text, "VN", GBuu_Cuc_Khai_Thac, 1, myE1DenChiTiet.Phan_Loai, myE1DenChiTiet.PostCode, myE1DenChiTiet.Ngay_Phat_Hanh, myE1DenChiTiet.Loai_Hang_Hoa).Cuoc_Chinh
        Else
            dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = 0
        End If

        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_COD").Value = IIf(0.0075 * Convert.ToInt32(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Gia_Tri").Value) > 7000, 0.0075 * Convert.ToInt32(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Gia_Tri").Value), 7000) * (1 + GVat)
        ThuHo = 0
        If Not Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("EMS").Value) Then
            ThuHo = myE1DenChiTiet.Cuoc_Chinh
        End If
        If Not Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("COD").Value) Then
            ThuHo = ThuHo + dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_COD").Value + dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_TCT").Value
        End If
        NguoiGuiTra = 0
        If Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("EMS").Value) Then
            NguoiGuiTra = myE1DenChiTiet.Cuoc_Chinh
        End If
        If Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("COD").Value) Then
            NguoiGuiTra = NguoiGuiTra + dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_COD").Value + dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_TCT").Value
        End If
        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value = ThuHo
        lblTraiTam.Text = "EMS: " & dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_EMS").Value & vbNewLine & "COD: " & dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_COD").Value & vbNewLine & "Chuyển tiếp: " & dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Chuyen_Tiep").Value
        lblPhaiTam.Text = "TCT: " & dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_TCT").Value & vbNewLine & "Chuyển nhanh: " & dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value & vbNewLine & "Thu hộ: " & dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value
        lblDuoiTam.Text = "Người nhận phải trả: " + ThuHo.ToString
    End Sub
    Private Sub dgCODDenTam_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCODDenTam.AfterExitEditMode
        Select Case dgCODDenTam.ActiveCell.Column.Key
            Case "Ma_COD1"
                If dgCODDenTam.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số COD1 không được để trống !!!", "Thông báo")
                    myCell = dgCODDenTam.ActiveCell
                    Exit Sub
                End If
            Case "Ma_E1"
                If dgCODDenTam.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số E1 không được để trống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'myCell = dgCODDenTam.ActiveCell
                    Exit Sub
                Else
                    'Kiem tra xem co Ma_E1 nay hay khong
                    myE1DenChiTiet = myE1Den.Lay_Theo_Ma_E1(dgCODDenTam.ActiveCell.Text, Ham_Dung_Chung.ConvertDateToInt(Convert.ToDateTime(dtpNgayDenTam.Value).AddDays(-GSo_Ngay_E1_Duoc_Trung)))
                    If myE1DenChiTiet.Id_E1 = "" Then
                        CMessageBox.Show("Mã E1 không tồn tại !!!")
                        myCell = dgCODDenTam.ActiveCell
                        Exit Sub
                    Else
                        myCODDenTamChiTiet = myCODDenTam.Lay(myE1DenChiTiet.Id_E1)
                        If myCODDenTamChiTiet.Ma_E1 <> "" And myCODDenTamChiTiet.Ngay_Nhan <> Ham_Dung_Chung.ConvertDateToInt(dtpNgayDenTam.Value) Then
                            If CMessageBox.Show("Mã E1 " & dgCODDenTam.ActiveCell.Text & " đã tồn tại ở ngày " & Ham_Dung_Chung.ConvertIntToDate(myCODDenTamChiTiet.Ngay_Nhan).ToString("dd/MM/yyyy") & " !!!" & vbNewLine & "Bạn có muốn hiệu chỉnh lại COD1 này ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_COD1").Value = myCODDenTamChiTiet.Ma_COD1
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("So_TT").Value = myCODDenTamChiTiet.So_TT
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("So_Hoa_Don").Value = myCODDenTamChiTiet.So_Hoa_Don
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Gia_Tri").Value = myCODDenTamChiTiet.Gia_Tri
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_COD").Value = myCODDenTamChiTiet.Cuoc_COD
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_TCT").Value = myCODDenTamChiTiet.Cuoc_TCT
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value = myCODDenTamChiTiet.Cuoc_Thu_Ho
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = myCODDenTamChiTiet.Cuoc_Chuyen_Nhanh
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_Chuyen_Tiep").Value = myCODDenTamChiTiet.Cuoc_Chuyen_Tiep
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_EMS").Value = myCODDenTamChiTiet.Cuoc_EMS
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("EMS").Value = myCODDenTamChiTiet.EMS
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("COD").Value = myCODDenTamChiTiet.COD
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Nhanh").Value = myCODDenTamChiTiet.Nhanh
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Chuyen_Tiep").Value = myCODDenTamChiTiet.Chuyen_Tiep
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Giay_To_Kem_Theo").Value = myCODDenTamChiTiet.Giay_To_Kem_Theo
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = myCODDenTamChiTiet.Ma_Bc_Goc
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_Bc_Chuyen_Tiep").Value = myCODDenTamChiTiet.Ma_Bc_Chuyen_Tiep
                                dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Nguoi_Gui_Nhan_Tien").Value = myCODDenTamChiTiet.Nguoi_Gui_Nhan_Tien
                            Else
                                myCell = dgCODDenTam.ActiveCell
                                Exit Sub
                            End If
                        End If
                        'Them moi ngay dong do
                        BindingDataNullCODDenTam()
                        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Id_E1").Value = myE1DenChiTiet.Id_E1
                        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Cuoc_EMS").Value = myE1DenChiTiet.Cuoc_Chinh
                        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = myE1DenChiTiet.Ma_Bc_Goc
                        Tinh_Cuoc_COD_Den_Tam()
                        If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
                            'Cap nhat, them moi nguoi dung
                            With dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index)
                                myCODDenTam.Cap_Nhat_Them(.Cells("Id_E1").Text, .Cells("Ma_E1").Text, .Cells("Ma_COD1").Text, Gid_Nguoi_Dung, Convert.ToInt32(.Cells("So_TT").Text), .Cells("So_Hoa_Don").Text, Convert.ToInt32(.Cells("Gia_Tri").Value), Convert.ToInt32(.Cells("Cuoc_COD").Value), Convert.ToInt32(.Cells("Cuoc_TCT").Value), Convert.ToInt32(.Cells("Cuoc_Thu_Ho").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Nhanh").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Tiep").Value), Convert.ToInt32(.Cells("Cuoc_EMS").Value), Convert.ToBoolean(.Cells("EMS").Value), Convert.ToBoolean(.Cells("COD").Value), Convert.ToBoolean(.Cells("Nhanh").Value), Convert.ToBoolean(.Cells("Chuyen_Tiep").Value), .Cells("Giay_To_Kem_Theo").Text, myE1DenChiTiet.Ngay_Phat_Hanh, myE1DenChiTiet.Gio_Phat_Hanh, Ham_Dung_Chung.ConvertDateToInt(dtpNgayDenTam.Value), Ham_Dung_Chung.ConvertTimeToInt(dtpNgayDenTam.Value), Convert.ToInt32(.Cells("Ma_Bc_Goc").Text), GBuu_Cuc_Khai_Thac, Convert.ToInt32(.Cells("Ma_Bc_Chuyen_Tiep").Text), Convert.ToBoolean(.Cells("Nguoi_Gui_Nhan_Tien").Value), False)
                            End With
                            AddNewRowCODDenTam(dgCODDenTam)
                            'BindingDataNull()
                        End If

                        'AddNewRow(dgCODDenTam)
                        'BindingDataNull()
                    End If

                    If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("EMS").Value Is System.DBNull.Value Then
                        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("EMS").Value = 1
                    End If
                    If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("COD").Value Is System.DBNull.Value Then
                        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("COD").Value = 1
                    End If
                    If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Nhanh").Value Is System.DBNull.Value Then
                        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Nhanh").Value = 0
                    End If
                    If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Chuyen_Tiep").Value Is System.DBNull.Value Then
                        dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Chuyen_Tiep").Value = 0
                    End If
                End If

            Case "Chuyen_Tiep"
                If Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Chuyen_Tiep").Value) Then
                    dgCODDenTam.DisplayLayout.Bands(0).Groups("Tiền cước").Hidden = Not Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
                End If
                dgCODDenTam.DisplayLayout.Bands(0).Groups("Bưu cục chuyển tiếp").Hidden = Not Convert.ToBoolean(dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
                Tinh_Cuoc_COD_Den_Tam()
            Case Else
                Tinh_Cuoc_COD_Den_Tam()
        End Select
    End Sub

    Private Sub dgCODDen_Tam_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCODDenTam.AfterRowUpdate
        If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
            Exit Sub
        End If
        If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_COD1").Text = "" Then
            Exit Sub
        End If
        If dgCODDenTam.Rows(dgCODDenTam.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            'Cap nhat, them moi nguoi dung
            With e.Row
                myE1DenChiTiet = myE1Den.Lay(.Cells("Id_E1").Text)
                myCODDenTam.Cap_Nhat_Them(.Cells("Id_E1").Text, .Cells("Ma_E1").Text, .Cells("Ma_COD1").Text, Gid_Nguoi_Dung, Convert.ToInt32(.Cells("So_TT").Text), .Cells("So_Hoa_Don").Text, Convert.ToInt32(e.Row.Cells("Gia_Tri").Value), Convert.ToInt32(.Cells("Cuoc_COD").Value), Convert.ToInt32(.Cells("Cuoc_TCT").Value), Convert.ToInt32(.Cells("Cuoc_Thu_Ho").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Nhanh").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Tiep").Value), Convert.ToInt32(.Cells("Cuoc_EMS").Value), Convert.ToBoolean(.Cells("EMS").Value), Convert.ToBoolean(.Cells("COD").Value), Convert.ToBoolean(.Cells("Nhanh").Value), Convert.ToBoolean(.Cells("Chuyen_Tiep").Value), .Cells("Giay_To_Kem_Theo").Text, myE1DenChiTiet.Ngay_Phat_Hanh, myE1DenChiTiet.Gio_Phat_Hanh, Ham_Dung_Chung.ConvertDateToInt(dtpNgayDenTam.Value), Ham_Dung_Chung.ConvertTimeToInt(dtpNgayDenTam.Value), myE1DenChiTiet.Ma_Bc_Goc, GBuu_Cuc_Khai_Thac, Convert.ToInt32(.Cells("Ma_Bc_Chuyen_Tiep").Text), Convert.ToBoolean(.Cells("Nguoi_Gui_Nhan_Tien").Value), False)
            End With
            AddNewRowCODDenTam(dgCODDenTam)
            'BindingDataNull()
        End If
    End Sub

    Private Sub dgCODDenTam_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgCODDenTam.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Cancel = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            myCell = Nothing
        End If
    End Sub

    Private Sub chkCuocTam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCuocTam.CheckedChanged
        dgCODDenTam.DisplayLayout.Bands(0).Groups("Tiền cước").Hidden = Not chkCuocTam.Checked
    End Sub
    Private Sub dtpNgayDenTam_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNgayDenTam.ValueChanged
        DataInitCODDenTam()
    End Sub
    Private Sub dgCODDenTam_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCODDenTam.LostFocus
        myCell = Nothing
    End Sub
    Private Sub btnXacNhanDen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXacNhanDen.Click
        If CMessageBox.Show("Bạn có muốn xác nhận đến các COD1 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCODDenTam.Xac_Nhan_Theo_Ngay(Ham_Dung_Chung.ConvertDateToInt(dtpNgayDenTam.Value))
            CMessageBox.Show("Đã xác nhận thành công !!!", "Thông báo")
            DataInitCODDenTam()
        End If

        
    End Sub
#End Region
#Region "COD_Den"
    Private Sub DataInitCODDen()
        dgCODDen.DataSource = myCODDen.Danh_Sach_Theo_Ngay_Nhan(Ham_Dung_Chung.ConvertDateToInt(dtpNgayDen.Value))
        dgCODDen.DataBind()
        AddNewRowCODDen(dgCODDen)
    End Sub
    Private Sub chkGuiNhanDen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuiNhanTam.CheckedChanged

        dgCODDen.DisplayLayout.Bands(0).Groups("Thông tin gửi nhận").Hidden = Not chkGuiNhanTam.Checked

    End Sub

    Private Sub dgCODDen_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCODDen.InitializeLayout
        'Dim cultureVN As CultureInfo = CultureInfo.CreateSpecificCulture("vi-VN")
        'e.Layout.Bands(0).Columns("Gia_Tri").Format = "d"
        'e.Layout.Bands(0).Columns("Gia_Tri").FormatInfo = cultureVN

        dgCODDen.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCODDen.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCODDen.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Goc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Goc").ValueList = ddMaBc
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").Style = ColumnStyle.DropDown
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").ValueList = ddMaBc
        End With
    End Sub
    Private Sub DeleteRowCODDen()
        If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_E1").Text.Length <> 0 Then
            If MessageBox.Show("Bạn có thực sự muốn COD1 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myCODDen.Xoa(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Id_E1").Text)
                dgCODDen.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgCODDen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCODDen.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                myCell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                DeleteRowCODDen()
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub
    Private Sub BindingDataNullCODDen()
        'max = 0
        'For i = 0 To dgCODDen.Rows.Count - 1
        '    If Convert.ToInt32(dgCODDen.Rows(i).Cells("Ma_COD1").Text) > max Then
        '        max = Convert.ToInt32(dgCODDen.Rows(i).Cells("Ma_COD1").Text)
        '    End If
        'Next
        For i = 0 To dgCODDen.Rows.Count - 1
            If dgCODDen.Rows(i).Cells("Ma_E1").Text = "" Then
                dgCODDen.Rows(i).Cells("Ma_COD1").Value = ""
                dgCODDen.Rows(i).Cells("So_TT").Value = 0
                dgCODDen.Rows(i).Cells("So_Hoa_Don").Value = ""
                dgCODDen.Rows(i).Cells("Gia_Tri").Value = 0
                dgCODDen.Rows(i).Cells("Cuoc_COD").Value = 0
                dgCODDen.Rows(i).Cells("Cuoc_TCT").Value = 0
                dgCODDen.Rows(i).Cells("Cuoc_Thu_Ho").Value = 0
                dgCODDen.Rows(i).Cells("Cuoc_Chuyen_Nhanh").Value = 0
                dgCODDen.Rows(i).Cells("Cuoc_Chuyen_Tiep").Value = 0
                dgCODDen.Rows(i).Cells("Cuoc_EMS").Value = 0
                dgCODDen.Rows(i).Cells("EMS").Value = True
                dgCODDen.Rows(i).Cells("COD").Value = True
                dgCODDen.Rows(i).Cells("Nhanh").Value = False
                dgCODDen.Rows(i).Cells("Chuyen_Tiep").Value = False
                dgCODDen.Rows(i).Cells("Giay_To_Kem_Theo").Value = ""
                dgCODDen.Rows(i).Cells("Ma_Bc_Goc").Value = 0
                dgCODDen.Rows(i).Cells("Ma_Bc_Chuyen_Tiep").Value = 0
                dgCODDen.Rows(i).Cells("Nguoi_Gui_Nhan_Tien").Value = False

            End If
        Next
    End Sub
    Private Sub AddNewRowCODDen(ByVal sender As Object)
        IsNewRow = True
        For i = 0 To dgCODDen.Rows.Count - 1
            If dgCODDen.Rows(i).Cells("Ma_E1").Text = "" Then
                IsNewRow = False
            End If
        Next
        myGridKeyDown = sender
        If IsNewRow Then
            myGridKeyDown.Rows.Band.AddNew()
        End If
        BindingDataNullCODDen()
        'If myGridKeyDown.Rows.Count > 0 Then
        '    If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).HasNextSibling = False Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If
        'If Not myGridKeyDown.ActiveCell Is Nothing Then
        '    If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If

    End Sub

    Private Sub Tinh_Cuoc_COD_Den()
        myE1DenChiTiet = myE1Den.Lay_Theo_Ma_E1(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_E1").Text, Ham_Dung_Chung.ConvertDateToInt(Convert.ToDateTime(dtpNgayDen.Value).AddDays(-GSo_Ngay_E1_Duoc_Trung)))
        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_TCT").Value = myCuocTCT.Tinh_Cuoc_TCT(Ham_Dung_Chung.ConvertDateToInt(dtpNgayDen.Value), Convert.ToInt32(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Gia_Tri").Value)) * (1 + GVat)
        If Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Nhanh").Value) Then
            dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = myCuocTCT.Tinh_Cuoc(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_E1").Text, "VN", GBuu_Cuc_Khai_Thac, 1, myE1DenChiTiet.Phan_Loai, myE1DenChiTiet.PostCode, myE1DenChiTiet.Ngay_Phat_Hanh, myE1DenChiTiet.Loai_Hang_Hoa).Cuoc_Chinh
        Else
            dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = 0
        End If

        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_COD").Value = IIf(0.0075 * Convert.ToInt32(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Gia_Tri").Value) > 7000, 0.0075 * Convert.ToInt32(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Gia_Tri").Value), 7000) * (1 + GVat)
        ThuHo = 0
        If Not Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("EMS").Value) Then
            ThuHo = myE1DenChiTiet.Cuoc_Chinh
        End If
        If Not Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("COD").Value) Then
            ThuHo = ThuHo + dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_COD").Value + dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_TCT").Value
        End If
        NguoiGuiTra = 0
        If Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("EMS").Value) Then
            NguoiGuiTra = myE1DenChiTiet.Cuoc_Chinh
        End If
        If Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("COD").Value) Then
            NguoiGuiTra = NguoiGuiTra + dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_COD").Value + dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_TCT").Value
        End If
        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value = ThuHo
        lblTraiDen.Text = "EMS: " & dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_EMS").Value & vbNewLine & "COD: " & dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_COD").Value & vbNewLine & "Chuyển tiếp: " & dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Chuyen_Tiep").Value
        lblPhaiDen.Text = "TCT: " & dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_TCT").Value & vbNewLine & "Chuyển nhanh: " & dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value & vbNewLine & "Thu hộ: " & dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value
        lblDuoiDen.Text = "Người nhận phải trả: " + ThuHo.ToString
    End Sub
    Private Sub dgCODDen_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCODDen.AfterExitEditMode
        Select Case dgCODDen.ActiveCell.Column.Key
            Case "Ma_COD1"
                If dgCODDen.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số COD1 không được để trống !!!", "Thông báo")
                    myCell = dgCODDen.ActiveCell
                    Exit Sub
                End If
            Case "Ma_E1"
                If dgCODDen.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số E1 không được để trống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'myCell = dgCODDen.ActiveCell
                    Exit Sub
                Else
                    'Kiem tra xem co Ma_E1 nay hay khong
                    myE1DenChiTiet = myE1Den.Lay_Theo_Ma_E1(dgCODDen.ActiveCell.Text, Ham_Dung_Chung.ConvertDateToInt(Convert.ToDateTime(dtpNgayDen.Value).AddDays(-GSo_Ngay_E1_Duoc_Trung)))
                    If myE1DenChiTiet.Id_E1 = "" Then
                        CMessageBox.Show("Mã E1 không tồn tại !!!")
                        myCell = dgCODDen.ActiveCell
                        Exit Sub
                    Else
                        myCODDenChiTiet = myCODDen.Lay(myE1DenChiTiet.Id_E1)
                        If myCODDenChiTiet.Ma_E1 <> "" And myCODDenChiTiet.Ngay_Nhan <> Ham_Dung_Chung.ConvertDateToInt(dtpNgayDen.Value) Then
                            If CMessageBox.Show("Mã E1 " & dgCODDen.ActiveCell.Text & " đã tồn tại ở ngày " & Ham_Dung_Chung.ConvertIntToDate(myCODDenChiTiet.Ngay_Nhan).ToString("dd/MM/yyyy") & " !!!" & vbNewLine & "Bạn có muốn hiệu chỉnh lại COD1 này ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_COD1").Value = myCODDenChiTiet.Ma_COD1
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("So_TT").Value = myCODDenChiTiet.So_TT
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("So_Hoa_Don").Value = myCODDenChiTiet.So_Hoa_Don
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Gia_Tri").Value = myCODDenChiTiet.Gia_Tri
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_COD").Value = myCODDenChiTiet.Cuoc_COD
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_TCT").Value = myCODDenChiTiet.Cuoc_TCT
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Thu_Ho").Value = myCODDenChiTiet.Cuoc_Thu_Ho
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Chuyen_Nhanh").Value = myCODDenChiTiet.Cuoc_Chuyen_Nhanh
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_Chuyen_Tiep").Value = myCODDenChiTiet.Cuoc_Chuyen_Tiep
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_EMS").Value = myCODDenChiTiet.Cuoc_EMS
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("EMS").Value = myCODDenChiTiet.EMS
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("COD").Value = myCODDenChiTiet.COD
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Nhanh").Value = myCODDenChiTiet.Nhanh
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Chuyen_Tiep").Value = myCODDenChiTiet.Chuyen_Tiep
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Giay_To_Kem_Theo").Value = myCODDenChiTiet.Giay_To_Kem_Theo
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = myCODDenChiTiet.Ma_Bc_Goc
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_Bc_Chuyen_Tiep").Value = myCODDenChiTiet.Ma_Bc_Chuyen_Tiep
                                dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Nguoi_Gui_Nhan_Tien").Value = myCODDenChiTiet.Nguoi_Gui_Nhan_Tien
                            Else
                                myCell = dgCODDen.ActiveCell
                                Exit Sub
                            End If
                        End If
                        'Them moi ngay dong do
                        BindingDataNullCODDen()
                        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Id_E1").Value = myE1DenChiTiet.Id_E1
                        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Cuoc_EMS").Value = myE1DenChiTiet.Cuoc_Chinh
                        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = myE1DenChiTiet.Ma_Bc_Goc
                        Tinh_Cuoc_COD_Den()
                        If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
                            'Cap nhat, them moi nguoi dung
                            With dgCODDen.Rows(dgCODDen.ActiveRow.Index)
                                myCODDen.Cap_Nhat_Them(.Cells("Id_E1").Text, .Cells("Ma_E1").Text, .Cells("Ma_COD1").Text, Gid_Nguoi_Dung, Convert.ToInt32(.Cells("So_TT").Text), .Cells("So_Hoa_Don").Text, Convert.ToInt32(.Cells("Gia_Tri").Value), Convert.ToInt32(.Cells("Cuoc_COD").Value), Convert.ToInt32(.Cells("Cuoc_TCT").Value), Convert.ToInt32(.Cells("Cuoc_Thu_Ho").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Nhanh").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Tiep").Value), Convert.ToInt32(.Cells("Cuoc_EMS").Value), Convert.ToBoolean(.Cells("EMS").Value), Convert.ToBoolean(.Cells("COD").Value), Convert.ToBoolean(.Cells("Nhanh").Value), Convert.ToBoolean(.Cells("Chuyen_Tiep").Value), .Cells("Giay_To_Kem_Theo").Text, myE1DenChiTiet.Ngay_Phat_Hanh, myE1DenChiTiet.Gio_Phat_Hanh, Ham_Dung_Chung.ConvertDateToInt(dtpNgayDen.Value), Ham_Dung_Chung.ConvertTimeToInt(dtpNgayDen.Value), Convert.ToInt32(.Cells("Ma_Bc_Goc").Text), GBuu_Cuc_Khai_Thac, Convert.ToInt32(.Cells("Ma_Bc_Chuyen_Tiep").Text), Convert.ToBoolean(.Cells("Nguoi_Gui_Nhan_Tien").Value), False)
                            End With
                            AddNewRowCODDen(dgCODDen)
                            'BindingDataNull()
                        End If

                        'AddNewRow(dgCODDen)
                        'BindingDataNull()
                    End If

                    If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("EMS").Value Is System.DBNull.Value Then
                        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("EMS").Value = 1
                    End If
                    If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("COD").Value Is System.DBNull.Value Then
                        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("COD").Value = 1
                    End If
                    If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Nhanh").Value Is System.DBNull.Value Then
                        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Nhanh").Value = 0
                    End If
                    If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Chuyen_Tiep").Value Is System.DBNull.Value Then
                        dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Chuyen_Tiep").Value = 0
                    End If
                End If

            Case "Chuyen_Tiep"
                If Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Chuyen_Tiep").Value) Then
                    dgCODDen.DisplayLayout.Bands(0).Groups("Tiền cước").Hidden = Not Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
                End If
                dgCODDen.DisplayLayout.Bands(0).Groups("Bưu cục chuyển tiếp").Hidden = Not Convert.ToBoolean(dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
                Tinh_Cuoc_COD_Den()
            Case Else
                Tinh_Cuoc_COD_Den()
        End Select
    End Sub

    Private Sub dgCODDen_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCODDen.AfterRowUpdate
        If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
            Exit Sub
        End If
        If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_COD1").Text = "" Then
            Exit Sub
        End If
        If dgCODDen.Rows(dgCODDen.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            'Cap nhat, them moi nguoi dung
            With e.Row
                myE1DenChiTiet = myE1Den.Lay(.Cells("Id_E1").Text)
                myCODDen.Cap_Nhat_Them(.Cells("Id_E1").Text, .Cells("Ma_E1").Text, .Cells("Ma_COD1").Text, Gid_Nguoi_Dung, Convert.ToInt32(.Cells("So_TT").Text), .Cells("So_Hoa_Don").Text, Convert.ToInt32(e.Row.Cells("Gia_Tri").Value), Convert.ToInt32(.Cells("Cuoc_COD").Value), Convert.ToInt32(.Cells("Cuoc_TCT").Value), Convert.ToInt32(.Cells("Cuoc_Thu_Ho").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Nhanh").Value), Convert.ToInt32(.Cells("Cuoc_Chuyen_Tiep").Value), Convert.ToInt32(.Cells("Cuoc_EMS").Value), Convert.ToBoolean(.Cells("EMS").Value), Convert.ToBoolean(.Cells("COD").Value), Convert.ToBoolean(.Cells("Nhanh").Value), Convert.ToBoolean(.Cells("Chuyen_Tiep").Value), .Cells("Giay_To_Kem_Theo").Text, myE1DenChiTiet.Ngay_Phat_Hanh, myE1DenChiTiet.Gio_Phat_Hanh, Ham_Dung_Chung.ConvertDateToInt(dtpNgayDen.Value), Ham_Dung_Chung.ConvertTimeToInt(dtpNgayDen.Value), myE1DenChiTiet.Ma_Bc_Goc, GBuu_Cuc_Khai_Thac, Convert.ToInt32(.Cells("Ma_Bc_Chuyen_Tiep").Text), Convert.ToBoolean(.Cells("Nguoi_Gui_Nhan_Tien").Value), False)
            End With
            AddNewRowCODDen(dgCODDen)
            'BindingDataNull()
        End If
    End Sub

    Private Sub dgCODDen_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgCODDen.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Cancel = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            myCell = Nothing
        End If
    End Sub

    Private Sub chkCuocDen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCuocDen.CheckedChanged
        dgCODDen.DisplayLayout.Bands(0).Groups("Tiền cước").Hidden = Not chkCuocDen.Checked
    End Sub
    Private Sub dtpNgayDen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNgayDen.ValueChanged
        DataInitCODDen()
    End Sub
    Private Sub dgCODDen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCODDen.LostFocus
        myCell = Nothing
    End Sub
    
#End Region
#Region "Tim_Kiem"
    Private Sub Tao_Bang_Id_Phan_Loai()

        'Them moi mot bang
        Dim dataTable As New dataTable("Chieu")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Chieu", GetType(String))
        dataTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Chieu") = "Chiều đi"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Chieu") = "Chiều đến"
        dataTable.Rows.Add(row)

        cbChieu.DataSource = dataTable
        cbChieu.DataBind()
        cbChieu.Text = "Chiều đi"

        cbBuuCuc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
        cbBuuCuc.DataBind()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim strSQL As String = ""
        If cbChieu.Text = "Chiều đi" Then
            strSQL += "SELECT	C.Id_E1,C.Ma_E1,Ma_COD1,	E.Ma_KH,	So_TT,	So_Hoa_Don,	Gia_Tri,	C.Cuoc_COD,	Cuoc_TCT,	Cuoc_Thu_Ho,	Cuoc_Chuyen_Nhanh,	Cuoc_Chuyen_Tiep,	E.Cuoc_Chinh AS Cuoc_EMS,	EMS,	C.COD,	Nhanh,	Chuyen_Tiep,	Nguoi_Gui AS Ho_Ten_Nguoi_Gui,	Dia_Chi_Gui AS Dia_Chi_Nguoi_Gui,	Nguoi_Nhan AS Ho_Ten_Nguoi_Nhan,	Dia_Chi_Nhan AS Dia_Chi_Nguoi_Nhan,	Giay_To_Kem_Theo,		C.Ma_Bc_Tra,	Ma_Bc_Chuyen_Tiep,            Nguoi_Gui_Nhan_Tien FROM COD_Di C INNER JOIN E1_Di E ON C.Id_E1 = E.Id_E1 WHERE 1=1 "
        Else
            strSQL += "SELECT	C.Id_E1,	C.Ma_E1,	Ma_COD1,		E.Ma_KH,	So_TT,	So_Hoa_Don,	Gia_Tri,	C.Cuoc_COD,	Cuoc_TCT,	Cuoc_Thu_Ho,	Cuoc_Chuyen_Nhanh,	Cuoc_Chuyen_Tiep,	E.Cuoc_Chinh AS Cuoc_EMS,	EMS,	C.COD,	Nhanh,	Chuyen_Tiep,	Nguoi_Gui AS Ho_Ten_Nguoi_Gui,	Dia_Chi_Gui AS Dia_Chi_Nguoi_Gui,	Nguoi_Nhan AS Ho_Ten_Nguoi_Nhan,	Dia_Chi_Nhan AS Dia_Chi_Nguoi_Nhan,	Giay_To_Kem_Theo,		C.Ma_Bc_Goc,	Ma_Bc_Chuyen_Tiep,            Nguoi_Gui_Nhan_Tien FROM COD_Den C INNER JOIN E1_Den E ON C.Id_E1 = E.Id_E1            WHERE 1=1 "
        End If
        If chkNgay.Checked Then
            If Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value) > Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value) Then
                CMessageBox.Show("Giá trị từ ngày phải bé hơn hoặc bằng giá trị đến ngày !!!", "Thông báo")
                dtpTuNgay.Focus()
                Exit Sub
            End If
            If cbChieu.Text = "Chiều đi" Then
                strSQL += " AND C.Ngay_Gui BETWEEN " & Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value) & " AND " & Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)
            Else
                strSQL += " AND C.Ngay_Nhan BETWEEN " & Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value) & " AND " & Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)
            End If
        End If
        If chkBuuCuc.Checked Then
            If cbBuuCuc.Text.Length <> 6 Then
                CMessageBox.Show("Bạn phải nhập mã bưu cục 6 số vào !!!", "Thông báo")
                cbBuuCuc.Focus()
                Exit Sub
            End If
            If cbChieu.Text = "Chiều đi" Then
                strSQL += " AND C.Ma_Bc_Tra = " & cbBuuCuc.Value
            Else
                strSQL += " AND C.Ma_Bc_Goc = " & cbBuuCuc.Value
            End If

        End If
        If chkMaE1.Checked Then
            If txtMaE1.Text.Trim = "" Then
                CMessageBox.Show("Bạn phải nhập mã E1 vào !!!", "Thông báo")
                txtMaE1.Focus()
                Exit Sub
            End If
            strSQL += " AND C.Ma_E1 = '" & txtMaE1.Text.Trim & "'"
        End If
        If cbChieu.Text = "Chiều đi" Then
            dgTimKiemDen.Visible = False
            dgTimKiemDi.Visible = True
            dgTimKiemDi.DataSource = myCODDi.Tim_Kiem(strSQL)
            dgTimKiemDi.DataBind()
        Else
            dgTimKiemDen.Visible = True
            dgTimKiemDi.Visible = False
            dgTimKiemDen.DataSource = myCODDi.Tim_Kiem(strSQL)
            dgTimKiemDen.DataBind()
        End If
        
    End Sub
    Private Sub dgTimKiemDi_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTimKiemDi.InitializeLayout
        dgTimKiemDi.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTimKiemDi.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTimKiemDi.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Tra").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Tra").ValueList = ddMaBc
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").Style = ColumnStyle.DropDown
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").ValueList = ddMaBc
        End With
    End Sub

    Private Sub dgTimKiemDen_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTimKiemDen.InitializeLayout
        dgTimKiemDen.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTimKiemDen.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTimKiemDen.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Goc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Goc").ValueList = ddMaBc
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").Style = ColumnStyle.DropDown
            .Bands(0).Columns("Ma_Bc_Chuyen_Tiep").ValueList = ddMaBc
        End With
    End Sub
#End Region

    
End Class
