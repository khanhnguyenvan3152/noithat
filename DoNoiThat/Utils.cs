using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace DoNoiThat
{
    class Utils : Form 
    {
        public static DataTable KhachHang = Functions.GetDataTable("SELECT MaKH,TenKH FROM KhachHang");
        public static DataTable TheLoai = Functions.GetDataTable("SELECT MaLoai,TenLoai FROM TheLoai");
        public static DataTable KieuDang = Functions.GetDataTable("SELECT MaKieu,TenKieu FROM KieuDang");
        public static DataTable ChatLieu = Functions.GetDataTable("SELECT MaChatLieu,TenChatLieu From ChatLieu");
        public static DataTable MauSac = Functions.GetDataTable("SELECT MaMau,TenMau FROM MauSac");
        public static void FillCombo(DataTable dt,ComboBox cb,string display,string value)
        {
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
        }
    }
}
