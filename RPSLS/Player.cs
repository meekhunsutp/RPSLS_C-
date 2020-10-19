using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int wins;
        //public string chosenGesture;
        public List<Gesture> gestures;
        public Gesture chosenGesture;



        public Player()
        {
            gestures = new List<Gesture>() { new Gesture("Rock"), new Gesture("Paper"), new Gesture("Scissors"), new Gesture("Lizard"), new Gesture("Spock") };
        }
        public abstract Gesture ChooseGesture();

    }
}