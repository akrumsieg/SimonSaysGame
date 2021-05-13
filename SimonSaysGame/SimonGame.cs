using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysGame
{
    public enum Directions { Up = 0, Right, Down, Left, Unknown }
    public class SimonGame
    {
        //constructor

        //properties
        public bool GameOver { get; private set; }
        public List<int> _gamePattern = new List<int> { };
        private int guessPosition = 0;
        public int _scoreCounter = -1;

        //methods
        public void generateNextNumber()
        {
            Random rand = new Random();
            int nextNum = rand.Next(4);
            _gamePattern.Add(nextNum);
            guessPosition = 0;
            _scoreCounter++;
        }

        public void CheckGuess(Directions input)
        {
            if (_gamePattern[guessPosition] == (int)input)
            {
                guessPosition++;
            }
            else
            {
                GameOver = true;
            }
        }

        //method to receive and convert input
        public Directions InputDirection()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    return Directions.Up;
                case ConsoleKey.RightArrow:
                    return Directions.Right;
                case ConsoleKey.DownArrow:
                    return Directions.Down;
                case ConsoleKey.LeftArrow:
                    return Directions.Left;
                default:
                    return Directions.Unknown;
            }
        }

        //method to return current game pattern (Simon's turn)
        public List<int> ReturnGamePattern()
        {
            return _gamePattern;
        }

        public int ReturnScoreCounter()
        {
            return _scoreCounter;
        }


        //TODO LATER method to playback user input in real time

    }
}
