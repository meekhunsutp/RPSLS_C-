using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{

    public class Gesture
    {

        public List<string> losesTo;

        public Gesture(string selection)
        {
            if(selection == "Rock")
            {
                selection = "Rock";
                losesTo = new List<string>() { "Paper", "Spock" };

            }
            if (selection == "Paper")
            {
                losesTo = new List<string>() { "Scissors", "Lizard" };

            }
            if (selection == "Scissors")
            {
                losesTo = new List<string>() { "Rock", "Spock" };

            }
            if (selection == "Lizard")
            {
                losesTo = new List<string>() { "Rock", "Scissors" };

            }
            if (selection == "Spock")
            {
                losesTo = new List<string>() { "Paper", "Lizard" };

            }
        }























    }









    //Rock (> scissors, lizard) ( < paper, spock) ( = Rock )

    //Paper (> rock,  spock) ( < scissors, lizard)( = Paper )

    //Scissors (> paper, lizard) ( < spock, rock)( = Scissors )

    //Lizard (> spock, paper) ( < rock, scissors)( = Lizard )

    //Spock (> rock, scissors) ( < lizard, paper)( = Spock )



    //Scissors cuts paper //
    //Paper covers rock  //
    //Rock crushes lizard  //
    //Lizard poisons spock //
    //Spock smashes scissors //
    //scissors decapitates lizards //
    //Lizard eats paper //
    //Paper disproves spock //
    //Spock vaporizes rock 
    //rock crushes scissors 


}