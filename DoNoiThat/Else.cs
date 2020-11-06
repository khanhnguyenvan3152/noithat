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
    public partial class Else : Form
    {
        int state;
        int dGV;
        Dictionary<int, string[]> dicTable = new Dictionary<int, string[]>() {
            {0, new string[] {"TheLoai", "MaLoai", "TenLoai" } },
            {1, new string[] {"KieuDang", "MaKieu", "TenKieu"} },
            {2, new string[] {"MauSac", "MaMau", "TenMau"} },
            {3, new string[] {"ChatLieu", "MaChatLieu", "TenChatLieu"} },
            {4, new string[] {"NuocSX", "MaNSX", "TenNSX"} },
            {5, new string[] {"CaLam", "MaCa", "TenCa"} },
            {6, new string[] {"CongViec", "MaCV", "TenCV"} }
        };

        public Else()
        {
            InitializeComponent();
        }

        private void Else_Load(object sender, EventArgs e)
        {
         
            ShowTable();
        }

        private void ShowTable()
        {
            this.dataGridViewKind.DataSource = Functions.GetDataTable("SELECT * FROM TheLoai");
            this.dataGridViewModern.DataSource = Functions.GetDataTable("SELECT * FROM KieuDang");
            this.dataGridViewColor.DataSource = Functions.GetDataTable("SELECT * FROM MauSac");
            this.dataGridViewMateral.DataSource = Functions.GetDataTable("SELECT * FROM ChatLieu");
            this.dataGridViewCountry.DataSource = Functions.GetDataTable("SELECT * FROM NuocSX");
            this.dataGridViewPast.DataSource = Functions.GetDataTable("SELECT * FROM CaLam");
            this.dataGridViewJob.DataSource = Functions.GetDataTable("SELECT * FROM CongViec");
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            EnabledTextBox();
            EnabledButton();
            ClearTextBox();
            state = 1;
        }

        private void iconButtonRepair_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            RunCase(state);
            DisenableTextBox();
            DisenableButton();
            ClearTextBox();
            ShowTable();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            DisenableButton();
            DisenableTextBox();
        }

        private void comboBoxNameTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNameTable.Text == "") return;
            int state = comboBoxNameTable.SelectedIndex;
            if (state == 0) textBoxId.Text = Functions.HandleNumber(dataGridViewKind, "TL");
            else if (state == 1) textBoxId.Text = Functions.HandleNumber(dataGridViewModern, "KD");
            else if (state == 2) textBoxId.Text = Functions.HandleNumber(dataGridViewColor, "MS");
            else if (state == 3) textBoxId.Text = Functions.HandleNumber(dataGridViewKind, "CL");
            else if (state == 4) textBoxId.Text = Functions.HandleNumber(dataGridViewCountry, "NSX");
            else if (state == 5) textBoxId.Text = Functions.HandleNumber(dataGridViewPast, "CA");
            else textBoxId.Text = Functions.HandleNumber(dataGridViewJob, "CV"); ;
        }

        //chọn chức năng thực hiện
        private void RunCase(int state)
        {
            string[] strs = dicTable[comboBoxNameTable.SelectedIndex];
            switch (state)
            {
                case 1:
                    {
                        string sql = "INSERT INTO " + strs[0] + " (" + strs[1] + ", " + strs[2] + ")" + " VALUES (N'" + textBoxId.Text + "', N'" + textBoxName.Text + "')";
                        Functions.PerformSql(sql);
                        break;
                    }
                case 2:
                    {
                        string sql = "UPDATE " + strs[0] + " SET " + strs[2] + " = N'" + textBoxName.Text + "' WHERE " + strs[1] + " = N'" + textBoxId.Text + "'";
                        Functions.PerformSql(sql);
                        break;
                    }
            }
            ShowTable();
        }


        //kiểm tra textBox có rỗng hay không
        private bool IsEmpty()
        {
            if (textBoxId.Text == "" || textBoxName.Text == "" || comboBoxNameTable.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin!");
                return true;
            }
            return false;
        }

        //làm sạch textBox
        private void ClearTextBox()
        {
            comboBoxNameTable.SelectedIndex = -1;
            textBoxId.Text = "";
            textBoxName.Text = "";
        }


        //kích hoạt textBox
        private void EnabledTextBox()
        {
            comboBoxNameTable.Enabled = true;
            textBoxName.Enabled = true;
        }

        //tắt kich hoạt textBox
        private void DisenableTextBox()
        {
            textBoxName.Enabled = false;
            comboBoxNameTable.Enabled = false;
        }

        //kích hoạt nút
        private void EnabledButton()
        {
            buttonOk.Enabled = true;
            buttonCancel.Enabled = true;
        }

        //tắt kích hoạt nút
        private void DisenableButton()
        {
            buttonOk.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void dataGridViewKind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor(dataGridViewKind, 0);
        }

        private void dataGridViewModern_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor(dataGridViewModern, 1);
        }

        private void dataGridViewColor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor(dataGridViewColor, 2);
        }

        private void dataGridViewMateral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor(dataGridViewMateral, 3);
        }

        private void dataGridViewCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor(dataGridViewCountry, 4);
        }

        private void dataGridViewPast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor(dataGridViewPast, 5);
        }

        private void dataGridViewJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfor(dataGridViewJob, 6);
        }

        private void GetInfor(DataGridView dataTable, int index)
        {
            comboBoxNameTable.SelectedIndex = index;
            int selectedRowIndex = dataTable.SelectedCells[0].RowIndex;
            if (selectedRowIndex < dataTable.RowCount)
            {
                DataGridViewRow row = dataTable.Rows[selectedRowIndex];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
