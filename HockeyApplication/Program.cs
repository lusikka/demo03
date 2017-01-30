using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string[] enemyName1 = { "Holy", "Golden", "Mighty", "Evil", "Menacing", "Cold", "Hot", "Puck", "Stick", "Stone", "Blasting", "Silver", "Explosive", "Dreamy", "Speedy", "Sluggish", "Purple", "Best", "Rampaging", "Rage", "Peaceful", "Green", "Red", "Mysterious", "Ice", "Top Cheese", "Sonic", "Overpowered", "Anime", "Mobile", "Power", "Blue", "Small", "Attacking", "Astral", "Time-space", "Square", "Rectangular", "Static", "Large", "Legendary", };
            string[] enemyName2 = { "Bears", "Ducks", "Wild", "Penguins", "Fish", "Coyotes", "Knights", "Wildcats", "Panthers", "Cats", "Lightning", "Explosions", "Blasters", "Winners", "Hockeyers", "Trains", "Sound", "Rampage", "Kings", "White Knights", "Jets", "Aliens", "Snipers", "Clap Bombs", "Snappers", "Weeaboos", "Blues", "Refridgerators", "Freezers", "Bepis", "Sharks", "Giants", "Lions", "Mongoose", "Steelers", "Bucks", "Titans", "Dogs", "Cubes", "Blackhawks", "Unknowns", "Assault", "Sonics" };
            Hockey hockey = new Hockey();
            Random random = new Random();
            Random teamname = new Random();
            hockey.Points = 0;
            hockey.Wins = 0;
            hockey.Losses = 0;
            hockey.Ties = 0;
            hockey.Attack = 0;
            hockey.Defense = 0;
            hockey.Money = 100;
            hockey.Upgrade = false;
            Console.WriteLine("Welcome to Late's hockey simulator. Pick a name for your team!");
            string line = Console.ReadLine();
            hockey.TeamName = line;
            do
            {
                int enscore = random.Next((7 - hockey.Defense));
                int youscore = random.Next((6 + hockey.Attack));
                int ranEn1 = teamname.Next(enemyName1.Length);
                int ranEn2 = teamname.Next(enemyName2.Length);
                Console.WriteLine(hockey.TeamName + "'s regular season is underway. What would you like to do?");
                //Console.WriteLine("1. Win a game!");
                //Console.WriteLine("2. Lose a game...");
                Console.WriteLine("1. Check your stats");
                Console.WriteLine("2. Check with your GM");
                Console.WriteLine("3. Play next game!");
                Console.WriteLine("4. Buy players");
                string line2 = Console.ReadLine();
                choice = int.Parse(line2);
               /* if (choice == 1)
                {
                    hockey.WinGame();
                }
                else if (choice == 2)
                {
                    hockey.LoseGame();
                }*/
                if (choice == 1)
                {
                    hockey.CheckStat();
                }
                else if (choice == 2) 
                {
                    hockey.GMChat();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Your next game will be against the " + enemyName1[ranEn1] + " " + enemyName2[ranEn2]);
                    Console.WriteLine("You play in a game. Good luck!");
                    Console.WriteLine("The game has ended.");
                    Console.WriteLine(hockey.TeamName + ": " + youscore + " " + enemyName1[ranEn1] + " " + enemyName2[ranEn2] + ": " + enscore);
                    if (youscore > enscore)
                    {
                        hockey.WinGame();
                    }
                    else if (enscore > youscore)
                    {
                        hockey.LoseGame();
                    }
                    else if (enscore == youscore)
                    {
                        hockey.TieGame();
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid option.");
                }

            } while ((hockey.Wins + hockey.Losses) < 82);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("The regular season has ended. " + hockey.TeamName + " has " + hockey.Points + " points.");
            if (hockey.Points >= 90)
            {
                Console.WriteLine("Your team made the playoffs!! Well done. The real hockey begins now...");
            }
            else
            {
                Console.WriteLine("Despite your best effort, you didn't make the playoffs...");
            }

        }
    }
}
