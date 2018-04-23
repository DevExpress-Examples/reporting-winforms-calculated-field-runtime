using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Configuration;
// ...

namespace UsingCalculatedFields {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Create a calculated field 
            // and add it to the report's collection.
            CalculatedField calcField = new CalculatedField();
            report.CalculatedFields.Add(calcField);

            // Define the calculated field's properties.
            calcField.DataSource = report.DataSource;
            calcField.DataMember = report.DataMember;
            calcField.FieldType = FieldType.Double;
            calcField.DisplayName = "Calculated Field";
            calcField.Name = "myField";
            calcField.Expression = "[UnitPrice] * [UnitsInStock]";

            // Bind a label's Text property to the calculated field.
            report.FindControl("xrlabel2", true).DataBindings.Add("Text", null, "Order Details.myField");

            // Bind a label's Text property to the calculated field 
            // depending on the report's data binding mode.
            if (Settings.Default.UserDesignerOptions.DataBindingMode == DataBindingMode.Bindings)
                report.FindControl("xrlabel3", true).DataBindings.Add("Text", null, "Products.myField", "{0:c2}");
            else report.FindControl("xrlabel3", true).ExpressionBindings.Add(
                new ExpressionBinding("BeforePrint", "Text", "FormatString('{0:c2}', [myField])"));

            // Display the report.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

    }
}