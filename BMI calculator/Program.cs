Console.Clear();
// vaha kg (int)
Console.WriteLine("Zadej svoji vahu v kg");
string vaha = Console.ReadLine();

// vyska cm (int)
Console.WriteLine("Zadej svoji vysku v cm");
string vyska = Console.ReadLine(); 

//Vaha (kg) / (vyska [m] * vyska [m]) 

float vyskafloat = int.Parse(vyska);
float vahafloat = int.Parse(vaha);

float vyska2 = vyskafloat / 100;

float calculator = (vahafloat / (vyska2 * vyska2));
Console.WriteLine(vahafloat / (vyska2 * vyska2));
Console.WriteLine(calculator);

if (calculator < 18.49)
{
    Console.WriteLine("Mas podvahu");
}
else if (calculator <=18.5 && calculator <= 24.99 )
{
    Console.WriteLine("jsi normalni ");
}
else if (calculator >= 25 && calculator <= 29.99) 
{
    Console.WriteLine("Mas nadvahu");
    
}
else
{
     Console.WriteLine("jsi obezni");
}