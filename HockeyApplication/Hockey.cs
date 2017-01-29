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
        public int Ties { get; set; }
        public void WinGame()
        {
            Console.WriteLine("You win the game! Well done.");
            Wins += 1;
            Points += 2;
        }
        public void LoseGame()
        {
            Console.WriteLine("You lose the game...better luck next time.");
            Losses += 1;
        }
        public void TieGame()
        {
            Console.WriteLine("The game ended in a tie.");
            Ties += 1;
            Points += 1;
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
            Console.WriteLine(TeamName + "'s stats: " + Wins + "-" + Losses + "-" + Ties);
            Console.WriteLine(TeamName + " has " + Points + " points.");
            
        }
        public void GMChat()
        {
            if ((Wins + Losses) == 0)
            {
                Console.WriteLine("We haven't played a single game yet. My hopes are high for this season.");
            }
            else if (Losses > Wins)
            {
                Console.WriteLine("We are underperforming. Maybe we'll have to make some moves...");
            }
            else if (Wins > Losses)
            {
                Console.WriteLine("Seems like we're doing decently so far. Hopefully the guys can keep this up.");
            }
            else if (Wins == Losses)
            {
                Console.WriteLine("We are 50%. This is not enough to make the playoffs, so we'll need to step it up.");
            }
        }
    }
      

    }

