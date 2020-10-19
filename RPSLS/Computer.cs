using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{
    public class Computer : Player
    {
        public Computer()
        {
            name = "SHELDON";
        }
        public override Gesture ChooseGesture()
        {
            Random rng = new Random();
            int randomChoice = rng.Next(0, gestures.Count);
            chosenGesture = gestures[randomChoice];
            return chosenGesture;
        }
    }
}
