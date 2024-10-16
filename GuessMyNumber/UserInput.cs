using System;
using GuessMyNumber;

namespace GuessMyNumberGameApp
{
    public class UserInput : IInput
    {
        public int GetGuess()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too large or too small. Please enter a valid number between 1 and 10.");
                }
            }
        }
    }
}
