using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Room
    {
        public string RoomDescription { get; set; }
        public string Riddle { get; set; }
        public string Answer { get; set; }
        public decimal Loot { get; set; }

        public Room(string roomDescription, string riddle, string answer, decimal loot)
        {
            RoomDescription = roomDescription;
            Riddle = riddle;
            Answer = answer;
            Loot = loot;
        }
    }


}
