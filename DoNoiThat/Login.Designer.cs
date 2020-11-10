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
            this.labelDatasource = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxDatasource = new System.Windows.Forms.TextBox();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.textBoxUername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelTitleLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDatasource
            // 
            this.labelDatasource.AutoSize = true;
            this.labelDatasource.BackColor = System.Drawing.Color.Transparent;
            this.labelDatasource.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatasource.ForeColor = System.Drawing.Color.White;
            this.labelDatasource.Location = new System.Drawing.Point(544, 340);
            this.labelDatasource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatasource.Name = "labelDatasource";
            this.labelDatasource.Size = new System.Drawing.Size(105, 19);
            this.labelDatasource.TabIndex = 1;
            this.labelDatasource.Text = "Datasource:";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.BackColor = System.Drawing.Color.Transparent;
            this.labelDatabase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabase.ForeColor = System.Drawing.Color.White;
            this.labelDatabase.Location = new System.Drawing.Point(544, 377);
            this.labelDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(88, 19);
            this.labelDatabase.TabIndex = 2;
            this.labelDatabase.Text = "Database:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(544, 411);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(94, 19);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(545, 446);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 19);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(43)))), ((int)(((byte)(121)))));
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(73)))), ((int)(((byte)(235)))));
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(549, 507);
            this.buttonSignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(119, 36);
            this.buttonSignup.TabIndex = 5;
            this.buttonSignup.Text = "Đăng Nhập";
            this.buttonSignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(43)))), ((int)(((byte)(121)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(73)))), ((int)(((byte)(235)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(709, 507);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 36);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxDatasource
            // 
            this.textBoxDatasource.Location = new System.Drawing.Point(681, 338);
            this.textBoxDatasource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDatasource.Name = "textBoxDatasource";
            this.textBoxDatasource.Size = new System.Drawing.Size(260, 22);
            this.textBoxDatasource.TabIndex = 7;
            // 
            // textBoxDB
            // 
            this.textBoxDB.Location = new System.Drawing.Point(681, 375);
            this.textBoxDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(260, 22);
            this.textBoxDB.TabIndex = 8;
            // 
            // textBoxUername
            // 
            this.textBoxUername.Location = new System.Drawing.Point(681, 410);
            this.textBoxUername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUername.Name = "textBoxUername";
            this.textBoxUername.Size = new System.Drawing.Size(260, 22);
            this.textBoxUername.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(681, 444);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(260, 22);
            this.textBoxPassword.TabIndex = 10;
            // 
            // labelTitleLogin
            // 
            this.labelTitleLogin.AutoSize = true;
            this.labelTitleLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(43)))), ((int)(((byte)(121)))));
            this.labelTitleLogin.Location = new System.Drawing.Point(636, 268);
            this.labelTitleLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleLogin.Name = "labelTitleLogin";
            this.labelTitleLogin.Size = new System.Drawing.Size(203, 36);
            this.labelTitleLogin.TabIndex = 0;
            this.labelTitleLogin.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1493, 775);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUername);
            this.Controls.Add(this.textBoxDB);
            this.Controls.Add(this.textBoxDatasource);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.labelDatasource);
            this.Controls.Add(this.labelTitleLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelDatasource;
        private Label labelDatabase;
        private Label labelUsername;
        private Label labelPassword;
        private Button buttonSignup;
        private Button buttonCancel;
        private TextBox textBoxDatasource;
        private TextBox textBoxDB;
        private TextBox textBoxUername;
        private TextBox textBoxPassword;
        private Label labelTitleLogin;
    }
}

