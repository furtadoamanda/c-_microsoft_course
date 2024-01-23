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

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int roll1 = 4;
// int roll2 = 2;
// int roll3 = 2;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // condição composta
// { 
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }


// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total ==7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }




// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }


// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;

// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");




//Desafio4
// string[] fraudulentIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// foreach (string item in fraudulentIDs)
// {
//     if (item.StartsWith("B"))
//     {
//         Console.WriteLine(item);
//     }
// }


// ------------- PARTE 3: -------------
// ----- MÓDULO 1 ------

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");


// ------- DESAFIO 1.1 -------------
// Random coin = new Random();
// int flip = coin.Next(1,3);
// if (flip == 1)
// {
//     Console.WriteLine("Heads");
// } else {
//     Console.WriteLine("Tails");
// }

// ----------- MÓDULO 2 -----------
// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }

// ------ DESAFIO 2 -------
// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//     {
//         Console.WriteLine("Set contains 42");
//     }
// }

// Console.WriteLine($"Total: {total}");

// --------- DESAFIO 3 ----------
// string sku = "01-MN-L";

// string[] product = sku.Split('-'); 

// string type = "";
// string color = "";
// string size = "";

// switch(product[0])
// {
//     case "01":
//     type = "Sweat shirt";
//     break;
//     case "02":
//     type = "T-shirt";
//     break;
//     case "03":
//     type = "Sweat pants";
//     break;
//     default:
//     type = "Other";
//     break;
// }

// switch(product[1])
// {
//     case "BL":
//     color = "Black";
//     break;
//     case "MN":
//     color = "Maroon";
//     break;
//     default:
//     color = "White";
//     break;
// }

// switch(product[2])
// {
//     case "S":
//     size = "Small";
//     break;
//     case "M":
//     size = "Medium";
//     break;
//     case "L":
//     size = "Large";
//     break;
//     default:
//     size = "One Size Fits All";
//     break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");


// ---------- MÓDULO 4 ---------
// for (int i = 1; i <= 100; i++)
// {
//     if ( i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - FizzBuzz");
//     } else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - Fizz");
//     } else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     } else 
//     {
//         Console.WriteLine(i);
//     }
// }

// --------- MÓDULO 5 -------
// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);


// Random random = new Random();
// int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");
