using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
            tableLayoutPanel9.ColumnStyles[1].Width = 0;
            string sql = "SELECT * FROM DMNoiThat";
            DataTable table = Functions.GetDataTable(sql);
            dataGridViewItemList.DataSource = table;
            dataGridViewItemList.ForeColor = Color.Black;
            /*dataGridViewItemList.Columns[2].Width = 70;
            dataGridViewItemList.Columns[3].Width = 70;
            dataGridViewItemList.Columns[4].Width = 70;
            dataGridViewItemList.Columns[5].Width = 80;
            dataGridViewItemList.Columns[6].Width = 80;*/
            dataGridViewItemList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewItemList.MultiSelect = false;
            Functions.setDataSource(cbChatLieu, "Select MaChatLieu,TenChatLieu FROM ChatLieu");
            Functions.setDataSource(cbKieuDang, "Select * FROM KieuDang");
            Functions.setDataSource(cbTheLoai, "Select *FROM TheLoai");
            Functions.setDataSource(cbMauSac, "Select * FROM MauSac");
            Functions.setDataSource(cbNuocSX, "SELECT MaNSX,TenNSX FROM NuocSX");
            Functions.setDataSource(comboBoxMaterial, "Select MaChatLieu,TenChatLieu FROM ChatLieu");
            Functions.setDataSource(comboBoxType, "Select *FROM TheLoai");
            Functions.setDataSource(comboBoxColor, "Select * FROM MauSac");
            Functions.setDataSource(comboBoxCountry, "SELECT MaNSX,TenNSX FROM NuocSX");
            comboBoxColor.SelectedIndex=comboBoxMaterial.SelectedIndex = comboBoxType.SelectedIndex = comboBoxColor.SelectedIndex = comboBoxCountry.SelectedIndex = -1;
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

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 600;
        }

        private void iconButtonRepair_Click(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 600;

            if (dataGridViewItemList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewItemList.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridViewItemList.Rows[selectedrowindex];
                MessageBox.Show(row.Cells[10].Value.ToString());
                NoiThat sanpham = new NoiThat(row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString(),
                int.Parse(row.Cells[7].Value.ToString()),
                double.Parse(row.Cells[8].Value.ToString()),
                double.Parse(row.Cells[9].Value.ToString()), row.Cells[10].Value.ToString(), row.Cells[11].Value.ToString());
                EditItem editform = new EditItem(sanpham);
                editform.Show();
            }
            // NoiThat sanpham = new NoiThat(row.Cells[0].ToString(), row.Cells[1].ToString(), row.Cells[2].ToString(), row.Cells[3].ToString(), row.Cells[4].ToString(), row.Cells[5].ToString(),
            //                    row.Cells[6].ToString(), int.Parse(row.Cells[7].ToString()), double.Parse(row.Cells[8].ToString()), double.Parse(row.Cells[9].ToString()), row.Cells[10].ToString(), row.Cells[11].ToString());
            //EditItem editform = new EditItem(sanpham);
            //editform.Show();


        }

        private void dataGridViewItemList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridViewItemList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 600;
           
            int selectedrowindex = dataGridViewItemList.SelectedCells[0].RowIndex;
            if (selectedrowindex < dataGridViewItemList.RowCount-1)
            {
                DataGridViewRow row = dataGridViewItemList.Rows[selectedrowindex];
                string path = Application.StartupPath + "\\" + row.Cells[10].Value.ToString();
                
                Image img = Image.FromFile(path);
                pictureBox1.Image = img;
                pictureBox1.ImageLocation = path;
                pictureBox1.Visible = true;
                btnAdd.Enabled = false;
                btnAdd.ForeColor = Color.White;

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxId.Enabled = false;
                textBoxName.Text = row.Cells[1].Value.ToString();

                cbTheLoai.SelectedValue = row.Cells[2].Value;
                cbKieuDang.SelectedValue = row.Cells[3].Value;
                cbMauSac.SelectedValue = row.Cells[4].Value;
                cbChatLieu.SelectedValue = row.Cells[5].Value;
                cbNuocSX.SelectedValue = row.Cells[6].Value;

                textBoxQuantity.Text = row.Cells[7].Value.ToString();
                textBoxImportPrice.Text = row.Cells[8].Value.ToString();
                textBoxSalePrice.Text = row.Cells[9].Value.ToString();
                txtImagePath.Text = path;
                textBoxWarranty.Text = row.Cells[11].Value.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
