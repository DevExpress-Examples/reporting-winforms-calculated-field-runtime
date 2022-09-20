using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Configuration;

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

            // Specify the calculated field's properties.
            calcField.DataSource = report.DataSource;
            calcField.DataMember = report.DataMember;
            calcField.FieldType = FieldType.Double;
            calcField.DisplayName = "Calculated Field";
            calcField.Name = "myField";
            calcField.Expression = "[UnitPrice] * [UnitsInStock]";

            // Bind the label's Text property to the calculated field.
            report.FindControl("xrlabel3", true).ExpressionBindings
                        .Add(new ExpressionBinding() {
                            EventName = "BeforePrint",
                            PropertyName = "Text",
                            Expression = "FormatString('{0:c2}', [myField])"
                        });

            // Preview the report.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}