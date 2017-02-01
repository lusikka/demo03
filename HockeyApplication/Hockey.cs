using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyApplication
{
    class Hockey
    {
        public bool Upgrade { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Points { get; set; }
        public int Players { get; set; }
        public string TeamName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public int Money { get; set; }
        public void WinGame()
        {
            Console.WriteLine("You win the game! Well done.");
            Wins += 1;
            Points += 2;
            Money += 250;
        }
        public void LoseGame()
        {
            Console.WriteLine("You lose the game...better luck next time.");
            Losses += 1;
            Money -= 70;
        }
        public void TieGame()
        {
            Console.WriteLine("The game ended in a tie.");
            Ties += 1;
            Points += 1;
            Money += 100;
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
            Console.WriteLine("Attack power: " + Attack);
            Console.WriteLine("Defensive ability: " + Defense);

        }
        public void GMChat()
        {
            if ((Wins + Losses) == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("We haven't played a single game yet. My hopes are high for this season.");
            }
            else if (Losses > Wins)
            {
                Console.WriteLine("");
                Console.WriteLine("We are underperforming. Maybe we'll have to make some moves...");
            }
            else if (Wins > Losses)
            {
                Console.WriteLine("");
                Console.WriteLine("Seems like we're doing decently so far. Hopefully the guys can keep this up.");
            }
            else if (Wins == Losses)
            {
                Console.WriteLine("");
                Console.WriteLine("We are 50%. This is not enough to make the playoffs, so we'll need to step it up.");
            }
            Console.WriteLine("We currently have " + Money + " hockey bucks. You can use them to buy better players!");
        }
        public void PlayerBuy()
        {
            int playchoice = 0;
            Console.WriteLine("");
            Console.WriteLine("Welcome to the player shop! What'cha buyin'?");
            Console.WriteLine("1. Defenseman - 450 hockey bucks");
            Console.WriteLine("2. Scoring winger - 400 hockey bucks");
            Console.WriteLine("3. Generational talent - 1500 hockey bucks");
            Console.WriteLine("4. Nothing, thank you.");
            Console.WriteLine("~ Hockey bucks - " + Money + " ~");
            string line3 = Console.ReadLine();
            playchoice = int.Parse(line3);
            if (playchoice == 1)
            {
                if (Money >= 450)
                {
                    Upgrade = true;
                    Defense += 1;
                    Money -= 450;
                    Console.WriteLine("Thanks for your purchase.");
                }
                else
                {
                    Console.WriteLine("You don't have enough money.");
                }
            }
            else if (playchoice == 2)
            {
                if (Money >= 400)
                {
                    Upgrade = true;
                    Attack += 1;
                    Money -= 400;
                    Console.WriteLine("Thanks for your purchase.");
                }
                else
                {
                    Console.WriteLine("You don't have enough money.");
                }
            }
            else if (playchoice == 3)
            {
                if (Money >= 1500)
                {
                    Upgrade = true;
                    Attack += 3;
                    Defense += 2;
                    Money -= 1500;
                    Console.WriteLine("Thanks for your purchase.");
                }
                else
                {
                    Console.WriteLine("You don't have enough money.");
                }
            }
            else if (playchoice == 4)
            {
                Console.WriteLine("I see. Come again!");
            }

            else
            {
                Console.WriteLine("Not a valid option.");
            }
        }

    }
      

    }

