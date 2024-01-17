### Avaliar uma expressão:

> Uma expressão é qualquer combinação de valores (literal ou variável), operadores e métodos que devolvem um só valor.

_**Expressão booleana** é aquela que possui como valor de retorno sempre um único `true` ou `false` valor._

IMPORTANTE: Antes de verificar dois valores de cadeia de caracteres para igualdade, especialmente quando um ou ambos os valores foram inseridos por um usuário, você deve:

1. Certificar-se de que ambas as cadeias estão todas em maiúsculas ou todas em minúsculas, ao utilizar o método auxiliar `ToUpper()` ou `ToLower()` em qualquer valor de cadeia.
2. Remova todos os espaços em branco à esquerda ou à direita usando o `Trim()` método auxiliar em qualquer valor de cadeia de caracteres.  

~~~csharp
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
~~~

#### Negação lógica
O termo "Negação Lógica" refere-se ao operador "!" de negação unária. Algumas pessoas chamam este operador de "não operador". Quando você coloca o ! operador antes de uma expressão condicional (ou qualquer código que é avaliado para um true ou false), ele *força seu código a reverter sua avaliação do operando*. Quando a negação lógica é aplicada, a avaliação produz true, se o operando avalia para false, e false , se o operando avalia para true.

~~~csharp
// Ambos os códigos a seguir produzem a mesma saída:

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
~~~

OBS: O operador `!=` de desigualdade inclui um caractere !, mas não deve ser confundido com negação lógica. O operador de desigualdade retorna false se seus operandos não forem iguais e retorna false se os operandos forem iguais. Para os operandos dos tipos internos, a expressão x != y produz o mesmo resultado que a expressão !(x == y) (um exemplo de negação lógica).


### Implementar o operador condicional:
O operador `?` condicional avalia uma expressão booleana e retorna um dos dois resultados, dependendo se a expressão booleana é avaliada como true ou false. O operador condicional é comumente referido como o operador condicional ternário.
> Utiliza-se o operador condicional quando é necessário retornar um valor baseado em uma condição binária

Este é o formato básico:
~~~csharp
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
~~~

Exemplo:
~~~csharp
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
// A saída será: "Discount: 100"
~~~