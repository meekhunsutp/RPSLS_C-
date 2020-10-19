using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace RPSLS
{
    public class Game
    {
        public Human playerOne;
        public Human playerTwo;
        public Computer computer;
        public int numberOfPlayers;
        public string playerOneSelection;
        public string playerTwoSelection;
        public string computerSelection;

        public void RunGame()
        {
            Welcome();
            ChoosePlayers();
            DisplyWinner();
        }

        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("LET'S PLAY RPSLS!");
            Console.WriteLine("It's very simple\n\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Scissors CUTS paper");
            Console.WriteLine("Paper COVERS rock");
            Console.WriteLine("Rock CRUSHES lizard");
            Console.WriteLine("Lizard POISONS Spock");
            Console.WriteLine("Spock SMASKES scissors");
            Console.WriteLine("scissors DECAPITATES lizards");
            Console.WriteLine("Lizard EATS paper");
            Console.WriteLine("Paper DISPROVES Spock ");
            Console.WriteLine("Spock VAPORIZES rock ");
            Console.WriteLine("Rock CRUSHES Scissors\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int ChoosePlayers()
        {
            Console.WriteLine("Please select 1 or 2 players");
            string numPlayers = Console.ReadLine();
            if (!int.TryParse(numPlayers, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter a number");
                Console.ForegroundColor = ConsoleColor.White;
                return ChoosePlayers();
            }
            int numberPlayers = int.Parse(numPlayers);
            if (numberPlayers != 1 && numberPlayers != 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option, please select again");
                Console.ForegroundColor = ConsoleColor.White;
                return ChoosePlayers();
            }
            else if ( numberPlayers == 1)
            {
                OnePlayer();
                return numberOfPlayers;
            }
            else
            {
                TwoPlayer();
                return numberOfPlayers;
            }
        }



        public void OnePlayer()
        {
            playerOne = new Human();
            computer = new Computer();
            DetermineWinnerOnePlayer();

        }
        public void TwoPlayer()
        {
            playerOne = new Human();
            playerTwo = new Human();
            DetermineWinnerTwoPlayer();
        }

        public void PromptPlayerOne()
        {
            playerOneSelection = playerOne.ChooseGesture().selection;
        }

        public void PromptPlayerTwo() 
        {
            playerTwoSelection = playerTwo.ChooseGesture().selection;
        }

        public void ComputerChoice()
        {
            computerSelection = computer.ChooseGesture().selection;
        }

        public void CompareOnePlayer()
        {

            if( playerOneSelection == computerSelection)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nYou both threw {computerSelection}, it's a TIE!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerOne.chosenGesture.losesTo.Contains(computerSelection))
            {
                computer.wins++;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n{playerOne.name} threw {playerOneSelection}");
                Console.WriteLine($"{computer.name} threw {computerSelection}, {computer.name} wins this round!\n" );
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                playerOne.wins++;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n{playerOne.name} threw {playerOneSelection}");
                Console.WriteLine($"{computer.name} threw {computerSelection}, {playerOne.name} wins this round!\n");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        public void CompareTwoPlayer()
        {

            if (playerOneSelection == playerTwoSelection)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nYou both threw {playerTwoSelection}, it's a TIE!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerOne.chosenGesture.losesTo.Contains(playerTwoSelection))
            {
                playerTwo.wins++;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n{playerOne.name} threw {playerOneSelection}");
                Console.WriteLine($"{playerTwo.name} threw {playerTwoSelection}, {playerTwo.name} wins this round!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                playerOne.wins++;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n{playerOne.name} threw {playerOneSelection}");
                Console.WriteLine($"{playerTwo.name} threw {playerTwoSelection}, {playerOne.name} wins this round!\n");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        public void DetermineWinnerOnePlayer()
        {
            while (playerOne.wins != 2 && computer.wins != 2)
            {
                PromptPlayerOne();
                ComputerChoice();
                CompareOnePlayer();
            }
        }
        
        public void DetermineWinnerTwoPlayer()
        {
            while (playerOne.wins != 2 && playerTwo.wins != 2)
            {
                PromptPlayerOne();
                PromptPlayerTwo();
                CompareTwoPlayer();
            }
        }

        public void DisplyWinner()
        {
            if (playerOne.wins == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"***{playerOne.name} WINS THE GAME!!***");
            }
            else if (playerTwo.wins == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"***{playerTwo.name} WINS THE GAME!!***");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"***{computer.name} WINS THE GAME!!***");
            }
        }

        //For two player game, need to Console.Clear so you dont see selection
        //public void ClearLastLine()
        //{
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //    Console.Write(new string (' ', Console.BufferWidth));
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //}


    }
}
