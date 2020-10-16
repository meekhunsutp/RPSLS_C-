using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {


        public Computer()
        {
            name = "Sheldon";
        }


        public override string ChooseGesture()
        {
            Random rng = new Random();
            int randomChoice = rng.Next(0, gestures.Count);
            return chosenGesture = gestures[randomChoice];
        }
    }
}
