using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{
    public class Human : Player
    {


        public Human()
        {
            GetPlayerName();
        }

        public void GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

        }
        public override Gesture ChooseGesture()
        {

            Gesture chosenGesture;
            Console.WriteLine($"{name} Please input the Gesture number to throw: ");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i}) {gestures[i]}");
            }
            string userinput = Console.ReadLine();

            if (!int.TryParse(userinput, out _))
            {
                Console.WriteLine("Invalid input, please enter a number");
                return ChooseGesture();
            }

            int choice = int.Parse(userinput);

            if (choice > gestures.Count - 1 || choice < 0)
            {
                Console.WriteLine("Invalid option, please select again");
                return ChooseGesture();
            }
            chosenGesture = gestures[choice];
            return chosenGesture;
        }

                    //bool whileUserSelectsWrongInfo = true;
            //while (whileUserSelectsWrongInfo)
            //{
            //    //if they enter the wrong into, do nothing.
            //    //if they enter the right info, change whileUserSelectsWrongInfo to false
            //}
    }
}
