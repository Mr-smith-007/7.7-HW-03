using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class HomeDelivery : Delivery
    {
        Address delivAddress;
        Courier courier;
        internal override void Deliver()
        {
            Console.WriteLine($"Доставка {planDelivTime} по адресу:{delivAddress} \n Доставку осуществляет: {courier.lastName} {courier.firstName}");
        }
        internal HomeDelivery(DateTime plandel, Address deladdress, Courier courier)
        {
            planDelivTime = plandel;
            delivAddress = deladdress;
            this.courier = courier;
        }
    }
}
