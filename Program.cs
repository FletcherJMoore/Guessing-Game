using System.Globalization;

Console.WriteLine("Welcome to Guessing Game!");
Console.WriteLine("Guess a number (1 - 100)");

int secretNumber = 42;
int maxGuess = 4;
int numOfGuess = 0;
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
                numOfGuess++;
                Console.WriteLine($"That answer is incorrect!");
                Console.WriteLine("NUmber of guesses you've made:" + numOfGuess);
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