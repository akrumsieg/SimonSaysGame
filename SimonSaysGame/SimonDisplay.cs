using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysGame
{
    public class SimonDisplay
    {
        //array of 5 display strings - one default, four directions highlighted
        string _title = @"
  _      __    __                     ______       _____                   ____              ____
 | | /| / /__ / /______  __ _  ___   /_  __/__    / __(_)_ _  ___  ___    / __/__ ___ _____ / / /
 | |/ |/ / -_) / __/ _ \/  ' \/ -_)   / / / _ \  _\ \/ /  ' \/ _ \/ _ \  _\ \/ _ `/ // (_-</_/_/ 
 |__/|__/\__/_/\__/\___/_/_/_/\__/   /_/  \___/ /___/_/_/_/_/\___/_//_/ /___/\_,_/\_, /___(_|_)  
                                                                                 /___/           
";

        string _instructions = 
            "Copy Simon's pattern with your arrow keys. Good luck and keep up! \n \n" +
            "Press any key to start.";

        public SimonGame _simonGame = new SimonGame();

        string _gameOver = @"
  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                     ░                   
            ";
            
            

        string[] _dPad = new string[] {
         @"     x     " + '\n' +
         @"    xxx    " + '\n' +
         @"   xxxxx   " + '\n' +
         @"  xxxxxxx  " + '\n' +
         @" xxxxxxxxx " + '\n' +
         @"xxxxxxxxxxx" + '\n' +
         @"   xxxxx   " + '\n' +
         @"   xxxxx   " + '\n' +
         @"   xxxxx   " + '\n' +
         @"   xxxxx   ",


         @"       x     " + '\n' +
         @"       xxx   " + '\n' +
         @"xxxxxxxxxxx  " + '\n' +
         @"xxxxxxxxxxxxx" + '\n' +
         @"xxxxxxxxxxx  " + '\n' +
         @"       xxx   " + '\n' +
         @"       x     ",


         @"   xxxxx   " + '\n' +
         @"   xxxxx   " + '\n' +
         @"   xxxxx   " + '\n' +
         @"   xxxxx   " + '\n' +
         @"xxxxxxxxxxx" + '\n' +
         @" xxxxxxxxx " + '\n' +
         @"  xxxxxxx  " + '\n' +
         @"   xxxxx   " + '\n' +
         @"    xxx    " + '\n' +
         @"     x     ",


         @"      x       " + '\n' +
         @"    xxx       " + '\n' +
         @"  xxxxxxxxxxxx" + '\n' +
         @"xxxxxxxxxxxxxx" + '\n' +
         @"  xxxxxxxxxxxx" + '\n' +
         @"    xxx       " + '\n' +
         @"      x       ",

         @"                   x                   " + '\n' +
         @"                  xxx                  " + '\n' +
         @"                 xxxxx                 " + '\n' +
         @"                xxxxxxx                " + '\n' +
         @"               xxxxxxxxx               " + '\n' +
         @"              xxxxxxxxxxx              " + '\n' +
         @"                 xxxxx                 " + '\n' +
         @"                 xxxxx                 " + '\n' +
         @"         x       xxxxx       x         " + '\n' +
         @"       xxx       xxxxx       xxx       " + '\n' +
         @"     xxxxxxxxxxxx     xxxxxxxxxxx      " + '\n' +
         @"   xxxxxxxxxxxxxx     xxxxxxxxxxxxx    " + '\n' +
         @"     xxxxxxxxxxxx     xxxxxxxxxxx      " + '\n' +
         @"       xxx       xxxxx       xxx       " + '\n' +
         @"         x       xxxxx       x         " + '\n' +
         @"                 xxxxx                 " + '\n' +
         @"                 xxxxx                 " + '\n' +
         @"              xxxxxxxxxxx              " + '\n' +
         @"               xxxxxxxxx               " + '\n' +
         @"                xxxxxxx                " + '\n' +
         @"                 xxxxx                 " + '\n' +
         @"                  xxx                  " + '\n' +
         @"                   x                   "
        };

        public void DisplayTitle()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(_title);
            Console.ResetColor();
        }

        public void DisplayInstructions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_instructions);
            Console.ResetColor();
        }

        public void DisplayScore()
        {
            Console.SetCursorPosition(0, 23);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Score: " + _simonGame.ReturnScoreCounter());
            Console.ResetColor();
        }

        public void DisplayGameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_gameOver);
            Console.ResetColor();
        }

        public void DisplayFinalMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int score = _simonGame.ReturnScoreCounter();
            Console.WriteLine($"Your final score was: {score}\n\n" +
            "Thanks for playing!\n\n" +
            "Press any key to exit.");
            Console.ResetColor();
        }

        public void DisplayDPad()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(_dPad[4]);
        }

        //method to display a given string (one direction highlighted) for a given amount of time
        public void DisplayDirection(Directions input)
        {
            DisplayDPad();
            switch ((int)input)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    DisplayInPosition(14, 0, _dPad[0]);
                    Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    DisplayInPosition(22, 8, _dPad[1]);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    DisplayInPosition(14, 13, _dPad[2]);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    DisplayInPosition(3, 8, _dPad[3]);
                    Console.ResetColor();
                    break;
                default:
                    break;

            }
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            System.Threading.Thread.Sleep(20);

        }

        public void DisplayInPosition(int x, int y, string direction)
        {
            string[] stringAsArray = direction.Split('\n');
            foreach (string line in stringAsArray)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;
            }
            DisplayScore();
        }

        public void PlaybackSimonPattern()
        {
            List<int> gamePattern = _simonGame.ReturnGamePattern();
            foreach (int direction in gamePattern)
            {
                DisplayDirection((Directions)direction);
            }
        }

    }

}
