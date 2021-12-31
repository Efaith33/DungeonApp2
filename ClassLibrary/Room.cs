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
        public int Score { get; set; }

        public Room(string roomDescription, string riddle, string answer, int score)
        {
            RoomDescription = roomDescription;
            Riddle = riddle;
            Answer = answer;
            Score = Score;
        }
    }


}
