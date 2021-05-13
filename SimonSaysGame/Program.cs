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

            Console.CursorVisible = false;
            simonDisplay.DisplayTitle();
            simonDisplay.DisplayInstructions();
            Console.ReadKey();

            while (!simonGame.GameOver)
            {
                Console.Clear();
                simonGame.generateNextNumber();
                simonDisplay.PlaybackSimonPattern();
                simonDisplay.DisplayDPad();
                simonDisplay.DisplayScore();
                for (int i = 0; i < simonGame._gamePattern.Count; i++)
                {
                    simonGame.CheckGuess(simonGame.InputDirection());
                }
            }
            Console.Clear();
            simonDisplay.DisplayGameOver();
            simonDisplay.DisplayFinalMessage();
            Console.ReadKey();

        }

        //helper methods

    }
}
