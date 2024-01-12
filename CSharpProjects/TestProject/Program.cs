// Random dice = new Random(); // o método Random.Next() gera um número
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(dice.Next(1, 7));

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 on total");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
    Console.WriteLine("You lose");
}