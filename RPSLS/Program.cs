namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {



            //Testing
            Human human = new Human();
            human.chosenGesture = human.ChooseGesture();

            Human human2 = new Human();
            human.chosenGesture = human.ChooseGesture();

            //Computer computer = new Computer();
            //computer.ChooseGesture();

        }
    }
}
