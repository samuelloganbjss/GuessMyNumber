using GuessMyNumber;
using System;

namespace GuessMyNumberGameApp
{
    public class UserInput : IInput
    {
        private const int MaxAttempts = 5; 

        public int GetGuess()
        {
            int attempts = 0;  

            while (attempts < MaxAttempts)
            {
                try
                {
                    Console.WriteLine($"Enter your guess (Attempt {attempts + 1} of {MaxAttempts}):");

                    string input = Console.ReadLine();

                    
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please enter a valid number.");
                        attempts++;
                        continue;
                    }

                    
                    int guess = int.Parse(input);

                    
                    if (guess < 1 || guess > 10)
                    {
                        Console.WriteLine("Number out of range. Please enter a number between 1 and 10.");
                        attempts++;
                        continue;
                    }

                    
                    return guess;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    attempts++;  
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too large or too small. Please enter a valid number between 1 and 10.");
                    attempts++;  
                }
            }

            
            Console.WriteLine("Sorry, you've exceeded the maximum number of attempts.");
            return -1; 
        }
    }
}

