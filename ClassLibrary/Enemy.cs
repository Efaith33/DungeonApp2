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
        public string Riddle { get; set; }
        public string Answer { get; set; }
        
        //collect / constructors
        public Enemy() {}

        public Enemy(string name, decimal money, string description)
        {
            Name = name;
            Money = money;
            Description = description;
        }

        //money / methods
    }
}
