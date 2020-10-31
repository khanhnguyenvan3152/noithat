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
            string sql = "SELECT * FROM DMNoiThat";
            DataTable table = Functions.GetDataTable(sql);
            dataGridViewItemList.DataSource = table;
            dataGridViewItemList.ForeColor = Color.Black;
            dataGridViewItemList.Columns[2].Width = 70;
            dataGridViewItemList.Columns[3].Width = 70;
            dataGridViewItemList.Columns[4].Width = 70;
            dataGridViewItemList.Columns[5].Width = 80;
            dataGridViewItemList.Columns[6].Width = 80;
            dataGridViewItemList.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            int selectedrowindex = dataGridViewItemList.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridViewItemList.Rows[selectedrowindex];
            string path = Application.StartupPath + "\\" + row.Cells[10].Value.ToString();
           
                Image img = Image.FromFile(path);
                pictureBox1.Image = img;
                pictureBox1.ImageLocation = path;
                pictureBox1.Visible = true;

           
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButtonRepair_Click(object sender, EventArgs e)
        {

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
            DataGridView dgv_sender = sender as DataGridView;
            DataGridViewRow dgv_MouseOverRow = null;
            if(e.RowIndex>0 && e.ColumnIndex>0 && e.RowIndex<dgv_sender.RowCount && e.ColumnIndex<dgv_sender.ColumnCount)
            {
                dgv_MouseOverRow = dgv_sender.Rows[e.RowIndex];
            }
            if(dgv_MouseOverRow !=null)
            {
                
            }
        }

        private void dataGridViewItemList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
