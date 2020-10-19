using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{

    public class Gesture
    {
        public List<string> losesTo;
        public string selection;

        public Gesture(string selection, List<string> losesTo)
        {
            this.selection = selection;
            this.losesTo = losesTo;
        }
    }
}