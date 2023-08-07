using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    internal enum Level
    {
        Basic,
        VIP
    }
    class Client : Person
    {
        Level status;
        internal Address address;
        internal Contacts contacts;
        internal Client(int age, string name, string lname): base(age, name, lname)
        {
            address = new Address(apt:"47", fl:"3", bld:"6");
            contacts = new Contacts(eml: "client@gmail.com", phone: "79265987415");
        }
        internal override string Show()
        {
            return base.Show() + $" статус: {status}; телефон: {contacts.Telphone}; email: {contacts.Email} \n Адрес: {address.Show()}"; 
        }
    }
}
