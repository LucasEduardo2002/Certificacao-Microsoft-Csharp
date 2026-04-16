string permission = "Admin|Manager";
int level = 55;



if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if(permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if(permission.Contains("Manager") && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}






/*string Permission;
int level;


Console.WriteLine("Enter your permission (Admin, Manager, User)");
Permission = Console.ReadLine();

Console.WriteLine("Enter your level");
level = Convert.ToInt32(Console.ReadLine());*/