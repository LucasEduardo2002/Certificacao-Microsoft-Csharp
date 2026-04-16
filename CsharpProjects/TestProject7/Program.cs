string[] pedidosID = {
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

foreach (string pedidoID in pedidosID)
{
    if (pedidoID.StartsWith("B"))
    {
        Console.WriteLine(pedidoID);
    }
}