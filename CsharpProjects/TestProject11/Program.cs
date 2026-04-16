
int number = 10;
decimal number2 = 10.22m;

int number3 = (int)number2;

Console.WriteLine($"int: {number3}");

//******************************************

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

//******************************************

int first = 1;
int secund = 2;

Console.WriteLine(first.ToString() + secund.ToString());


//******************************************

string numero1 = "1";
string numero2 = "2";

int sum = int.Parse(numero1) + int.Parse(numero2);

Console.WriteLine(sum);


//******************************************

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) + Convert.ToInt32(value2);
Console.WriteLine(result);


//******************************************
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");