## Introdução às noções básicas de array

> Uma matriz é uma sequência de elementos de dados individuais acessíveis através de um único nome de variável. É utilizado um índice numérico iniciado em zero para aceder a cada elemento de uma matriz. Como você pode ver, as matrizes permitem que você colete dados semelhantes que compartilham uma finalidade ou características comuns em uma única estrutura de dados para facilitar o processamento.

**Uma matriz é um tipo de variável especial que pode conter múltiplos valores do mesmo tipo de dados**

- Exemplo de criação de uma matriz de cadeia de caracteres:
    ~~~csharp
    string[] fraudulentOrderIDs = new string[3];
    // O primeiro conjunto de colchetes apenas diz ao compilador que a variável é uma matriz, mas o segundo indica o número de elementos que a matriz pode conter
    ~~~

OBS: podem ser criadas matrizes de inteiros, booleanos, etc.

Como qualquer outro elemento de uma variável, os elementos de uma matriz podem ser atribuídos, recuperados e reatribuídos.

~~~csharp
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
~~~

Os valores de inicialização de uma matriz podem ser declarados em uma única instrução ou em instruções individuais:
~~~csharp
// Instruções individuais:
string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// Única instrução:
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
~~~

OBS: Se você tentar acessar um índice fora do limite da matriz, obterá uma exceção de tempo de execução.

O tamanho de uma matriz - o número de elementos - pode ser determinado por meio da propriedade `Length` (que *não* é baseada em zero):
~~~csharp
fraudulentOrderIDs.Length
~~~

## Implementar a instrução foreach

>A foreach instrução fornece uma maneira simples e limpa de iterar através dos elementos de uma matriz. A foreach instrução processa elementos de matriz em ordem de índice crescente, começando com o índice 0 e terminando com o comprimento do índice - 1. Ele usa uma variável temporária para manter o valor do elemento de matriz associado à iteração atual. Cada iteração executará o bloco de código localizado abaixo da foreach declaração.

Exemplo:
~~~csharp
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
// O código dentro do foreach será executado uma vez para cada elemento da matriz `names`
// !!! *À medida que o runtime do .NET percorre cada elemento da matriz através de um ciclo, o valor armazenado no elemento atual da matriz names é atribuído à variável temporária name para um fácil acesso dentro do bloco de código.*
~~~
