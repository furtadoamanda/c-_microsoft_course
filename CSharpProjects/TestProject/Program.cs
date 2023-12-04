// Random dice = new Random(); // o método Random.Next() gera um número
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(dice.Next(1, 7));