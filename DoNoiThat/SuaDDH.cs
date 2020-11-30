using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public partial class SuaDDH : Form
    {
        string id,idkh,idnv,datcoc;
        DateTime ngaydat,ngaygiao;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuaDDH_Load(object sender, EventArgs e)
        {
            labelID.Text = id;
            comboBoxCustomerId.SelectedItem = idkh;
            txtCustomerName.Text = comboBoxCustomerId.SelectedValue.ToString();
            txtStaffId.Text = idnv;
            txtDeposit.Text = datcoc;
            dateTimePicker1.Value = ngaydat;
            dateTimePicker2.Value = ngaygiao;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }

        public SuaDDH(string id, string idkh,string idnv,string datcoc,DateTime ngaydat, DateTime ngaygiao)
        {
            this.id = id;
            this.idkh = idkh;
            this.idnv = idnv;
            this.datcoc = datcoc;
            this.ngaydat = ngaydat;
            this.ngaygiao = ngaygiao;
          
            InitializeComponent();
            Utils.FillCombo(Utils.NhanVien,comboBoxStaffName, "TenNV", "MaNV");
            Utils.FillCombo(Utils.KhachHang, comboBoxCustomerId, "MaKH", "TenKH");
        }

        private void comboBoxStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStaffId.Text = comboBoxStaffName.SelectedValue.ToString();
        }

        private void comboBoxCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerName.Text = comboBoxCustomerId.SelectedValue.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((comboBoxCustomerId.Text != "") && (txtStaffId.Text != "") && (txtDeposit.Text != ""))
            {
                string sql = "UPDATE DonDH SET MaNV = '" + txtStaffId.Text + "', MaKH ='" + comboBoxCustomerId.Text + "', DatCoc =" + txtDeposit.Text.Trim() + ",NgayDat = CAST('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AS DATE), NgayGiao =CAST('" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AS DATE) WHERE SoDDH = '" + labelID.Text +"'";
                Functions.RunSQL(sql);
                MessageBox.Show("Cập nhật thông tin thành công");
          
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!");
            }
        }
        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

    }
}
