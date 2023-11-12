# Combinar cadeias de caracteres usando sequências de escape de caracteres: :bookmark_tabs:

Uma **sequência de caracteres de escape** é uma instrução especial que insere um caractere especial na saída de cadeia de caracteres.

- `\n` : nova linha
- `\t` : cria um tab
- `\"` : insere aspas duplas
- `\\` : insere uma barra invertida (\) simples

Para evitar o uso dos caracteres de escape, pode-se usar a diretiva `@` antes do literal de cadeia de caracteres, o que fará com que todos os espaços, barras e etc sejam lidos literalmente:
~~~csharp
Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");
// Todos os espaços e tabs serão impressos normalmente, assim como a \ não será lida como entrada de caractere de escape
~~~
OBS: *Caracteres Unicode podem ser inseridos com o caractere de escape `\u` seguido do código de 4 dígitos do caractere, mas não é exatamente recomendado, porque podem não ser impressos corretamente a depender do aplicativo.*

# Combinar cadeias de caracteres usando a concatenação de cadeias de caracteres:
**Concatenação de cadeias de caracteres** = combinação de dois ou mais valores string em um novo valor string, por meio do uso do operador de concatenação de cadeia de caracteres (+)
~~~csharp
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
~~~

# Combinar cadeias de caracteres usando a interpolação de cadeias de caracteres:
A interpolação combina vários valores em uma única daceia de caracteres literal usando um "modelo" e umna ou mais expressões de interpolação.  
Uma **expressão de interpolação** é indicada entre chaves {} e a cadeia de caracteres literal se torna um modelo quando prefixada pelo caractere `$`:
~~~csharp
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName}!");
~~~
OBS: *o prefixo literal textual `@` pode ser aplicado junto com a interpolação, na seguinte ordem: `$@` (o contrário da erro)*