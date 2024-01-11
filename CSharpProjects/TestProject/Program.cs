// Random dice = new Random(); // o método Random.Next() gera um número
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(dice.Next(1, 7));

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

