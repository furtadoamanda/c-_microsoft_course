## Implementar uma instrução switch

> Uma `switch` instrução é uma instrução de seleção C# que fornece uma alternativa a uma `if-elseif-else` construção de ramificação. A `switch` instrução fornece vantagens ao avaliar um único valor.

A `switch` instrução escolhe uma seção de código para executar a partir de uma lista de possíveis seções de switch. A seção de *opção selecionada* é escolhida com base em uma correspondência de padrão com a expressão de correspondência da instrução.  
Exemplo:
~~~csharp
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}

// Nesse código, a instrução switch segue a palavra-chave "fruit", sendo que cada seção do switch é definida por um *padrão de caso*. Padrões de caso são expressões booleanas que avaliam para true ou false e, quando true, executam a seção switch a que pertencem.
~~~

Uma instrução switch deve incluir pelo menos uma seção switch, mas normalmente conterá três ou mais seções switch.

A instrução switch é melhor utilizada quando:

- Você tem um único valor (variável ou expressão) que deseja corresponder a muitos valores possíveis.
- Para qualquer correspondência, você precisa executar no máximo algumas linhas de código.  

OBS: Se nenhum dos rótulos for uma correspondência, a lista de instruções para o `default` caso será executada. Se nenhum padrão for incluído, o controle será transferido para o ponto final da instrução switch.    

:bangbang: **Apenas uma seção de switch pode ser executada.** Isso significa que a execução de uma seção de switch não pode "cair" para a próxima seção de switch. A `break` palavra-chave é uma das várias maneiras de encerrar uma seção de switch antes que ela chegue à próxima seção. Caso se esqueça da palavra-chave break (ou, opcionalmente, a palavra-chave return), o compilador irá gerar um erro.  

Mais de um valor pode ser atribuído à mesma seção de switch (múltiplas etiquetas de caso):
~~~csharp
case 100:
case 200:
    title = "Senior Associate";
    break;
~~~