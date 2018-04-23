using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace UsingCalculatedFields {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Create a calculated field, 
            // and add it to the report's collection.
            CalculatedField calcField = new CalculatedField();
            report.CalculatedFields.Add(calcField);

            // Define its properties.
            calcField.DataSource = report.DataSource;
            calcField.DataMember = report.DataMember;
            calcField.FieldType = FieldType.Double;
            calcField.DisplayName = "A Calculated Field";
            calcField.Name = "myField";
            calcField.Expression = "[UnitPrice] * [Quantity]";

            // Bind a label's Text property to the calculated field.
            report.FindControl("xrlabel2", true).DataBindings.Add("Text", null, "Order Details.myField");

            // Display the report.
            report.ShowPreview();
        }

    }
}