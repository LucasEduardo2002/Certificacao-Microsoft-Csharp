Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = PlayTarget();
        var roll = PlayRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int PlayTarget()
{
    return random.Next(1, 6);
}

int PlayRoll()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target) { return "You Win"; }
    else
    {
        return "You Lose";
    }
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}