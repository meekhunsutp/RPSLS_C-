using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{

    public class Gesture
    {
        public List<string> losesTo;
        public string selection;

        public Gesture(string selection)

        {
            if(selection == "Rock")
            {
                this.selection = selection;
                losesTo = new List<string>() { "Paper", "Spock" };
            }
            if (selection == "Paper")
            {
                this.selection = selection;
                losesTo = new List<string>() { "Scissors", "Lizard" };
            }
            if (selection == "Scissors")
            {
                this.selection = selection;
                losesTo = new List<string>() { "Rock", "Spock" };
            }
            if (selection == "Lizard")
            {
                this.selection = selection;
                losesTo = new List<string>() { "Rock", "Scissors" };
            }
            if (selection == "Spock")
            {
                this.selection = selection;
                losesTo = new List<string>() { "Paper", "Lizard" };
            }
        }
    }
}