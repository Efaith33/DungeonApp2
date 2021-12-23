using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary;

namespace Dungeon
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Green;
            string txt = "?? The Riddlers Lair ?? ";
            Console.Title = string.Format("{0," + ((Console.WindowWidth / 1) + txt.Length / 2) + "}", txt);
            Console.WriteLine("Hello Batman!! You approach, what looks to be an abondoned building in the old district. You have intel which suggust that this is the hideout of the infamous ?Riddler?\n.....................??Enter if you Dare??\n");

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
                                                             #####  ");
            //Create Player
            Player player = new Player("Batman", 0, 0, 3);
            //Create Enemy
            Enemy enemy = new Enemy("?The Riddler?", 200, "desc");
            //Create a loop for enemy and room

            int Level = 1;
            bool exit = false;

            do
            {
                Room room = GetRoom(Level);

                bool reload = false;
                do
                {
                    // menu of options
                    Console.WriteLine(@"
Make a choice:
S). Solve Riddle
E). Exit
");
                    string userChoice = Console.ReadKey(true).Key.ToString();
                    //Create switch to handle user selection
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "S":

                            break;

                        case "E":
                            Console.WriteLine("Crime doesn't take a day off... see you soon!!");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Option, try again");
                            break;
                    }// end switch

                } while (!reload && !exit);
            } while (!exit);
        }//end Main()

        private static Room GetRoom(int level)
        {// maybe instead of random room have them progress thuough
            Room[] rooms =
                {
              new Room ("You've entered a room with lots of computer components and a desk. Just some scattered papers, a lamp and" +
                "a book of matches.", "Tear one off and scratch my head. What once was red is black instead.", "A Match", 100),

              new Room ("A dark, damp room... lots of steampipes and valves. One of the valves looks like a clock but no numbers....", "If you look at the numbers on my face, you won't find 13 anyplace.", "A Clock", 100 ),

              new Room ("It's a huge empty room...checkard tiled floor with weird shaped statues. One of the statues has a hat and sign on it.", "The eight of us go forth, not back, to protect our king from a foe's attack.", "Chess Pawns", 100),

              new Room ("?ITS THE RIDDLER?", "I see without seeing. To me, darkness is as clear as daylight", "A Bat", 100)

            };

            return rooms[level - 1];
        }
    }//end class
}//end namespace
