using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNoiThat.Class
{
    class OrderObject
    {
        private string orderid;
        private string customerid;
        private string staffid;
        private DateTime orderdate;
        private DateTime deliverdate;
        private float deposit;
        private float tax;
        private float sum;

        public OrderObject(string orderid, string customerid, string staffid, DateTime orderdate, DateTime deliverdate, float deposit, float tax, float sum)
        {
            Orderid = orderid;
            Customerid = customerid;
            Staffid = staffid;
            Orderdate = orderdate;
            Deliverdate = deliverdate;
            Deposit = deposit;
            Tax = tax;
            Sum = sum;
        }

        public string Orderid { get => orderid; set => orderid = value; }
        public string Customerid { get => customerid; set => customerid = value; }
        public string Staffid { get => staffid; set => staffid = value; }
        public DateTime Orderdate { get => orderdate; set => orderdate = value; }
        public DateTime Deliverdate { get => deliverdate; set => deliverdate = value; }
        public float Deposit { get => deposit; set => deposit = value; }
        public float Tax { get => tax; set => tax = value; }
        public float Sum { get => sum; set => sum = value; }
    }
}
