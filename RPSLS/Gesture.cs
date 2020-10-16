using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{

    public class Gesture
    {
        public List<string> rockLosesTo;
        public List<string> paperLosesTo;
        public List<string> scissorsLosesTo;
        public List<string> lizardLosesTo;
        public List<string> spockLosesTo;

        public Gesture(string gesture)
        {
            if(gesture == "Rock")
            {
                rockLosesTo = new List<string>() { "Paper", "Spock" };
               

            }
            if (gesture == "Paper")
            {
                paperLosesTo = new List<string>() { "Scissors", "Lizard" };

            }
            if (gesture == "Scissors")
            {
                scissorsLosesTo = new List<string>() { "Rock", "Spock" };

            }
            if (gesture == "Lizard")
            {
                lizardLosesTo = new List<string>() { "Rock", "Scissors" };

            }
            if (gesture == "Spock")
            {
                spockLosesTo = new List<string>() { "Paper", "Lizard" };

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