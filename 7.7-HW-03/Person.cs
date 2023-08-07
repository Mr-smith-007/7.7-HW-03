using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        internal Person(int age, string fname, string lname)
        {
            this.age = age;
            firstName = fname;
            lastName = lname;
        }
        internal virtual string Show()
        {
            return firstName + " " + lastName + " " + age;
        }

    }
}
