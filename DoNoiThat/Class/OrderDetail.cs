using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNoiThat.Class
{
    class OrderDetail
    {
        private string orderid;
        private string productid;
        private int quantity;
        private float discount;
        private float total;

        public OrderDetail(string orderid, string productid, int quantity, float discount, float total)
        {
            Orderid = orderid;
            Productid = productid;
            Quantity = quantity;
            Discount = discount;
            Total = total;
        }

        public string Orderid { get => orderid; set => orderid = value; }
        public string Productid { get => productid; set => productid = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Discount { get => discount; set => discount = value; }
        public float Total { get => total; set => total = value; }
    }
}
