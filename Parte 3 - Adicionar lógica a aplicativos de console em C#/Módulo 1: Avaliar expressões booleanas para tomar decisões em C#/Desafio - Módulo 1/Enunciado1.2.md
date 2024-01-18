### Desafio da lógica de decisão

Neste desafio, você implementará a lógica de decisão com base em uma série de regras de negócios. As regras de negócios especificam o acesso que será concedido aos usuários com base em suas permissões baseadas em função e em seu nível de carreira. As ramificações de código exibirão uma mensagem diferente para o usuário, dependendo de suas permissões e nível.

 Digite o seguinte código no Editor de Códigos do Visual Studio:
~~~csharp
string permission = "Admin|Manager";
int level = 55;
~~~
Seu aplicativo usará uma combinação de e *level* para aplicar/avaliar as regras de negócios neste cenário de *permission* desafio. A lista completa de condições para as regras de negócio é especificada na próxima etapa. Sua solução concluída deve usar *permission* e *level*.

> Você precisará usar o método auxiliar para determinar se o `Contains()` valor atribuído à `permission` cadeia de caracteres contém um dos valores de permissão especificados pelas "regras de negócios". Por exemplo, a expressão `permission.Contains("Admin")` retornará true ao usar os valores de dados iniciais especificados no código acima.

**Regras de negócio:**
1. Se o utilizador for um Administrador com um nível superior a 55, devolva a mensagem:
    ~~~
    Welcome, Super Admin user.
    ~~~

2. Se o utilizador for um Administrador com um nível inferior ou igual a 55, devolva a mensagem:
    ~~~
    Welcome, Admin user.
    ~~~

3. Se o utilizador for um Gestor com um nível de 20 ou superior, devolva a mensagem:
    ~~~
    Contact an Admin for access.
    ~~~

4. Se o utilizador for um Gestor com um nível inferior a 20, devolva a mensagem:
    ~~~
    You do not have sufficient privileges.
    ~~~

5. Se o utilizador não for um Administrador nem um Gestor, devolva a mensagem:
    ~~~
    You do not have sufficient privileges.
    ~~~