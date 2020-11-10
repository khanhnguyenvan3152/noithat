using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public delegate void SendNotification(int value);

    public partial class Main : Form
    {
        static private Form currentForm;

        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            ECAvatar(pictureBoxAvatar, 36);
            ECAvatar(panelAvatar, 40);

            labelDate.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            Functions.Connect();
            OpenChildForm(new Home(GetValue));
        }

        private void GetValue(int value)
        {
            if (value == 2) iconButtonIItem.PerformClick();
            if (value == 3) iconButtonOrder.PerformClick();
            if (value == 4) iconButtonImportBill.PerformClick();
            if (value == 5) iconButtonCustomer.PerformClick();
            if (value == 6) iconButtonSupplier.PerformClick();
            if (value == 7) iconButtonStaff.PerformClick();
            if (value == 8) iconButtonStElse.PerformClick();
            if (value == 9) iconButtonReport.PerformClick();
        }


        //tạo avatar tròn
        private void ECAvatar(Control ob, int cornerRadius)
        {
            ElipseControl elipseControl = new ElipseControl();
            elipseControl.TargetControl = ob;
            elipseControl.CornerRadius = cornerRadius;
        }


        //mở form con
        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null) currentForm.Close(); 
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            paneMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }



        /*
         * Chuyển giao diện
         */

        public void iconButtonHome_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button1, iconButtonHome);
            OpenChildForm(new Home(GetValue));
        }

        public void iconButtonIItem_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button2, iconButtonIItem);
            OpenChildForm(new Item());
        }


        public void iconButtonOrder_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button3, iconButtonOrder);
            OpenChildForm(new Order());
        }

        public void iconButtonImportBill_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button4, iconButtonImportBill);
            OpenChildForm(new Import());
        }

        public void iconButtonCustomer_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button5, iconButtonCustomer);
            OpenChildForm(new Customer());
        }


        public void iconButtonSupplier_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button6, iconButtonSupplier);
            OpenChildForm(new Supplier());
        }

        public void iconButtonStaff_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button7, iconButtonStaff);
            OpenChildForm(new Staff());
        }

        private void iconButtonStElse_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button8, iconButtonStElse);
            OpenChildForm(new Else());
        }


        public void iconButtonReport_Click(object sender, EventArgs e)
        {
            Disenable();
            EnableButton(button9, iconButtonReport);
        }



        //kich hoạt nút khi click vào button
        private void EnableButton(Button btn1, Button btn2)
        {
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.FromArgb(30,30,30);
            btn2.Font = new Font("Arial", 12, FontStyle.Bold);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
        }


        //tắt kích hoạt sau khi chuyển form
        private void Disenable()
        {
            DisenableButton(button1, iconButtonHome);
            DisenableButton(button2, iconButtonIItem);
            DisenableButton(button3, iconButtonOrder);
            DisenableButton(button4, iconButtonImportBill);
            DisenableButton(button5, iconButtonCustomer);
            DisenableButton(button6, iconButtonSupplier);
            DisenableButton(button7, iconButtonStaff);
            DisenableButton(button8, iconButtonStElse);
            DisenableButton(button9, iconButtonReport);
        }

        private void DisenableButton(Button btn1, Button btn2)
        {
            btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn2.Font = new Font("Arial",12 , FontStyle.Regular);
        }



        //Sự kiện nút Bars khi được Click
        private void iconButtonBars_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel3.ColumnStyles[0].Width != 60) tableLayoutPanel3.ColumnStyles[0].Width = 60;
            else tableLayoutPanel3.ColumnStyles[0].Width = 239;
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
        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }
    }
}
