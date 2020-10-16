using System;
using System.Collections.Generic;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int wins;
        public string chosenGesture;
        public List<string> gestures;


        public Player()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        public abstract string ChooseGesture();

    }
}