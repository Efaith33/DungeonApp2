using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Enemy : Character
    {
        //frugal / fields

        //people / properties
        public string Description { get; set; }
        public int Score { get; set; }

        //collect / constructors
        public Enemy() {}

        public Enemy(string name, int score, string description)
        {
            Name = name;
            Score = score;
            Description = description;
        }

        //money / methods
    }
}
