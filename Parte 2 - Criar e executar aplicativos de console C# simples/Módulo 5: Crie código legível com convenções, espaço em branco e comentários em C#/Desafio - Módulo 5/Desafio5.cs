/* 
    The following code turns a message into a char array, then reverts the chars.
    After, it counts the number of times the letter "o" appears in the message.
    Then it converts the char array back into a string, and prints the message and the number os times the specific character appears.
*/

string message = "The quick brown fox jumps over the lazy dog.";
char[] messageCharacters = message.ToCharArray();

Array.Reverse(messageCharacters);

int bin = 0;

foreach (char character in messageCharacters) 
{ 
    if (character == 'o')
    { 
        bin++; 
    } 
}

string newMessage = new String(messageCharacters);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {bin} times.");

// RESOLUÇÃO MICROSOFT:

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");