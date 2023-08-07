using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class Item
    {
        internal Product product;
        int quantity;
        double price;
        internal Item(Product product, int quantity = 1, double price = 0)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = price;
        }
        internal string Show() => "Артикул " + product.vendorCode + "\tНазвание: "+ product.name + "\tколличество: " + quantity.ToString() + "\tцена: " + price.ToString();
    }

}
