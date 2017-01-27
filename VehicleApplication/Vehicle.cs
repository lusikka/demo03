using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        public void PrintData()
        {
            Console.WriteLine("The name of the vehicle is: " + Name);
            Console.WriteLine("Vehicle speed is: " + Speed);
            Console.WriteLine("The number of tyres the vehicle has: " + Tyres);
        }
        public void ToString()
        {
            Console.WriteLine("Vehicle name: " + Name + ", vehicle speed: " + Speed + ", number of tyres: " + Tyres);
        }
    }
}
