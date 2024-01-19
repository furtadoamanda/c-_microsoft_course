## Desafio Converter em instruções de comutador

Começará com o código que utiliza uma construção if-elseif-else para avaliar os componentes de um SKU de produto. O SKU (Unidade de Manutenção de Stock) é formatado com três valores codificados: <product #>-<2-letter color code>-<size code>. Por exemplo, um valor de SKU de 01-MN-L corresponde a (camisa de suor)-(marrom)-(grande) e o código produz uma descrição que aparece como "Produto: Camisa De Suor Marrom Grande".

O seu desafio é converter o código de if instrução numa switch instrução que obtenha o mesmo resultado que o código inicial.

1. Introduza o seguinte código no Visual Studio Code Editor:
~~~csharp
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
~~~

3. Atualize o código para utilizar uma switch instrução em vez da if-elseif-else construção.

4. Verifique se o resultado não foi alterado.
Independentemente da forma como o fizer, o código deve produzir o seguinte resultado:
~~~
Product: Large Maroon Sweat shirt
~~~