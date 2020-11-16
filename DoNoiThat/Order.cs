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
            radioButtonNo.Checked = true;
            loadComboKH();
            Functions.setDataSource(comboBoxStaffName, "SELECT MaNV,TenNV FROM NhanVien");
            comboBoxStaffName.SelectedIndex = -1;
      
        }
        void loadComboKH()
        {
            SqlCommand cmd = Functions.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM KhachHang";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxCustomerId.Items.Add(dr["MaKH"]);
            }

        }
        private void loadDataGridView()
        {
            if(tabControlOrder.SelectedIndex ==0)
            {
                string sql = "SELECT * FROM DonDH";
                dataGridViewOrder.ForeColor = Color.Black;
                dataGridViewDetailOrder.ForeColor = Color.Black;
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
                double tongtien = Convert.ToDouble(labelTotal1.Text);
               
                double thanhtien = Convert.ToDouble(dataGridViewDetail.CurrentRow.Cells[3].Value);
                double tienthue = thanhtien * Convert.ToDouble(labelTax1.Text.Substring(0, 2))/100;
                tongtien = tongtien - thanhtien-tienthue;
                labelTotal1.Text = tongtien.ToString();
                dataGridViewDetail.Rows.RemoveAt(dataGridViewDetail.CurrentRow.Index);
                if (dataGridViewDetail.Rows.Count == 0)
                {
                    labelTotal1.Text = "0";
                }
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }
        bool checkTextbox()
        {
            if(txtCustomerName.Text == "")
            {
                MessageBox.Show("Nhap ten khach hang");
                txtCustomerName.Focus();
                return false;
            }
            if(txtPhoneNumber.Text =="")
            {
                MessageBox.Show("Nhap so dien thoai khach hang");
                txtPhoneNumber.Focus();
                return false;
            }
            if(txtAddress.Text =="")
            {
                MessageBox.Show("Nhap dia chi khach hang");
                txtAddress.Focus();
                    return false;
            }
            if(txtStaffId.Text =="")
            {
                MessageBox.Show("Chon nhan vien");
                comboBoxStaffName.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string ngaydat = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string ngaygiao = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (radioButtonYes.Checked == true)
            {
                string customerid = generateCustomerId();      
                if (checkTextbox() == true)
                {
                    try
                    {
                        string sql="INSERT dbo.[KhachHang] ([MaKH],[TenKH],[DiaChi],[DienThoai]) VALUES (N'" + customerid + "',N'" + txtCustomerName.Text + "',N'" + txtAddress.Text + "',N'" + txtPhoneNumber.Text + "')";
                        Functions.RunSQL(sql);
                        try
                        {
                            sql = "INSERT [dbo].[DonDH] ([SoDDH], [MaNV], [MaKH], [NgayDat], [NgayGiao], [DatCoc], [Thue], [TongTien]) VALUES(N'" + labelIdOrder1.Text + "', N'" + txtStaffId.Text + "', N'" + customerid + "', CAST(N'" + ngaydat + "' AS Date), CAST(N'" + ngaygiao + "' AS Date)," + txtDeposit.Text + "," + labelTax1.Text.Substring(0,2) + "," + labelTotal1.Text + ")";
                            MessageBox.Show(sql);
                            Functions.RunSQL(sql);
                            foreach (DataGridViewRow row in dataGridViewDetail.Rows)
                            {
                                try
                                {
                                    string iddondathang = labelIdOrder1.Text;
                                    string mant = row.Cells[0].Value.ToString();
                                    string soluong = row.Cells[1].Value.ToString();
                                    string giamgia = row.Cells[2].Value.ToString();
                                    string thanhtien = row.Cells[3].Value.ToString();
                                    sql = "INSERT [dbo].[ChiTietDonDH] ([SoDDH], [MaNoiThat], [SoLuong], [GiamGia], [ThanhTien]) VALUES(N'" + iddondathang + "', N'" + mant + "'," + soluong + "," + giamgia + "," + thanhtien + ")";
                                    Functions.RunSQL(sql);
                                    MessageBox.Show("Thêm hóa đơn thành công!");
                                }
                                catch (SqlException)
                                {
                                    MessageBox.Show("Gặp lỗi khi lưu chi tiết đơn đặt hàng!");

                                }
                            }


                        }
                        catch (SqlException )
                        {
                            MessageBox.Show("Thêm hóa đơn thất bại!");

                            Functions.RunSQL("ROLLBACK;");
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!");
                    }


                }
            }
            else
            {
                if (checkTextbox() == true)
                {
                    string customerid = comboBoxCustomerId.SelectedItem.ToString();

                    try
                    {
                        string sql = "INSERT [dbo].[DonDH] ([SoDDH], [MaNV], [MaKH], [NgayDat], [NgayGiao], [DatCoc], [Thue], [TongTien]) VALUES (N'" + labelIdOrder1.Text + "', N'" + txtStaffId.Text + "', N'" + customerid + "', CAST(N'" + ngaydat + "' AS Date), CAST(N'" + ngaygiao + "' AS Date)," + txtDeposit.Text + "," + labelTax1.Text.Substring(0,2) + "," + labelTotal1.Text + ")";
                        Functions.RunSQL(sql);
                        foreach (DataGridViewRow row in dataGridViewDetail.Rows)
                        {
                            try
                            {
                                string iddondathang = labelIdOrder1.Text;
                                string mant = row.Cells[0].Value.ToString();
                                string soluong = row.Cells[1].Value.ToString();
                                string giamgia = row.Cells[2].Value.ToString();
                                string thanhtien = row.Cells[3].Value.ToString();
                                sql = "INSERT[dbo].[ChiTietDonDH] ([SoDDH], [MaNoiThat], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'" + iddondathang + "', N'" + mant + "'," + soluong + "," + giamgia + "," + thanhtien + ")";
                                Functions.RunSQL(sql);
                                MessageBox.Show("Thêm hóa đơn thành công");
                            }
                            catch (SqlException)
                            {
                                MessageBox.Show("Gặp lỗi khi lưu chi tiết đơn đặt hàng!");

                            }
                        }


                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại!");
                  
                    }
                }
            
                }
            
        }
        string generateCustomerId()
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.AUTO_IDKH()", Functions.Con);
            cmd.CommandType = CommandType.Text;
            string id = (string)cmd.ExecuteScalar();
            return id;
        }

        private void comboBoxCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = Functions.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM KhachHang WHERE MaKH = '" + comboBoxCustomerId.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtCustomerName.Text = dr["TenKH"].ToString();
                txtPhoneNumber.Text = dr["DienThoai"].ToString();
                txtAddress.Text = dr["DiaChi"].ToString();
            }
        }

    
        private void comboBoxStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStaffName.SelectedIndex == -1)
            {
                txtStaffId.Text = "";
            }
            else
            {
                txtStaffId.Text = comboBoxStaffName.SelectedValue.ToString();
            }
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewOrder.CurrentRow != null && dataGridViewOrder.Rows.Count > 0)
            {
                string SoDDH = dataGridViewOrder.CurrentRow.Cells[0].Value.ToString();
                string sql = "SELECT * FROM ChiTietDonDH WHERE SoDDH = N'" + SoDDH + "'";
                DataTable dt = new DataTable();
                dt = Functions.GetDataTable(sql);
                dataGridViewDetailOrder.DataSource = dt;
                dt.Dispose();
            }
        }
    }
}
