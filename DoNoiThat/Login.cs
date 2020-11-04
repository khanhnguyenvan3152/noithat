﻿using System;
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
    public partial class Login : Form
    {
        private Main main;

        public Login()
        {
            InitializeComponent();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            main = new Main();
            main.ShowDialog();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
