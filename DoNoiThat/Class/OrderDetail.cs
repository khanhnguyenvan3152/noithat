using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNoiThat.Class
{
    public class OrderDetail
    {
        public OrderDetail(string orderid, string productid, string productname, double price, int quantity, double discount, double total)
        {
            this.orderid = orderid;
            this.productid = productid;
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
            this.discount = discount;
            this.total = total;
        }

        public string orderid { get; set; }
        public string productid { get; set; }
        public string productname { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public double discount { get; set; }
        public double total { get; set; }
   
    }
}
