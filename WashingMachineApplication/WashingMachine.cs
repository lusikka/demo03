using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineApplication
{
    class WashingMachine
    {
        public string Machine { get; set; }
        public bool IsOn { get; set; }
        public string SetWash { get; set; }
        public int SetTime { get; set; }
        public int DetergentAmount { get; set; }
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Klonk klonk");
        }
        //default constructor
        public WashingMachine()
        {

        }
        //other constructor
        public WashingMachine(string machine)
        {
            Machine = machine;
        }
    }
}
