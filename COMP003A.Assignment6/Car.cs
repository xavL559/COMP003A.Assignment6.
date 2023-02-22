using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6_
{
    internal class Car : Vehicle
    {






        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("I don't want to disclose my information.");
        }
    }
}
