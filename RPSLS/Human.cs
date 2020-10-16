using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {


        public Human()
        {
            GetPlayerName();
        }

        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            return name;
        }
        public override string ChooseGesture()
        {
            Console.WriteLine($"Please select your gesture {name}:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i}) {gestures[i]}");
            }
            int choice = int.Parse(Console.ReadLine());
            return chosenGesture = gestures[choice];
        }
    }
}
