/*
Console.Clear();

int target = 10;
int sum = 0;

for (int i = 1; i <= target; i++)
{
    sum += i;
}

Console.WriteLine($"Suma cisel od 0-{target} : {sum}");


using System.Globalization;

Console.Clear();
int start = 0;
int end = 3;

for (int i = start; i <= end; i++)
{
    Console.Write ( i);
    if (i % 2 == 0)
    {
        Console.WriteLine(" cislo je sude");
    }
    else
    {
        Console.WriteLine(" cislo je liche");
    }
}


//vygenerovani nahodneho cisla

using System.ComponentModel.Design;
using System.Globalization;

Console.Clear();
Random random = new Random();
int target = random.Next(1, 11); // Vygeneruje 1-10

for (int i = 1; i <= 3; i++)
{
    Console.Write("Zadej cislo: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == target)
    {
        Console.WriteLine("spravne");
        break;
    }
    else
    {
        Console.WriteLine("spatne");
    }
}
*/

Console.Clear();
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

