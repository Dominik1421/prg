Console.Clear();
for (double i = 0; i <= 100; i++)
{
    double vypocet = ((i - 32.0) * (5.0 / 9.0));
    vypocet = Math.Round(vypocet, 1);
    Console.WriteLine($"{i} F -> {vypocet} C");
}