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
    public partial class EditItem : Form
    {
        NoiThat sanpham;
     
        public EditItem()
        {
                InitializeComponent();
        }
        public EditItem(NoiThat o)
        {
            int index = -1;
            InitializeComponent();
            sanpham = o;
            txtMaNoiThat.Text = sanpham.Ma;
            txtTenNoiThat.Text = sanpham.Ten;
            Functions.FillCombo("SELECT * FROM ChatLieu", cbMaChatLieu, "MaChatLieu", "TenChatLieu");
            cbMaChatLieu.SelectedIndex = cbMaChatLieu.FindString(o.MaChatLieu);
            cbMaChatLieu.SelectedText = o.MaChatLieu;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
  
        private void EditItem_Load(object sender, EventArgs e)
        {
            
        }

        private void cbMaChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
                                                       
        }
    }
}
