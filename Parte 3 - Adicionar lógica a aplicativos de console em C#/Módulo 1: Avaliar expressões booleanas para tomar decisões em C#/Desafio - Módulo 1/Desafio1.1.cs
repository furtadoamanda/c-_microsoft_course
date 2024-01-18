// Solução com if:
Random coin = new Random();
int flip = coin.Next(1,3);
if (flip == 1)
{
    Console.WriteLine("Heads");
} else {
    Console.WriteLine("Tails");
}

// Solução com condicional 1:
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

// Solução com condicional 2:
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");