using System.Globalization;

Console.WriteLine("Welcome to Guessing Game!");
Console.WriteLine("Guess a number (1 - 100)");

Random random = new Random();
int secretNumber = random.Next(1, 100);
int maxGuess = 4;
for (int i = 0; i < maxGuess; i++)
{
    string userGuessInput = Console.ReadLine();
    if (int.TryParse(userGuessInput, out int guessInput) && guessInput > 0 && guessInput <= 100)
    {
        Console.WriteLine($"Checking answer...");
        if (guessInput == secretNumber)
        {
            Console.WriteLine("Congrats you guessed correctly!");
            break;
        }
        else
        {
            if (i < maxGuess - 1)
            {
                Console.WriteLine($"That answer is incorrect! You have {maxGuess - (i + 1)} guesses remaining");
            }
            else
            {
                Console.WriteLine("You have used all your guesses. Thank you for playing!");
            };
        }
    }
    else
    {
        Console.WriteLine("Please guess a number between 1 and 100. Invalid Input");
        
    }
    }