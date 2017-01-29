using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyApplication
{
    class Hockey
    {
        public int Points { get; set; }
        public int Players { get; set; }
        public string TeamName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public void WinGame()
        {
            Console.WriteLine("You win a game! Well done.");
            Wins += 1;
            Points += 2;
        }
        public void LoseGame()
        {
            Console.WriteLine("You lose a game...better luck next time, I guess.");
            Losses += 1;
        }
        public void CheckStat()
        {
            if ((Wins + Losses) == 1)
            {
                Console.WriteLine((Wins + Losses) + " game played.");
            }
            else
            {
                Console.WriteLine((Wins + Losses) + " games played.");
            }
            Console.WriteLine(TeamName + "'s stats: " + Wins + "-" + Losses);
            Console.WriteLine(TeamName + " has " + Points + " points.");
            
        }
    }
      

    }

