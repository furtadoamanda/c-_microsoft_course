## Criar loops de interação do e while


#### Instrução do-while:
A `do-while` instrução executa uma instrução ou um bloco de instruções enquanto uma expressão booleana é avaliada cono true. Como a expressão é avaliada *após* cada execução do ciclo, um ciclo do-while é executado *uma ou mais vezes*.  
O código é executado pelo menos uma vez e, em seguida, a expressão booleana junto à palavra-chave while é avaliada. Se a expressão booleana devolver true, o bloco de código será executado novamente.  

Exemplo:
~~~csharp
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

// O código do exemplo continua a gerar números aleatórios entre 1 e 10 até gerar o número 7, quando o fluxo de execução sairá do bloco de código
~~~

:round_pushpin: **Instrução `continue`**:
~~~csharp
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

// Se a expressão do if retornar true, a continue instrução transferirá o controle para o final do bloco de código e o while avaliará o (current != 7). O loop continuará enquanto o valor de current não for igual a 7 e o continue garante que um valor maior que 8 nunca será gravado na saída. 
~~~

OBS: a instrução `continue` transfere a execução para o final da iteração atual. Este comportamento é diferente do comportamento da `break` declaração. A break instrução encerra a iteração (ou switch) e transfere o controle para a instrução que segue a instrução terminada. Se não houver nenhuma instrução após a instrução terminada, o controle será transferido para o final do arquivo ou método.



#### Instrução while:
A instrução `while` e a expressão booleana são posicionadas antes do bloco de código, de modo que o fluxo de execução somente inicia se a expressão booleana for avaliada como true.  
Exemplo:
~~~csharp
Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

// Dentro do bloco de código, a primeira coisa que fazemos é escrever o valor de current no console. Em seguida, ainda dentro do bloco de código, atualizamos o valor de current com um novo valor aleatório. Neste ponto, o controle volta para o topo da while instrução onde a expressão booleana é avaliada. Esse processo continua até que a expressão booleana retorne false e o fluxo de execução seja interrompido do bloco de código.
~~~


> :pencil: A `do-while` instrução itera através de um bloco de código pelo menos uma vez e pode continuar a iterar com base em uma expressão booleana. A avaliação da expressão booleana geralmente depende de um determinado valor gerado ou obtido dentro do bloco de código.  
A instrução `while` começa por avaliar uma expressão booleana e, em seguida, continua a iterar o bloco de código, desde que a expressão booleana seja avaliada como true.

RELEMBRANDO:
- A `for` instrução: executa seu corpo enquanto uma expressão booleana especificada (a 'condição') é avaliada como verdadeira.
- A `foreach` instrução: enumera os elementos de uma coleção e executa seu corpo para cada elemento da coleção.
- A `do-while` afirmação: condicionalmente executa seu corpo uma ou mais vezes.
- A `while` afirmação: condicionalmente executa seu corpo zero ou mais vezes.