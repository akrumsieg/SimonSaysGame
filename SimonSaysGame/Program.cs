using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimonDisplay simonDisplay = new SimonDisplay();
            SimonGame simonGame = simonDisplay._simonGame;
            bool playAgain = true;

            Console.CursorVisible = false;
            simonDisplay.DisplayTitle();
            simonDisplay.DisplayInstructions();
            Console.ReadKey();
            Console.Clear(); //moved from top of while loop

            while (playAgain)
            {
                while (!simonGame.GameOver)
                {
                    simonGame.GenerateNextNumber();
                    simonDisplay.PlaybackSimonPattern();
                    simonDisplay.DisplayDPad();
                    simonDisplay.DisplayScore();
                    for (int i = 0; i < simonGame._gamePattern.Count; i++)
                    {
                        Directions input = simonGame.InputDirection();
                        if (!simonGame.CheckGuess(input))
                        {
                            goto WrongAnswer;
                        }
                        simonDisplay.DisplayUserDirection(input);
                    }
                    System.Threading.Thread.Sleep(500);
                }
                WrongAnswer:
                Console.Clear();
                simonDisplay.DisplayGameOver();
                simonDisplay.DisplayFinalMessage();
                ConsoleKey playOrExit = Console.ReadKey().Key;
                if (playOrExit == ConsoleKey.Enter)
                {
                    simonGame.GameOver = false;
                    Console.Clear();
                    simonGame.ResetGameData();
                }
                else if (playOrExit == ConsoleKey.Escape)
                {
                    playAgain = false;
                }
            }

        }

        //helper methods

    }
}
