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
        Dictionary<string, string> ChatLieu;
     
        public EditItem()
        {
                InitializeComponent();
        }
        public EditItem(NoiThat o)
        {
            InitializeComponent();
            sanpham = o;
            txtMaNoiThat.Text = sanpham.Ma;
            txtTenNoiThat.Text = sanpham.Ten;
            cbMaChatLieu.SelectedIndex = cbMaChatLieu.FindString(sanpham.MaChatLieu);
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
        private Dictionary<string,string> TimKiem(string sql)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            DataTable table = Functions.GetDataTable(sql);
            foreach(DataRow row in table.Rows)
            {
                dic.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString());
            }
            return dic;
        }
        private void EditItem_Load(object sender, EventArgs e)
        {
            ChatLieu = TimKiem("SELECT * FROM ChatLieu");
            foreach(var lmao in ChatLieu)
            {
                cbMaChatLieu.Items.Add(lmao.Key);
            }
        }

        private void cbMaChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            sanpham.MaChatLieu = ChatLieu[cbMaChatLieu.SelectedItem.ToString()];
        }
    }
}
