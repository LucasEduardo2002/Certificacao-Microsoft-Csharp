

for(int number = 1; number <= 100; number++)
    if(number % 3 == 0)
        Console.WriteLine($"{number} - Fizz");
    else if(number % 5 == 0)
        Console.WriteLine($"{number} - Buzz");
    else if(number % 3 == 0 && number % 5 == 0)
        Console.WriteLine($"{number} - FizzBuzz");
    else
        Console.WriteLine(number);