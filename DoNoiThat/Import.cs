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
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            SetDateForDateTimePicker();
            Utils.FillCombo(Utils.NhanVien, comboBoxStaffName, "TenNV", "MaNV");
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
            dateTimePicker2.Value = System.DateTime.Now;
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
    }
}
