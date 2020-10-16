using System;

namespace RPSLS
{
    public class Computer : Player
    {


        public Computer()
        {
            name = "Sheldon";
        }


        public override string ChooseGesture()
        {
            string userInputForGestureSelection = "";
            Random rng = new Random();
            int randomChoice = rng.Next(0, gestures.Count);
            userInputForGestureSelection = gestures[randomChoice];
            return userInputForGestureSelection;
        }
    }
}
