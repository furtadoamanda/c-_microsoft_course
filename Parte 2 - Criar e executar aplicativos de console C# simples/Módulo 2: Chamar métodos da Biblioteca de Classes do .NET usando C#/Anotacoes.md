## Chamar os métodos de uma classe .NET

#### Métodos com estado vs. sem estado:
- Métodos sem estado (*métodos estáticos*): não dependem do estado atual do aplicativo; são implementados para funcionar sem referenciar ou alterar valores já armazenados na memória 
Exemplo: Console.WriteLine()
- Métodos com estado (*métodos de instância*): são construídos de maneira que os torna dependentes de valores armazenados na memória por linhas de código anteriores já executadas; ou modificam o estado do aplicativo atualizando valores ou armazenando novos valores na memória -> controlam seu estado em _campos_, que são variáveis definidas na classe (cada noca instância da classe tem sua própria cópia desses campos nos quais o estado é armazenado)  
*OBS:* Uma única classe pode dar suporte a métodos com e sem estado  

~~~csharp
Random dice = new Random();
// é a mesma coisa que dizer:
Random dice = new();
~~~
O operador `new` cria uma instância de uma classe, chamada de _objeto_.

## Retornar valores e parâmetros de entrada de métodos
- Métodos nulos: não retornam um valor quando são finalizados

#### Parâmetros de entrada:
Parâmetro = informação consumida por um método.  
Um método pode usar um ou mais parâmetros, ou nenhum.  
*OBS:* Muitas vezes, os termos “parâmetro” e “argumento” são usados de maneira intercambiável. No entanto, “parâmetro” refere-se à variável que está sendo usada no método. O “argumento” é o valor transmitido quando o método é chamado.

Os parâmetros de entrada podem ser usados para configurar a maneira como o método executa o trabalho ou podem ser operados diretamente.
~~~csharp
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
// Esse código cria uma instância da classe Random chamada dice. Em seguida, ele usa dice.Next(1, 7) para atribuir um valor aleatório a um número inteiro chamado roll. Nesse caso, o método Next() aceita dois parâmetros, que são usados para configurar os limites inferior e superior do novo número aleatório. Observe que os argumentos são separados por um símbolo ,. Finalmente, ele usa o método Console.WriteLine() para imprimir o valor de roll no console. Nesse caso, ambos os métodos estão usando parâmetros de entrada.
~~~

#### Retornar valores e parâmetros de entrada de métodos

- *Métodos nulos* não retornam um valor quando são finalizados
- Métodos não nulos são projetados para retornar um valor após a conclusão, sendo este valor de retorno normalmente o resultado de uma operação -> ao chamar um método que retorna um valor, geralmente se atribui o valor de retorno a uma variável, tornando possível utilizar o valor posteriormente no código