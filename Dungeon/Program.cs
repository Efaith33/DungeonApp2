using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary;

namespace Dungeon
{   // Total of 3 chances the whole game? Or Each riddle answered correctly, Get that many chances at riddler.
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string txt = "?? The Riddlers Lair ?? " + DateTime.Now;
            Console.Title = string.Format("{0," + ((Console.WindowWidth / 1) + txt.Length / 2) + "}", txt);

            Console.WriteLine("Hello BATMAN!! You approach, what looks to be an abondoned building in the old district.\n" +
                "Alfred has provided you with intel which suggest that this is the hideout of the infamous ?Riddler?\n" +
                "................................................??Enter if you Dare??...................................................");
            Console.WriteLine(@"                                           
                                                         ________
                                                     _jgN########Ngg_
                                                   _N##N@@        9NN##N
                                                  d###P            N####p
                                                  ^^                T####
                                                                    d###P
                                                                 _g###@F
                                                              _gN##@P
                                                            gN###F
                                                           d###F
                                                          0###F
                                                          0###F
                                                          0###F
                                                           NN@
                                                           ___
                                                           ###  ");

            //Create Player
            Player player = new Player("Batman", 0, 0, 1);
            //Create Enemy
            Enemy enemy = new Enemy("?The Riddler?", 200, "desc");

            //Create a loop for enemy and room
            int Level = 1;
            bool exit = false;

            do
            {
                Room room = GetRoom(Level);
                Console.WriteLine(room.RoomDescription);

                bool reload = false;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    // menu of options
                    Console.WriteLine(@"
Make a choice:
S) Solve Riddle
E) Exit
");
                    string userChoice = Console.ReadKey(true).Key.ToString();
                    //Create switch to handle user selection
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "S":
                            Console.WriteLine(room.Riddle);
                            string input = (Console.ReadLine());
                            if (input == room.Answer)
                            {
                                Console.WriteLine("Correct, you may proceed! You received some loot.");
                                Console.WriteLine(room.Loot);
                                player.RiddlesAnswered++;
                                Console.WriteLine();
                                Level++;
                                if (Level == 5)
                                {
                                    Console.WriteLine("You solved the riddle but you The Riddler escaped...!!\n");
                                    exit = true;
                                }
                                else 
                                {
                                reload = true;

                                }
                            }
                            
                            else if (input != room.Answer)
                            {
                                Console.WriteLine("Are you even trying?\n");   
                                player.Chances++;
                            }
                            break;

                        case "E":
                            Console.WriteLine("Crimefighting never take a day off... see you soon!!\n");
                            exit = true;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Option, try again");
                            Console.ResetColor();
                            exit = false;
                            break;
                    }// end switch


                    if (player.Chances > 3)
                    {
                        Console.WriteLine("You let The Riddler outriddle you....Better luck next time!"); 
                        exit = true;
                    }
                } while (!reload && !exit);
            } while (!exit);
        }//end Main()

        // Create Room []
        private static Room GetRoom(int level)
        {
            Room[] rooms =
                {
              new Room ("You've entered a room with lots of computer components and a desk. Just some scattered papers,\n" +
              "a lamp and a book of matches. You look at the matches and there's a riddle...... \n",
              "Tear one off and scratch my head. What once was red is black instead.", "A Match", 100),

              new Room ("A dark, damp room... lots of steampipes and valves. The valves look like clocks but no numbers...." +  "writting on the wall.... a riddle.",
              "If you look at the numbers on my face, you won't find 13 anyplace.", "A Clock", 100 ),

              new Room ("It's a huge empty room...checkard tiled floor with weird shaped statues. " +
              "One of the statues has a hat and sign on it.\n " +
              " It's another riddle....",
              "The eight of us go forth, not back, to protect our king from a foe's attack.", "Chess Pawns", 100),

              new Room ("?ITS THE RIDDLER? The gig is up Riddler, but first I have a riddle for you" ,
              "I see without seeing. To me, darkness is as clear as daylight", "A Bat", 100)

            };

            return rooms[level - 1];
        }
    }//end class
}//end namespace
