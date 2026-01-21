double ConverToEuro(double czk)
{
 return czk / 25;
}

Console.WriteLine("zadejte hodnotu: ");
string input = Console.ReadLine();
double czk = double.Parse(input);

double ConverToCzk = ConverToEuro(czk);
Console.WriteLine($"Hodnota v EUR: {ConverToCzk}");
