string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Camisa";
        break;
    case "02":
        type = "Calça";
        break;
    case "03":
        type = "Blusa";
        break;
    default:
        type = "N/A";
        break;
}

switch (product[1])
{
    
    case "MN" :
        color = "Marinho";
        break;
    case "RD":
        color = "Vermelho";
        break;
    case "BK":
        color = "Preto";
        break;
    default:
        color = "N/A";
        break;
}
switch (product[2])
{
    case "S":
        size = "Pequeno";
        break;
    case "M":
        size = "Médio";
        break;
    case "L":
        size = "Grande";
        break;
    default:
        size = "N/A";
        break;
}

Console.WriteLine("O produto escolhido foi: " + type + " " + color + " " + size);