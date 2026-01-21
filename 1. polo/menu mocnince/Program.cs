Console.Clear();
while (true)
{
    Console.WriteLine("1. Faktorial");
    Console.WriteLine("2. Mocnina");
    Console.WriteLine("3. Konec");
    Console.WriteLine("Zadej cislo");
    string volba = Console.ReadLine();

    if (volba == "1")
    {
        Console.WriteLine("Zadej cislo:");
        int n = int.Parse(Console.ReadLine());
        long f = 1;
        for (int i = 1; i <= n; i++)
            f *= i;
        Console.WriteLine("Vysledek: " + f);
    }
    else if (volba == "2")
    {
        Console.WriteLine("Zadej zaklad:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej exponent:");
        int e = int.Parse(Console.ReadLine());
        double v = 1;
        for (int i = 0; i < e; i++)
            v *= a;
        Console.WriteLine("Vysledek: " + v);
    }
    else if (volba == "3")
    {
        break;
    }
}
