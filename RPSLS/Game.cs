using System;
using System.Collections.Generic;
using System.Text;
namespace RPSLS
{
    public class Game
    {
        Human playerOne;
        Human playerTwo;
        Computer computer;
        string playerOneSelection;
        string playerTwoSelection;
        string computerSelection;







        public void RunGame() // while win != 2
        {
            Welcome();
            ChoosePlayers();

        }

        public void ChoosePlayers() // One or two players
        {
            Console.WriteLine("Please select 1 or 2 players");
            int numPlayers = int.Parse(Console.ReadLine());
            if( numPlayers == 1)
            {
                OnePlayer();
            }
            else
            {
                TwoPlayer();
            }



        }

        public void Welcome() // introduction and state rules
        {
            Console.WriteLine("LET'S PLAY RPSLS!");
            Console.WriteLine("It's very simple");
            Console.WriteLine("Scissors CUTS paper");
            Console.WriteLine("Paper COVERS rock");
            Console.WriteLine("Rock CRUSHES lizard");
            Console.WriteLine("Lizard POISONS Spock");
            Console.WriteLine("Spock SMASKES scissors");
            Console.WriteLine("scissors DECAPITATES lizards");
            Console.WriteLine("Lizard EATS paper");
            Console.WriteLine("Paper DISPROVES Spock ");
            Console.WriteLine("Spock VAPORIZES rock ");
            Console.WriteLine("Rock CRUSHES Scissors");
        }

        public void DisplyWinner() // print score and winner of game
        {

        }
        public void OnePlayer()
        {
            playerOne = new Human();
            computer = new Computer();
        }
        public void TwoPlayer()
        {
            playerOne = new Human();
            playerTwo = new Human();
        }

        public void PromptPlayerOne() //Display gesture <list> and get user input (switch), while loop for bad input
        {
            Gesture playerOneSelection = playerOne.ChooseGesture();
            //playerOne.chosenGesture = playerOne.ChooseGesture();
        }

        public void PromptPlayerTwo() //Display gesture <list> and get user input (switch), while loop for bad input
        {
            //playerTwo.chosenGesture = playerTwo.ChooseGesture();
        }

        public void ComputerChoice() // random selection from gestures
        {
            //computer.chosenGesture = computer.ChooseGesture();
            Gesture computerSelection = computer.ChooseGesture(); 
            
            computerSelection.losesTo.Contains(playerOneSelection);
        }

        public void CompareOnePlayer() //compare inputs 
        {
            //if ()
            //{

            //}
        }
        public void CompareTwoPlayer() //compare inputs 
        {
            if (playerOne.chosenGesture == "Rock")
            {

            }
        }

        public void DetermineWinner() //increment winner
        {

        }



        //For two player game, need to Console.Clear so you dont see selection
        //public void ClearLastLine()
        //{
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //    Console.Write(new string (' ', Console.BufferWidth));
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //}
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.ForegroundColor = ConsoleColor.White;

    }
}
