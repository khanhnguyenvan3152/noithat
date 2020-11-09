using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }


        private void Order_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            if(tabControlOrder.SelectedIndex ==0)
            {
                string sql = "SELECT * FROM DonDH";
                dataGridViewOrder.ForeColor = Color.Black;
                DataTable table = Functions.GetDataTable(sql);
                dataGridViewOrder.DataSource = table;
                table.Dispose();
            }
            if(tabControlOrder.SelectedIndex ==1)
            {
                string sql = "SELECT * FROM DMNoiThat";
                dataGridViewItem.ForeColor = Color.Black;
                DataTable table = Functions.GetDataTable(sql);
                dataGridViewItem.DataSource = table;
                table.Dispose();
            }
        }
        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }
    }
}
