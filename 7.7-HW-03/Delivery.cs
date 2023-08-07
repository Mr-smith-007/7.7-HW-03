using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    abstract class Delivery
    {
        protected DateTime planDelivTime;
        internal abstract void Deliver();
    }
}
