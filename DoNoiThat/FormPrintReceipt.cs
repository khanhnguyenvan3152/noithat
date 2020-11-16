using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoNoiThat.Class;

namespace DoNoiThat
{
    public partial class FormPrintReceipt : Form
    {
        public List<OrderDetail> _list;
        public OrderObject _order;
        public FormPrintReceipt(OrderObject order,List<OrderDetail> list)
        {
            InitializeComponent();
            _order = order;
            _list = list;
        }


        private void FormPrintReceipt_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("@SoDDH",_order.Orderid),
                new Microsoft.Reporting.WinForms.ReportParameter("@")
            };
            this.reportViewer1.RefreshReport();
        }
    }
}
