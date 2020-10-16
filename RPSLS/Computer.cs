using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{
    public class Computer : Player
    {
        public Computer()
        {
            name = "Sheldon";
        }
        public override Gesture ChooseGesture()
        {
            Gesture chosenGesture;
            Random rng = new Random();
            int randomChoice = rng.Next(0, gestures.Count);
            chosenGesture = gestures[randomChoice];
            return chosenGesture;
        }
    }
}
