﻿using Microsoft.Win32.SafeHandles;
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
using System.Data.SqlClient;

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
            dataGridViewDetail.ForeColor = Color.Black;
            labelIdOrder1.Text = genarateKey(); //Gan id moi cho lap hoa don
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
           if(radioButtonNo.Checked == true)
            {
                comboBoxCustomerId.Enabled = true;
                txtCustomerName.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtAddress.Enabled = false;
            }
       
        }

        private void radioButtonYes_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked == true)
            {
                comboBoxCustomerId.Enabled = false;
                txtCustomerName.Enabled = true;
                txtPhoneNumber.Enabled = true;
                txtAddress.Enabled = true;
            }
           
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
                    bool check = false;
                    SL = soluong.ToString();
                    thanhtien = (soluong * float.Parse(dongia)-float.Parse(giamgia)).ToString();
                    if (dataGridViewDetail.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow tmprow in dataGridViewDetail.Rows)
                        {
                            if (tmprow.Cells[0].Value != null)
                            {
                                if (tmprow.Cells[0].Value.ToString().Equals(mant))
                                {
                                    soluong = soluong + int.Parse(tmprow.Cells[1].Value.ToString());
                                    double tong = float.Parse(thanhtien) + float.Parse(tmprow.Cells[3].Value.ToString());
                                    tmprow.Cells[1].Value = soluong.ToString();
                                    tmprow.Cells[3].Value = tong.ToString();
                                    tmprow.Cells[2].Value = giamgia.ToString();
                                    check = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (check==false)
                    {
                        dataGridViewDetail.Rows.Add(mant, soluong, giamgia, thanhtien);
                    }
                    if(dataGridViewDetail.Rows.Count >0)
                    {
                        double tong = 0;
                        foreach(DataGridViewRow r in dataGridViewDetail.Rows)
                        {
                            if (r.Cells[3].Value != null)
                            {
                                tong = tong + Convert.ToDouble(r.Cells[3].Value);
                            }
                        }
                        double tongtien = tong * Convert.ToDouble(labelTax1.Text.Substring(0,2))/100+tong;
                        labelTotal1.Text = tongtien.ToString();
                    }
                }
            }
        }
        public string genarateKey()
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.AUTO_IDDDH()", Functions.Con);
            cmd.CommandType = CommandType.Text;

            //add parameter for return value


            string id = (string)cmd.ExecuteScalar();
            return id;
        }

        private void iconButtonDeleteDetailRow_Click(object sender, EventArgs e)
        {
            if(dataGridViewDetail.Rows.Count == 0)
            {
                MessageBox.Show("Đơn hàng chưa có sản phẩm!");
            }
            else
            {
                dataGridViewDetail.Rows.RemoveAt(dataGridViewDetail.CurrentRow.Index);
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(radioButtonYes.Checked == true)
            {
                string customerid = generateCustomerId();

            }
        }
        string generateCustomerId()
        {
            SqlCommand cmd = new SqlCommand("SELECT FROM dbo.AUTO_IDKH()", Functions.Con);
            cmd.CommandType = CommandType.Text;
            string id = (string)cmd.ExecuteScalar();
            return id;
        }
    }
}
