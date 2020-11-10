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
            Con.ConnectionString = "Data Source=DESKTOP-QAHILO8;Initial Catalog=QuanLyCuaHang;Integrated Security=True";
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
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
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
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static SortedDictionary<string, string> Dic (string sql)
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            dap.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                dic.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString());
            }
            return dic;
        }
        public static void setDataSource(ComboBox cb,string sql)
        {
            SortedDictionary<string, string> dic = Dic(sql);
            cb.DataSource = new BindingSource(dic, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        public static void InsertDMNoiThat(string id,
        string name ,
        string type ,
        string shape ,
        string color ,
        string material ,
        string country ,
        int quantity,
        float importPrice ,
        float salePrice,
        string image,
        string warranty)
        {
                SqlCommand cmd = new SqlCommand("InsertDMNoiThat", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNoiThat", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.AddWithValue("@TenNoiThat", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.AddWithValue("@MaLoai", SqlDbType.NVarChar).Value = type;
                cmd.Parameters.AddWithValue("@MaKieu", SqlDbType.NVarChar).Value = shape;
                cmd.Parameters.AddWithValue("@MaMau", SqlDbType.NVarChar).Value = color;
                cmd.Parameters.AddWithValue("@MaChatLieu", SqlDbType.NVarChar).Value = material;
                cmd.Parameters.AddWithValue("@MaNSX", SqlDbType.NVarChar).Value = country;
                cmd.Parameters.AddWithValue("@SoLuong", SqlDbType.Int).Value = quantity;
                cmd.Parameters.AddWithValue("@DonGiaNhap", SqlDbType.Float).Value = importPrice;
                cmd.Parameters.AddWithValue("@DonGiaBan", SqlDbType.Float).Value = salePrice;
                cmd.Parameters.AddWithValue("@Anh", SqlDbType.NVarChar).Value = image;
                cmd.Parameters.AddWithValue("@ThoiGianBH", SqlDbType.NVarChar).Value = warranty;
               try
                {
                    cmd.ExecuteNonQuery();

                }
                catch(Exception)
                {
                    MessageBox.Show("Thêm hàng thất bại!");
                   
                }
                finally
                {
                    
                }

            
        }
        public static void UpdateDMNoiThat(string id,
      string name,
      string type,
      string shape,
      string color,
      string material,
      string country,
      int quantity,
      float importPrice,
      float salePrice,
      string image,
      string warranty)
        {
            SqlCommand cmd = new SqlCommand("UpdateDMNoiThat", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNoiThat", SqlDbType.NVarChar).Value = id;
            cmd.Parameters.AddWithValue("@TenNoiThat", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@MaLoai", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.AddWithValue("@MaKieu", SqlDbType.NVarChar).Value = shape;
            cmd.Parameters.AddWithValue("@MaMau", SqlDbType.NVarChar).Value = color;
            cmd.Parameters.AddWithValue("@MaChatLieu", SqlDbType.NVarChar).Value = material;
            cmd.Parameters.AddWithValue("@MaNSX", SqlDbType.NVarChar).Value = country;
            cmd.Parameters.AddWithValue("@SoLuong", SqlDbType.Int).Value = quantity;
            cmd.Parameters.AddWithValue("@DonGiaNhap", SqlDbType.Float).Value = importPrice;
            cmd.Parameters.AddWithValue("@DonGiaBan", SqlDbType.Float).Value = salePrice;
            cmd.Parameters.AddWithValue("@Anh", SqlDbType.NVarChar).Value = image;
            cmd.Parameters.AddWithValue("@ThoiGianBH", SqlDbType.NVarChar).Value = warranty;
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Sửa mặt hàng thất bại!");

            }
            finally
            {

            }


        }
        public static void PerformSql(string sql)
        {
            SqlCommand Command;
            Command = new SqlCommand(sql, Functions.Con);
            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại!");
            }
            finally
            {

            }
        }

        public static int SubString(DataGridView view)
        {
            if (view.RowCount == 0) return 1;
            string id = view[0, view.RowCount - 1].Value.ToString();
            return int.Parse(id.Substring(3)) + 1;
        }

        public static string HandleNumber(DataGridView view, string str)
        {
            string id;
            if (SubString(view) < 10) id = str + "00" + SubString(view);
            else if (SubString(view) >= 10 && SubString(view) < 100) id = str + "0" + SubString(view);
            else id = str + SubString(view);
            return id;
        }
    }
}
