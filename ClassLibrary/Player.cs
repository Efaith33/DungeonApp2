﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public sealed class Player : Character
    {
        //frugal / fields
        private int _chances;

        //people / properties
        public int RiddlesAnswered { get; set; }
        public int Score { get; set; }
        public int Chances
        {
            get { return _chances; }
            set
            {
                _chances = value;              
            }//end set
        }//end chances

        //collect / constructors
        public Player(string name, int riddlesAnswered, int score, int chances)
        {
            Name = name;
            RiddlesAnswered = riddlesAnswered;
            Score = score;
            Chances = chances;
        }//end FQ CTOR

        

        //money / methods

    }// class

}//end namespace
