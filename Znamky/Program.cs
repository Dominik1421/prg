Console.Clear();
Console.Write("Zadej svoji známku:");
string znamka = Console.ReadLine();

if (znamka == "1")
{
    Console.WriteLine("Výborně");
}
else if (znamka == "2")
{
    Console.WriteLine("Chvalitebně");
}
else if (znamka == "3")
{
    Console.WriteLine("Dobrý");
}
else if (znamka == "4")
{
    Console.WriteLine("Dostatečně");
}
else if (znamka == "5")
{
    Console.WriteLine("Nedostatečně");
}
else
{
    Console.WriteLine("Neplatná známka");
}
