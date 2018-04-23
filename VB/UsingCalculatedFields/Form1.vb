Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Configuration
' ...

Namespace UsingCalculatedFields
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

            ' Create a report.
            Dim report As New XtraReport1()

            ' Create a calculated field 
            ' and add it to the report's collection.
            Dim calcField As New CalculatedField()
            report.CalculatedFields.Add(calcField)

            ' Define the calculated field's properties.
            calcField.DataSource = report.DataSource
            calcField.DataMember = report.DataMember
            calcField.FieldType = FieldType.Double
            calcField.DisplayName = "Calculated Field"
            calcField.Name = "myField"
            calcField.Expression = "[UnitPrice] * [UnitsInStock]"

            ' Bind a label's Text property to the calculated field.
            report.FindControl("xrlabel2", True).DataBindings.Add("Text", Nothing, "Order Details.myField")

            ' Bind a label's Text property to the calculated field 
            ' depending on the report's data binding mode.
            If Settings.Default.UserDesignerOptions.DataBindingMode = DataBindingMode.Bindings Then
                report.FindControl("xrlabel3", True).DataBindings.Add("Text", Nothing, "Products.myField", "{0:c2}")
            Else
                report.FindControl("xrlabel3", True).ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Text", "FormatString('{0:c2}', [myField])"))
            End If

            ' Display the report.
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub

    End Class
End Namespace