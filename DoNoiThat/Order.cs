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
using DoNoiThat.Class;
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
            this.dateTimePicker1.Value = System.DateTime.Now;
            this.dateTimePicker1.Value = System.DateTime.Now;
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

        private void radioButtonNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if(radioButtonYes.Checked == true)
            {
                
            }
        }

        private void radioButtonYes_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            if(dataGridViewItem.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một sản phẩm!");
            }
            else
            {
                DataGridViewRow row = dataGridViewItem.CurrentRow;
                string mant = row.Cells[0].Value.ToString();
                string SL = "";
                string dongia = row.Cells[9].Value.ToString();
                string giamgia = textBoxDisccount.Text;
                string thanhtien = "";
                if(numericUpDownAmount.Value ==0)
                {
                    MessageBox.Show("Chọn số lượng!");
                    numericUpDownAmount.Focus();
                }
                else
                {
                    int soluong = int.Parse(numericUpDownAmount.Value.ToString());
                    SL = soluong.ToString();
                    thanhtien = (soluong * float.Parse(dongia)-float.Parse(giamgia)).ToString();
                    dataGridViewDetail.Rows.Add(mant, SL, giamgia, thanhtien.ToString());
                }
            }
        }
        public string genarateKey()
        {
            string temp = dataGridViewOrder.Rows[dataGridViewItem.Rows.Count - 1].Cells[0].Value.ToString();
            string[] arr = temp.Split('T');
            int chiso = int.Parse(arr[1]);
            chiso++;
            string stringchiso = chiso.ToString();
            string result = "NT" + chiso.ToString("000");
            return result;
        }
    }
}
