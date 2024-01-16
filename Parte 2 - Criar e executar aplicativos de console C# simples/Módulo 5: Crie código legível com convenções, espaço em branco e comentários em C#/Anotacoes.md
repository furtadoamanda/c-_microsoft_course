### Escolha nomes de variáveis que sigam regras e convenções

#### Regras de nomenclatura das variáveis em C#:
- Os nomes de variáveis podem conter caraacteres alfanuméricos e o caracter de sublinhado `_`. *Não são permitidos caracteres especiais como o sinal de libra `#`, o traço `-` e o cifrão `$`* 

- Os nomes de variáveis têm de começar com uma letra alfabética ou um caracter de sublinhado, não com um número.   
    -- O caracter de sublinhado é utilizado para uma finalidade especial

- Os nomes de variáveis NÃO devem ser uma palavra-chave C#. Por exemplo, estas declarações de nome de variável não serão permitidas: `float float;` ou `string string;`.

- Os nomes das variáveis são sensíveis a maiúsculas e minúsculas, o que significa que `string MyValue;` e `string myValue;` são duas variáveis diferentes.

#### Convenções de nome de variáveis
- Os nomes das variáveis devem utilizar o **camelCase**, que é um estilo de escrita que utiliza uma letra minúscula no início da primeira palavra e uma letra maiúscula no início de cada palavra subsequente. Por exemplo: `string thisIsCamelCase;`.

- Os nomes de variáveis devem ser descritivos e ter significado na sua aplicação. Você deve escolher um nome para sua variável que represente o tipo de dados que ela manterá (não o tipo de dados). Por exemplo: `bool orderComplete;`, _NÃO_ `bool isComplete;`.

- Os nomes das variáveis devem ser uma ou mais palavras inteiras anexadas umas às outras. Não utilize contrações porque o nome da variável pode não ser claro para as outras pessoas que estão lendo o código. Por exemplo: decimal `orderAmount;`, _NÃO_ `decimal odrAmt;`.

- Os nomes de variáveis não devem incluir o tipo de dados da variável. Podem aconselhá-lo a utilizar um estilo como `string strMyValue;`. Era um estilo popular há alguns anos. No entanto, a maioria dos desenvolvedores não segue mais este conselho e há boas razões para não usá-lo.

Exemplos de nomes de variáveis:
~~~csharp
char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;
~~~

### Criar comentários de código eficazes

Comentários podem ser úteis quando:
- quiser deixar uma observação sobre a intenção de uma passagem de código.
- quer remover temporariamente o código da aplicação para tentar uma abordagem diferente, mas ainda não está convencido de que a nova ideia funcionará. 
- quiser lembrar de examinar determinada passagem de código posteriormente, utilizando o `TODO`.  

OBS: comentários de código devem ser usados para dizer o que o código não pode, em apoio à documentação, para ideias de nível superior

> São considerados comentários de baixa qualidade aqueles que explicam desnecessariamente a funcionalidade óbvia de linhas individuais de código.

### Use espaço em branco para facilitar a leitura do código

O termo “espaço em branco” refere-se a espaços individuais produzidos pela space bar, tabulações produzidas pela tecla de tab e novas linhas produzidas pela tecla enter. 
O compilador do C# ignora o espaço em branco. 
- Um espaço em branco eficaz deve facilitar a compreensão do que seu código está fazendo e sua legibilidade