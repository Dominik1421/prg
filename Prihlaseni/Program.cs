Console.Clear();
string heslo = "ahoj";
string vstup;
do
{
    Console.Write("Zadej heslo: ");
    vstup = Console.ReadLine();
} while (vstup != heslo); // dokud není heslo správně, vrací se to nahoru

Console.WriteLine("Spravne heslo!");