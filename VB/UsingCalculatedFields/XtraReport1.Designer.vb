Namespace UsingCalculatedFields
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 42.70833!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrLabel3
            '
            Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
            Me.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(278.125!, 10.00001!)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseForeColor = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            Me.xrLabel3.Text = "xrLabel3"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'xrLabel2
            '
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(141.6667!, 9.708341!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'xrLabel1
            '
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.xrLabel1.TextFormatString = "{0:c2}"
            '
            'TopMargin
            '
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'sqlDataSource1
            '
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            ColumnExpression1.ColumnName = "ProductID"
            Table1.Name = "Products"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "ProductName"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "SupplierID"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "CategoryID"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "QuantityPerUnit"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "UnitPrice"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            ColumnExpression7.ColumnName = "UnitsInStock"
            ColumnExpression7.Table = Table1
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "UnitsOnOrder"
            ColumnExpression8.Table = Table1
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "ReorderLevel"
            ColumnExpression9.Table = Table1
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "Discontinued"
            ColumnExpression10.Table = Table1
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "EAN13"
            ColumnExpression11.Table = Table1
            Column11.Expression = ColumnExpression11
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Columns.Add(Column7)
            SelectQuery1.Columns.Add(Column8)
            SelectQuery1.Columns.Add(Column9)
            SelectQuery1.Columns.Add(Column10)
            SelectQuery1.Columns.Add(Column11)
            SelectQuery1.Name = "Products"
            SelectQuery1.Tables.Add(Table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel6, Me.xrLabel5, Me.xrLabel4})
            Me.ReportHeader.HeightF = 39.58333!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'xrLabel6
            '
            Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
            Me.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(278.125!, 10.00001!)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrLabel6.StylePriority.UseFont = False
            Me.xrLabel6.StylePriority.UseForeColor = False
            Me.xrLabel6.StylePriority.UseTextAlignment = False
            Me.xrLabel6.Text = "Calculated Field"
            Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'xrLabel5
            '
            Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(141.6667!, 10.00001!)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UseTextAlignment = False
            Me.xrLabel5.Text = "Units in Stock"
            Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'xrLabel4
            '
            Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "Unit Price"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'XtraReport1
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "22.1"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
