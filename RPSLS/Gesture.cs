using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{

    public class Gesture
    {

        public List<string> losesTo;
        //public string[] losesTo;

        public string selection;
        //public string losesToName;

        //public string Rock;
        //public string Paper;
        //public string Scissors;
        //public string Lizard;
        //public string Spock;


        public Gesture()
        {

        }


        public Gesture(string selection)
        //public Gesture(string selection, string[] losesTo)
        {
            if(selection == "Rock")
            {
                this.selection = selection;
                losesTo = new List<string>() { "Paper", "Spock" };
                //this.losesTo = sting[] losesTo { "Paper", "Spock" };
                //losesTo = new List<Gesture>() { new Gesture("Paper"), new Gesture("Spock") };

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