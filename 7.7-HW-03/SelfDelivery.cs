using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class SelfDelivery : Delivery
    {
        private string shopAddress = "Shop Address";
        internal override void Deliver()
        {
            Console.WriteLine($"Оформлен самомывоз по адресу {shopAddress}");
        }

    }
}
