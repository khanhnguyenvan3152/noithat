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
    public partial class Item : Form
    {
        
        public Item()
        {
            InitializeComponent();
        }


        private void Item_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM DMNoiThat";
            DataTable table = Functions.GetDataTable(sql);
            dataGridViewItemList.DataSource = table;
            dataGridViewItemList.ForeColor = Color.Black;
            dataGridViewItemList.Columns[2].Width = 70;
            dataGridViewItemList.Columns[3].Width = 70;
            dataGridViewItemList.Columns[4].Width = 70;
            dataGridViewItemList.Columns[5].Width = 80;
            dataGridViewItemList.Columns[6].Width = 80;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 0;
        }

        private void listViewItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 522;
        }

        private void dataGridViewItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }
    }
}
