﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2463
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class Bao_Cao_Buu_Kien_Buu_Pham
    Inherits DataSet
    
    Private tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable
    
    Private tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop")) Is Nothing) Then
                Me.Tables.Add(New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable(ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop")))
            End If
            If (Not (ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan")) Is Nothing) Then
                Me.Tables.Add(New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable(ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable
        Get
            Return Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable
        Get
            Return Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As Bao_Cao_Buu_Kien_Buu_Pham = CType(MyBase.Clone,Bao_Cao_Buu_Kien_Buu_Pham)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop")) Is Nothing) Then
            Me.Tables.Add(New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable(ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop")))
        End If
        If (Not (ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan")) Is Nothing) Then
            Me.Tables.Add(New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable(ds.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop = CType(Me.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop"),Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable)
        If (Not (Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop) Is Nothing) Then
            Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.InitVars
        End If
        Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan = CType(Me.Tables("Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan"),Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable)
        If (Not (Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan) Is Nothing) Then
            Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "Bao_Cao_Buu_Kien_Buu_Pham"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/Bao_Cao_Buu_Kien_Buu_Pham.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop = New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable
        Me.Tables.Add(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop)
        Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan = New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable
        Me.Tables.Add(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan)
    End Sub
    
    Private Function ShouldSerializeBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEventHandler(ByVal sender As Object, ByVal e As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEvent)
    
    Public Delegate Sub Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEventHandler(ByVal sender As Object, ByVal e As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnTong_SL_Den As DataColumn
        
        Private columnTong_KL_Den As DataColumn
        
        Private columnTong_SL_Chuyen_Tiep As DataColumn
        
        Private columnTong_KL_Chuyen_Tiep As DataColumn
        
        Private columnTong_SL_CPCPN As DataColumn
        
        Private columnTong_KL_CPCPN As DataColumn
        
        Friend Sub New()
            MyBase.New("Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property Tong_SL_DenColumn As DataColumn
            Get
                Return Me.columnTong_SL_Den
            End Get
        End Property
        
        Friend ReadOnly Property Tong_KL_DenColumn As DataColumn
            Get
                Return Me.columnTong_KL_Den
            End Get
        End Property
        
        Friend ReadOnly Property Tong_SL_Chuyen_TiepColumn As DataColumn
            Get
                Return Me.columnTong_SL_Chuyen_Tiep
            End Get
        End Property
        
        Friend ReadOnly Property Tong_KL_Chuyen_TiepColumn As DataColumn
            Get
                Return Me.columnTong_KL_Chuyen_Tiep
            End Get
        End Property
        
        Friend ReadOnly Property Tong_SL_CPCPNColumn As DataColumn
            Get
                Return Me.columnTong_SL_CPCPN
            End Get
        End Property
        
        Friend ReadOnly Property Tong_KL_CPCPNColumn As DataColumn
            Get
                Return Me.columnTong_KL_CPCPN
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow
            Get
                Return CType(Me.Rows(index),Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow)
            End Get
        End Property
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChanged As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEventHandler
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChanging As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEventHandler
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowDeleted As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEventHandler
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowDeleting As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEventHandler
        
        Public Overloads Sub AddBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow(ByVal row As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow(ByVal Tong_SL_Den As Integer, ByVal Tong_KL_Den As Integer, ByVal Tong_SL_Chuyen_Tiep As Integer, ByVal Tong_KL_Chuyen_Tiep As Integer, ByVal Tong_SL_CPCPN As Integer, ByVal Tong_KL_CPCPN As Integer) As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow
            Dim rowBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow = CType(Me.NewRow,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow)
            rowBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow.ItemArray = New Object() {Tong_SL_Den, Tong_KL_Den, Tong_SL_Chuyen_Tiep, Tong_KL_Chuyen_Tiep, Tong_SL_CPCPN, Tong_KL_CPCPN}
            Me.Rows.Add(rowBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow)
            Return rowBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable = CType(MyBase.Clone,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnTong_SL_Den = Me.Columns("Tong_SL_Den")
            Me.columnTong_KL_Den = Me.Columns("Tong_KL_Den")
            Me.columnTong_SL_Chuyen_Tiep = Me.Columns("Tong_SL_Chuyen_Tiep")
            Me.columnTong_KL_Chuyen_Tiep = Me.Columns("Tong_KL_Chuyen_Tiep")
            Me.columnTong_SL_CPCPN = Me.Columns("Tong_SL_CPCPN")
            Me.columnTong_KL_CPCPN = Me.Columns("Tong_KL_CPCPN")
        End Sub
        
        Private Sub InitClass()
            Me.columnTong_SL_Den = New DataColumn("Tong_SL_Den", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_SL_Den)
            Me.columnTong_KL_Den = New DataColumn("Tong_KL_Den", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_KL_Den)
            Me.columnTong_SL_Chuyen_Tiep = New DataColumn("Tong_SL_Chuyen_Tiep", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_SL_Chuyen_Tiep)
            Me.columnTong_KL_Chuyen_Tiep = New DataColumn("Tong_KL_Chuyen_Tiep", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_KL_Chuyen_Tiep)
            Me.columnTong_SL_CPCPN = New DataColumn("Tong_SL_CPCPN", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_SL_CPCPN)
            Me.columnTong_KL_CPCPN = New DataColumn("Tong_KL_CPCPN", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_KL_CPCPN)
        End Sub
        
        Public Function NewBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow() As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow
            Return CType(Me.NewRow,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangedEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChanged(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangingEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChanging(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowDeletedEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowDeleted(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowDeletingEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowDeleting(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveBuu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow(ByVal row As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow
        Inherits DataRow
        
        Private tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop = CType(Me.Table,Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopDataTable)
        End Sub
        
        Public Property Tong_SL_Den As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_DenColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_DenColumn) = value
            End Set
        End Property
        
        Public Property Tong_KL_Den As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_DenColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_DenColumn) = value
            End Set
        End Property
        
        Public Property Tong_SL_Chuyen_Tiep As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_Chuyen_TiepColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_Chuyen_TiepColumn) = value
            End Set
        End Property
        
        Public Property Tong_KL_Chuyen_Tiep As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_Chuyen_TiepColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_Chuyen_TiepColumn) = value
            End Set
        End Property
        
        Public Property Tong_SL_CPCPN As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_CPCPNColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_CPCPNColumn) = value
            End Set
        End Property
        
        Public Property Tong_KL_CPCPN As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_CPCPNColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_CPCPNColumn) = value
            End Set
        End Property
        
        Public Function IsTong_SL_DenNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_DenColumn)
        End Function
        
        Public Sub SetTong_SL_DenNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_DenColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTong_KL_DenNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_DenColumn)
        End Function
        
        Public Sub SetTong_KL_DenNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_DenColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTong_SL_Chuyen_TiepNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_Chuyen_TiepColumn)
        End Function
        
        Public Sub SetTong_SL_Chuyen_TiepNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_Chuyen_TiepColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTong_KL_Chuyen_TiepNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_Chuyen_TiepColumn)
        End Function
        
        Public Sub SetTong_KL_Chuyen_TiepNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_Chuyen_TiepColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTong_SL_CPCPNNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_CPCPNColumn)
        End Function
        
        Public Sub SetTong_SL_CPCPNNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_SL_CPCPNColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTong_KL_CPCPNNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_CPCPNColumn)
        End Function
        
        Public Sub SetTong_KL_CPCPNNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Tong_Hop.Tong_KL_CPCPNColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Buu_Pham_Buu_Kien_Bao_Cao_Tong_HopRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnTong_SL_Den As DataColumn
        
        Private columnTong_KL_Den As DataColumn
        
        Private columnTong_So_Roi_HQ As DataColumn
        
        Friend Sub New()
            MyBase.New("Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property Tong_SL_DenColumn As DataColumn
            Get
                Return Me.columnTong_SL_Den
            End Get
        End Property
        
        Friend ReadOnly Property Tong_KL_DenColumn As DataColumn
            Get
                Return Me.columnTong_KL_Den
            End Get
        End Property
        
        Friend ReadOnly Property Tong_So_Roi_HQColumn As DataColumn
            Get
                Return Me.columnTong_So_Roi_HQ
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow
            Get
                Return CType(Me.Rows(index),Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow)
            End Get
        End Property
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChanged As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEventHandler
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChanging As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEventHandler
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowDeleted As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEventHandler
        
        Public Event Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowDeleting As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEventHandler
        
        Public Overloads Sub AddBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow(ByVal row As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow(ByVal Tong_SL_Den As Integer, ByVal Tong_KL_Den As Integer, ByVal Tong_So_Roi_HQ As Integer) As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow
            Dim rowBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow = CType(Me.NewRow,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow)
            rowBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow.ItemArray = New Object() {Tong_SL_Den, Tong_KL_Den, Tong_So_Roi_HQ}
            Me.Rows.Add(rowBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow)
            Return rowBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable = CType(MyBase.Clone,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnTong_SL_Den = Me.Columns("Tong_SL_Den")
            Me.columnTong_KL_Den = Me.Columns("Tong_KL_Den")
            Me.columnTong_So_Roi_HQ = Me.Columns("Tong_So_Roi_HQ")
        End Sub
        
        Private Sub InitClass()
            Me.columnTong_SL_Den = New DataColumn("Tong_SL_Den", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_SL_Den)
            Me.columnTong_KL_Den = New DataColumn("Tong_KL_Den", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_KL_Den)
            Me.columnTong_So_Roi_HQ = New DataColumn("Tong_So_Roi_HQ", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTong_So_Roi_HQ)
        End Sub
        
        Public Function NewBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow() As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow
            Return CType(Me.NewRow,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangedEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChanged(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangingEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChanging(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowDeletedEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowDeleted(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowDeletingEvent) Is Nothing) Then
                RaiseEvent Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowDeleting(Me, New Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEvent(CType(e.Row,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveBuu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow(ByVal row As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow
        Inherits DataRow
        
        Private tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan = CType(Me.Table,Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanDataTable)
        End Sub
        
        Public Property Tong_SL_Den As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_SL_DenColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_SL_DenColumn) = value
            End Set
        End Property
        
        Public Property Tong_KL_Den As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_KL_DenColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_KL_DenColumn) = value
            End Set
        End Property
        
        Public Property Tong_So_Roi_HQ As Integer
            Get
                Try 
                    Return CType(Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_So_Roi_HQColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_So_Roi_HQColumn) = value
            End Set
        End Property
        
        Public Function IsTong_SL_DenNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_SL_DenColumn)
        End Function
        
        Public Sub SetTong_SL_DenNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_SL_DenColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTong_KL_DenNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_KL_DenColumn)
        End Function
        
        Public Sub SetTong_KL_DenNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_KL_DenColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTong_So_Roi_HQNull() As Boolean
            Return Me.IsNull(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_So_Roi_HQColumn)
        End Function
        
        Public Sub SetTong_So_Roi_HQNull()
            Me(Me.tableBuu_Pham_Buu_Kien_Bao_Cao_Thong_Quan.Tong_So_Roi_HQColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Buu_Pham_Buu_Kien_Bao_Cao_Thong_QuanRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class