using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung1Data
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person(string lastName, string firstName, int age, Address address)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Address = address;
        }
    }
}
