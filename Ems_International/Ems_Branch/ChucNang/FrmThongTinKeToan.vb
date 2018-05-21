Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class FrmThongTinKeToan
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
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents sFileDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents lbEMS As System.Windows.Forms.Label
    Friend WithEvents PrbAccounting As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents GrBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tabControl As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents BtnThoat As System.Windows.Forms.Button
    Friend WithEvents btnThuc_Hien As System.Windows.Forms.Button
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnXem_Chi_Tiet As System.Windows.Forms.Button
    Friend WithEvents btnTao_Du_Lieu As System.Windows.Forms.Button
    Friend WithEvents GrBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbSo_Chuyen_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents dgEMS_QT_DEN As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents dgEMS_QT_DI As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents cbDuong_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents dgEMS_QG As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents lblDuong_Thu As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraDataSource5 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource6 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ddBCG As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDataSource7 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource8 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource9 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents OptHangKhong As System.Windows.Forms.RadioButton
    Friend WithEvents OptQuoTe As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbLoai_Chuyen_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblThongTin As System.Windows.Forms.Label
    Friend WithEvents chkDEN As System.Windows.Forms.CheckBox
    Friend WithEvents chkDI As System.Windows.Forms.CheckBox
    Friend WithEvents chkQG As System.Windows.Forms.CheckBox
    Friend WithEvents btnChotSL As System.Windows.Forms.Button
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgUSPS_QT_DEN As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtFile_USPS As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCuoc_Hang_Khong As System.Windows.Forms.Button
    Friend WithEvents chkQTDenTheoChuyenBay As System.Windows.Forms.CheckBox
    Friend WithEvents chkQTDenTheoNuocNgayKT As System.Windows.Forms.CheckBox
    Friend WithEvents chkQTDenTheoNuocNgayDong As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_BC")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Buu_Cuc")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("EMS_QT_DEN", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Acc_Key")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCT")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BCG")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BCN")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KL_EMS")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KL_EMS_TT")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_D")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_M")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_R")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOTICE")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HVC")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("I_O")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_BCG")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_BCN")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("EMS_QT_DEN", -1)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Acc_Key")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCT", -1, Nothing, 2, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BCG")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BCN", -1, Nothing, 1, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KL_EMS")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KL_EMS_TT")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_D")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_M")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_R")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOTICE")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HVC")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("I_O")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_BCG")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_BCN")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Acc_Key")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SCT")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCG")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCN")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS_TT")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_D")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_M")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_R")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOTICE")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HVC")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("I_O")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCG")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCN")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("EMS_QG", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCT", -1, Nothing, 1, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SH_EMS")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_GUI")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_QG", -1, Nothing, 2, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NUOC_NHAN", -1, Nothing, 3, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KL_EMS")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Van_Don")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Notice")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SCT")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SH_EMS")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nuoc_QG")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUOC_NHAN")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Van_Don")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Notice")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("USPS_QT_DEN", -1)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Acc_Key")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCT")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BCG")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BCN")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KL_EMS")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KL_EMS_TT")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_D")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_M")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_R")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOTICE")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HVC")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("I_O")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_BCG")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_BCN")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Acc_Key")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SCT")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCG")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCN")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS_TT")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_D")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_M")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_R")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOTICE")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HVC")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("I_O")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCG")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCN")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Acc_Key")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SCT")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCG")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCN")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_D")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_M")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_R")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOTICE")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HVC")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("I_O")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCG")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCN")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SCT")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SH_EMS")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nuoc_QG")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUOC_NHAN")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Van_don")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Notice")
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmThongTinKeToan))
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai_Chuyen_Thu", -1)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Chuyen_Thu")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu", -1)
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Bc")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Chuyen_Thu", -1)
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCT")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SCT")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Acc_Key")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SCT")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCG")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BCN")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_D")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_M")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LOAI_R")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOTICE")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HVC")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("I_O")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCG")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_BCN")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KL_EMS_TT")
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddBCG = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraDataSource6 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.dgEMS_QT_DEN = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgEMS_QT_DI = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource9 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgEMS_QG = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgUSPS_QT_DEN = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource8 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource5 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.BtnThoat = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnFile = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.sFileDlg = New System.Windows.Forms.SaveFileDialog
        Me.lbEMS = New System.Windows.Forms.Label
        Me.PrbAccounting = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.GrBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnChotSL = New System.Windows.Forms.Button
        Me.cbLoai_Chuyen_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDuong_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.cbSo_Chuyen_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.btnXem_Chi_Tiet = New System.Windows.Forms.Button
        Me.lblDuong_Thu = New Infragistics.Win.Misc.UltraLabel
        Me.btnTao_Du_Lieu = New System.Windows.Forms.Button
        Me.chkQTDenTheoChuyenBay = New System.Windows.Forms.CheckBox
        Me.chkQTDenTheoNuocNgayKT = New System.Windows.Forms.CheckBox
        Me.chkDEN = New System.Windows.Forms.CheckBox
        Me.chkDI = New System.Windows.Forms.CheckBox
        Me.chkQG = New System.Windows.Forms.CheckBox
        Me.GrBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.txtFile_USPS = New System.Windows.Forms.TextBox
        Me.btnThuc_Hien = New System.Windows.Forms.Button
        Me.OptQuoTe = New System.Windows.Forms.RadioButton
        Me.OptHangKhong = New System.Windows.Forms.RadioButton
        Me.tabControl = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.UltraDataSource7 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.lblThongTin = New System.Windows.Forms.Label
        Me.btnCuoc_Hang_Khong = New System.Windows.Forms.Button
        Me.chkQTDenTheoNuocNgayDong = New System.Windows.Forms.CheckBox
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ddBCG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEMS_QT_DEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.dgEMS_QT_DI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dgEMS_QG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.dgUSPS_QT_DEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBox1.SuspendLayout()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuong_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBox2.SuspendLayout()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        CType(Me.UltraDataSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ddBCG)
        Me.UltraTabPageControl1.Controls.Add(Me.dgEMS_QT_DEN)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(812, 412)
        '
        'ddBCG
        '
        Me.ddBCG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ddBCG.DataSource = Me.UltraDataSource6
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddBCG.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Mã BC"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Mã chữ"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Mã Tỉnh"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Tên bưu cục"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ddBCG.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.ForeColor = System.Drawing.Color.Black
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddBCG.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.ddBCG.DisplayMember = "Ma_BC"
        Me.ddBCG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddBCG.Location = New System.Drawing.Point(302, 138)
        Me.ddBCG.Name = "ddBCG"
        Me.ddBCG.Size = New System.Drawing.Size(208, 128)
        Me.ddBCG.TabIndex = 75
        Me.ddBCG.ValueMember = "Ma_BC"
        Me.ddBCG.Visible = False
        '
        'UltraDataSource6
        '
        Me.UltraDataSource6.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        Me.UltraDataSource6.Band.Key = "Dm_Bc"
        '
        'dgEMS_QT_DEN
        '
        Me.dgEMS_QT_DEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgEMS_QT_DEN.DisplayLayout.AddNewBox.Prompt = " "
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgEMS_QT_DEN.DisplayLayout.Appearance = Appearance3
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Format = ""
        UltraGridColumn7.Header.Caption = "Ngày đóng"
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.MaskInput = "dd/mm/yyyy"
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Width = 91
        UltraGridColumn8.Header.Caption = "Số chuyến thư"
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 90
        UltraGridColumn9.Header.Caption = "BC gửi"
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Width = 89
        UltraGridColumn10.Header.Caption = "BC nhận"
        UltraGridColumn10.Header.VisiblePosition = 5
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Width = 90
        UltraGridColumn11.Header.Caption = "Khối lượng"
        UltraGridColumn11.Header.VisiblePosition = 6
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Width = 76
        UltraGridColumn12.Header.VisiblePosition = 15
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Loại D"
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Width = 86
        UltraGridColumn14.Header.Caption = "Loại M"
        UltraGridColumn14.Header.VisiblePosition = 8
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Width = 84
        UltraGridColumn15.Header.Caption = "Loại R"
        UltraGridColumn15.Header.VisiblePosition = 9
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Width = 79
        UltraGridColumn16.Header.Caption = "Chú thích"
        UltraGridColumn16.Header.VisiblePosition = 11
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Hãng vận chuyển"
        UltraGridColumn17.Header.VisiblePosition = 10
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 12
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "Tên Bc gửi"
        UltraGridColumn19.Header.VisiblePosition = 13
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.VisiblePosition = 14
        UltraGridColumn20.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        UltraGridBand2.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgEMS_QT_DEN.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgEMS_QT_DEN.DisplayLayout.InterBandSpacing = 10
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.dgEMS_QT_DEN.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.dgEMS_QT_DEN.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgEMS_QT_DEN.DisplayLayout.Override.HeaderAppearance = Appearance5
        Appearance6.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgEMS_QT_DEN.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgEMS_QT_DEN.DisplayLayout.Override.RowSelectorAppearance = Appearance7
        Me.dgEMS_QT_DEN.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgEMS_QT_DEN.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.dgEMS_QT_DEN.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.dgEMS_QT_DEN.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgEMS_QT_DEN.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgEMS_QT_DEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgEMS_QT_DEN.Location = New System.Drawing.Point(0, 0)
        Me.dgEMS_QT_DEN.Name = "dgEMS_QT_DEN"
        Me.dgEMS_QT_DEN.Size = New System.Drawing.Size(808, 400)
        Me.dgEMS_QT_DEN.TabIndex = 74
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.dgEMS_QT_DI)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 26)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(812, 388)
        '
        'dgEMS_QT_DI
        '
        Me.dgEMS_QT_DI.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgEMS_QT_DI.DataSource = Me.UltraDataSource9
        Me.dgEMS_QT_DI.DisplayLayout.AddNewBox.Prompt = " "
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgEMS_QT_DI.DisplayLayout.Appearance = Appearance9
        UltraGridColumn21.Header.VisiblePosition = 0
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn23.Format = ""
        UltraGridColumn23.Header.Caption = "Ngày đóng"
        UltraGridColumn23.Header.VisiblePosition = 2
        UltraGridColumn23.MaskInput = "dd/mm/yyyy"
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Width = 86
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn24.Header.Caption = "Số chuyến thư"
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Width = 81
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.Header.Caption = "BC gửi"
        UltraGridColumn25.Header.VisiblePosition = 4
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Width = 79
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn26.Header.Caption = "BC nhận"
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Width = 79
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.Header.Caption = "KL EMS"
        UltraGridColumn27.Header.VisiblePosition = 6
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Width = 69
        UltraGridColumn28.Header.Caption = "KL Theo E1"
        UltraGridColumn28.Header.VisiblePosition = 7
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.Header.Caption = "Loại D"
        UltraGridColumn29.Header.VisiblePosition = 8
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Width = 65
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn30.Header.Caption = "Loại M"
        UltraGridColumn30.Header.VisiblePosition = 9
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Width = 60
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.Header.Caption = "Loại R"
        UltraGridColumn31.Header.VisiblePosition = 10
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Width = 63
        UltraGridColumn32.Header.Caption = "Chú thích"
        UltraGridColumn32.Header.VisiblePosition = 12
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn33.Header.Caption = "Hãng vận chuyển"
        UltraGridColumn33.Header.VisiblePosition = 11
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Width = 97
        UltraGridColumn34.Header.VisiblePosition = 13
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 14
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.Caption = "Tên BC nhận"
        UltraGridColumn36.Header.VisiblePosition = 15
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        UltraGridBand3.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand3.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.dgEMS_QT_DI.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgEMS_QT_DI.DisplayLayout.InterBandSpacing = 10
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.dgEMS_QT_DI.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Me.dgEMS_QT_DI.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgEMS_QT_DI.DisplayLayout.Override.HeaderAppearance = Appearance11
        Appearance12.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgEMS_QT_DI.DisplayLayout.Override.RowAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgEMS_QT_DI.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.dgEMS_QT_DI.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgEMS_QT_DI.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.dgEMS_QT_DI.DisplayLayout.Override.SelectedRowAppearance = Appearance14
        Me.dgEMS_QT_DI.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgEMS_QT_DI.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgEMS_QT_DI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgEMS_QT_DI.Location = New System.Drawing.Point(0, 0)
        Me.dgEMS_QT_DI.Name = "dgEMS_QT_DI"
        Me.dgEMS_QT_DI.Size = New System.Drawing.Size(808, 400)
        Me.dgEMS_QT_DI.TabIndex = 75
        '
        'UltraDataSource9
        '
        Me.UltraDataSource9.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20})
        Me.UltraDataSource9.Band.Key = "EMS_QT_DEN"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dgEMS_QG)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(812, 412)
        '
        'dgEMS_QG
        '
        Me.dgEMS_QG.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgEMS_QG.DataSource = Me.UltraDataSource4
        Me.dgEMS_QG.DisplayLayout.AddNewBox.Prompt = " "
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgEMS_QG.DisplayLayout.Appearance = Appearance15
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn38.Format = ""
        UltraGridColumn38.Header.Caption = "Ngày đóng"
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.MaskInput = "dd/mm/yyyy"
        UltraGridColumn38.Width = 82
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.Header.Caption = "Số chuyến thư"
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Width = 91
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.Header.Caption = "Số hiệu EMS"
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Width = 107
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.Header.Caption = "Bưu cục gửi"
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Width = 71
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.Header.Caption = "Nước QG"
        UltraGridColumn42.Header.VisiblePosition = 5
        UltraGridColumn42.Width = 69
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn43.Header.Caption = "Nước nhận"
        UltraGridColumn43.Header.VisiblePosition = 6
        UltraGridColumn43.Width = 77
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn44.Header.Caption = "Khối lượng"
        UltraGridColumn44.Header.VisiblePosition = 7
        UltraGridColumn44.Width = 62
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn45.Header.Caption = "Loại"
        UltraGridColumn45.Header.VisiblePosition = 8
        UltraGridColumn45.Width = 44
        UltraGridColumn46.Header.VisiblePosition = 9
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn47.Header.Caption = "Cước"
        UltraGridColumn47.Header.VisiblePosition = 10
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.Caption = "Ghi chú"
        UltraGridColumn48.Header.VisiblePosition = 11
        UltraGridColumn48.Width = 64
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48})
        UltraGridBand4.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand4.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgEMS_QG.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgEMS_QG.DisplayLayout.InterBandSpacing = 10
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.dgEMS_QG.DisplayLayout.Override.CardAreaAppearance = Appearance16
        Me.dgEMS_QG.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.ForeColor = System.Drawing.Color.Black
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgEMS_QG.DisplayLayout.Override.HeaderAppearance = Appearance17
        Appearance18.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgEMS_QG.DisplayLayout.Override.RowAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgEMS_QG.DisplayLayout.Override.RowSelectorAppearance = Appearance19
        Me.dgEMS_QG.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgEMS_QG.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.dgEMS_QG.DisplayLayout.Override.SelectedRowAppearance = Appearance20
        Me.dgEMS_QG.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgEMS_QG.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgEMS_QG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgEMS_QG.Location = New System.Drawing.Point(0, 0)
        Me.dgEMS_QG.Name = "dgEMS_QG"
        Me.dgEMS_QG.Size = New System.Drawing.Size(808, 416)
        Me.dgEMS_QG.TabIndex = 76
        '
        'UltraDataSource4
        '
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32})
        Me.UltraDataSource4.Band.Key = "EMS_QG"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.dgUSPS_QT_DEN)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(812, 412)
        '
        'dgUSPS_QT_DEN
        '
        Me.dgUSPS_QT_DEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgUSPS_QT_DEN.DisplayLayout.AddNewBox.Prompt = " "
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgUSPS_QT_DEN.DisplayLayout.Appearance = Appearance21
        UltraGridColumn49.Header.VisiblePosition = 0
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 1
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Format = ""
        UltraGridColumn51.Header.Caption = "Ngày đóng"
        UltraGridColumn51.Header.VisiblePosition = 2
        UltraGridColumn51.MaskInput = "dd/mm/yyyy"
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Width = 91
        UltraGridColumn52.Header.Caption = "Số chuyến thư"
        UltraGridColumn52.Header.VisiblePosition = 3
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Width = 90
        UltraGridColumn53.Header.Caption = "BC gửi"
        UltraGridColumn53.Header.VisiblePosition = 4
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.Width = 89
        UltraGridColumn54.Header.Caption = "BC nhận"
        UltraGridColumn54.Header.VisiblePosition = 5
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Width = 90
        UltraGridColumn55.Header.Caption = "Khối lượng"
        UltraGridColumn55.Header.VisiblePosition = 6
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.Width = 76
        UltraGridColumn56.Header.VisiblePosition = 15
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.Caption = "Loại D"
        UltraGridColumn57.Header.VisiblePosition = 7
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.Width = 86
        UltraGridColumn58.Header.Caption = "Loại M"
        UltraGridColumn58.Header.VisiblePosition = 8
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.Width = 84
        UltraGridColumn59.Header.Caption = "Loại R"
        UltraGridColumn59.Header.VisiblePosition = 9
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Width = 79
        UltraGridColumn60.Header.Caption = "Chú thích"
        UltraGridColumn60.Header.VisiblePosition = 11
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.Caption = "Hãng vận chuyển"
        UltraGridColumn61.Header.VisiblePosition = 10
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 12
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.Caption = "Tên Bc gửi"
        UltraGridColumn63.Header.VisiblePosition = 13
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.VisiblePosition = 14
        UltraGridColumn64.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64})
        UltraGridBand5.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand5.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand5.UseRowLayout = True
        Me.dgUSPS_QT_DEN.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgUSPS_QT_DEN.DisplayLayout.InterBandSpacing = 10
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.ForeColor = System.Drawing.Color.Black
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance23.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.HeaderAppearance = Appearance23
        Appearance24.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.RowAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance25.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.RowSelectorAppearance = Appearance25
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance26.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.dgUSPS_QT_DEN.DisplayLayout.Override.SelectedRowAppearance = Appearance26
        Me.dgUSPS_QT_DEN.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgUSPS_QT_DEN.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgUSPS_QT_DEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgUSPS_QT_DEN.Location = New System.Drawing.Point(2, 2)
        Me.dgUSPS_QT_DEN.Name = "dgUSPS_QT_DEN"
        Me.dgUSPS_QT_DEN.Size = New System.Drawing.Size(808, 400)
        Me.dgUSPS_QT_DEN.TabIndex = 75
        '
        'UltraDataSource8
        '
        Me.UltraDataSource8.Band.Columns.AddRange(New Object() {UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48})
        Me.UltraDataSource8.Band.Key = "EMS_QT_DEN"
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63})
        Me.UltraDataSource3.Band.Key = "EMS_QT_DEN"
        '
        'UltraDataSource5
        '
        Me.UltraDataSource5.Band.Columns.AddRange(New Object() {UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75})
        Me.UltraDataSource5.Band.Key = "EMS_QG"
        '
        'BtnThoat
        '
        Me.BtnThoat.Image = CType(resources.GetObject("BtnThoat.Image"), System.Drawing.Image)
        Me.BtnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnThoat.Location = New System.Drawing.Point(536, 648)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(104, 32)
        Me.BtnThoat.TabIndex = 72
        Me.BtnThoat.Text = "&Close"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(376, 648)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 32)
        Me.btnPrint.TabIndex = 71
        Me.btnPrint.Text = "&Print"
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(216, 648)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(104, 32)
        Me.btnPreview.TabIndex = 70
        Me.btnPreview.Text = "Prei&vew"
        '
        'btnFile
        '
        Me.btnFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Image = CType(resources.GetObject("btnFile.Image"), System.Drawing.Image)
        Me.btnFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFile.Location = New System.Drawing.Point(344, 32)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(72, 80)
        Me.btnFile.TabIndex = 5
        Me.btnFile.Text = "Ghi &File Access"
        '
        'txtFile
        '
        Me.txtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.Location = New System.Drawing.Point(80, 72)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(304, 21)
        Me.txtFile.TabIndex = 2
        Me.txtFile.Text = ""
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(128, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Ðến ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.DateTime = New Date(2009, 6, 23, 0, 0, 0, 0)
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(128, 40)
        Me.CbDen_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(96, 23)
        Me.CbDen_Ngay.TabIndex = 3
        Me.CbDen_Ngay.Value = New Date(2009, 6, 23, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(8, 40)
        Me.CbTu_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(96, 23)
        Me.CbTu_Ngay.TabIndex = 1
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 56)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(200, 16)
        Me.UltraLabel1.TabIndex = 69
        Me.UltraLabel1.Text = "Đường dẫn File Access"
        '
        'lbEMS
        '
        Me.lbEMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEMS.Location = New System.Drawing.Point(8, 136)
        Me.lbEMS.Name = "lbEMS"
        Me.lbEMS.Size = New System.Drawing.Size(344, 16)
        Me.lbEMS.TabIndex = 63
        Me.lbEMS.Text = "Tiến trình thực hiện"
        '
        'PrbAccounting
        '
        Me.PrbAccounting.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbAccounting.Location = New System.Drawing.Point(8, 160)
        Me.PrbAccounting.Maximum = 10000
        Me.PrbAccounting.Name = "PrbAccounting"
        Me.PrbAccounting.Size = New System.Drawing.Size(376, 23)
        Me.PrbAccounting.Step = 1
        Me.PrbAccounting.TabIndex = 65
        Me.PrbAccounting.Text = "[Formatted]"
        '
        'GrBox1
        '
        Me.GrBox1.Controls.Add(Me.chkQTDenTheoNuocNgayDong)
        Me.GrBox1.Controls.Add(Me.btnChotSL)
        Me.GrBox1.Controls.Add(Me.cbLoai_Chuyen_Thu)
        Me.GrBox1.Controls.Add(Me.UltraLabel2)
        Me.GrBox1.Controls.Add(Me.cbDuong_Thu)
        Me.GrBox1.Controls.Add(Me.UltraLabel5)
        Me.GrBox1.Controls.Add(Me.cbSo_Chuyen_Thu)
        Me.GrBox1.Controls.Add(Me.btnXem_Chi_Tiet)
        Me.GrBox1.Controls.Add(Me.lblDuong_Thu)
        Me.GrBox1.Controls.Add(Me.btnTao_Du_Lieu)
        Me.GrBox1.Controls.Add(Me.CbTu_Ngay)
        Me.GrBox1.Controls.Add(Me.UltraLabel4)
        Me.GrBox1.Controls.Add(Me.CbDen_Ngay)
        Me.GrBox1.Controls.Add(Me.UltraLabel3)
        Me.GrBox1.Controls.Add(Me.chkQTDenTheoChuyenBay)
        Me.GrBox1.Controls.Add(Me.chkQTDenTheoNuocNgayKT)
        Me.GrBox1.Controls.Add(Me.chkDEN)
        Me.GrBox1.Controls.Add(Me.chkDI)
        Me.GrBox1.Controls.Add(Me.chkQG)
        Me.GrBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBox1.Location = New System.Drawing.Point(0, 8)
        Me.GrBox1.Name = "GrBox1"
        Me.GrBox1.Size = New System.Drawing.Size(336, 208)
        Me.GrBox1.SupportThemes = False
        Me.GrBox1.TabIndex = 5
        Me.GrBox1.Text = "Cập nhật thông tin Kế toán Quốc tế"
        '
        'btnChotSL
        '
        Me.btnChotSL.Image = CType(resources.GetObject("btnChotSL.Image"), System.Drawing.Image)
        Me.btnChotSL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChotSL.Location = New System.Drawing.Point(232, 120)
        Me.btnChotSL.Name = "btnChotSL"
        Me.btnChotSL.Size = New System.Drawing.Size(96, 32)
        Me.btnChotSL.TabIndex = 15
        Me.btnChotSL.Text = "&Chốt số liệu"
        Me.btnChotSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbLoai_Chuyen_Thu
        '
        Me.cbLoai_Chuyen_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbLoai_Chuyen_Thu.DisplayLayout.Appearance = Appearance27
        UltraGridColumn65.Header.VisiblePosition = 0
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn65})
        UltraGridBand6.Header.Caption = "Loại CT"
        Me.cbLoai_Chuyen_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance28.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance28.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbLoai_Chuyen_Thu.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.cbLoai_Chuyen_Thu.DisplayMember = ""
        Me.cbLoai_Chuyen_Thu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_Chuyen_Thu.Location = New System.Drawing.Point(176, 88)
        Me.cbLoai_Chuyen_Thu.Name = "cbLoai_Chuyen_Thu"
        Me.cbLoai_Chuyen_Thu.Size = New System.Drawing.Size(48, 21)
        Me.cbLoai_Chuyen_Thu.TabIndex = 10
        Me.cbLoai_Chuyen_Thu.ValueMember = ""
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(176, 72)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel2.TabIndex = 9
        Me.UltraLabel2.Text = "Loại CT"
        '
        'cbDuong_Thu
        '
        Me.cbDuong_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbDuong_Thu.DataSource = Me.UltraDataSource2
        Appearance29.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDuong_Thu.DisplayLayout.Appearance = Appearance29
        UltraGridColumn66.Header.VisiblePosition = 0
        UltraGridColumn67.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn66, UltraGridColumn67})
        UltraGridBand7.Header.Caption = "Đường thư"
        Me.cbDuong_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance30.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance30.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDuong_Thu.DisplayLayout.Override.HeaderAppearance = Appearance30
        Me.cbDuong_Thu.DisplayMember = "Ma_Bc"
        Me.cbDuong_Thu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuong_Thu.Location = New System.Drawing.Point(8, 88)
        Me.cbDuong_Thu.Name = "cbDuong_Thu"
        Me.cbDuong_Thu.Size = New System.Drawing.Size(80, 21)
        Me.cbDuong_Thu.TabIndex = 6
        Me.cbDuong_Thu.ValueMember = "Ma_Bc"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn76, UltraDataColumn77})
        Me.UltraDataSource2.Band.Key = "Duong_Thu"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(96, 72)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel5.TabIndex = 7
        Me.UltraLabel5.Text = "Số CT"
        '
        'cbSo_Chuyen_Thu
        '
        Me.cbSo_Chuyen_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbSo_Chuyen_Thu.DataSource = Me.UltraDataSource1
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbSo_Chuyen_Thu.DisplayLayout.Appearance = Appearance31
        UltraGridColumn68.Header.VisiblePosition = 0
        UltraGridColumn69.Header.VisiblePosition = 1
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn68, UltraGridColumn69})
        UltraGridBand8.Header.Caption = "Số chuyến thư"
        Me.cbSo_Chuyen_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance32.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance32.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbSo_Chuyen_Thu.DisplayLayout.Override.HeaderAppearance = Appearance32
        Me.cbSo_Chuyen_Thu.DisplayMember = "SCT"
        Me.cbSo_Chuyen_Thu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSo_Chuyen_Thu.Location = New System.Drawing.Point(96, 88)
        Me.cbSo_Chuyen_Thu.Name = "cbSo_Chuyen_Thu"
        Me.cbSo_Chuyen_Thu.Size = New System.Drawing.Size(72, 21)
        Me.cbSo_Chuyen_Thu.TabIndex = 8
        Me.cbSo_Chuyen_Thu.ValueMember = "SCT"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn78, UltraDataColumn79})
        Me.UltraDataSource1.Band.Key = "Chuyen_Thu"
        '
        'btnXem_Chi_Tiet
        '
        Me.btnXem_Chi_Tiet.Image = CType(resources.GetObject("btnXem_Chi_Tiet.Image"), System.Drawing.Image)
        Me.btnXem_Chi_Tiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXem_Chi_Tiet.Location = New System.Drawing.Point(232, 72)
        Me.btnXem_Chi_Tiet.Name = "btnXem_Chi_Tiet"
        Me.btnXem_Chi_Tiet.Size = New System.Drawing.Size(96, 32)
        Me.btnXem_Chi_Tiet.TabIndex = 11
        Me.btnXem_Chi_Tiet.Text = "&Xem chi tiết"
        Me.btnXem_Chi_Tiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDuong_Thu
        '
        Me.lblDuong_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuong_Thu.Location = New System.Drawing.Point(8, 72)
        Me.lblDuong_Thu.Name = "lblDuong_Thu"
        Me.lblDuong_Thu.Size = New System.Drawing.Size(104, 16)
        Me.lblDuong_Thu.TabIndex = 5
        Me.lblDuong_Thu.Text = "Đường thư"
        '
        'btnTao_Du_Lieu
        '
        Me.btnTao_Du_Lieu.Image = CType(resources.GetObject("btnTao_Du_Lieu.Image"), System.Drawing.Image)
        Me.btnTao_Du_Lieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTao_Du_Lieu.Location = New System.Drawing.Point(232, 24)
        Me.btnTao_Du_Lieu.Name = "btnTao_Du_Lieu"
        Me.btnTao_Du_Lieu.Size = New System.Drawing.Size(96, 32)
        Me.btnTao_Du_Lieu.TabIndex = 4
        Me.btnTao_Du_Lieu.Text = "&Tạo dữ liệu"
        Me.btnTao_Du_Lieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkQTDenTheoChuyenBay
        '
        Me.chkQTDenTheoChuyenBay.Location = New System.Drawing.Point(160, 152)
        Me.chkQTDenTheoChuyenBay.Name = "chkQTDenTheoChuyenBay"
        Me.chkQTDenTheoChuyenBay.Size = New System.Drawing.Size(160, 24)
        Me.chkQTDenTheoChuyenBay.TabIndex = 17
        Me.chkQTDenTheoChuyenBay.Text = "QT đến theo chuyến bay"
        '
        'chkQTDenTheoNuocNgayKT
        '
        Me.chkQTDenTheoNuocNgayKT.Location = New System.Drawing.Point(8, 152)
        Me.chkQTDenTheoNuocNgayKT.Name = "chkQTDenTheoNuocNgayKT"
        Me.chkQTDenTheoNuocNgayKT.Size = New System.Drawing.Size(144, 24)
        Me.chkQTDenTheoNuocNgayKT.TabIndex = 16
        Me.chkQTDenTheoNuocNgayKT.Text = "QT đến theo ngày KT"
        '
        'chkDEN
        '
        Me.chkDEN.Location = New System.Drawing.Point(8, 128)
        Me.chkDEN.Name = "chkDEN"
        Me.chkDEN.Size = New System.Drawing.Size(72, 24)
        Me.chkDEN.TabIndex = 12
        Me.chkDEN.Text = "QT đến"
        '
        'chkDI
        '
        Me.chkDI.Location = New System.Drawing.Point(80, 128)
        Me.chkDI.Name = "chkDI"
        Me.chkDI.Size = New System.Drawing.Size(56, 24)
        Me.chkDI.TabIndex = 13
        Me.chkDI.Text = "QT đi"
        '
        'chkQG
        '
        Me.chkQG.Location = New System.Drawing.Point(144, 128)
        Me.chkQG.Name = "chkQG"
        Me.chkQG.Size = New System.Drawing.Size(80, 24)
        Me.chkQG.TabIndex = 14
        Me.chkQG.Text = "Quá giang"
        '
        'GrBox2
        '
        Me.GrBox2.Controls.Add(Me.UltraLabel7)
        Me.GrBox2.Controls.Add(Me.UltraLabel6)
        Me.GrBox2.Controls.Add(Me.txtFile_USPS)
        Me.GrBox2.Controls.Add(Me.btnThuc_Hien)
        Me.GrBox2.Controls.Add(Me.OptQuoTe)
        Me.GrBox2.Controls.Add(Me.OptHangKhong)
        Me.GrBox2.Controls.Add(Me.txtFile)
        Me.GrBox2.Controls.Add(Me.UltraLabel1)
        Me.GrBox2.Controls.Add(Me.PrbAccounting)
        Me.GrBox2.Controls.Add(Me.lbEMS)
        Me.GrBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBox2.Location = New System.Drawing.Point(424, 8)
        Me.GrBox2.Name = "GrBox2"
        Me.GrBox2.Size = New System.Drawing.Size(392, 208)
        Me.GrBox2.SupportThemes = False
        Me.GrBox2.TabIndex = 68
        Me.GrBox2.Text = "Thông tin kết xuất ra Access"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(16, 112)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel7.TabIndex = 72
        Me.UltraLabel7.Text = "D. vụ USPS"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 72)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel6.TabIndex = 71
        Me.UltraLabel6.Text = "D. vụ EMS"
        '
        'txtFile_USPS
        '
        Me.txtFile_USPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile_USPS.Location = New System.Drawing.Point(80, 112)
        Me.txtFile_USPS.Name = "txtFile_USPS"
        Me.txtFile_USPS.Size = New System.Drawing.Size(304, 21)
        Me.txtFile_USPS.TabIndex = 70
        Me.txtFile_USPS.Text = ""
        '
        'btnThuc_Hien
        '
        Me.btnThuc_Hien.Image = CType(resources.GetObject("btnThuc_Hien.Image"), System.Drawing.Image)
        Me.btnThuc_Hien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThuc_Hien.Location = New System.Drawing.Point(296, 56)
        Me.btnThuc_Hien.Name = "btnThuc_Hien"
        Me.btnThuc_Hien.Size = New System.Drawing.Size(88, 32)
        Me.btnThuc_Hien.TabIndex = 3
        Me.btnThuc_Hien.Text = "Thực &hiện"
        Me.btnThuc_Hien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThuc_Hien.Visible = False
        '
        'OptQuoTe
        '
        Me.OptQuoTe.Location = New System.Drawing.Point(200, 16)
        Me.OptQuoTe.Name = "OptQuoTe"
        Me.OptQuoTe.Size = New System.Drawing.Size(168, 24)
        Me.OptQuoTe.TabIndex = 1
        Me.OptQuoTe.Text = "Dữ liệu cho thanh toán QT"
        '
        'OptHangKhong
        '
        Me.OptHangKhong.Location = New System.Drawing.Point(8, 16)
        Me.OptHangKhong.Name = "OptHangKhong"
        Me.OptHangKhong.Size = New System.Drawing.Size(152, 24)
        Me.OptHangKhong.TabIndex = 0
        Me.OptHangKhong.Text = "Dữ liệu cho hàng không"
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl1)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl2)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl3)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl4)
        Me.tabControl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(0, 216)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabControl.Size = New System.Drawing.Size(816, 416)
        Me.tabControl.TabIndex = 72
        Me.tabControl.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab1.Key = "0"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Chuyến thư EMS Quốc tế đến"
        UltraTab2.Key = "1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Chuyến thư EMS đi Quốc tế"
        UltraTab3.Key = "2"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Chi tiết EMS Quốc tế quá giang"
        UltraTab4.Key = "3"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Chuyến thư USPS Quốc tế đến"
        Me.tabControl.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(812, 388)
        '
        'mnuMenu
        '
        Me.mnuMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTimKiem})
        '
        'mnuTimKiem
        '
        Me.mnuTimKiem.Index = 0
        Me.mnuTimKiem.Text = "Tìm Kiếm"
        '
        'UltraDataSource7
        '
        Me.UltraDataSource7.Band.Columns.AddRange(New Object() {UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95})
        Me.UltraDataSource7.Band.Key = "EMS_QT_DEN"
        '
        'lblThongTin
        '
        Me.lblThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongTin.Location = New System.Drawing.Point(8, 648)
        Me.lblThongTin.Name = "lblThongTin"
        Me.lblThongTin.Size = New System.Drawing.Size(144, 23)
        Me.lblThongTin.TabIndex = 73
        Me.lblThongTin.Text = "Tổng số dòng:"
        '
        'btnCuoc_Hang_Khong
        '
        Me.btnCuoc_Hang_Khong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuoc_Hang_Khong.Image = CType(resources.GetObject("btnCuoc_Hang_Khong.Image"), System.Drawing.Image)
        Me.btnCuoc_Hang_Khong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCuoc_Hang_Khong.Location = New System.Drawing.Point(344, 112)
        Me.btnCuoc_Hang_Khong.Name = "btnCuoc_Hang_Khong"
        Me.btnCuoc_Hang_Khong.Size = New System.Drawing.Size(72, 80)
        Me.btnCuoc_Hang_Khong.TabIndex = 74
        Me.btnCuoc_Hang_Khong.Text = "Quản lý Cước hàng không"
        Me.btnCuoc_Hang_Khong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'chkQTDenTheoNuocNgayDong
        '
        Me.chkQTDenTheoNuocNgayDong.Location = New System.Drawing.Point(8, 176)
        Me.chkQTDenTheoNuocNgayDong.Name = "chkQTDenTheoNuocNgayDong"
        Me.chkQTDenTheoNuocNgayDong.Size = New System.Drawing.Size(152, 24)
        Me.chkQTDenTheoNuocNgayDong.TabIndex = 18
        Me.chkQTDenTheoNuocNgayDong.Text = "QT đến theo ngày bay"
        '
        'FrmThongTinKeToan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 685)
        Me.Controls.Add(Me.btnCuoc_Hang_Khong)
        Me.Controls.Add(Me.lblThongTin)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.GrBox2)
        Me.Controls.Add(Me.GrBox1)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.BtnThoat)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "FrmThongTinKeToan"
        Me.Text = "Kết xuất thông tin Kế toán EMS Quốc tế ra Access"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ddBCG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEMS_QT_DEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.dgEMS_QT_DI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.dgEMS_QG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.dgUSPS_QT_DEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBox1.ResumeLayout(False)
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuong_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBox2.ResumeLayout(False)
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        CType(Me.UltraDataSource7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien su dung trong toan Form"
    'Lay thong tin trong SQL
    Private myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
    Private myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
    'Private myHam_Dung_Chung As New Ham_Dung_Chung
    'Thong tin EMS
    Private tblAccounting As New DataTable
    'Thong tin EMS Qua giang
    Private tblAccounting_Transit As New DataTable
    'Thong tin USPS
    Private tblAccountingUSPS As New DataTable
    'Luu Ten File Dich theo tung thang ke toan
    Private inFileName As String
    Private inFileName_USPS As String
    'Duong dan file MDB mau
    Private Const inPathFile As String = "C:\Ems_International\KeToanQT\"
    'Ten file MDB mau
    Private sFileName As String
    Private sFileName_USPS As String
    'Ket noi voi MDB
    Private gconMDB As New ADODB.Connection
    'Cau lenh SQL
    Private strSQL As String
    'Luu gia tri Tab nao duoc chon
    Private isTab As Integer
    'Lan dau tien khi load Form
    Private isFirst As Boolean = True
    'Bien Object
    Private myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private FrmTK As FrmTimKiemDanhMuc = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private myRow As Infragistics.Win.UltraWinGrid.UltraGridRow
    Private myThongTinKeToanChotSL As New Thong_Tin_Ke_Toan_Chot_SL(GConnectionString)
#End Region

#Region "Form Load"
    Private Sub FrmThongTinKeToan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tu ngay = Ngay dau tien cua thang hien tai
        CbTu_Ngay.Value = Ham_Dung_Chung.dBeginMonth(Date.Now)
        'Den ngay = ngay hien tai
        CbDen_Ngay.Value = Now().Date
        'Load du lieu cho cbDuong_Thu theo chieu
        Get_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        'Load du lieu cho cbChuyen_Thu theo Chieu Dong va theo Duong Thu
        Get_Chuyen_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab, cbDuong_Thu.Value)
        'Load du lieu cho DgBCG
        ddBCG_Load_Data()
        'Defaul tab Qte den
        isTab = 0
        'Load du lieu cho cbLoai_Chuyen_Thu
        Get_Loai_CT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        'Load du lieu cho DataGrid
        Refresh_Data_Grid()
        'Gan lai bien isFisrt
        isFirst = False
        'Defaul value cho txtFile = ""
        txtFile.Text = ""
        'Dat Status cho Group Box File Access
        'GrBox2.Enabled = False
        'Khong cho Active btnThuc_Hien khi chua chon duong dan File dich 
        btnThuc_Hien.Enabled = False
        'Focus vao cbTu_Ngay khi Form Load
        CbTu_Ngay.Select()
        'Default la lay du lieu cho hang khong
        OptHangKhong.Checked = True
    End Sub
#End Region

#Region "Cac event cua doi tuong tren Form"
    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        If OptHangKhong.Checked = True Then
            If MessageBox.Show("Bạn đang chọn kết xuất dữ liệu cho Hàng không?", "Xác nhận thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                Exit Sub
            End If
        Else
            If MessageBox.Show("Bạn đang chọn kết xuất dữ liệu cho thanh toán Quốc tế?", "Xác nhận thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                Exit Sub
            End If
        End If
        'GrBox2.Enabled = True
        Select Case GBuu_Cuc_Khai_Thac.ToString 'Case Mid(GBuu_Cuc_Khai_Thac.ToString, 1, 3)
            Case "100915"   'Ha Noi  -  Ten File:   VMS1
                sFileName = "VPS1_EMS"
                sFileName_USPS = "VPS1_USPS"
            Case "100914"   'Ha Noi  -  Ten File:   VMS1
                sFileName = "VPS1_EMS"
                sFileName_USPS = "VPS1_USPS"
            Case "140708"   'Ha Noi  -  Ten File:   VMS1
                sFileName = "VPS1_EMS"
                sFileName_USPS = "VPS1_USPS"
            Case "700915"   'Ho Chi Minh  -  Ten_File:    VMS2
                sFileName = "VPS2_EMS"
                sFileName_USPS = "VPS2_USPS"
            Case "700914"   'Ho Chi Minh  -  Ten_File:    VMS2
                sFileName = "VPS2_EMS"
                sFileName_USPS = "VPS2_USPS"
        End Select
        'Lay ten file dich tu cbTu_Ngay
        If OptHangKhong.Checked = True Then  'Neu lay du lieu cho Hang khong
            inFileName = sFileName & "_" & CbTu_Ngay.DateTime.Month.ToString("00") & "_" & CbTu_Ngay.DateTime.Year
            inFileName_USPS = sFileName_USPS & "_" & CbTu_Ngay.DateTime.Month.ToString("00") & "_" & CbTu_Ngay.DateTime.Year
        Else   'Lay du lieu cho thanh toan quoc te (ten_file = "****_TT.MDB"
            inFileName = sFileName & "_" & CbTu_Ngay.DateTime.Month.ToString("00") & "_" & CbTu_Ngay.DateTime.Year & "_TT"
            inFileName_USPS = sFileName_USPS & "_" & CbTu_Ngay.DateTime.Month.ToString("00") & "_" & CbTu_Ngay.DateTime.Year & "_TT"
        End If
        '=========EMS===============
        'Open SaveDialog
        With sFileDlg
            .InitialDirectory = inPathFile
            .FileName = inFileName
            .Title = "Chon ten File"
            .DefaultExt = "*.mdb"
            .Filter = "Mdb (*.mdb)|*.mdb"
            .ShowDialog()
        End With
        'Lay ten file dich theo lua chon cua nguoi dung tu savedialog
        If InStr(sFileDlg.FileName, "\", CompareMethod.Text) <> 0 Then
            txtFile.Text = sFileDlg.FileName
        End If

        '=========USPS===============
        'Open SaveDialog
        With sFileDlg
            .InitialDirectory = inPathFile
            .FileName = inFileName_USPS
            .Title = "Chon ten File"
            .DefaultExt = "*.mdb"
            .Filter = "Mdb (*.mdb)|*.mdb"
            .ShowDialog()
        End With
        'Lay ten file dich theo lua chon cua nguoi dung tu savedialog
        If InStr(sFileDlg.FileName, "\", CompareMethod.Text) <> 0 Then
            txtFile_USPS.Text = sFileDlg.FileName
        End If

        If txtFile.Text.Trim <> "" And txtFile_USPS.Text.Trim <> "" Then   'Neu file la hop le, active btThuc_Hien
            'btnThuc_Hien.Enabled = True
            'btnThuc_Hien.Select()
            btnThuc_Hien_Click(btnThuc_Hien, e)
        Else  'Neu khong hop le , Not Active btThuc_Hien
            'btnThuc_Hien.Enabled = False
            btnFile.Select()
        End If
    End Sub
    Private Sub txtFile_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFile.GotFocus
        txtFile.SelectionStart = 0
        txtFile.SelectionLength = Len(txtFile.Text)
    End Sub
    Private Sub BtnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThoat.Click
        Close()
    End Sub
    Private Sub btnThuc_Hien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThuc_Hien.Click
        Dim strPath As String    'Luu thu muc chua file dich
        Dim strPath_USPS As String    'Luu thu muc chua file dich
        strPath = Directory.GetParent(txtFile.Text).ToString
        strPath_USPS = Directory.GetParent(txtFile_USPS.Text).ToString
        'Kiem tra xem thu muc co ton tai khong
        If Directory.Exists(strPath) = False Then
            MsgBox("Không tồn tại thư mục [" & strPath & "] trên máy tính của bạn, Mời bạn chọn lại", MsgBoxStyle.Information, "Thông báo")
            btnFile.Select()
            Exit Sub
        End If
        If Directory.Exists(strPath_USPS) = False Then
            MsgBox("Không tồn tại thư mục [" & strPath_USPS & "] trên máy tính của bạn, Mời bạn chọn lại", MsgBoxStyle.Information, "Thông báo")
            btnFile.Select()
            Exit Sub
        End If
        'Kiem tra ngay nhap vao co hop le khong
        If CbTu_Ngay.Value > CbDen_Ngay.Value Then
            MsgBox("Từ ngày không được lớn hơn đến ngày, mời nhập lại thông tin ngày tháng", MsgBoxStyle.Information, "Thông báo")
            CbTu_Ngay.Select()
            Exit Sub
        End If
        'Neu da ton tai File dich roi thi xoa
        If File.Exists(txtFile.Text) = True Then
            File.Delete(txtFile.Text)
        End If
        If File.Exists(txtFile_USPS.Text) = True Then
            File.Delete(txtFile_USPS.Text)
        End If

        'Ket noi MDB, lay du lieu tu SQL va insert vao MDB
        If GetData() = False Then
            Exit Sub
        Else
            File.Copy(inPathFile & sFileName & ".MDB", txtFile.Text)
            If MessageBox.Show("Bạn có muốn in bản kê chi tiết <EMS> bây giờ không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'EMS Chieu den
                Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                'Ban ke tong hop chieu den
                Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                'EMS Chieu Di
                Common.Ban_Ke_Ke_Toan_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                'EMS Qua Giang
                Common.Ban_Ke_Ke_Toan_EMS_Qua_Giang(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                'Ban ke tong hop chieu di
                Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            End If
        End If

        'Khong cho Active btnTHUC_HIEN sau khi da click
        'GrBox2.Enabled = False
        'btnThuc_Hien.Enabled = False
        'Chuyen File mau thanh file dich

        If GetData_USPS() = False Then
            Exit Sub
        Else
            File.Copy(inPathFile & sFileName & ".MDB", txtFile_USPS.Text)
            If MessageBox.Show("Bạn có muốn in bản kê chi tiết <USPS> bây giờ không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'EMS Chieu den
                Common.Ban_Ke_Ke_Toan_USPS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                'Ban ke tong hop chieu den
                Common.Ban_Ke_Ke_Toan_TH_USPS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                ''EMS Chieu Di
                'Common.Ban_Ke_Ke_Toan_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                ''EMS Qua Giang
                'Common.Ban_Ke_Ke_Toan_EMS_Qua_Giang(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
                ''Ban ke tong hop chieu di
                'Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            End If
        End If

        'Focus vao cbTu_Ngay sau khi da hoan tat cong viec
        CbTu_Ngay.Select()
        'Close()
    End Sub
    Private Sub btnTao_Du_Lieu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTao_Du_Lieu.Click
        'Kiem tra chot so lieu
        Dim mId_Thang As String
        Dim mChot_SL_Den As Boolean
        Dim mChot_SL_Di As Boolean
        Dim mChot_SL_QG As Boolean
        'Chieu Den
        mId_Thang = Create_Id_Thang(CbTu_Ngay.Value, CbDen_Ngay.Value, 0)
        If myThongTinKeToanChotSL.Thong_Tin_Ke_Toan_Chot_SL_Lay(mId_Thang).Chot_SL Then
            mChot_SL_Den = True
            MessageBox.Show("Dữ liệu chiều đến trong tháng đã được chốt số liệu, vì vậy không thể tạo lại dữ liệu chiều đến." & vbNewLine & "Dữ liệu khác vẫn được tạo lại bình thường nếu chưa chốt số liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            mChot_SL_Den = False
        End If
        'Chieu Di
        mId_Thang = Create_Id_Thang(CbTu_Ngay.Value, CbDen_Ngay.Value, 1)
        If myThongTinKeToanChotSL.Thong_Tin_Ke_Toan_Chot_SL_Lay(mId_Thang).Chot_SL Then
            mChot_SL_Di = True
            MessageBox.Show("Dữ liệu chiều đi trong tháng đã được chốt số liệu, vì vậy không thể tạo lại dữ liệu chiều đi." & vbNewLine & "Dữ liệu khác vẫn được tạo lại bình thường nếu chưa chốt số liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            mChot_SL_Di = False
        End If
        'Qua Giang
        mId_Thang = Create_Id_Thang(CbTu_Ngay.Value, CbDen_Ngay.Value, 2)
        If myThongTinKeToanChotSL.Thong_Tin_Ke_Toan_Chot_SL_Lay(mId_Thang).Chot_SL Then
            mChot_SL_QG = True
            MessageBox.Show("Dữ liệu quá giang chiều đi trong tháng đã được chốt số liệu, vì vậy không thể tạo lại dữ liệu quá giang chiều đi." & vbNewLine & "Dữ liệu khác vẫn được tạo lại bình thường nếu chưa chốt số liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            mChot_SL_QG = False
        End If
        'Neu ca 3 loai deu da duoc khoa
        If mChot_SL_Den = True And mChot_SL_Di = True And mChot_SL_QG = True Then
            MessageBox.Show("Toàn bộ dữ liệu đến, đi , quá giang đã được khoá, vì vậy bạn không được phép tạo lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Hoi lai nguoi dung truoc khi tao du lieu
        If MessageBox.Show("Bạn có chắc chắn muốn tạo dữ liệu không ???" & Chr(13) & "Chú ý nếu đồng ý, dữ liệu đã tạo trước đó sẽ bị xoá và thay bằng dữ liệu mới." & vbNewLine & "Dữ liệu được tổng hợp sẽ mất một vài phút, mời bạn chờ cho đến khi có thông báo kết thúc.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        'Dat lai trang thai cho Mouse
        FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.WaitCursor
        'Lay du lieu trong SQL
        'Loc du lieu va Insert vao 2 bang: Accounting va Accounting_Transit 
        If (myKe_Toan_Ca_QT.Lay_Thong_Tin_Ke_Toan(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), mChot_SL_Den, mChot_SL_Di, mChot_SL_QG) > 0) Then
            'Dat lai trang thai cho Mouse
            FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
            MsgBox("Tạo dữ liệu kế toán quốc tế thành công", MsgBoxStyle.Information, "Thông báo")
            Refresh_Data_Grid_ALL(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime))
        Else
            MsgBox("Không có dữ liệu kế toán, tạo dữ liệu thất bại", MsgBoxStyle.Information, "Thông báo")
            'Dat lai trang thai cho Mouse
            FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
        End If
    End Sub
    Private Sub tabControl_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabControl.SelectedTabChanged
        isTab = e.Tab.Index
        If isTab = 2 Then
            cbLoai_Chuyen_Thu.Enabled = False
            lblDuong_Thu.Text = "Nước quá giang"
            lblDuong_Thu.Refresh()
        Else
            If isTab = 0 Then
                ddBCG_Load_Data()
            End If
            cbLoai_Chuyen_Thu.Enabled = True
            lblDuong_Thu.Text = "Đường thư"
            lblDuong_Thu.Refresh()
        End If
        'Load du lieu cho cbDuong_Thu theo chieu
        Get_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        'Load du lieu cho cbChuyen_Thu theo Chieu Dong va theo Duong Thu
        Get_Chuyen_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab, cbDuong_Thu.Value)
        'Load du lieu cho cbLoai_Chuyen_Thu theo Chieu Dong 
        If isTab <> 2 Then
            Get_Loai_CT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        End If
        'Khong Load du lieu vao grid cho lan dau tien khi form load
        If isFirst = False Then
            Refresh_Data_Grid()
        End If
    End Sub
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Select Case isTab
            Case 0  'EMS QT Den
                If chkQTDenTheoNuocNgayKT.Checked = True Then ' EMs QT đến theo nước và ngày khai thác
                    Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Nuoc_Ngay_KT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                    Exit Sub
                End If

                If chkQTDenTheoChuyenBay.Checked = True Then ' EMS QT đến theo chuyến bay và ngày đóng
                    Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Chuyen_Bay_Ngay_Dong(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                    Exit Sub
                End If

                If chkQTDenTheoNuocNgayDong.Checked = True Then
                    Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Nuoc_Ngay_Dong(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                    Exit Sub
                End If

                Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                Common.Bao_Cao_Tong_Hop_San_Luong_EMS_QT(True, Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
            Case 1  'EMS QT Di
                Common.Ban_Ke_Ke_Toan_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                Common.Bao_Cao_Tong_Hop_San_Luong_EMS_QT(False, Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
            Case 2  'EMS Qua Giang
                Common.Ban_Ke_Ke_Toan_EMS_Qua_Giang(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
            Case 3  'USPS QT Den
                Common.Ban_Ke_Ke_Toan_USPS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                Common.Ban_Ke_Ke_Toan_TH_USPS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
                'Common.Bao_Cao_Tong_Hop_San_Luong_EMS_QT(True, Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 1)
        End Select
    End Sub
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Select Case isTab
            Case 0  'EMS QT Den
                Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), False, 1)
                Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), False, 1)
            Case 1  'EMS QT Di
                Common.Ban_Ke_Ke_Toan_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), False, 1)
                Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), False, 1)
            Case 2  'EMS Qua Giang
                Common.Ban_Ke_Ke_Toan_EMS_Qua_Giang(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), False, 1)
            Case 3  'USPS QT Den
                Common.Ban_Ke_Ke_Toan_USPS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), False, 1)
                Common.Ban_Ke_Ke_Toan_TH_USPS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), False, 1)
        End Select
    End Sub
    Private Sub btnXem_Chi_Tiet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXem_Chi_Tiet.Click
        Refresh_Data_Grid()
    End Sub

#Region "dgEMS_QT_DEN"
#Region "dgEMS_QT_DEN_MouseDown"
    Private Sub dgEMS_QT_DEN_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgEMS_QT_DEN.MouseDown, dgEMS_QT_DI.MouseDown, dgEMS_QG.MouseDown, dgUSPS_QT_DEN.MouseDown
        myGridKeyDown = sender
        If e.Button = MouseButtons.Right Then
            Dim oHeaderUI As Infragistics.Win.UltraWinGrid.HeaderUIElement
            Dim oUIElement As Infragistics.Win.UIElement
            Dim point As point = New point(e.X, e.Y)

            oUIElement = Me.myGridKeyDown.DisplayLayout.UIElement.ElementFromPoint(point)
            If oUIElement Is Nothing Then Exit Sub
            oUIElement = oUIElement.GetAncestor(GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement))
            If oUIElement Is Nothing Then
                Return
            End If
            If Not oUIElement.GetType() Is GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement) Then Exit Sub
            oHeaderUI = oUIElement
            Dim oColHeader As Infragistics.Win.UltraWinGrid.ColumnHeader = Nothing
            Me.myColumn = Nothing
            oColHeader = oHeaderUI.SelectableItem
            Me.myColumn = oColHeader.Column
            If Me.myColumn Is Nothing Then Exit Sub

            Me.mnuMenu.Show(Me.myGridKeyDown, point)
        End If
    End Sub
#End Region
#Region "dgEMS_QT_DEN_AfterRowUpdate"
    Private Sub dgEMS_QT_DEN_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgEMS_QT_DEN.AfterRowUpdate
        If MessageBox.Show("Bạn vừa cập nhật thông tin trong bảng EMS quốc tế đến" & Chr(13) & "Bạn có chắc chắn về sự thay đổi này không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            myKe_Toan_Ca_QT.Accounting_Cap_Nhat_Them(IIf(e.Row.Cells("Acc_key").Value Is System.DBNull.Value, 0, e.Row.Cells("Acc_key").Value), e.Row.Cells("ID").Value, e.Row.Cells("NGAY").Value, e.Row.Cells("SCT").Value, e.Row.Cells("BCG").Value, e.Row.Cells("BCN").Value, e.Row.Cells("KL_EMS").Value, e.Row.Cells("Loai_D").Value, e.Row.Cells("Loai_M").Value, e.Row.Cells("Loai_R").Value, e.Row.Cells("Notice").Value, e.Row.Cells("HVC").Value, e.Row.Cells("I_O").Value)
        Else
            Refresh_Data_Grid()
        End If
    End Sub
#End Region
#Region "dgEMS_QT_DEN_InitializeTemplateAddRow"
    Private Sub dgEMS_QT_DEN_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgEMS_QT_DEN.InitializeTemplateAddRow
        SetDefaultValueDgEMS_QT_DEN(sender)
    End Sub
#End Region
#Region "dgEMS_QT_DEN_AfterExitEditMode"
    Private Sub dgEMS_QT_DEN_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgEMS_QT_DEN.AfterExitEditMode
        myGridKeyDown = sender
        'BCN - Buu cuc nhan
        If myGridKeyDown.ActiveRow.Cells("BCN").Value Is System.DBNull.Value And myGridKeyDown.ActiveRow.Index <> 0 Then
            myGridKeyDown.ActiveRow.Cells("BCN").Value = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells("BCN").Value
        End If
        'BCG - Buu cuc gui
        If myGridKeyDown.ActiveRow.Cells("BCG").Value Is System.DBNull.Value And myGridKeyDown.ActiveRow.Index <> 0 Then
            myGridKeyDown.ActiveRow.Cells("BCG").Value = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells("BCG").Value
        End If
        'Lay ten buu cuc theo ma bc da chon (BCG)
        If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "BCG" And myGridKeyDown.ActiveCell.Text <> "" Then
            myGridKeyDown.ActiveRow.Cells("Ten_BCG").Value = myDanh_Muc_BC.Lay(CInt(myGridKeyDown.ActiveRow.Cells("BCG").Text & "0")).Ten_Buu_Cuc
        End If

    End Sub
#End Region
#Region "dgEMS_QT_DEN_BeforeCellDeactivate"
    Private Sub dgEMS_QT_DEN_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgEMS_QT_DEN.BeforeCellDeactivate
        myGridKeyDown = sender
        If myGridKeyDown.ActiveCell Is Nothing Then
            Exit Sub
        End If
        Select Case UCase(myGridKeyDown.ActiveCell.Column.Key)
            Case "NGAY"
                If Not IsDate(myGridKeyDown.ActiveCell.Value) Then
                    MessageBox.Show("Ngày nhập vào không đúng định dạng!!!" & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    e.Cancel = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
                'Case "SCT"
                '    If Not IsNumeric(myGridKeyDown.ActiveCell.Text) Then
                '        MessageBox.Show("Số chuyến thư không đúng định dạng!!!" & Chr(13) & "Số chuyến thư phải là số nguyên hoặc nếu là chuyến thư sai nhãn thì nhập số chuyến thư = 0" & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                '        e.Cancel = True
                '        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                '    End If
            Case "KL_EMS"
                If Not IsNumeric(myGridKeyDown.ActiveCell.Text) Then
                    MessageBox.Show("Khối lượng bưu phẩm không đúng định dạng!!!" & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    e.Cancel = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case "LOAI_D"
                If Not IsNumeric(myGridKeyDown.ActiveCell.Text) Then
                    MessageBox.Show("Số lượng loại D nhập vào không đúng định dạng!!!" & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    e.Cancel = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case "LOAI_M"
                If Not IsNumeric(myGridKeyDown.ActiveCell.Text) Then
                    MessageBox.Show("Số lượng loại M nhập vào không đúng định dạng!!!" & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    e.Cancel = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case "LOAI_R"
                If Not IsNumeric(myGridKeyDown.ActiveCell.Text) Then
                    MessageBox.Show("Số lượng loại R nhập vào không đúng định dạng!!!" & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    e.Cancel = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
        End Select
    End Sub
#End Region
#Region "dgEMS_QT_DEN_InitializeLayout"
    Private Sub dgEMS_QT_DEN_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgEMS_QT_DEN.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        With myGridKeyDown.DisplayLayout.Bands(0)
            'BCG
            .Columns("BCG").Style = ColumnStyle.DropDown
            .Columns("BCG").ValueList = ddBCG
            '.Columns("BCG").DefaultCellValue = myMa_Nuoc_Di
        End With
        Refresh_Thong_Tin(myGridKeyDown)
    End Sub
#End Region
#Region "dgEMS_QT_DEN_KeyDown"
    Private Sub dgEMS_QT_DEN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgEMS_QT_DEN.KeyDown
        myGridKeyDown = sender
        Select Case e.KeyValue
            Case Keys.Escape
                If myGridKeyDown.ActiveRow.Cells("Ngay").Value Is DBNull.Value Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.Home
                If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                    If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                        e.Handled = False
                        myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Else
                    e.Handled = False
                    myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case Keys.End
                If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                    If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                        e.Handled = False
                        myGridKeyDown.PerformAction(LastCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Else
                    e.Handled = False
                    myGridKeyDown.PerformAction(LastCellInRow, False, True)
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case Keys.F8
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Acc_Key").Text <> "" Then
                    If MessageBox.Show("Bạn có thực sự muốn xóa chuyến thư này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                        myKe_Toan_Ca_QT.Accounting_Xoa(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Acc_Key").Value)
                        myGridKeyDown.ActiveRow.Delete(False)
                        CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub
#End Region
#End Region

#Region "dgUSPS_QT_DEN"
#Region "dgEMS_QT_DEN_InitializeLayout"
    Private Sub dgUSPS_QT_DEN_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgUSPS_QT_DEN.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        With myGridKeyDown.DisplayLayout.Bands(0)
            'BCG
            .Columns("BCG").Style = ColumnStyle.DropDown
            .Columns("BCG").ValueList = ddBCG
            '.Columns("BCG").DefaultCellValue = myMa_Nuoc_Di
        End With
        Refresh_Thong_Tin(myGridKeyDown)
    End Sub
#End Region
#Region "dgUSPS_QT_DEN_KeyDown"
    Private Sub dgUSPS_QT_DEN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgUSPS_QT_DEN.KeyDown
        myGridKeyDown = sender
        Select Case e.KeyValue
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.Home
                If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                    If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                        e.Handled = False
                        myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Else
                    e.Handled = False
                    myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case Keys.End
                If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                    If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                        e.Handled = False
                        myGridKeyDown.PerformAction(LastCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Else
                    e.Handled = False
                    myGridKeyDown.PerformAction(LastCellInRow, False, True)
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case Keys.F8
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Acc_Key").Text <> "" Then
                    If MessageBox.Show("Bạn có thực sự muốn xóa chuyến thư này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                        myKe_Toan_Ca_QT.Accounting_USPS_Xoa(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Acc_Key").Value)
                        myGridKeyDown.ActiveRow.Delete(False)
                        CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub
#End Region
#End Region

#Region "dgEMS_QT_DI  &  dgEMS_QT_QG"
    Private Sub dgEMS_QG_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgEMS_QG.AfterCellUpdate
        If e.Cell.Column.Key.ToUpper = "NOTICE" Then
            myKe_Toan_Ca_QT.Accounting_Transit_Cap_Nhat_Notice(e.Cell.Row.Cells("ID").Value, e.Cell.Row.Cells("NOTICE").Text)
        End If
    End Sub
    Private Sub dgEMS_QT_DI_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgEMS_QT_DI.AfterCellUpdate
        If e.Cell.Column.Key = "NOTICE" Then
            myKe_Toan_Ca_QT.Accounting_Cap_Nhat_Notice(e.Cell.Row.Cells("Acc_Key").Value, e.Cell.Row.Cells("NOTICE").Text)
        End If
    End Sub
    Private Sub dgEMS_QT_DI_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgEMS_QT_DI.InitializeLayout, dgEMS_QG.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        Refresh_Thong_Tin(myGridKeyDown)
    End Sub
    Private Sub dgEMS_QT_DI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgEMS_QT_DI.KeyDown, dgEMS_QG.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.Home
                If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                    If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                        e.Handled = False
                        myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Else
                    e.Handled = False
                    myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
            Case Keys.End
                If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                    If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                        e.Handled = False
                        myGridKeyDown.PerformAction(LastCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Else
                    e.Handled = False
                    myGridKeyDown.PerformAction(LastCellInRow, False, True)
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                End If
        End Select
    End Sub
#End Region
#Region "cbTu_Ngay"
    Private Sub CbTu_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbTu_Ngay.KeyDown
        If e.KeyValue = Keys.Enter Then
            CbDen_Ngay().Select()
        End If
    End Sub
    Private Sub CbTu_Ngay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTu_Ngay.Validated
        'Load du lieu cho cbDuong_Thu theo chieu
        Get_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        'Load du lieu cho cbChuyen_Thu theo Chieu Dong va theo Duong Thu
        Get_Chuyen_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab, cbDuong_Thu.Value)
        'Load du lieu cho cbLoai_Chuyen_Thu theo Chieu Dong 
        If isTab <> 2 Then
            Get_Loai_CT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        End If
    End Sub
#End Region
#Region "cbDen_Ngay"
    Private Sub CbDen_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbDen_Ngay.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnTao_Du_Lieu.Select()
        End If
    End Sub
    Private Sub CbDen_Ngay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbDen_Ngay.Validated
        'Load du lieu cho cbDuong_Thu theo chieu
        Get_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        'Load du lieu cho cbChuyen_Thu theo Chieu Dong va theo Duong Thu
        Get_Chuyen_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab, cbDuong_Thu.Value)
        'Load du lieu cho cbLoai_Chuyen_Thu theo Chieu Dong 
        If isTab <> 2 Then
            Get_Loai_CT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab)
        End If
    End Sub
#End Region
#Region "cbSo_Chuyen_Thu"
    Private Sub cbSo_Chuyen_Thu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbSo_Chuyen_Thu.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnXem_Chi_Tiet.Select()
        End If
    End Sub
    Private Sub cbSo_Chuyen_Thu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSo_Chuyen_Thu.Validated
        If cbDuong_Thu.Value <> Nothing Or cbSo_Chuyen_Thu.Value <> Nothing Then
            btnPreview.Enabled = False
            btnPrint.Enabled = False
        Else
            btnPreview.Enabled = True
            btnPrint.Enabled = True
        End If
    End Sub
#End Region
#Region "cbDuong_Thu"
    Private Sub cbDuong_Thu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuong_Thu.Validated
        Get_Chuyen_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), isTab, cbDuong_Thu.Value)
        If cbDuong_Thu.Value <> Nothing Or cbSo_Chuyen_Thu.Value <> Nothing Then
            btnPreview.Enabled = False
            btnPrint.Enabled = False
        Else
            btnPreview.Enabled = True
            btnPrint.Enabled = True
        End If
    End Sub
    Private Sub cbDuong_Thu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbDuong_Thu.KeyDown
        If e.KeyValue = Keys.Enter Then
            cbSo_Chuyen_Thu.Select()
        End If
    End Sub
#End Region
#Region "btnChotSL_Click"
    Private Sub btnChotSL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChotSL.Click
        Dim mId_Thang As String
        Dim mTu_Ngay As Integer
        Dim mDen_Ngay As Integer
        Dim mPhan_Loai As Integer
        Dim mDataTable As New DataTable
        'Kiem tra nguoi dung khong check
        If chkDEN.Checked = False And chkDI.Checked = False And chkQG.Checked = False Then
            MessageBox.Show("Khoá số liệu thất bại. Bạn chưa chọn loại dữ liệu nào cần khoá số liệu!!!" & vbNewLine & _
                            "Mời bạn chọn bằng cách tích vào ô vuông tương ứng với loại dữ liệu mà bạn muốn khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        mTu_Ngay = Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        mDen_Ngay = Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        'Chieu den
        If chkDEN.Checked Then
            mDataTable = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(mTu_Ngay, mDen_Ngay, 0).Tables(0)
            If mDataTable.Rows.Count = 0 Then
                MessageBox.Show("Chưa có dữ liệu chiều đến trong tháng, vì vậy không thực hiện được việc chốt số liệu cho chiều đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                mPhan_Loai = 0
                mId_Thang = Create_Id_Thang(CbTu_Ngay.Value, CbDen_Ngay.Value, mPhan_Loai)
                myThongTinKeToanChotSL.Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat_Them(mId_Thang, mPhan_Loai, True)
                MessageBox.Show("Chốt số liệu chiều đến thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Chieu_Di
        If chkDI.Checked Then
            mDataTable = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(mTu_Ngay, mDen_Ngay, 1).Tables(0)
            If mDataTable.Rows.Count = 0 Then
                MessageBox.Show("Chưa có dữ liệu chiều đi trong tháng, vì vậy không thực hiện được việc chốt số liệu cho chiều đi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                mPhan_Loai = 1
                mId_Thang = Create_Id_Thang(CbTu_Ngay.Value, CbDen_Ngay.Value, mPhan_Loai)
                myThongTinKeToanChotSL.Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat_Them(mId_Thang, mPhan_Loai, True)
                MessageBox.Show("Chốt số liệu chiều đi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Qua giang
        If chkQG.Checked Then
            mDataTable = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay).Tables(0)
            If mDataTable.Rows.Count = 0 Then
                MessageBox.Show("Chưa có dữ liệu quá giang chiều đi trong tháng, vì vậy không thực hiện được việc chốt số liệu cho quá giang chiều đi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                mPhan_Loai = 2
                mId_Thang = Create_Id_Thang(CbTu_Ngay.Value, CbDen_Ngay.Value, mPhan_Loai)
                myThongTinKeToanChotSL.Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat_Them(mId_Thang, mPhan_Loai, True)
                MessageBox.Show("Chốt số liệu quá giang thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region
#End Region

#Region "Cac ham nguoi dung viet"
#Region "-----------------------Search-----------------------"

    Private Sub mnuTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTimKiem.Click
        If Me.FrmTK Is Nothing Then
            Me.FrmTK = New FrmTimKiemDanhMuc
        End If
        Me.FrmTK.ShowMe(Me, myGridKeyDown, "")
    End Sub

    Private Function Match(ByVal userString As String, ByVal cellValue As String) As Boolean
        If userString.Length > cellValue.Length Then
            Match = False
            Exit Function
        ElseIf userString.Length = cellValue.Length Then
            If userString.ToLower = cellValue.ToLower Then Match = True Else Match = False
            Exit Function
        Else
            Dim i As Integer
            For i = 0 To (cellValue.Length - userString.Length) - 0
                If userString.ToLower = cellValue.ToLower.Substring(i, userString.Length) Then
                    Match = True
                    Exit Function
                End If
            Next
            Match = False
            Exit Function
        End If
    End Function
    Private Function MatchText(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal oRow As Infragistics.Win.UltraWinGrid.UltraGridRow, ByVal _myString As String) As Boolean
        If oRow Is Nothing Then
            MatchText = False
            Exit Function
        End If
        Dim oCol As Infragistics.Win.UltraWinGrid.UltraGridColumn
        Dim strCellValue As String = ""
        For Each oCol In _myGrid.DisplayLayout.Bands(0).Columns
            If Not oRow.Cells(oCol.Key).Value Is System.DBNull.Value Then
                If Me.Match(_myString, oRow.Cells(oCol.Key).Value) Then
                    MatchText = True
                    Me.myColumn = oCol
                    Exit Function
                End If
            End If
        Next
    End Function
    Public Sub Search(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal _myString As String)
        Dim oRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        oRow = _myGrid.ActiveRow
        If oRow Is Nothing Then oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)

        While Not oRow Is Nothing
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                End If
                Exit Sub
            End If
        End While
        oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)
        While Not oRow Is Nothing
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                End If
                Exit Sub
            End If
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
        End While
        MessageBox.Show("Đã tìm kiếm hết danh sách rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub
#End Region
#Region "Lay du lieu tu SQL ghi vao File Access"
    Private Function GetData() As Boolean
        'Dat lai trang thai cho Mouse
        FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.WaitCursor
        'Ket noi voi MDB
        Try
            gconMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & inPathFile & sFileName & ".MDB" & ";Persist Security Info=False"
            gconMDB.Open()
        Catch
            'Dat lai trang thai cho Mouse
            FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
            MsgBox("Không kết nối được với File Access, Kiểm tra xem đã tồn tại file: " & inPathFile & sFileName & ".MDB" & " chưa!!!", MsgBoxStyle.Information, "Thông báo")
            CbTu_Ngay.Select()
            Return False
            Exit Function
        End Try

        'Xoa du lieu trong bang EMS
        strSQL = "Delete * From EMS"
        gconMDB.Execute(strSQL)
        'Xoa du lieu trong bang EMS_QG
        strSQL = "Delete * From EMS_QG"
        gconMDB.Execute(strSQL)

        ''Lay du lieu trong SQL----------------------
        ''Loc du lieu va Insert vao 2 bang: Accounting va Accounting_Transit 
        'myKe_Toan_Ca_QT.Lay_Thong_Tin_Ke_Toan(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value))
        '----------------------------------------------------------------------------------------
        'Lay du lieu tu bang Accounting
        tblAccounting = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)).Tables(0)
        'Lay du lieu tu bang Accounting_Transit
        tblAccounting_Transit = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)).Tables(0)

        'Kiem tra trang thai
        If tblAccounting.Rows.Count <= 0 And tblAccounting_Transit.Rows.Count <= 0 Then
            MsgBox("Không có dữ liệu EMS", MsgBoxStyle.Information, "Thông báo")
            Return False
        Else
            If tblAccounting.Rows.Count > 0 Then   'Insert vao bang EMS (Hang_Khong Or Thanh_Toan_QT)
                InsertToEMS(tblAccounting, tblAccounting.Rows.Count - 1, OptHangKhong.Checked)
            End If
            If tblAccounting_Transit.Rows.Count > 0 Then  'Insert vao bang EMS_QG
                InsertToEMS_QG(tblAccounting_Transit, tblAccounting_Transit.Rows.Count - 1)
            End If
            'Gna lai Label thong tin sau khi hoan tat
            lbEMS.Text = "Dữ liệu EMS :  " & tblAccounting.Rows.Count & "      Dữ liệu EMS Quá giang :  " & tblAccounting_Transit.Rows.Count
            'Dong connection
            gconMDB.Close()
            'Dat lai trang thai Mouse
            FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
            'Thong bao cho nguoi dung
            MsgBox("Dữ liệu EMS phục vụ cho kế toán đã tạo thành công" & vbNewLine & "File kết quả lưu tại : " & txtFile.Text, MsgBoxStyle.Information, "Thông báo")
            'If MessageBox.Show("Bạn có muốn in bản kê chi tiết bây giờ không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            '    'EMS Chieu den
            '    Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'Ban ke tong hop chieu den
            '    Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'EMS Chieu Di
            '    Common.Ban_Ke_Ke_Toan_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'EMS Qua Giang
            '    Common.Ban_Ke_Ke_Toan_EMS_Qua_Giang(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'Ban ke tong hop chieu di
            '    Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            'End If
            'Close()
            'Dat lai trang thai cho Mouse
            'FrmThongTinKeToan.ActiveForm.Cursor = Cursors.Default
            Return True
        End If
    End Function

    Private Sub InsertToEMS(ByVal myTable As DataTable, ByVal TongSoBanGhi As Integer, ByVal OptLoai As Boolean)
        Dim i As Integer
        PrbAccounting.Maximum = myTable.Rows.Count
        PrbAccounting.Step = 1
        PrbAccounting.Value = 0
        For i = 0 To TongSoBanGhi
            strSQL = "Insert Into EMS (NGAY, SCT, BCG, BCN, KL_EMS, LOAI_D, LOAI_M, LOAI_R, NOTICE, HVC, I_O) " & _
                     "Values ('" & myTable.Rows(i).Item("NGAY") & "','" & IIf(myTable.Rows(i).Item("SCT") = "0", "SN", myTable.Rows(i).Item("SCT")) & "'," & _
                     "'" & myTable.Rows(i).Item("BCG") & "','" & myTable.Rows(i).Item("BCN") & "'," & _
                     "'" & IIf(OptLoai = False And myTable.Rows(i).Item("I_O") = 0, myTable.Rows(i).Item("KL_EMS_TT"), myTable.Rows(i).Item("KL_EMS")) & "'," & myTable.Rows(i).Item("LOAI_D") & "," & _
                     " " & myTable.Rows(i).Item("LOAI_M") & "," & myTable.Rows(i).Item("LOAI_R") & "," & _
                     "'" & myTable.Rows(i).Item("NOTICE") & "','" & myTable.Rows(i).Item("HVC") & "'," & _
                     myTable.Rows(i).Item("I_O") & ")"
            gconMDB.Execute(strSQL)
            PrbAccounting.PerformStep()
            'PrbAccounting.Value = i + 1
            lbEMS.Text = "Đang ghi dữ liệu EMS  ( " & PrbAccounting.Value & " / " & PrbAccounting.Maximum & " )"
            lbEMS.Refresh()
        Next i
    End Sub

    Private Sub InsertToEMS_QG(ByVal myTable As DataTable, ByVal TongSoBanGhi As Integer)
        Dim i As Integer
        PrbAccounting.Maximum = myTable.Rows.Count
        PrbAccounting.Step = 1
        PrbAccounting.Value = 0
        For i = 0 To TongSoBanGhi
            strSQL = "Insert Into EMS_QG (NGAY, SCT, SH_EMS, BCG, NUOC_NHAN, NUOC_QG, LOAI, KL_EMS, VAN_DON, NOTICE) Values ('" & myTable.Rows(i).Item("NGAY") & "','" & myTable.Rows(i).Item("SCT") & "'," & _
            "'" & myTable.Rows(i).Item("SH_EMS") & "','" & myTable.Rows(i).Item("BC_GUI") & "'," & _
            "'" & myTable.Rows(i).Item("NUOC_NHAN") & "','" & myTable.Rows(i).Item("NUOC_QG") & "'," & _
            "'" & myTable.Rows(i).Item("LOAI") & "','" & myTable.Rows(i).Item("KL_EMS") & "'," & _
            "'" & myTable.Rows(i).Item("VAN_DON") & "','" & myTable.Rows(i).Item("NOTICE") & "')"
            gconMDB.Execute(strSQL)
            PrbAccounting.PerformStep()
            'PrbAccounting_Transit.Value = i + 1
            lbEMS.Text = "Đang ghi dữ liệu EMS Quá giang  ( " & PrbAccounting.Value & " / " & PrbAccounting.Maximum & " )"
            lbEMS.Refresh()
        Next i
    End Sub

    Private Function GetData_USPS() As Boolean
        'Dat lai trang thai cho Mouse
        FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.WaitCursor
        'Ket noi voi MDB
        Try
            gconMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & inPathFile & sFileName & ".MDB" & ";Persist Security Info=False"
            gconMDB.Open()
        Catch
            'Dat lai trang thai cho Mouse
            FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
            MsgBox("Không kết nối được với File Access, Kiểm tra xem đã tồn tại file: " & inPathFile & sFileName & ".MDB" & " chưa!!!", MsgBoxStyle.Information, "Thông báo")
            CbTu_Ngay.Select()
            Return False
            Exit Function
        End Try

        'Xoa du lieu trong bang EMS
        strSQL = "Delete * From EMS"
        gconMDB.Execute(strSQL)
        'Xoa du lieu trong bang EMS_QG
        strSQL = "Delete * From EMS_QG"
        gconMDB.Execute(strSQL)

        ''Lay du lieu trong SQL----------------------
        ''Loc du lieu va Insert vao 2 bang: Accounting va Accounting_Transit 
        'myKe_Toan_Ca_QT.Lay_Thong_Tin_Ke_Toan(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value))
        '----------------------------------------------------------------------------------------
        'Lay du lieu tu bang Accounting
        tblAccountingUSPS = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)).Tables(0)
        'Lay du lieu tu bang Accounting_Transit
        'tblAccounting_Transit = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)).Tables(0)

        'Kiem tra trang thai
        If tblAccountingUSPS.Rows.Count <= 0 Then
            MsgBox("Không có dữ liệu USPS", MsgBoxStyle.Information, "Thông báo")
            Return False
        Else
            If tblAccountingUSPS.Rows.Count > 0 Then   'Insert vao bang EMS (Hang_Khong Or Thanh_Toan_QT)
                InsertToEMS(tblAccountingUSPS, tblAccountingUSPS.Rows.Count - 1, OptHangKhong.Checked)
            End If
            'If tblAccounting_Transit.Rows.Count > 0 Then  'Insert vao bang EMS_QG
            '    InsertToEMS_QG(tblAccounting_Transit, tblAccounting_Transit.Rows.Count - 1)
            'End If
            'Gna lai Label thong tin sau khi hoan tat
            lbEMS.Text = "Dữ liệu USPS :  " & tblAccountingUSPS.Rows.Count
            'Dong connection
            gconMDB.Close()
            'Dat lai trang thai Mouse
            FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
            'Thong bao cho nguoi dung
            MsgBox("Dữ liệu USPS phục vụ cho kế toán đã tạo thành công" & vbNewLine & "File kết quả lưu tại : " & txtFile_USPS.Text, MsgBoxStyle.Information, "Thông báo")
            'If MessageBox.Show("Bạn có muốn in bản kê chi tiết bây giờ không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            '    'EMS Chieu den
            '    Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'Ban ke tong hop chieu den
            '    Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Den(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'EMS Chieu Di
            '    Common.Ban_Ke_Ke_Toan_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'EMS Qua Giang
            '    Common.Ban_Ke_Ke_Toan_EMS_Qua_Giang(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            '    'Ban ke tong hop chieu di
            '    Common.Ban_Ke_Ke_Toan_TH_EMS_Chieu_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), True, 0)
            'End If
            'Close()
            'Dat lai trang thai cho Mouse
            'FrmThongTinKeToan.ActiveForm.Cursor = Cursors.Default
            Return True
        End If
    End Function
#End Region
#Region "Hien thi du lieu tren luoi theo tuy chon"
    Private Sub Refresh_Data_Grid_Duong_Thu(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc As Object)
        Ma_Bc = Get_Ma_Bc_Value(isTab, Ma_Bc)
        Select Case isTab
            Case 0  'EMS QT Den
                dgEMS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu(Tu_Ngay, Den_Ngay, Ma_Bc, 0)
                dgEMS_QT_DEN.DataBind()
            Case 1  'EMS QT Di
                dgEMS_QT_DI.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu(Tu_Ngay, Den_Ngay, Ma_Bc, 1)
                dgEMS_QT_DI.DataBind()
            Case 2  'EMS Qua Giang
                dgEMS_QG.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG(Tu_Ngay, Den_Ngay, Ma_Bc)
                dgEMS_QG.DataBind()
            Case 3  'USPS QT Den
                dgUSPS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu(Tu_Ngay, Den_Ngay, Ma_Bc, 0)
                dgUSPS_QT_DEN.DataBind()
        End Select
    End Sub

    Private Sub Refresh_Data_Grid_Duong_Thu_Loai_CT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc As Object, ByVal Loai_CT As String)
        Ma_Bc = Get_Ma_Bc_Value(isTab, Ma_Bc)
        Select Case isTab
            Case 0  'EMS QT Den
                dgEMS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT(Tu_Ngay, Den_Ngay, Ma_Bc, 0, Loai_CT)
                dgEMS_QT_DEN.DataBind()
            Case 1  'EMS QT Di
                dgEMS_QT_DI.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT(Tu_Ngay, Den_Ngay, Ma_Bc, 1, Loai_CT)
                dgEMS_QT_DI.DataBind()
            Case 2  'EMS Qua Giang
                dgEMS_QG.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG(Tu_Ngay, Den_Ngay, Ma_Bc)
                dgEMS_QG.DataBind()
            Case 3  'USPS QT Den
                dgUSPS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT(Tu_Ngay, Den_Ngay, Ma_Bc, 0, Loai_CT)
                dgUSPS_QT_DEN.DataBind()
        End Select
    End Sub

    Private Sub Refresh_Data_Grid_So_Chuyen_Thu(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc As Object, ByVal SCT As Object)
        Ma_Bc = Get_Ma_Bc_Value(isTab, Ma_Bc)
        Select Case tabControl.SelectedTab.Index
            Case 0  'EMS QT Den
                dgEMS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu(Tu_Ngay, Den_Ngay, Ma_Bc, SCT, 0)
                dgEMS_QT_DEN.DataBind()
            Case 1  'EMS QT Di
                dgEMS_QT_DI.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu(Tu_Ngay, Den_Ngay, Ma_Bc, SCT, 1)
                dgEMS_QT_DI.DataBind()
            Case 2  'EMS Qua Giang
                dgEMS_QG.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG_Theo_SCT(Tu_Ngay, Den_Ngay, Ma_Bc, SCT)
                dgEMS_QG.DataBind()
            Case 3  'USPS QT Den
                dgUSPS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu(Tu_Ngay, Den_Ngay, Ma_Bc, SCT, 0)
                dgUSPS_QT_DEN.DataBind()
        End Select
    End Sub

    Private Sub Refresh_Data_Grid_So_Chuyen_Thu_Loai_CT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc As Object, ByVal SCT As Object, ByVal Loai_CT As String)
        Ma_Bc = Get_Ma_Bc_Value(isTab, Ma_Bc)
        Select Case tabControl.SelectedTab.Index
            Case 0  'EMS QT Den
                dgEMS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT(Tu_Ngay, Den_Ngay, Ma_Bc, SCT, 0, Loai_CT)
                dgEMS_QT_DEN.DataBind()
            Case 1  'EMS QT Di
                dgEMS_QT_DI.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT(Tu_Ngay, Den_Ngay, Ma_Bc, SCT, 1, Loai_CT)
                dgEMS_QT_DI.DataBind()
            Case 2  'EMS Qua Giang
                dgEMS_QG.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG_Theo_SCT(Tu_Ngay, Den_Ngay, Ma_Bc, SCT)
                dgEMS_QG.DataBind()
            Case 3  'USPS QT Den
                dgUSPS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT(Tu_Ngay, Den_Ngay, Ma_Bc, SCT, 0, Loai_CT)
                dgUSPS_QT_DEN.DataBind()
        End Select
    End Sub

    Private Sub Refresh_Data_Grid()
        If cbLoai_Chuyen_Thu.Value <> Nothing Then   'Loai chuyen thu
            'Xem tat ca
            If ((cbDuong_Thu.Value = Nothing) And (cbSo_Chuyen_Thu.Value = Nothing)) Then
                Refresh_Data_Grid_ALL_Loai_CT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), cbLoai_Chuyen_Thu.Text)
            End If
            'Xem theo duong thu
            If cbDuong_Thu.Value <> Nothing And cbSo_Chuyen_Thu.Value = Nothing Then
                Refresh_Data_Grid_Duong_Thu_Loai_CT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), cbDuong_Thu.Value, cbLoai_Chuyen_Thu.Text)
            End If
            'Xem theo so chuyen thu
            If cbDuong_Thu.Value <> Nothing And cbSo_Chuyen_Thu.Value <> Nothing Then
                Refresh_Data_Grid_So_Chuyen_Thu_Loai_CT(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), cbDuong_Thu.Value, cbSo_Chuyen_Thu.Value, cbLoai_Chuyen_Thu.Text)
            End If
        Else
            'Xem tat ca
            If ((cbDuong_Thu.Value = Nothing) And (cbSo_Chuyen_Thu.Value = Nothing)) Then
                Refresh_Data_Grid_ALL(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime))
            End If
            'Xem theo duong thu
            If cbDuong_Thu.Value <> Nothing And cbSo_Chuyen_Thu.Value = Nothing Then
                Refresh_Data_Grid_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), cbDuong_Thu.Value)
            End If
            'Xem theo so chuyen thu
            If cbDuong_Thu.Value <> Nothing And cbSo_Chuyen_Thu.Value <> Nothing Then
                Refresh_Data_Grid_So_Chuyen_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.DateTime), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.DateTime), cbDuong_Thu.Value, cbSo_Chuyen_Thu.Value)
            End If
        End If
    End Sub

    Private Sub Refresh_Data_Grid_ALL(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
        Select Case isTab
            Case 0  'EMS QT Den
                dgEMS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 0)
                dgEMS_QT_DEN.DataBind()
            Case 1  'EMS QT Di
                dgEMS_QT_DI.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 1)
                dgEMS_QT_DI.DataBind()
            Case 2  'EMS Qua Giang
                dgEMS_QG.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay(Tu_Ngay, Den_Ngay)
                dgEMS_QG.DataBind()
            Case 3  'USPS QT Den
                dgUSPS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 0)
                dgUSPS_QT_DEN.DataBind()
        End Select
    End Sub

    Private Sub Refresh_Data_Grid_ALL_Loai_CT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Loai_CT As String)
        Select Case isTab
            Case 0  'EMS QT Den
                dgEMS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT(Tu_Ngay, Den_Ngay, 0, Loai_CT)
                dgEMS_QT_DEN.DataBind()
            Case 1  'EMS QT Di
                dgEMS_QT_DI.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT(Tu_Ngay, Den_Ngay, 1, Loai_CT)
                dgEMS_QT_DI.DataBind()
            Case 2  'EMS Qua Giang
                dgEMS_QG.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay(Tu_Ngay, Den_Ngay)
                dgEMS_QG.DataBind()
            Case 3
                dgUSPS_QT_DEN.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT(Tu_Ngay, Den_Ngay, 0, Loai_CT)
                dgUSPS_QT_DEN.DataBind()
        End Select
    End Sub

#End Region
#Region "Load du lieu cho cbDuong_Thu va cbSo_Chuyen_Thu"
    Private Sub Get_Duong_Thu(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Chieu_Dong As Integer)
        Select Case isTab
            Case 2
                cbDuong_Thu.DisplayLayout.Bands(0).Columns("Ma_Bc").Header.Caption = "Mã nước QG"
                cbDuong_Thu.DisplayLayout.Bands(0).Columns("Ten_Bc").Header.Caption = "Tên nước QG"

                cbDuong_Thu.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Nuoc_QG_Tu_Ngay_Den_Ngay(Tu_Ngay, Den_Ngay)
                cbDuong_Thu.DataBind()
            Case 3
                cbDuong_Thu.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, Chieu_Dong)
                cbDuong_Thu.DataBind()
            Case Else
                cbDuong_Thu.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, Chieu_Dong)
                cbDuong_Thu.DataBind()
        End Select
        'cbDuong_Thu.LimitToList = True
        cbDuong_Thu.Value = Nothing
        ' cbDuong_Thu.Text = ""
    End Sub
    Private Sub Get_Chuyen_Thu(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Chieu_Dong As Integer, ByVal Ma_Bc As Object)
        Ma_Bc = Get_Ma_Bc_Value(isTab, Ma_Bc)
        Select Case isTab
            Case 2
                cbSo_Chuyen_Thu.DataSource = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_SCT_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG(Tu_Ngay, Den_Ngay, Ma_Bc)
                cbSo_Chuyen_Thu.DataBind()
            Case 3
                cbSo_Chuyen_Thu.DataSource = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, Ma_Bc, Chieu_Dong)
                cbSo_Chuyen_Thu.DataBind()
            Case Else
                cbSo_Chuyen_Thu.DataSource = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, Ma_Bc, Chieu_Dong)
                cbSo_Chuyen_Thu.DataBind()
        End Select
        'cbSo_Chuyen_Thu.LimitToList = True
        cbSo_Chuyen_Thu.Value = Nothing
        ' cbSo_Chuyen_Thu.Text = ""
    End Sub

    Private Sub Get_Loai_CT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Chieu_Dong As Integer)
        Select Case isTab
            Case 2
            Case Else
                'Them moi mot bang
                Dim dataTable As New dataTable("Loai_CT")

                'Tao ra cac cot cua bang nay
                Dim colWork As DataColumn = New DataColumn("Loai_Chuyen_Thu", GetType(String))
                dataTable.Columns.Add(colWork)

                'Them du lieu vao
                Dim row As DataRow = dataTable.NewRow()
                'Chuyen thu D
                row("Loai_Chuyen_Thu") = "."
                dataTable.Rows.Add(row)

                'Chuyen thu M
                row = dataTable.NewRow
                row("Loai_Chuyen_Thu") = "M-"
                dataTable.Rows.Add(row)

                'Load data
                cbLoai_Chuyen_Thu.DataSource = dataTable
                cbLoai_Chuyen_Thu.DataBind()
        End Select
        'cbLoai_Chuyen_Thu.LimitToList = True
        cbLoai_Chuyen_Thu.Value = Nothing
        ' cbDuong_Thu.Text = ""
    End Sub

    Private Function Get_Ma_Bc_Value(ByVal isTab As Integer, ByVal Obj_Ma_bc As Object) As Object
        If isTab = 2 Then
            If Obj_Ma_bc = Nothing Then
                Get_Ma_Bc_Value = ""
            Else
                Get_Ma_Bc_Value = Obj_Ma_bc
            End If
        Else
            If Obj_Ma_bc = Nothing Then
                Get_Ma_Bc_Value = 0
            Else
                Get_Ma_Bc_Value = Obj_Ma_bc
            End If
        End If
    End Function
#End Region
#Region "SetDefaultValueToCell - dgEMS_QT_DEN"
    Private Sub SetDefaultValueDgEMS_QT_DEN(ByVal sender As Object)
        myGridKeyDown = sender
        'SCT
        myGridKeyDown.DisplayLayout.Bands(0).Columns("SCT").DefaultCellValue = "0"
        'ID
        myGridKeyDown.DisplayLayout.Bands(0).Columns("ID").DefaultCellValue = 0
        'HVC - Hang van chuyen
        myGridKeyDown.DisplayLayout.Bands(0).Columns("HVC").DefaultCellValue = "."
        'Loai (Hang den = 0, Hang di = 1)
        myGridKeyDown.DisplayLayout.Bands(0).Columns("I_O").DefaultCellValue = CDec(1)
        'Ghi_Chu 
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Notice").DefaultCellValue = "."
    End Sub
#End Region
#Region "Load Data DropDown BCG"
    Private Sub ddBCG_Load_Data()
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        ddBCG.DataSource = myDanh_Muc_BC.Danh_Muc_BC_Quoc_Te
        ddBCG.DataBind()
    End Sub
#End Region
#Region "Thêm dòng mới"
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
    End Sub
#End Region
#Region "-------------------Refresh Label Thong Tin"
    Private Sub Refresh_Thong_Tin(ByVal sender As Object)
        myGridKeyDown = sender
        Try
            lblThongTin.Text = "Tổng số dòng :   " & myGridKeyDown.Rows.Count
        Catch
            lblThongTin.Text = "Tổng số dòng :   0"
        End Try
    End Sub
#End Region
#Region "Create_Id_Thang"
    Private Function Create_Id_Thang(ByVal Tu_Ngay As Date, ByVal Den_Ngay As Date, ByVal Phan_Loai As Integer) As String
        If Tu_Ngay.Month <> Den_Ngay.Month Then
            MessageBox.Show("Chức năng chốt số liệu chỉ thực hiện chốt số liệu theo tháng." & vbNewLine & "Vì vậy ngày bạn chọn phải là ngày trong cùng 1 tháng. Vui lòng nhập lại thông tin từ ngày , đến ngày cho hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
            Exit Function
        Else
            Return Tu_Ngay.Year.ToString("0000") & Tu_Ngay.Month.ToString("00") & Phan_Loai.ToString("0000")
        End If
    End Function
#End Region
#End Region

#Region "btnCuoc_Hang_Khong_Click"
    Private Sub btnCuoc_Hang_Khong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuoc_Hang_Khong.Click
        Dim frm As New FrmQuan_Ly_Cuoc_Hang_Khong
        frm.FrmQL_Cuoc_Hang_Khong_Tu_Ngay = CbTu_Ngay.Value
        frm.FrmQL_Cuoc_Hang_Khong_Den_Ngay = CbDen_Ngay.Value
        Me.Close()
        Me.Dispose()
        frm.ShowDialog()
    End Sub
#End Region
  
End Class
