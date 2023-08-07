using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class Contacts
    {
        string email;
        string telphone;
        internal string Telphone
        {
            get
            {
                return telphone;
            }
            set
            {
                if (value.Length == 11)
                    telphone = value;
                else
                    Console.WriteLine("Номер телефона введен некорректно");
            }
        }

        internal string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains('@'))
                {
                    email = value;
                }
                else
                    Console.WriteLine("Email введен некорректно");
            }
        }

        internal Contacts(string eml = "123@gmail.com", string phone = "79991234567")
        {
            email = eml;
            telphone = phone;
        }

    }
}
