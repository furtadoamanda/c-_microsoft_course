## Blocos de código e âmbito variável

Blocos de código são limitados por chaves `{}` e têm efeito no caminho de execução do programa, além de poderem afetar o escopo de suas variáveis.

_Escopo de variável_ refere-se à visibilidade de uma variável para outro código em seu aplicativo.

- **Variável com âmbito local**: acessível apenas dentro do bloco de código no qual está definida.

:pencil2: Exemplo de criação de variável dentro de um bloco de código:

~~~csharp
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
// Nesse código, a variável value é criada e acessada dentro de um bloco delimitado por chaves {}, não apresentando erros
~~~

:pencil2: Exemplo de tentativa de acesso a uma variável fora do bloco:

~~~csharp
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");
// Esse código apresentará um erro, informando que 'value' não existe. Isso ocorre porque a variável está definida dentro do bloco de código, só sendo acessível/visível, dentro dele.
~~~

OBS: o mesmo é válido para a atribuição de valor à variável. Se ela for definida fora do bloco de código mas só se atribuir um valor (inicializar) a ela dentro do bloco, este valor só será lido dentro do bloco. Exemplo:

~~~csharp
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");
// Aqui, a instrução tentará ler uma variável não inicializada e retornará um erro.
~~~

Para corrigir o erro anterior, basta inicializar a variável fora do bloco de código, o que vai permitir a leitura dos valores atribuídos dentro do bloco:
~~~csharp
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value);
~~~

> Uma variável local é definida como uma variável declarada em um bloco de código de método.

### Remover blocos de código das instruções if

Se você perceber que tem _**apenas uma linha de código**_ listada dentro dos blocos de código de uma if-elseif-else instrução, você pode remover as chaves do bloco de código e espaço em branco. A Microsoft recomenda que as chaves sejam usadas consistentemente para todos os blocos de código de uma if-elseif-else instrução (presentes ou removidos consistentemente).  
Apenas remova as chaves de um bloco de código quando isso tornar o código mais legível.  
Exemplo:
~~~csharp
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}

// É a mesma coisa que:
bool flag = true;
if (flag)
    Console.WriteLine(flag);

// E também é a mesma coisa que:
bool flag = true;
if (flag) Console.WriteLine(flag);
// Porém, o código anterior não apresenta boa legibilidade, não sendo recomendado
~~~