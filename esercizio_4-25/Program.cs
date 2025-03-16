double y;
Console.WriteLine("Inserisci un numero: ");
y = double.Parse(Console.ReadLine()); 
int x = 0;  
while (Math.Pow(x, x) < y)
{
    x++;
}
Console.WriteLine($"Il numero trovato è {x-1} che soddisfa {x-1}^{x - 1} < {y}");