Console.WriteLine("Welcome to Guessing Game!");
Console.WriteLine("Guess a number (1 - 100)");
string userGuessInput = Console.ReadLine();

int secretNumber = 42;
if (int.TryParse(userGuessInput, out int guessInput) && guessInput > 0 && guessInput <= 100)
{
    Console.WriteLine($"Checking answer...");
    if (guessInput == 42)
    {
        Console.WriteLine("Congrats you guessed correctly!");
    }
    else
    {
        Console.WriteLine("That answer is incorrect");
    }
}
else
{
    Console.WriteLine("Please guess a number between 1 and 100. Invalid Input");
}