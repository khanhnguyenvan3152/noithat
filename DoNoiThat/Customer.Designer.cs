using System.Drawing;

namespace DoNoiThat
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.tabControlItem = new System.Windows.Forms.TabControl();
            this.tabPageICustomerList = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelItem = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.iconButtonRepair = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dataGridViewItem = new System.Windows.Forms.DataGridView();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.tabControlItem.SuspendLayout();
            this.tabPageICustomerList.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanelItem.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlItem
            // 
            this.tabControlItem.Controls.Add(this.tabPageICustomerList);
            this.tabControlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlItem.Location = new System.Drawing.Point(0, 0);
            this.tabControlItem.Margin = new System.Windows.Forms.Padding(38, 25, 38, 25);
            this.tabControlItem.Name = "tabControlItem";
            this.tabControlItem.SelectedIndex = 0;
            this.tabControlItem.Size = new System.Drawing.Size(1006, 632);
            this.tabControlItem.TabIndex = 2;
            // 
            // tabPageICustomerList
            // 
            this.tabPageICustomerList.BackColor = System.Drawing.Color.White;
            this.tabPageICustomerList.Controls.Add(this.tableLayoutPanel7);
            this.tabPageICustomerList.Location = new System.Drawing.Point(4, 31);
            this.tabPageICustomerList.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageICustomerList.Name = "tabPageICustomerList";
            this.tabPageICustomerList.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageICustomerList.Size = new System.Drawing.Size(998, 597);
            this.tabPageICustomerList.TabIndex = 1;
            this.tabPageICustomerList.Text = "Khách Hàng";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanelItem, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 589F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(990, 589);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanelItem
            // 
            this.tableLayoutPanelItem.ColumnCount = 2;
            this.tableLayoutPanelItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 492F));
            this.tableLayoutPanelItem.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanelItem.Controls.Add(this.panel13, 1, 0);
            this.tableLayoutPanelItem.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanelItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelItem.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelItem.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelItem.Name = "tableLayoutPanelItem";
            this.tableLayoutPanelItem.RowCount = 2;
            this.tableLayoutPanelItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelItem.Size = new System.Drawing.Size(990, 589);
            this.tableLayoutPanelItem.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.iconButtonAdd);
            this.flowLayoutPanel1.Controls.Add(this.iconButtonRepair);
            this.flowLayoutPanel1.Controls.Add(this.iconButtonDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 533);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(490, 52);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButtonAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.White;
            this.iconButtonAdd.IconSize = 20;
            this.iconButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.Location = new System.Drawing.Point(19, 4);
            this.iconButtonAdd.Margin = new System.Windows.Forms.Padding(19, 4, 4, 0);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Padding = new System.Windows.Forms.Padding(6, 0, 19, 0);
            this.iconButtonAdd.Rotation = 0D;
            this.iconButtonAdd.Size = new System.Drawing.Size(118, 49);
            this.iconButtonAdd.TabIndex = 0;
            this.iconButtonAdd.Text = "Thêm";
            this.iconButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAdd.UseVisualStyleBackColor = false;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // iconButtonRepair
            // 
            this.iconButtonRepair.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonRepair.FlatAppearance.BorderSize = 0;
            this.iconButtonRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRepair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonRepair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRepair.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonRepair.IconColor = System.Drawing.Color.White;
            this.iconButtonRepair.IconSize = 20;
            this.iconButtonRepair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRepair.Location = new System.Drawing.Point(160, 4);
            this.iconButtonRepair.Margin = new System.Windows.Forms.Padding(19, 4, 4, 0);
            this.iconButtonRepair.Name = "iconButtonRepair";
            this.iconButtonRepair.Padding = new System.Windows.Forms.Padding(6, 0, 19, 0);
            this.iconButtonRepair.Rotation = 0D;
            this.iconButtonRepair.Size = new System.Drawing.Size(118, 49);
            this.iconButtonRepair.TabIndex = 0;
            this.iconButtonRepair.Text = "Sửa";
            this.iconButtonRepair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonRepair.UseVisualStyleBackColor = false;
            this.iconButtonRepair.Click += new System.EventHandler(this.iconButtonRepair_Click);
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.iconButtonDelete.FlatAppearance.BorderSize = 0;
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonDelete.IconColor = System.Drawing.Color.White;
            this.iconButtonDelete.IconSize = 20;
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDelete.Location = new System.Drawing.Point(301, 4);
            this.iconButtonDelete.Margin = new System.Windows.Forms.Padding(19, 4, 4, 0);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Padding = new System.Windows.Forms.Padding(6, 0, 19, 0);
            this.iconButtonDelete.Rotation = 0D;
            this.iconButtonDelete.Size = new System.Drawing.Size(118, 49);
            this.iconButtonDelete.TabIndex = 0;
            this.iconButtonDelete.Text = "Xóa";
            this.iconButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SlateGray;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.buttonCancel);
            this.panel13.Controls.Add(this.buttonOk);
            this.panel13.Controls.Add(this.dataGridViewItem);
            this.panel13.Controls.Add(this.textBoxAddress);
            this.panel13.Controls.Add(this.textBoxPhone);
            this.panel13.Controls.Add(this.textBoxId);
            this.panel13.Controls.Add(this.textBoxName);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(510, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(480, 529);
            this.panel13.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label9.Location = new System.Drawing.Point(198, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "BÁO CÁO";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(341, 472);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonOk.Enabled = false;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(211, 472);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 32);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dataGridViewItem
            // 
            this.dataGridViewItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem.Location = new System.Drawing.Point(5, 185);
            this.dataGridViewItem.Margin = new System.Windows.Forms.Padding(12, 62, 4, 4);
            this.dataGridViewItem.Name = "dataGridViewItem";
            this.dataGridViewItem.RowHeadersWidth = 51;
            this.dataGridViewItem.Size = new System.Drawing.Size(468, 280);
            this.dataGridViewItem.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Location = new System.Drawing.Point(301, 86);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(119, 26);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Enabled = false;
            this.textBoxPhone.Location = new System.Drawing.Point(90, 81);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(119, 26);
            this.textBoxPhone.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(90, 41);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(119, 26);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(301, 41);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(119, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên KH:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "DANH SÁCH SẢN PHẨM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "SĐT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã KH:";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel9.Controls.Add(this.dataGridViewCustomer, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.61986F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(498, 529);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCustomer.GridColor = System.Drawing.Color.Black;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(498, 529);
            this.dataGridViewCustomer.TabIndex = 0;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 632);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlItem);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1006, 632);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tabControlItem.ResumeLayout(false);
            this.tabPageICustomerList.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanelItem.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlItem;
        private System.Windows.Forms.TabPage tabPageICustomerList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private FontAwesome.Sharp.IconButton iconButtonRepair;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridView dataGridViewItem;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonCancel;
    }
}