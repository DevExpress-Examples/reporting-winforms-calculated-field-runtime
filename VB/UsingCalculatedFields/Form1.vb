Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

' ...
Namespace UsingCalculatedFields

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a report.
            Dim report As XtraReport1 = New XtraReport1()
            ' Create a calculated field, 
            ' and add it to the report's collection.
            Dim calcField As CalculatedField = New CalculatedField()
            report.CalculatedFields.Add(calcField)
            ' Define its properties.
            calcField.DataSource = report.DataSource
            calcField.DataMember = report.DataMember
            calcField.FieldType = FieldType.Double
            calcField.DisplayName = "A Calculated Field"
            calcField.Name = "myField"
            calcField.Expression = "[UnitPrice] * [Quantity]"
            ' Bind a label's Text property to the calculated field.
            report.FindControl("xrlabel2", True).DataBindings.Add("Text", Nothing, "Order Details.myField")
            ' Display the report.
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
