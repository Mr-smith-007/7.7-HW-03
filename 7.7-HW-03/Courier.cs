using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class Courier: Person
    {
        Contacts clientContacts;
        Address deliveryAddress;
        
        internal Courier (int age, string name, string lname, Contacts cont, Address addr) : base(age, name, lname)
        {
            clientContacts = cont;
            deliveryAddress = addr;
            
        }
    }
}
