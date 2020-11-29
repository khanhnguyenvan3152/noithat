using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public partial class PrintReport : Form
    {
        public string id;
        public PrintReport(string id)
        {
            this.id = id;
            InitializeComponent();
            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            reportViewer1.SetPageSettings(setup);
        }

        private void PrintReport_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM HOADONBAN WHERE SoDDH ='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Functions.Con);
            Datasets.DataSet1 ds = new Datasets.DataSet1();
            da.Fill(ds, "DataTable1");;
            ReportDataSource dataSource = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);
          
            
            this.reportViewer1.RefreshReport();
        }
    }
}
