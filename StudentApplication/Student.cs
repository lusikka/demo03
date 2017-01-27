using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Student
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public bool Motivation { get; set; } // true, false
        public void DrinkBeer()
        {
            Console.WriteLine("You down a beer. You feel like you understand the world a bit more.");
        }
    }
}
