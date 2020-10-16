using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.ChooseGesture();

            Human human2 = new Human();
            human2.ChooseGesture();

            Computer computer = new Computer();
            computer.ChooseGesture();

        }
    }
}
