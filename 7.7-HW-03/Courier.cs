using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class Courier: Person
    {
        Contacts contacts;
        Address address;
        internal Courier (int age, string name, string lname, Contacts cont, Address addr) : base(age, name, lname)
        {
            contacts = cont;
            address = addr;
        }
    }
}
