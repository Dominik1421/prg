Console.Clear();
for (float i = 0; i <= 100; i++)
{
    bool jePrvocislo = true;
    Console.Write($"{i} :");
    for (int j = 2; j < i; j++)
    {
      
        if (i % j == 0)
        {
            Console.Write(j);
            jePrvocislo = false;
        }
    }

    if (jePrvocislo) 
    {
        Console.Write("prvocislo");   
    }
    
    Console.WriteLine();
}