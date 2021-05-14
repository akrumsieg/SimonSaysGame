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
        //properties and fields
        public bool GameOver { get; set; }
        public List<int> _gamePattern = new List<int> { };
        private int _guessPosition = 0;
        public int _scoreCounter = -1;

        //methods
      
        public void ResetGameData()
        {
            _guessPosition = 0;
            _scoreCounter = -1;
            for (int i = _gamePattern.Count - 1; i >= 0; i--)
            {
                _gamePattern.Remove(_gamePattern[i]);
            }
        }

        public void GenerateNextNumber()
        {
            Random rand = new Random();
            int nextNum = rand.Next(4);
            _gamePattern.Add(nextNum);
            _guessPosition = 0;
            _scoreCounter++;
        }

        public bool CheckGuess(Directions input)
        {
            if (_gamePattern[_guessPosition] == (int)input)
            {
                _guessPosition++;
                return true;
            }
            else
            {
                GameOver = true;
                return false;
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
