using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Tv
    {
        public bool IsOn { get; set; }
        public int TvHealth { get; set; }
        public string Channel { get; set; }
        public int Volume { get; set; }
        public int Brightness { get; set; }
        public void HitTv()
        {
            TvHealth -= 3;
            Console.WriteLine("You hit the television. The picture becomes clearer!");
            if (TvHealth == 1)
            {
                Console.WriteLine("...the television has " + TvHealth + " hit point left. Do be more careful now.");
            }
            else
            {
                Console.WriteLine("The television has " + TvHealth + " hit points left.");
            }
        }
        public void VolUp()
        {
            Console.WriteLine("You crank the volume up a notch.");
            Volume += 5;
        }
        public void BrightUp()
        {
            Console.WriteLine("You crank up the brightness a notch.");
            Brightness += 5;
        }
        public void PrintData()
        {
            Console.WriteLine("The brightness is currently set at: " + Brightness);
            Console.WriteLine("The Volume is currently set at: " + Volume);
            Console.WriteLine("The channel you are currently viewing is: " + Channel);
            if (TvHealth == 1)
            {
                Console.WriteLine("...the television has " + TvHealth + " hit point left. Do be more careful now.");
            }
            else
            {
                Console.WriteLine("The television has " + TvHealth + " hit points left.");
            }
        }

    }
}
