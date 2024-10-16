using GuessMyNumber;
using System;

namespace GuessMyNumberGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int numberToGuess = random.Next(1, 10);

            IInput input = new UserInput();
            IOutput output = new ConsoleOutput();

            GameLogic game = new GameLogic(input, output, numberToGuess);
            game.Play();
        }
    }
}

