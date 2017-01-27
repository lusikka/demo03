using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Speed = 190; // a fast motherfucking car dog
            vehicle.Tyres = 4;
            vehicle.Name = "De Lorean DMC-12";
            vehicle.PrintData(); // everything in their own lines
            vehicle.ToString(); // everything in a row
        }
    }
}
