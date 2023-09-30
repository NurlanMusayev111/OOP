using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_
{
    internal class Student : Person
    {
        public string name;
        public string surname;
        public int age;
        public string address;


        private string GetFullName()
        {
            return name + " " + surname; 
        }

        
        public string GetFullData()
        {
            return GetFullName() + " " + age + " " + address;
        }
    }
}
