const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity;
string output;

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length);

Console.WriteLine($"Quantity: {quantity}");

output = input.Replace("<div>","");
output = output.Replace("trade","reg");

Console.WriteLine($"Output: {output}");