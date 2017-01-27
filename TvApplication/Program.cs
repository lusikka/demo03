using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Tv tv = new Tv();
            tv.TvHealth = 10;
            tv.IsOn = true;
            tv.Brightness = 25;
            tv.Volume = 25;
            tv.Channel = "NBCSN";
            tv.PrintData();
            while (true)
            {
                if (tv.TvHealth <= 0)
                {
                    Console.WriteLine("Congratulations. You broke the thing. Are you happy now? You know how much this shit costs?!");
                    Console.WriteLine("Well, here's a new one. Be more careful this time, ok?");
                    tv.TvHealth = 50;
                }
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Raise the volume");
                Console.WriteLine("2. Raise the brightness");
                Console.WriteLine("3. Hit the television with your finest uppercut");
                Console.WriteLine("4. Check the status of the televison");
               
                string line = Console.ReadLine();
                choice = int.Parse(line);
                if (choice == 1)
                {
                    tv.VolUp();
                }
                else if (choice == 2)
                {
                    tv.BrightUp();
                }
                else if (choice == 3)
                {
                    tv.HitTv();
                }
                else if (choice == 4)
                {
                    tv.PrintData();
                }
                else
                {
                    Console.WriteLine("Please pick one of the options.");
                }
               

            };
        }
    }
}
