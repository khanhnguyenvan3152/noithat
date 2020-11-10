﻿using System;
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

namespace DoNoiThat
{
    public partial class Supplier : Form
    {
        int state;

        public Supplier()
        {
            InitializeComponent();
        }


        private void Supplier_Load(object sender, EventArgs e)
        {
        
            ShowTable();
        }

        private void ShowTable()
        {
            this.dataGridViewSupplier.DataSource = Functions.GetDataTable("SELECT * FROM NhaCungCap");
        }


        /*
         * Bắt sự kiện khi ấn nút
         */
        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridViewSupplier.SelectedCells[0].RowIndex;
            if (selectedRowIndex < dataGridViewSupplier.RowCount)
            {
                DataGridViewRow row = dataGridViewSupplier.Rows[selectedRowIndex];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxAddress.Text = row.Cells[2].Value.ToString();
                textBoxPhone.Text = row.Cells[3].Value.ToString();
            }
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            state = 1;
            EnabledTextBox();
            EnabledButton();
            ClearTextBox();
            textBoxId.Text = Functions.HandleNumber(dataGridViewSupplier,"NCC");
        }

        private void iconButtonRepair_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupplier.SelectedRows.Count > 0)
            {
                state = 2;
                EnabledTextBox();
                EnabledButton();
            }
            else MessageBox.Show("Hãy chọn 1 nhà cung cấp trong bảng!");
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupplier.SelectedRows.Count > 0)
            {
                string sql = @"DELETE FROM NhaCungCap WHERE MaNCC = N'" + textBoxId.Text + "'";
                Functions.PerformSql(sql);
            }
            else MessageBox.Show("Hãy chọn 1 nhà cung cấp trong bảng!");
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

        private void RunCase(int state)
        {
            switch (state)
            {
                case 1:
                    {
                        if (IsEmpty() == false)
                        {
                            string sql = @"INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, DienThoai) VALUES (N'" + textBoxId.Text + "', N'" + textBoxName.Text + "',N'" + textBoxAddress.Text + "',N'" + textBoxPhone.Text + "')";
                            Functions.PerformSql(sql);
                        }
                        break;
                    }
                case 2:
                    {
                        string sql = @"UPDATE NhaCungCap 
                            SET TenNCC = N'" + textBoxName.Text + "', DiaChi = N'" + textBoxAddress.Text + "', DienThoai = N'" + textBoxPhone.Text +
                            "' WHERE MaNCC = N'" + textBoxId.Text + "'";
                        Functions.PerformSql(sql);
                        break;
                    }
            }
        }


        //kiểm tra textBox có rỗng hay không
        private bool IsEmpty()
        {
            if (textBoxId.Text == "" || textBoxName.Text == "" || textBoxAddress.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin!");
                return true;
            }
            return false;
        }

        //làm sạch textBox
        private void ClearTextBox()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
        }

        //kích hoạt textBox
        private void EnabledTextBox()
        {
            textBoxAddress.Enabled = true;
            textBoxName.Enabled = true;
            textBoxPhone.Enabled = true;
        }

        //tắt kich hoạt textBox
        private void DisenableTextBox()
        {
            textBoxAddress.Enabled = false;
            textBoxName.Enabled = false;
            textBoxPhone.Enabled = false;
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
    }
}
