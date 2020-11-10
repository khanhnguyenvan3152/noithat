using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public partial class Home : Form
    {
        public SendNotification send;

        public Home(SendNotification sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        /*
         * Chuyển giao diện
         */


        private void icoBtnItem_Click(object sender, EventArgs e)
        {
            this.send(2);
        }

        private void icoBtnOrder_Click(object sender, EventArgs e)
        {
            this.send(3);
        }

        private void icoBtnImportBill_Click(object sender, EventArgs e)
        {
            this.send(4);
        }

        private void icoBtnCustomer_Click(object sender, EventArgs e)
        {
            this.send(5);
        }

        private void icoBtnSupplier_Click(object sender, EventArgs e)
        {
            this.send(6);
        }

        private void icoBtnStaff_Click(object sender, EventArgs e)
        {
            this.send(7);
        }

        private void icoBtnStElse_Click(object sender, EventArgs e)
        {
            this.send(8);
        }

        private void icoBtnReport_Click(object sender, EventArgs e)
        {
            this.send(9);
        }


        /*
         * Thay đổi border, màu, size
        */

        public void MouseMoveChange(Button btn, Panel panel)
        {
            btn.FlatAppearance.BorderSize = 2;
            panel.Margin = new Padding(0);
            panel.Size = new Size(195, 89);
        }

        public void MouseLeaveChange(Button btn, Panel panel, Color color)
        {
            btn.FlatAppearance.BorderSize = 0;
            panel.Margin = new Padding(5);
            panel.Size = new Size(185, 79);
            panel.BackColor = color;
        }

        
        //hover cho icoBtnItem
        private void icoBtnItem_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnItem, panelItem);
        }

        private void icoBtnItem_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnItem, panelItem, Color.DodgerBlue);
        }

        private void icoBtnItem_MouseDown(object sender, MouseEventArgs e)
        {
            panelItem.BackColor = Color.RoyalBlue;
        }


        //hover cho icoBtnOrder
        private void icoBtnOrder_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnOrder, panelOrder);
        }

        private void icoBtnOrder_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnOrder, panelOrder, Color.Tomato);
        }

        private void icoBtnOrder_MouseDown(object sender, MouseEventArgs e)
        {
            panelOrder.BackColor = Color.Red;
        }


        //hover cho icoBtnImportBill
        private void icoBtnImportBill_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnImportBill, panelImportBill);
        }

        private void icoBtnImportBill_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnImportBill, panelImportBill, Color.ForestGreen);
        }

        private void icoBtnImportBill_MouseDown(object sender, MouseEventArgs e)
        {
            panelImportBill.BackColor = Color.DarkGreen;
        }


        //hover cho icoBtnCustomer
        private void icoBtnCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnCustomer, panelCustomer);
        }

        private void icoBtnCustomer_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnCustomer, panelCustomer, Color.DarkViolet);
        }

        private void icoBtnCustomer_MouseDown(object sender, MouseEventArgs e)
        {
            panelCustomer.BackColor = Color.Purple;
        }



        //hover cho icoBtnSupplier
        private void icoBtnSupplier_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnSupplier, panelSupplier);
        }

        private void icoBtnSupplier_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnSupplier, panelSupplier, Color.IndianRed);
        }

        private void icoBtnSupplier_MouseDown(object sender, MouseEventArgs e)
        {
            panelSupplier.BackColor = Color.Firebrick;
        }


        //hover cho icoBtnStaff
        private void icoBtnStaff_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnStaff, panelStaff);
        }

        private void icoBtnStaff_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnStaff, panelStaff, Color.MediumSeaGreen);
        }

        private void icoBtnStaff_MouseDown(object sender, MouseEventArgs e)
        {
            panelStaff.BackColor = Color.SeaGreen;
        }


        //hover cho icoBtnStElse
        private void icoBtnStElse_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnStElse, panelStElse);
        }

        private void icoBtnStElse_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnStElse, panelStElse, Color.Orange);
        }

        private void icoBtnStElse_MouseDown(object sender, MouseEventArgs e)
        {
            panelStElse.BackColor = Color.DarkOrange;
        }


        //hover cho icoBtnReport
        private void icoBtnReport_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveChange(icoBtnReport, panelReport);
        }

        private void icoBtnReport_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveChange(icoBtnReport, panelReport, Color.Teal);
        }

        private void icoBtnReport_MouseDown(object sender, MouseEventArgs e)
        {
            panelReport.BackColor = Color.DarkSlateGray;
        }




        /*
         * Tạo bộ đếm cho các danh mục
         */

        //Đếm cho icoBtnItem
        private void timerCount_Tick(object sender, EventArgs e)
        {
            if (labelItem.Text != "50") labelItem.Text = "" + (int.Parse(labelItem.Text) + 1);
            else timerCount.Stop();
        }
    }
}
