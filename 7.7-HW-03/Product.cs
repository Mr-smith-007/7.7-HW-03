using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    internal class Product
    {
        internal string vendorCode;
        internal string name;
        internal double price;
        public Product(string vc, string name = "product", double price = 0)
        {
            vendorCode = vc;
            this.name = name;
            this.price = price;
        }
    }
}
