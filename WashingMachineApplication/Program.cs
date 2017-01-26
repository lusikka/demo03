using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine washing = new WashingMachine();
            washing.IsOn = false;
            washing.Machine = "Cheap-ass machine";
            Console.WriteLine("Washing machine is on? " + washing.IsOn);
            washing.DetergentAmount = 40;
            washing.SetTime = 30;
            washing.SetWash = "Pikapesu Color";
            Console.WriteLine("Amount of detergent: " + washing.DetergentAmount);
            Console.WriteLine("Time in minutes: " + washing.SetTime);
            Console.WriteLine("Type of wash: " + washing.SetWash);
            washing.TurnOn();
            Console.WriteLine("Washing machine is on? " + washing.IsOn);

            //another machine

            string machine = "Expensive machine";
            WashingMachine expWashing = new WashingMachine(machine);
            expWashing.Machine = "Expensive-ass machine";
            Console.WriteLine("Washing machine is on? " + expWashing.IsOn);
            expWashing.DetergentAmount = 80;
            expWashing.SetTime = 66;
            expWashing.SetWash = "Expensive-ass washing method";
            Console.WriteLine("Amount of detergent: " + expWashing.DetergentAmount);
            Console.WriteLine("Time in minutes: " + expWashing.SetTime);
            Console.WriteLine("Type of wash: " + expWashing.SetWash);
            expWashing.TurnOn();
            Console.WriteLine("Washing machine is on? " + washing.IsOn);

        }
    }
}
