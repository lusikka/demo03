using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }
        public void ThrowWater()
        {
            Console.WriteLine("shit man");
        }
    }
}
