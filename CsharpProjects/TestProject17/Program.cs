/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string ipInput = "";
bool validLength = false;
bool validRange = false;
bool validZeroes = false;

Console.WriteLine("Insert a IPv4:");
ipInput = Console.ReadLine().Trim();

ValidateLength();
ValidateRange();
ValidateZeroes();

if (validLength && validRange && validZeroes)
{
    Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}

void ValidateLength()
{
    string[] ipv4 = ipInput.Split('.',StringSplitOptions.RemoveEmptyEntries);

    if (ipv4.Length == 4)
    {
        validLength = true;
    }
}

void ValidateZeroes()
{
    string[] ipv4 = ipInput.Split('.',StringSplitOptions.RemoveEmptyEntries);

    foreach (string ip in ipv4)
    {
        if (ip.Length > 1 && ip.StartsWith('0'))
        {
            validZeroes = false;
            return;
        }
    }

        validZeroes = true;

}
void ValidateRange()
{
    string[] ipv4 = ipInput.Split('.', StringSplitOptions.RemoveEmptyEntries);

    foreach (string ip in ipv4)
    {
        int value = int.Parse(ip);
        if( value >= 0 && value <= 255)
        {
            validRange = true;
        }
        else
        {
            break;
        }
    }


}
