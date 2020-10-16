using System.Collections.Generic;

namespace RPSLS
{
    //public enum Gestures
    //{
    //    Rock = 1,
    //    Paper = 2,
    //    Scissors = 3,
    //    Lizard = 4,
    //    Spock = 5
    //}
    public class Gestrue
    {
        public List<string> rockLosesTo;
        public List<string> paperLosesTo;
        public List<string> scissorsLosesTo;
        public List<string> lizardLosesTo;
        public List<string> spockLosesTo;



        public Gestrue()
        {
            rockLosesTo = new List<string>() { "Paper", "Spock" };
            paperLosesTo = new List<string>() { "Scissors", "Lizard" };
            scissorsLosesTo = new List<string>() { "Rock", "Spock" };
            lizardLosesTo = new List<string>() { "Rock", "Scissors" };
            spockLosesTo = new List<string>() { "Paper", "Lizard" };
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