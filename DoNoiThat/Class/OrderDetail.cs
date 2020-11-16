using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNoiThat.Class
{
    public class OrderDetail
    {
        private string orderid;
        private string productid;
        private string productname;
        private int quantity;
        private double discount;
        private double total;
        public OrderDetail(string orderid, string productid, int quantity, double discount, double total)
        {
            Orderid = orderid;
            Productid = productid;
            Productname = TenSanPham(productid);
            Quantity = quantity;
            Discount = discount;
            Total = total;
        }

        public string Orderid { get => orderid; set => orderid = value; }
        public string Productid { get => productid; set => productid = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Discount { get => discount; set => discount = value; }
        public double Total { get => total; set => total = value; }
        public string Productname { get => productname; set => productname = value; }

        public string TenSanPham(string _pid)
        {
            string sql = "SELECT TenNoiThat FROM DMNoiThat WHERE MaNoiThat = N'" + _pid + "'";
            System.Data.DataTable dt = Functions.GetDataTable(sql);
            string ten = dt.Rows[0].ItemArray[0].ToString();
            return ten;

        }
    }

}
