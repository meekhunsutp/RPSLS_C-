using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int wins;
        public List<Gesture> gestures;
        public Gesture chosenGesture;

        public Player()
        {
            gestures = new List<Gesture>() { new Gesture("Rock", new List<string>() { "Paper", "Spock" }), new Gesture("Paper", new List<string>() { "Scissors", "Lizard" }), new Gesture("Scissors", new List<string>() { "Rock", "Spock" }), new Gesture("Lizard", new List<string>() { "Rock", "Scissors" }), new Gesture("Spock", new List<string>() { "Paper", "Lizard" }) };
        }
        public abstract Gesture ChooseGesture();
    }
}