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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }


        private void Staff_Load(object sender, EventArgs e)
        {
           
        }

        //private void listViewItem_Click(object sender, EventArgs e)
        //{
        //    tableLayoutPanelItem.ColumnStyles[1].Width = 522;
        //}

        private void iconButtonArrowRight_Click(object sender, EventArgs e)
        {
            tableLayoutPanelItem.ColumnStyles[1].Width = 0;
        }

        private void listViewItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanelItem.ColumnStyles[1].Width = 522;
        }
    }
}
