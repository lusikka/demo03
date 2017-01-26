using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDice { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }

        //default constructor
        public Car()
        {

        }

        //param constructor
        public Car(string model)
        {
            Model = model;
        }

        //method to give more speed
        public void Accelerate()
        {
            Speed += 10;
        }
        //method to slow down
        public void Brake(int value)
        {
            Speed -= value;
        }

        //method to display car data/properties

        public void PrintData()
        {
            Console.WriteLine("Car properties");
            Console.WriteLine("- model: " + Model);
            Console.WriteLine("- color: " + Color);
            Console.WriteLine("- engine: " + Engine);
            Console.WriteLine("- speed: " + Speed);
            Console.WriteLine("- fuzzy dice: " + FuzzyDice);
            Console.WriteLine("- door count: " + DoorCount);
            Console.WriteLine("- some static property: " + SomeProperty);

        }
        //destructor
        ~Car()
        {
            Console.WriteLine("Car destroyed!!");
        }
        

    }
}
