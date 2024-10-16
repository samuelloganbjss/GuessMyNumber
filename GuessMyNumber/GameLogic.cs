using GuessMyNumber;
using System;


namespace GuessMyNumberGameApp
{
    public class GameLogic
    {
        private IInput _input;
        private IOutput _output;
        private int _numberToGuess;
        private const int MaxAttempts = 5;

        public GameLogic(IInput input, IOutput output, int numberToGuess)
        {
            _input = input;
            _output = output;
            _numberToGuess = numberToGuess;
        }

        public void Play()
        {
            _output.WriteMessage("Guess the number between 1 and 10");

            for (int i = 0; i < MaxAttempts; i++)
            {
                AskUserToGuess(i + 1);
                int guess = _input.GetGuess();

                if (CheckGuess(guess))
                    return;
            }

            _output.WriteMessage($"Sorry, you've used all {MaxAttempts} attempts. The number was {_numberToGuess}.");
        }

        private void AskUserToGuess(int attempt)
        {
            _output.WriteMessage($"Attempt {attempt}: Enter your guess:");
        }

        private bool CheckGuess(int guess)
        {
            if (guess == _numberToGuess)
            {
                _output.WriteMessage("You win!");
                return true;
            }

            _output.WriteMessage(guess < _numberToGuess ? "Too low" : "Too high");
            return false;
        }
    }
}
