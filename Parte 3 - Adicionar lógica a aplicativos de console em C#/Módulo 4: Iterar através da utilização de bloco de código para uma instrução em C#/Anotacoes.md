## Criar e configurar loops de iteração

A instrução `for` itera um bloco de código um determinado número de vezes.

Uma for declaração possui seis partes:  

1. A palavra-chave `for`

2. Um conjunto de parênteses que define as condições de for iteração. Os parênteses contêm três partes distintas, separadas pelo operador final da instrução, um ponto-e-vírgula.

3. A primeira parte define e inicializa a variável do iterador. É chamada de **inicializador**

4. A segunda parte define a condição de conclusão. É chamada de **condição**

5. A terceira parte define a ação a executar após cada iteração. É chamada de **iterador**

6. Por fim, o bloco de código. O bloco de código contém o código que será executado para cada iteração. Essa seção é chamada de **corpo**  

Exemplo:
~~~csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
// o runtime irá continuar a iterar código no bloco de código abaixo da instrução for, enquanto i for menor do que 10. Quando i se torna igual a 10, o runtime para de executar o for bloco de código da instrução. 
~~~

:heavy_exclamation_mark: ATENÇÃO: **não** esquecer de definir a variável i como inteiro antes da execução, sem a definição o código apresentará erro.

- A instrução for deve ser utilizada quando sabe antecipadamente o número de vezes que precisa de iterar um bloco de código.

- A instrução for permite-lhe controlar a forma como cada iteração é processada.

OBS: a palavra-chave `break` pode ser usada para sair de instruções de iteração

### Percorrer cada elemento de uma matriz

A instrução for pode ser utilizada para iterar uma amtriz de elementos.  
Nesse ponto, embora a instrução `foreach` itere todos os elementos da matriz, a instrução `for` pode ser ajustada para proporcionar um maior nível de personalização.  
Exemplo:
~~~csharp
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// Também poderia ser: for (int i = 0; i < names.Length; i++) 
~~~

Com relação às matrizes, uma vantagem importante do `for` em relação ao `foreach` é que com o for é possível reatribuir o valor de uma variável durante a execução, o que não pode ser feito com o foreach.  
Exemplo:  
1. O código a seguir apresenta erro e não pode ser executado, uma vez que o valor da variável faz parte da implementação interna da foreach:
    ~~~csharp
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    foreach (var name in names)
    {
        if (name == "David") name = "Sammy";
    }
    ~~~

2. O código anterior pode ser substituído pelo seguinte, que funcionará como esperado:
    ~~~csharp
    string[] names = { "Alex", "Eddie", "David", "Michael" };

    for (int i = 0; i < names.Length; i++)
    {
        if (names[i] == "David")
        {
            names[i] = "Sammy";
        }
    }

    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
    ~~~

OBS: o código anterior também pode ser escrito como:
~~~csharp
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = 0; i < names.Length; i++)
        if (names[i] == "David") names[i] = "Sammy";

    foreach (var name in names) Console.WriteLine(name);
~~~