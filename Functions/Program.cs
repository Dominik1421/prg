void Greet(string name)
{
    Console.WriteLine($"Ahoj, {name}");
}

int AddTwoNumbers(int a , int b)
{
    return a + b;
}

int MakeDouble(int x)
{
    return x * 2;
} 

Greet("dominik");
int z = AddTwoNumbers(3, 4);
Console.WriteLine(z);
z = MakeDouble(z);
Console.WriteLine(z);
