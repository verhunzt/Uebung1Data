﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung1Data
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }


    }
}
