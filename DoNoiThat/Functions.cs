using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    class Functions
    {
        public static SqlConnection Con;
        public static void Connect()
        {
            Con = new SqlConnection(); //Khoi tao doi tuong
            Con.ConnectionString = "Data Source=LAPTOP-OHE6O6DD;Initial Catalog=QuanLyCuaHang;Integrated Security=True";
            Con.Open();
            if (Con.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu thành công");
            }
            else MessageBox.Show("Không thể kết nối với cơ sở dữ liệu");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }
        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter Dap = new SqlDataAdapter();
            Dap.SelectCommand = new SqlCommand();
            Dap.SelectCommand.Connection = Functions.Con;
            Dap.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            Dap.Fill(table);
            return table;
        }
        public static void FillCombo(string sql, ComboBox cbo,string ma,string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }

    }
}
