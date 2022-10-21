using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsaManageMentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployNo");

            dt.Rows.Add(new object[] { "AAA1" });
            dt.Rows.Add(new object[] { "AAA1" });
            dt.Rows.Add(new object[] { "AAA1" });

            for (int i = 10; i < 100; i++)
            {
                dt.Rows.Add(new object[] {
                    string.Format("AAA{0}", i.ToString())});
            }

            reportViewer1.PageCountMode = PageCountMode.Actual;

            ReportDataSource rDS = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rDS);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();


            this.reportViewer2.RefreshReport();
        }
    }
}
