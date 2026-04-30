string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string internalDomain = "contoso.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayInternalEmail(corporate[i,0], corporate[i,1]);
    // display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayExternalEmail(external[i,0], external[i,1]);
}

void DisplayInternalEmail(string firstName, string lastName)
{
    string email = string.Concat(firstName.AsSpan(0,2), lastName);
    email = email.ToLower();
    Console.WriteLine($"{email}@{internalDomain}");
}

void DisplayExternalEmail(string firstName, string lastName)
{
    string email = string.Concat(firstName.AsSpan(0,2), lastName);
    email = email.ToLower();
    Console.WriteLine($"{email}@{externalDomain}");
}