

void RandomNumber()
{
    Random random = new Random();

    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{random.Next(1,100)} ");
    }
}

RandomNumber();