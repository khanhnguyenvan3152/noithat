using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public partial class Item : Form
    {

        int state = 0; // readonly // 1 them //2 sua
        string anh = "";
        public Item()
        {
            InitializeComponent();
        }
        TaskCompletionSource<int> btnAddTs = new TaskCompletionSource<int>();

        private void Item_Load(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 0;
            loadDataGridView();
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
        private void loadDataGridView()
        {
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
        private void clearTextBox()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxQuantity.Text = "";
            textBoxImportPrice.Text = "";
            textBoxSalePrice.Text = "";
            txtImagePath.Text = "";
            textBoxWarranty.Text = "";
            cbChatLieu.SelectedIndex = -1;
            cbKieuDang.SelectedIndex = -1;
            cbMauSac.SelectedIndex = -1;
            cbNuocSX.SelectedIndex = -1;
            cbTheLoai.SelectedIndex = -1;

        }
        private void setEnable(int state)
        {
            switch(state)
            {
                case 0:
                    {
                        textBoxId.Enabled = false;
                        textBoxName.Enabled = false;
                        cbTheLoai.Enabled = false;
                        cbKieuDang.Enabled = false;
                        cbMauSac.Enabled = false;
                        cbChatLieu.Enabled = false;
                        cbNuocSX.Enabled = false;
                        textBoxQuantity.Enabled = false;
                        textBoxImportPrice.Enabled = false;
                        textBoxSalePrice.Enabled = false;
                        textBoxWarranty.Enabled = false;
                        btnChooseImage.Visible = false;
                        btnAdd.Visible = false;
                        btnCancel.Visible = false;
                        break;
                    }
                case 1:
                    {
                        textBoxId.Enabled =false;
                        textBoxName.Enabled = true;
                        cbTheLoai.Enabled = true;
                        cbKieuDang.Enabled = true;
                        cbMauSac.Enabled = true;
                        cbChatLieu.Enabled = true;
                        cbNuocSX.Enabled = true;
                        textBoxQuantity.Enabled = true;
                        textBoxImportPrice.Enabled = true;
                        textBoxSalePrice.Enabled = true;
                        textBoxWarranty.Enabled = true;
                        btnChooseImage.Visible = true;
                        btnAdd.Visible = true;
                        btnAdd.Enabled = true;
                        btnCancel.Visible = true;
                        break;
                    }
                case 2:
                    {
                        textBoxId.Enabled = false;
                        textBoxName.Enabled = true;
                        cbTheLoai.Enabled = true;
                        cbKieuDang.Enabled = true;
                        cbMauSac.Enabled = true;
                        cbChatLieu.Enabled = true;
                        cbNuocSX.Enabled = true;
                        textBoxQuantity.Enabled = true;
                        textBoxImportPrice.Enabled = true;
                        textBoxSalePrice.Enabled = true;
                        textBoxWarranty.Enabled = true;
                        btnChooseImage.Visible = true;
                        btnAdd.Visible = true;
                        btnCancel.Visible = true;
                        break;
                    }
                default: break;
            }
        }


        private void iconButtonRepair_Click(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 600;
            state = 2;
            setEnable(state);
            if (dataGridViewItemList.SelectedRows.Count > 0)
            {
                int selectedrowindex = dataGridViewItemList.SelectedCells[0].RowIndex;
                if (selectedrowindex < dataGridViewItemList.RowCount - 1 )
                {
                    DataGridViewRow row = dataGridViewItemList.Rows[selectedrowindex];
                    string path = Application.StartupPath + "\\" + row.Cells[10].Value.ToString();

                    Image img = Image.FromFile(path);
                    pictureBox1.Image = img;
                    pictureBox1.ImageLocation = path;
                    btnAdd.Text = "Xác nhận";


                    textBoxId.Text = row.Cells[0].Value.ToString();

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
            // NoiThat sanpham = new NoiThat(row.Cells[0].ToString(), row.Cells[1].ToString(), row.Cells[2].ToString(), row.Cells[3].ToString(), row.Cells[4].ToString(), row.Cells[5].ToString(),
            //                    row.Cells[6].ToString(), int.Parse(row.Cells[7].ToString()), double.Parse(row.Cells[8].ToString()), double.Parse(row.Cells[9].ToString()), row.Cells[10].ToString(), row.Cells[11].ToString());
            //EditItem editform = new EditItem(sanpham);
            //editform.Show();
            else
            {
                MessageBox.Show("Chọn một sản phẩm để sửa");
            }

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
            state = 0;
            setEnable(state); //Tat che do chinh sua cua cac o du lieu
            int selectedrowindex = dataGridViewItemList.SelectedCells[0].RowIndex;
            if (selectedrowindex < dataGridViewItemList.RowCount)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValue() == true && state ==1)
            {
                string id = textBoxId.Text;
                string name = textBoxName.Text;
                string type = cbTheLoai.SelectedValue.ToString();
                string shape = cbKieuDang.SelectedValue.ToString();
                string color = cbMauSac.SelectedValue.ToString();
                string material = cbChatLieu.SelectedValue.ToString();
                string country = cbNuocSX.SelectedValue.ToString();
                float importPrice = float.Parse(textBoxImportPrice.Text);
                float salePrice = float.Parse(textBoxSalePrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);
                string warranty = textBoxWarranty.Text;
                Functions.InsertDMNoiThat(id, name, type, shape, color, material, country,quantity, importPrice, salePrice, anh, warranty);
                btnAddTs.SetResult(5);
                MessageBox.Show("Thêm mặt hàng thành công!");
                clearTextBox();
                loadDataGridView();
            }


        }
        bool checkValue()
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Nhập vào tên");
                return false;
            }
             
          
            if (cbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn thể loại");
                return false;
            }
            if (cbKieuDang.SelectedIndex==-1)
            {
                MessageBox.Show("Chọn kiểu dáng");
                return false;
            }
            if (cbMauSac.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn màu sắc");
                return false;
            }
            if (cbChatLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn kiểu dáng");
                return false;
            }
            if (cbNuocSX.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nước sản xuất");
                return false;
            }
            if(textBoxQuantity.Text =="")
            {
                MessageBox.Show("Nhập số lượng");
                return false;
            }
            if(textBoxImportPrice.Text =="")
            {
                MessageBox.Show("Nhập giá nhập vào");
                return false;
            }
            if (textBoxSalePrice.Text == "") 
            {
                MessageBox.Show("Nhập giá bán");
                return false;
            }
            if (textBoxWarranty.Text == "")
            {
                MessageBox.Show("Nhập thời gian bảo hành");
                return false;
            }
            if(txtImagePath.Text=="")
            {
                MessageBox.Show("Chọn ảnh");
                return false;
            }
            return true;
        }
        public string genarateKey()
        {
            string temp = dataGridViewItemList.Rows[dataGridViewItemList.Rows.Count-1].Cells[0].Value.ToString();
            string[] arr = temp.Split('T');
            int chiso = int.Parse(arr[1]);
            chiso++;
            string stringchiso = chiso.ToString();
            string result = "NT" + chiso.ToString("000");
            return result;
        }
        private void iconEnableAdd_Click(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 600;
            state = 1;
            setEnable(state);
            clearTextBox();
            pictureBox1.Image = null;
            dataGridViewItemList.Rows[dataGridViewItemList.CurrentRow.Index].Selected = false;

            textBoxId.Text = genarateKey();
        }

        private async  void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            
            opendlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(opendlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opendlg.FileName);
                string oldPath = opendlg.FileName.ToString();
                string newpath = Application.StartupPath + "\\" +"furniture\\";
                string newFileName = textBoxId.Text;
                FileInfo f1 = new FileInfo(oldPath);
                if (f1.Exists)
                {
                    if (!Directory.Exists(newpath))
                    {
                        Directory.CreateDirectory(newpath);
                    }
                    txtImagePath.Text = newpath;
                    anh = "furniture\\" + newFileName + f1.Extension;
                   var buttondata = await btnAddTs.Task;
                    if (buttondata == 5)
                    {
                        f1.CopyTo(string.Format("{0}{1}{2}", newpath, newFileName, f1.Extension), true);
                    }
                    
                }
            }
        }

        private void textBoxImportPrice_TextChanged(object sender, EventArgs e)
        {   
            if ((state == 2) || (state == 1))
            {
                if (textBoxImportPrice.Text != "")
                {
                    double importprice = double.Parse(textBoxImportPrice.Text);
                    double saleprice = importprice * double.Parse("1.1");
                    textBoxSalePrice.Text = saleprice.ToString();
                }
                else
                {
                    textBoxImportPrice.Text = "0";
                    textBoxSalePrice.Text = "0";
                }
             
            }
        }

        private void Item_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxImportPrice_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxImportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsNumber(e.KeyChar) && Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxImportPrice.Text == "")
            {
                if(char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
        }

        private void textBoxWarranty_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
