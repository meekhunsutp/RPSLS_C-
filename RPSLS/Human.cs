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
            Console.WriteLine("\nPlease enter your name: ");
            name = Console.ReadLine().ToUpper();
        }
        public override Gesture ChooseGesture()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n{name} - Please input the Gesture number to throw: ");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i}) {gestures[i].selection}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            string userinput = Console.ReadLine();

            if (!int.TryParse(userinput, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID input, please enter a number");
                return ChooseGesture();
            }

            int choice = int.Parse(userinput);

            if (choice > gestures.Count - 1 || choice < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID option, please select again");
                return ChooseGesture();
            }
            chosenGesture = gestures[choice];
            return chosenGesture;
        }
    }
}
