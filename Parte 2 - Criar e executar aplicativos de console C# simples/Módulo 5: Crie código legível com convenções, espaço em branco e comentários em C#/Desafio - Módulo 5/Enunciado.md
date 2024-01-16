### Desafio de legibilidade do código

1. Para criar o código inicial para este desafio, insira o seguinte código:
~~~csharp
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
~~~
Dica: A finalidade de alto nível deste código é inverter uma cadeia de carateres e contar o número de vezes que um carater específico é apresentado.

2. Para melhorar a legibilidade, atualize o código usando diretrizes de estilo.