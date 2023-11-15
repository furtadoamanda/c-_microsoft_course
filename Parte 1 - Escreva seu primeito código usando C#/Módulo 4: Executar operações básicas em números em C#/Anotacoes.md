# Executar operações básicas em números em C#

### Realizar adição com conversão implícita de dados:

Para realizar a adição entre dois números inteiros, basta usar o *operador de adição* (`+`)
~~~csharp
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
~~~

Utilizando o símbolo de + entre strings e ints gera uma operação de concatenação de operandos. Nesse caso, ao tentar inserir diretamente uma operação matemática dentro de uma concatenação, o compilador interpretará tudo como concatenação:  
Exemplo 1:
~~~csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// Irá imprimir: Bob sold 7 widgets.
~~~
Exemplo 2:
~~~csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// Irá imprimir: Bob sold 77 widgets.
~~~
O problema do exemplo 2 pode ser resolvido por meio do uso dos parênteses, que formam o *operador de ordem de operações*, assim como seria usado em uma fórmula matemática:
~~~csharp
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// Irá imprimir: Bob sold 14 widgets.
~~~

### Executar operações matemáticas básicas:

#### Operadores aritméticos:
- `+` = adição
- `-` = subtração
- `*` = multiplicação
- `/` = divisão
- `%` = resto da divisão de inteiros

:exclamation: **Atenção!** Para que o operador de divisão retorne uma divisão exata, sem arredondamentos para um número inteiro, deve ser definido como um tipo de ponto flutuante (como o `decimal`) e **_pelo menos um dos números que estão sendo divididos também deve ser do tipo ponto flutuante_**
~~~csharp
decimal decimalQuocient = 7.0m / 5;
//ou:
decimal decimalQuocient = 7.0m / 5.0m;
~~~
-> Uma alternativa para o exemplo acima, quando se quer fazer a divisão entre dois inteiros sem que o resultado seja truncado, arredondado, deve-se converter os inteiros. A conversão é realizada inserindo o tipo de dados para o qual se deseja converter entre parênteses antes da variável:
~~~csharp
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
~~~
OBS: esse uso dos parênteses se chama *coerção*

#### Ordem de operações:
1. Parênteses
2. Multiplicação e divisão (da esquerda para a direita)
3. Adição e subtração (da esquerda para a direita)

### Incrementar e decrementar valores:
Os **operadores de atribuição composta** são `+=`. `-=`, `*=`, `++` e `--` e funcionam de maneira semelhante, como os exemplos a seguir:  
Exemplo 1:
~~~csharp
value += 5;
// É a mesma coisa que escrever: value = value + 5;
~~~
Exemplo 12:
~~~csharp
value ++;
// É a mesma coisa que escrever: value = value + 1;
~~~
:pencil2: **_Observação:_** `++value` e `value++` **não** são a mesma coisa, o primeiro incrementa para depois recuperar o valor, enquanto o segundo recupera o valor para depois incrementar.

