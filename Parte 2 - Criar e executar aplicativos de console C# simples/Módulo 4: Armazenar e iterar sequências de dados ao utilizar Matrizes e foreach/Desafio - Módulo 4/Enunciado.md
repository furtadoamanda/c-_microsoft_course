### Desafio de código - Relatar os IDs de pedido que precisam de investigação adicional

Sua equipe encontrou um padrão. As encomendas que começam com a letra "B" encontram fraudes a uma taxa 25 vezes superior à taxa normal. Você escreve um novo código que gera o ID do pedido de novos pedidos, onde o ID do pedido começa com a letra "B". Isso será usado pela equipe de fraude para investigar mais.

Use as etapas a seguir para concluir este desafio.  

1. Declare uma matriz e inicialize-a para conter os seguintes elementos:
    ~~~
    B123
    C234
    A345
    C15
    B177
    G3003
    C235
    B179
    ~~~
    Esses valores representam os dados fraudulentos de ID do pedido que seu aplicativo usa.  

2. Crie uma foreach instrução para iterar através de cada elemento da sua matriz.

3. Informe os IDs de pedido que começam com a letra "B".
    Você precisa avaliar cada elemento da matriz. Denuncie os IDs de pedidos potencialmente fraudulentos detetando os pedidos que começam com a letra "B". Para determinar se um elemento começa ou não pela letra "B", utilize o método String.StartsWith(). Aqui está um exemplo simples de como usar o String.StartsWith() método que você pode adaptar para seu código:
    ~~~csharp
    string name = "Bob";
    if (name.StartsWith("B"))
    {
        Console.WriteLine("The name starts with 'B'!");
    }
    ~~~
    Sua saída deve corresponder ao seguinte:
    ~~~
    B123
    B177
    B179
    ~~~

Dica: À medida que você percorre cada elemento em sua matriz, você precisará de uma if instrução. A instrução if precisará de utilizar um método na classe de cadeia para determinar se uma cadeia começa com uma letra específica. Se tiver dúvidas sobre como utilizar uma instrução if, veja o módulo "Add decision logic to your code using the if-elseif-else statement in C#" (Adicionar uma lógica de decisão ao seu código com a instrução if-elseif-else em C#).