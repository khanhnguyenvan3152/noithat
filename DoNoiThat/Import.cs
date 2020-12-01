using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public partial class Import : Form
    {
       
    
        public Import()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
           
            SetDateForDateTimePicker();
            Utils.FillCombo(Utils.NhanVien, comboBoxStaffName, "TenNV", "MaNV");
            txtStaffId.Text = comboBoxStaffName.SelectedValue.ToString();
        }
        void resetValue()
        {
            txtGiaNhap.Text = "0";
            txtIdNCC.Text = "";
            txtTenNCC.Text = "";
            txtSearchName.Text = "";
            numericUpDownAmount.Value = 0;
            txtGiamGia.Text = "0";
        }
        bool checkTextBox()
        {
            if(txtIdNCC.Text =="")
            {
                MessageBox.Show("Chọn nhà cung cấp!");
                btnChonNCC.Focus();
                return false;
            }
            if(txtStaffId.Text == "")
            {
                MessageBox.Show("Chọn nhân viên!");
                comboBoxStaffName.Focus();
                return false;
            }    
            if(txtGiamGia.Text =="")
            {
                MessageBox.Show("Nhập giá giảm!");
                txtGiamGia.Focus();
                return false;
            }
            if(numericUpDownAmount.Value ==0)
            {
                MessageBox.Show("Nhập số lượng!");
                numericUpDownAmount.Focus();
                return false;
            }
            if(Double.Parse(txtGiaNhap.Text)==0)
            {
                MessageBox.Show("Giá nhập phải lớn hơn 0!");
                txtGiaNhap.Focus();
                return false;
            }    
            return true;
        }
        private void Import_Load(object sender, EventArgs e)
        {
            loadDanhSachNoiThat();
            loadDanhSachHDN();
            resetValue();
            labelIdImport1.Text = genarateKey();
        }
        void SetDateForDateTimePicker()
        {
            dateTimePicker1.Value = System.DateTime.Now;
          
        }
        private void groupBoxCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void btnChonNCC_Click(object sender, EventArgs e)
        {
            ChooseSupplier ch = new ChooseSupplier();
            ch.DataSent += Ch_DataSent;
            ch.ShowDialog();
        }
        private void loadDanhSachNoiThat()
        {
            string sql = "SELECT MaNoiThat,TenNoiThat,DonGiaNhap,DonGiaBan,SoLuong FROM DMNoiThat";
            dataGridItem.DataSource = Functions.GetDataTable(sql);
        }
        private void loadDanhSachHDN()
        {
            string sql = "SELECT * FROM HoaDonNhap";
            dataGridViewImport.DataSource = Functions.GetDataTable(sql);
        }
        public string genarateKey()
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.AUTO_IDHDN()", Functions.Con);
            cmd.CommandType = CommandType.Text;

            //add parameter for return value

            string id = (string)cmd.ExecuteScalar();
            return id;
        }
        private void Ch_DataSent(string id, string name)
        {
            this.txtIdNCC.Text = id;
            this.txtTenNCC.Text = name;
           
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (dataGridItem.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một sản phẩm");
                dataGridItem.Focus();
            }
            else
            {
                if(checkTextBox() == true)
                {
                    DataGridViewRow row = dataGridItem.CurrentRow;
                    string mant = row.Cells[0].Value.ToString();
                    string dongia = txtGiaNhap.Text;
                    string giamgia = txtGiamGia.Text;
                    string thanhtien = "";
                    string SL = "";
                    int soluong = int.Parse(numericUpDownAmount.Value.ToString());
                    bool check = false;
                    SL = soluong.ToString();
                    thanhtien = ((double)(soluong * float.Parse(dongia) - double.Parse(giamgia))).ToString();
                    if (dataGridViewDetail.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow tmprow in dataGridViewDetail.Rows)
                        {
                            if (tmprow.Cells[0].Value != null)
                            {
                                if (tmprow.Cells[0].Value.ToString().Equals(mant))
                                {
                                    soluong = soluong + int.Parse(tmprow.Cells[2].Value.ToString());
                                    double tong = float.Parse(thanhtien) + float.Parse(tmprow.Cells[4].Value.ToString());
                                    double tonggiam = double.Parse(giamgia) + double.Parse(tmprow.Cells[3].Value.ToString());
                                    tmprow.Cells[2].Value = soluong.ToString();
                                    tmprow.Cells[4].Value = tong.ToString();
                                    tmprow.Cells[3].Value = tonggiam.ToString();
                                    check = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (check == false)
                    {
                        dataGridViewDetail.Rows.Add(mant, dongia, soluong, giamgia, thanhtien);
                    }
                    if (dataGridViewDetail.Rows.Count > 0)
                    {
                        double tong = 0;
                        foreach (DataGridViewRow r in dataGridViewDetail.Rows)
                        {
                            if (r.Cells[4].Value != null)
                            {
                                tong = tong + Convert.ToDouble(r.Cells[4].Value);
                            }
                        }
                   
                        labelTotal1.Text = tong.ToString();
                    }
                    
                }    
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

        private void btnLuuHDN_Click(object sender, EventArgs e)
        {
            if(dataGridViewDetail.Rows.Count > 0)
            {
                string ngaynhap = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string idhdn = labelIdImport1.Text;
                string idnv = txtStaffId.Text;
                string idncc = txtIdNCC.Text;
                string tongtien = labelTotal1.Text;
                string sql = "INSERT[dbo].[HoaDonNhap]([SoHDN], [MaNV], [NgayNhap], [MaNCC], [TongTien]) VALUES(N'" + idhdn + "', N'" + idnv + "', CAST(N'" + ngaynhap + "' AS Date), N'" + idncc + "', " + tongtien + ")";
                SqlCommand cmd = new SqlCommand(sql, Functions.Con);
                cmd.CommandType = CommandType.Text;
                int dem = 0;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewDetail.Rows)
                    {
                        string mant = row.Cells[0].Value.ToString();
                        string dongianhap = row.Cells[1].Value.ToString();
                        string sl = row.Cells[2].Value.ToString();
                        string giamgia = row.Cells[3].Value.ToString();
                        string thanhtien = row.Cells[4].Value.ToString();
                        string command = "INSERT [dbo].[ChiTietHDN] ([SoHDN], [MaNoiThat], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES (N'" + idhdn + "', N'" + mant + "'," + sl + "," + dongianhap + "," + giamgia + "," + thanhtien + ")";
                        SqlCommand sqlcmd = new SqlCommand(command, Functions.Con);
                        sqlcmd.CommandType = CommandType.Text;
                        dem += sqlcmd.ExecuteNonQuery();
                    }
                }
                if(dem >0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                    loadDanhSachNoiThat();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!");
                }   
              
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            comboBoxStaffName.SelectedIndex = -1;
            txtIdNCC.Text = "";
            txtGiamGia.Text = "0";
            txtGiaNhap.Text = "0";
            txtTenNCC.Text = "";
            numericUpDownAmount.Value = 0;
            labelTotal1.Text = "0";
            dataGridViewDetail.Rows.Clear();
            labelIdImport1.Text = genarateKey();
        }
        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void tabControlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlOrder.SelectedIndex == 0)
            {
                loadDanhSachHDN();
            }
            if(tabControlOrder.SelectedIndex == 1)
            {
                loadDanhSachNoiThat();
            }
        }

        private void iconTimKiemTen_Click(object sender, EventArgs e)
        {
            if(txtSearchName.Text !="")
            {
                string sql = "SELECT MaNoiThat,TenNoiThat,DonGiaNhap,DonGiaBan,SoLuong FROM DMNoiThat WHERE TenNoiThat LIKE N'%" + txtSearchName.Text.Trim() + "%'";
                dataGridItem.DataSource = Functions.GetDataTable(sql);
            }
            else
            {
                loadDanhSachNoiThat();
            }    
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                iconTimKiemTen.PerformClick();
            }    
        }

        private void dataGridViewImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewImport.CurrentRow != null && dataGridViewImport.Rows.Count > 0)
            {
                DataGridViewRow row = dataGridViewImport.CurrentRow;
                string SoHDN = row.Cells[0].Value.ToString();
                string sql = "SELECT * FROM ChiTietHDN WHERE SoHDN = N'" + SoHDN + "'";
                DataTable dt;
                dt = Functions.GetDataTable(sql);
                dataGridViewImportDetail.DataSource = dt;
                dt.Dispose();
                string mancc = row.Cells[3].Value.ToString();
                string manv = row.Cells[1].Value.ToString();
                DataTable kh;
                sql = "SELECT * FROM NhaCungCap WHERE MaNCC = N'" + mancc + "'";

                kh = Functions.GetDataTable(sql);
                labelIdImport.Text = row.Cells[0].Value.ToString();
                labelImportDate.Text = DateTime.Parse(row.Cells[2].Value.ToString()).ToString("dd-MM-yyyy");
                labelTotal.Text = row.Cells[4].Value.ToString();
                if (kh.Rows.Count > 0)
                {
                    lblMaNCC.Text = kh.Rows[0].ItemArray[0].ToString();
                    txtNCCTen.Text = kh.Rows[0].ItemArray[1].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!");
                }
                sql = "SELECT * FROM NhanVien WHERE MaNV = N'" + manv + "'";
                DataTable nv;
                nv = Functions.GetDataTable(sql);
                if (nv.Rows.Count > 0)
                {
                    lblMaNV.Text = nv.Rows[0].ItemArray[0].ToString();
                    lblTenNV.Text = nv.Rows[0].ItemArray[1].ToString();
               
                }
            }
        }
        void resettab0() //reset lại các control của tab 0
        {
            loadDanhSachHDN();
            labelIdImport.Text = "";
            labelImportDate.Text = "";
            dataGridViewImportDetail.Rows.Clear();
            labelTotal.Text = "";
            lblTenNV.Text = "";
            lblMaNV.Text = "";
            lblMaNCC.Text = "";
            txtNCCTen.Text = "";
        }
        private void iconButtonXoaDonDH_Click(object sender, EventArgs e)
        {
            if (dataGridViewImport.CurrentRow != null && dataGridViewImport.CurrentRow.Index > -1)
            {
                string mahdn = dataGridViewImport.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có muốn xóa hóa đơn nhập " + mahdn + " ?", "Xóa hóa đơn", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    string sql = "DELETE FROM HoaDonNhap WHERE SoHDN = N'" + mahdn + "'";
                    SqlCommand cmd = new SqlCommand(sql, Functions.Con);
                    cmd.CommandType = CommandType.Text;
                    if(cmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thành công!");
                        resettab0();
                    }    
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thất bại!");
                    }    
                }    
                
            }
        }

        private void iconButtonFilter_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTimMa.Text == "") && (txtTimNV.Text == "") && (txtTimNCC.Text == "") )
            {
                sql = "SELECT * FROM HoaDonNhap";
            }
            sql = "SELECT SoHDN,HoaDonNhap.MaNV,NgayNhap,HoaDonNhap.MaNCC,TongTien FROM HoaDonNhap JOIN NhanVien ON HoaDonNhap.MaNV = NhanVien.MaNV JOIN NhaCungCap ON HoaDonNhap.MaNCC = NhaCungCap.MaNCC WHERE 1=1";
            if (txtTimMa.Text != "")
            {
                sql += " AND SoHDN LIKE N'%" + txtTimMa.Text + "%'";
            }
            if (txtTimNV.Text != "")
            {
                sql += " AND TenNV LIKE N'%" + txtTimNV.Text + "%'";
            }
            if (txtTimNCC.Text != "")
            {
                sql += " AND TenNCC LIKE N'%" + txtTimNCC.Text + "%'";
            }
         
            DataTable temptb = Functions.GetDataTable(sql);
            dataGridViewImport.DataSource = temptb;
            temptb.Dispose();
            
        }

        private void iconPrint1_Click(object sender, EventArgs e)
        {
            PrintHDN printer = new PrintHDN(labelIdImport1.Text);
            printer.Show();
        }

        private void iconButtonPrinter_Click(object sender, EventArgs e)
        {
           if(labelIdImport.Text!="")
            {
                PrintHDN printer = new PrintHDN(labelIdImport.Text);
                printer.Show();
            }
           else
            {
                MessageBox.Show("Chọn đơn hàng để in");
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetail.Rows.Count == 0)
            {
                MessageBox.Show("Đơn hàng chưa có sản phẩm!");
            }
            else
            {
                double tongtien = Convert.ToDouble(labelTotal1.Text);

                double thanhtien = Convert.ToDouble(dataGridViewDetail.CurrentRow.Cells[4].Value);
                tongtien = tongtien - thanhtien;
                labelTotal1.Text = tongtien.ToString();
                dataGridViewDetail.Rows.RemoveAt(dataGridViewDetail.CurrentRow.Index);
                if (dataGridViewDetail.Rows.Count == 0)
                {
                    labelTotal1.Text = "0";
                }
            }
        }

        private void dataGridItem_SelectionChanged(object sender, EventArgs e)
        {
            txtGiaNhap.Text = "0";
            txtGiamGia.Text = "0";
            numericUpDownAmount.Value = 0;
        }

        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            resettab0();
        }
    }
}
