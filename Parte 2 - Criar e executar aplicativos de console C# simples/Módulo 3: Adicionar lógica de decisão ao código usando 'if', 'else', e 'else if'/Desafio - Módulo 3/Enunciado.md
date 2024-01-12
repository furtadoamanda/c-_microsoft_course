### Desafio: Melhorar a taxa de renovação de subscrições

Foi-lhe solicitado que adicionasse uma funcionalidade ao software da sua empresa. A funcionalidade destina-se a melhorar a taxa de renovação de subscrições do software. Sua tarefa é exibir uma mensagem de renovação quando um usuário fizer login no sistema de software e for notificado de que sua assinatura terminará em breve. Precisará de adicionar algumas instruções de decisão para adicionar corretamente a lógica de ramificação à aplicação de forma a corresponder às condições.  
Para criar o código inicial para este desafio, insira o seguinte código:
~~~csharp
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
~~~

#### Rever as regras de negócio para este desafio:
1. Regra 1: Seu código deve exibir apenas uma mensagem.

    A mensagem que seu código exibe dependerá das outras cinco regras. Para as regras 2 a 6, as regras numeradas mais altas têm precedência sobre as regras numeradas mais baixas.

2. Regra 2: Se a assinatura do usuário expirar em 10 dias ou menos, exiba a mensagem:
    ~~~csharp 
    Your subscription will expire soon. Renew now! 
    ~~~

3. Regra 3: Se a assinatura do usuário expirar em cinco dias ou menos, exiba as mensagens:
    ~~~csharp 
    Your subscription expires in _ days.
    Renew now and save 10%!
    ~~~
    Nota: Certifique-se de substituir o _ caractere exibido na mensagem acima pelo valor armazenado na variável daysUntilExpiration quando você construir a saída da mensagem.

4. Regra 4: Se a assinatura do usuário expirar em um dia, exiba as mensagens:
    ~~~csharp
    Your subscription expires within a day!
    Renew now and save 20%!
    ~~~

5. Regra 5: Se a assinatura do usuário expirou, exiba a mensagem:
    ~~~csharp
    Your subscription has expired.
    ~~~

6. Regra 6: Se a assinatura do usuário não expirar em 10 dias ou menos, não exiba nada.