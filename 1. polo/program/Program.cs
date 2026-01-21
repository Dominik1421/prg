/*
//2.1 Úkol 1 - Oprav funkci
void Greet ()
{
    Console.WriteLine("Ahoj!");
}
Greet();
Greet();
Greet();
//2.2 Úkol 2 - Doplň podmínky
Console.Write("Zadej číslo: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Kladné číslo");
}
else if (number < 0)
{
    Console.WriteLine("Záporné číslo");
}
else
{
    
    Console.WriteLine("Nula");
}
//2.3 Úkol 3 - Oprav cyklus while
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
//2.4 Úkol 4 - Funkce s parametrem
void PrintText(string text)
{
    Console.WriteLine(text);
}
PrintText("Programování je zábava");
//2.5 Úkol 5 - Oprava cyklu for
for (int a = 0; a < 5; a++)
{
    Console.Write("*");
}















//2.1 Úkol 1 - Funkce s návratovou hodnotou
int Bigger(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
//2.2 Úkol 2 - Sudé nebo liché
bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else 
    { 
        return false;
    }
}
Console.Write("Zadej číslo: ");
int n = int.Parse(Console.ReadLine());
if (IsEven(n))
{
    Console.WriteLine("Sudé");
}
else
{
    Console.WriteLine("Liché");
}
//2.3 Úkol 3 - Odpočítávání
void Countdown(int n)
{
    for (int e = n; e >= 0; e--)
    {
        Console.WriteLine(e);
    }
}
Countdown(3);
//2.4 Úkol 4 - Součet čísel
int SumFromOne(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
//Úkol 5 - Mini menu
while (true)
{
    Console.WriteLine("1 - Pozdrav");
    Console.WriteLine("2 - Součet dvou čísel");
    Console.WriteLine("3 - Konec");

    int volba = int.Parse(Console.ReadLine());

    if (volba == 1)
    {
        Console.WriteLine("Ahoj");
    }
    else if (volba == 2)
    {
        Console.WriteLine("Zadejte cislo:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadejte cislo:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a + b);
    }
    else if (volba == 3)
    {
        break; 
    }
}

*/

