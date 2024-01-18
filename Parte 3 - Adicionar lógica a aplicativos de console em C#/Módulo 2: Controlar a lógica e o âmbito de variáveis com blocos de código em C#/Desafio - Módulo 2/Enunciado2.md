## Desafio de escopo de variável

1. Digite o seguinte código no Editor de Códigos do Visual Studio:
~~~csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
~~~

2. Analise o resultado pretendido.

Quando você tiver concluído as edições de código necessárias, seu aplicativo deverá produzir a seguinte saída:
~~~
Set contains 42
Total: 108
~~~

3. Conclua as atualizações de código necessárias para que as instruções existentes Console.WriteLine() produzam a saída desejada.

Poderá ser necessário ajustar o âmbito variável.

4. Otimize seu código para legibilidade.

Dependendo da quantidade de espaço em branco que você incluir e alguns outros fatores, você deve ter cerca de 17 linhas de código.