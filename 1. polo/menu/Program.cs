Console.Clear();
Console.WriteLine("Vyberte si z menu: ");
Console.WriteLine("1.Vyber z uctu");
Console.WriteLine("2.Vklad na ucet");
Console.WriteLine("3.Zobrazeni zustatku");
string menu =  Console.ReadLine();

if (menu == "1")
{
    Console.WriteLine("Vybrali jste z uctu");
}
else if (menu == "2")
{
    Console.WriteLine("Vklad na ucet");
}
else if (menu == "3")
{
    Console.WriteLine("Zobrazeni zustatku");
}
else
{
    Console.WriteLine("Zadali jste spatne ci nezadali cislo");
}
