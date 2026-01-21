/*
string veta = "Dneska je velmi hezky";

//zmena velikosti pisma
Console.WriteLine(veta.ToUpper());
Console.WriteLine(veta.ToLower());

//Odstraneni mezer
Console.WriteLine(veta);
Console.WriteLine(veta.Trim());

//Hledani
Console.WriteLine(veta.Contains("hezky")); //true nebo false
Console.WriteLine(veta.IndexOf(" ")); //Pozici prbniho vyskytu

//Zacina/Konci
Console.WriteLine(veta.StartsWith("zitra")); //true nebo false
Console.WriteLine(veta.Trim().EndsWith("hezky.")); 
*/


/*
string veta = "zadej jmeno a prijmeni";
Console.WriteLine(veta.Trim());
Console.WriteLine(veta.Length);
Console.WriteLine(veta.ToUpper());
Console.WriteLine(veta.Contains("Jan"));
Console.WriteLine(veta[0]);
Console.WriteLine(veta[veta.Length-1]);
*/




/*
string datum = "2025-11-11T16:00";
string rok = datum.Substring(startIndex:0, length:4);
string cas = datum.Substring(11);
string den = datum.Substring(startIndex:5, length:5);

Console.WriteLine($"rok: {rok}, Cas: {cas}, Den: {den}");
*/




/*
string text = "cena: 100kc, Doprava: 50kc";
string opaveno = text.Replace("kc", "czk");
Console.WriteLine(opaveno);
*/

/*
string Radek = "Pavel; Novak;30;Praha";
string [] casti = Radek.Split(";");

Console.WriteLine($"jeno: {casti[0]}, Prijmeni {casti[1]}, vek: {casti[2]}, Mesto: {casti[3]}");
*/


/*
string veta = "Dneska je krasny den";
string[] slova = veta.Split(" ");
Console.WriteLine(slova.Length);


using System.Globalization;

Console.Clear();
Console.WriteLine("Zadejte jmeno a prijmeni");
string jmeno = Console.ReadLine();
jmeno = jmeno.ToLower();
jmeno = jmeno.Trim();
Console.WriteLine(jmeno.IndexOf(" "));
string [] jmena = jmeno.Split(" ");
jmena[0] = jmena[0].Substring(startIndex:0, length:1).ToUpper();
jmena[1] = jmena[1];
string zp = jmena[1].Substring(startIndex:1 , length:(jmena[1].Length) - 1);
jmena[1] = (jmena[1].Substring(startIndex:0, length:1).ToUpper());

Console.WriteLine(jmena[0] + "." + jmena[1] + zp);
*/

/*
string karel = "JMENO=KAREL; VEK=45; MESTO=PRAHA";
string[] casti = karel.Split(';');
foreach (string par in casti)
{
    string[] c = par.Split('=');
    Console.WriteLine(c[1]);
}
*/


/*
//Prvni zpusob (pro ukazku)
string [] radky = File.ReadAllLines("data.txt");
foreach (var radek in radky)
{
    Console.WriteLine(radek);   
}


//Druhy zpusob

string cesta = "data.txt";
if (File.Exists(cesta)) ;
{
    StreamReader sr = new StreamReader(cesta);
    string line = sr.ReadLine(); //Prectu prvni radek
    Console.WriteLine(line);

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close(); //Zavreni souboru
    
    StreamWriter sw = new StreamWriter(cesta, append: true);
    sw.WriteLine("Hello World!");
    sw.WriteLine("Dobry den");
    
    sw.Close();
    
}
*/
string path = "data.txt";

int celkovyVek = 0;
int pocetZaku = 0;

if (File.Exists(path))
{
    StreamWriter sw = new StreamWriter(path);
    
}