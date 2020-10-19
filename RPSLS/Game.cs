using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace RPSLS
{
    public class Game
    {
        public Player playerOne; 
        public Player playerTwo;
        public int numberOfPlayers;

        public void RunGame() 
        {
            Welcome();
            ChoosePlayers();
            while (playerOne.wins < 2 && playerTwo.wins < 2)
            {
                playerOne.ChooseGesture();
                ClearLastLine();
                playerTwo.ChooseGesture();
                ClearLastLine();
                Compare();
            }
            DisplyWinner();
        }

        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("LET'S PLAY ROCK PAPER SCISSOR LIZARD SPOCK!");
            Console.WriteLine("It's very simple\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BEST OF THREE WINS\n\n");
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

        public int ChoosePlayers() // Need to return due to recursion??
        {
            Console.WriteLine("Please select 1 or 2 players");
            string numPlayers = Console.ReadLine();
            if (!int.TryParse(numPlayers, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID input, please enter a number");
                Console.ForegroundColor = ConsoleColor.White;
                return ChoosePlayers();
            }
            int numberPlayers = int.Parse(numPlayers);
            if (numberPlayers != 1 && numberPlayers != 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID option, please select again");
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
            playerTwo = new Computer();
        }
        public void TwoPlayer()
        {
            playerOne = new Human();
            playerTwo = new Human();
        }

        public void Compare()
        {
            if( playerOne.chosenGesture.selection == playerTwo.chosenGesture.selection)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nYou BOTH threw {playerTwo.chosenGesture.selection}, it's a TIE!\n");
                Console.ForegroundColor = ConsoleColor.White;
                EnterNextRound();
            }
            else if (playerOne.chosenGesture.losesTo.Contains(playerTwo.chosenGesture.selection))
            {
                playerTwo.wins++;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n{playerOne.name} threw {playerOne.chosenGesture.selection}");
                Console.WriteLine($"{playerTwo.name} threw {playerTwo.chosenGesture.selection}, {playerTwo.name} wins this round!\n" );
                Console.ForegroundColor = ConsoleColor.White;
                EnterNextRound();
            }
            else
            {
                playerOne.wins++;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n{playerOne.name} threw {playerOne.chosenGesture.selection}");
                Console.WriteLine($"{playerTwo.name} threw {playerTwo.chosenGesture.selection}, {playerOne.name} wins this round!\n");
                Console.ForegroundColor = ConsoleColor.White;
                EnterNextRound();
            }
        }

        public void DisplyWinner() 
        {
            if (playerOne.wins == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\n***{playerOne.name} WINS THE GAME!!***\n\n");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\n***{playerTwo.name} WINS THE GAME!!***\n\n");
            }
        }

        public void EnterNextRound()
        {
            if (playerOne.wins < 2 && playerTwo.wins < 2)
            {
                Console.WriteLine("\n\nPress ENTER for next round\n\n");
                Console.ReadLine();
            }
        }

        public void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
