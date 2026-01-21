/*
Console.WriteLine("Password :");
string heslo = Console.ReadLine();
bool Bezpecne (string heslo)
{
return heslo.Length > 8 && !heslo.Contains("heslo");
}
bool safe = Bezpecne(heslo);
if (safe == true)
{
    Console.WriteLine("Heslo je bezpecne");
}
else
{
    Console.WriteLine("Heslo je nebezpecne");
}
*/

void FrameWord(string word)
{
    for (int i = -4; i < word.Length; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
    
    Console.WriteLine("* " + word + " *");
    for (int i = -4; i < word.Length; i++)
    {
        Console.Write("*");
    }
}
FrameWord("cau");