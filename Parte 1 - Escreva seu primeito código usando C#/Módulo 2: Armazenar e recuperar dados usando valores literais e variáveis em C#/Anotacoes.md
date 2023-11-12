# Armazenar e recuperar dados usando valores literais e variáveis em C#: :dart:

**Valor literal =** é um valor constante que nunca é alterado

- **Literais de caractere (char literal):** apenas um caractere alfanumérico é impresso na tela para apresentação, não para cálculo; são utilizadas aspas _simples_
~~~csharp
 Console.WriteLine('b') 
 ~~~ 

 **Observação:** as aspas duplas criam uma cadeia de caracteres literal, _string_, em que podem ser usados mais de um caractere (o que seria um erro entre aspas simples)

- **Literais de inteiros (int literal):** exibir um valor numérico inteiro (sem ponto flutuante); não requer o uso de aspas
~~~csharp
 Console.WriteLine(123) 
 ~~~ 

 - **Literais de ponto flutuante (float, double e decimal):** exibir um número que contém ponto flutuante, decimais. Podem ser de 3 tipos _float_, _double_ e _decimal_:

 Float Type | Precision
 ---------- | ---------
 float      | ~6-9 digits
 double     | ~15-17 digits
 decimal    | ~28-29 digits

 Precisão = número de casas decimais utilizadas

a. _float_: para criar um float é utilizado o sufixo literal F (ou f) após o número, para informar ao compilador que você deseja trabalhar com um valor do tipo float:
~~~csharp
 Console.WriteLine(0.25F) 
 ~~~ 
b. _double_: para criar um double basta inserir um número com ponto flutuante, pois o compilador utiliza o padrão double literal:
~~~csharp
 Console.WriteLine(2.625) 
 ~~~ 
c. _decimal_: para criar um decimal é preciso utilizar o sufixo literal M (ou m):
~~~csharp
 Console.WriteLine(12.39816m) 
 ~~~ 

 - **Literais boolianos (bool literal):** utilizado para imprimir um valor representando `true` ou `false`.
 ~~~csharp
 Console.WriteLine(true) 
 ~~~ 

 ## Resumo: :pencil:
 - `string` para palavras, frases ou qualquer dado alfanumérico para apresentação, não cálculo
 - `char` para um caractere alfanumérico
 - `int` para um número inteiro
 - `decimal` para um número com um componente fracionário
 - `bool` para um valor true/false  
  
# Declarar variáveis: :zap:

Uma **variável** é um container para armazenar um tipo de valor. As variáveis são importantes porque seus valores podem mudar durante a execução de um programa.  
Elas podem ser atribuídas, lidas e alteradas.  
**São valores temporários que você armazena na memória do computador.**
*Para criar uma variável, primeiro deve-se declarar o tipo de dados que ela armazenará, depois dar um nome a ela.*
 ~~~csharp
 string firstName;
 // Cria uma variável de nome firstName que só pode conter valores string
 ~~~ 

 #### Regras e convenções para nomnear variáveis:
 1. os nomes de variáveis podem conter caracteres alfanuméricos e o caractere de underline
 2. caracteres especiais **não** são permitidos
 3. os nomes de variáveis precisam começar com uma letra alfabética ou um underline (preferencialmente uma letra), não um número
 4. os nomes de variáveis diferenciam maiúsculas e minúsculas (Value *não* é a mesma coisa que value)
5. nomes de variáveis não podem ser uma palavra-chave do C#
6. os nomes de variáveis devem usar **minúsculas concatenadas** (CamelCase iniciado por minúscula), que é um estilo de escrita que usa uma letra minúscula no início da primeira palavra e uma letra maiúscula no início de cada palavra subsequente.
 7. os nomes de variáveis devem ser descritivos e sugestivos, no contexto do aplicativo
 8. nomes de variáveis devem ser uma ou mais palavras inteiras unidas, não contrações ou abreviações
 9. nomes de variáveis não devem incluir o tipo de dados da variável  

 *Exemplos:*
  ~~~csharp
 char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;
 ~~~ 

 ## Configurar e obter valores de variáveis:
*OPERAÇÃO SET:* Para definir o valor de uma variável, utiliza-se um operador de atribuição, que corresponde ao símbolço  `=` 
~~~csharp
string firstName;
firstName = "Bob";
~~~ 
:exclamation: **IMPOSIÇÃO DE TIPOS:**
*Não se pode atribuir um balor de um tipo de dados a uma variável declarada para conter outro tipo de dados diferente.*  
*OPERAÇÃO GET:* Recuperar o valor de uma variável  
~~~csharp
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
~~~ 
Uma variável pode ser reutilizada e redefinida:
~~~csharp
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
~~~ 

### Inicializar a variável:
Declarar e definir a variável em uma única linha.
~~~csharp
string firstName = "Bob";
~~~ 

# Declarar Variáveis locais de tipo implícito:
Uma variável de tipo implícito é criada usando a palavra-chave `var` seguida de uma inicialização de variável (sem a inicialização imediata gera um erro).
~~~csharp
var message = "Hello World!";
~~~ 
> A palavra-chave *var* informa ao compilador C# que o tipo de dados está implícito pelo valor atribuído. Depois que o tipo é implícito, a variável age da mesma forma como se o próprio tipo de dados real tivesse sido usado para declará-lo. A palavra-chave *var* é usada para salvar em pressionamentos de tecla quando os tipos são longos ou quando o tipo é óbvio no contexto.
> 
:bulb: **O tipo da variável é bloqueado no momento da declaração e _nunca_ poderá conter valores de um tipo de dados diferente**