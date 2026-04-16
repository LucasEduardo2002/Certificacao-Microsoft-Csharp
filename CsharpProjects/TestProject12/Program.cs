string[] values = {"12,3", "45", "ABC", "11", "DEF"};
double result = 0.0;
double total = 0.0;
string Message = "";

foreach(string check in values)
{
    if(double.TryParse(check, out result)){
        total += result;
    }
    else
    {
        Message += check;
    }
}

Console.WriteLine($"Message: {Message}");
Console.WriteLine($"Total: {total}");
