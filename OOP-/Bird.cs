using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_
{
    internal class Bird : Animal
    {
          public Bird(string t) : base(t) 
        {
            Console.WriteLine("Bird constructor00");
        }   
        //public Bird()
        //{
        //    Console.WriteLine("Bird constructor");
        //}

        //public void Sound()
        //{
        //    Console.WriteLine("Bird sounds");
        //}
    }
}
