using System;
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
    public partial class Item : Form
    {

        public Item()
        {
            InitializeComponent();
        }


        private void Item_Load(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 0;
        }

        private void listViewItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel9.ColumnStyles[1].Width = 522;
        }
    }
}
