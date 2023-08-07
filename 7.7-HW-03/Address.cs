﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class Address
    {
        string appartment;
        string floor;
        string building;
        string street;
        string city;
        string state;
        string postalCode;
        string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                if (value.Length == 6 && Int32.TryParse(value, out int res))
                    postalCode = value;
                else
                    Console.WriteLine("Индекс введен некорректно");
            }
        }
        internal Address(string apt = "1", string fl = "1", string bld = "1", string st = "Lenina", string ct = "City", string sta = "Moscow st", string postCode = "123456")
        {
            appartment = apt;
            floor = fl;
            building = bld;
            street = st;
            city = ct;
            state = sta;
            postalCode = postCode;
        }
        internal string Show() => $" {postalCode}, {state}, {city}, дом {building}, этаж {(String.IsNullOrWhiteSpace(floor) ? "нет" : floor)}, квартира {(String.IsNullOrWhiteSpace(appartment) ? "нет" : appartment)}";
    }
}
