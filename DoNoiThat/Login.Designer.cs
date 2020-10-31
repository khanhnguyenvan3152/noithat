using System.Drawing;
using System.Windows.Forms;

namespace DoNoiThat
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.labelTitleLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSignup);
            this.panel1.Controls.Add(this.labelTitleLogin);
            this.panel1.Location = new System.Drawing.Point(388, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 287);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxPassword);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Location = new System.Drawing.Point(49, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 32);
            this.panel3.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(48, 6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(211, 19);
            this.textBoxPassword.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Indigo;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Indigo;
            this.iconPictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 32);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(55, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật Khẩu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxUserName);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(49, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 32);
            this.panel2.TabIndex = 13;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(48, 6);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(211, 19);
            this.textBoxUserName.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Indigo;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Indigo;
            this.iconPictureBox1.IconSize = 33;
            this.iconPictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 33);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(55, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(43)))), ((int)(((byte)(121)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(73)))), ((int)(((byte)(235)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(148, 238);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 29);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(43)))), ((int)(((byte)(121)))));
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(73)))), ((int)(((byte)(235)))));
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(28, 238);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(89, 29);
            this.buttonSignup.TabIndex = 10;
            this.buttonSignup.Text = "Đăng Nhập";
            this.buttonSignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // labelTitleLogin
            // 
            this.labelTitleLogin.AutoSize = true;
            this.labelTitleLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleLogin.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(43)))), ((int)(((byte)(121)))));
            this.labelTitleLogin.Location = new System.Drawing.Point(99, 34);
            this.labelTitleLogin.Name = "labelTitleLogin";
            this.labelTitleLogin.Size = new System.Drawing.Size(173, 33);
            this.labelTitleLogin.TabIndex = 9;
            this.labelTitleLogin.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 630);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSignup;
        private Label labelTitleLogin;
        private TextBox textBoxUserName;
        private Panel panel3;
        private TextBox textBoxPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label2;
    }
}

