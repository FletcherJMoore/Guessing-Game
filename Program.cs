Console.WriteLine("Welcome to Guessing Game!");
Console.WriteLine("Guess a number (1 - 100)");
string secretNumberGuess = Console.ReadLine();
if (int.TryParse(secretNumberGuess, out int secretNumber) && secretNumber > 0 && secretNumber <= 100)
{
    Console.WriteLine($"You Guessed {secretNumber}");
}
else
{
    Console.WriteLine("Please guess a number between 1 and 100. Invalid Input");
}