using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNoiThat.Class
{
    public class KhachHang
    {
        public KhachHang(string customerid, string customername, string phonenumber, string address)
        {
            this.customerid = customerid;
            this.customername = customername;
            this.phonenumber = phonenumber;
            this.address = address;
        }

        public string customerid { get; set; }
        public string customername { get; set; }
        public string phonenumber { get; set; }
        public string address { get; set; }

    }
}
