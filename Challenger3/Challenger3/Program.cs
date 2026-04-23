string pangram = "The quick brown fox jumps over the lazy dog";
char[] valuesArray = pangram.ToCharArray();
Array.Reverse(valuesArray);

string result = new string(valuesArray);

string[] items = result.Split(' ');
Array.Reverse(items);


string result2 = String.Join(" ", items);
Console.WriteLine(result2);