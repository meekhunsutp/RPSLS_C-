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
            name = Console.ReadLine().ToUpper();

        }
        public override Gesture ChooseGesture()
        {

            Console.WriteLine($"\n{name} Please input the Gesture number to throw: ");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i}) {gestures[i].selection}");
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

    }
}
