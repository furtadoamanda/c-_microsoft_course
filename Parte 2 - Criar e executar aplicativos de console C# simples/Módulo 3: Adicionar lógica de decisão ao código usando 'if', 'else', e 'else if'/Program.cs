// Instruções: Você usará o método para simular o Random.Next() lançamento de três dados de seis lados. Você avaliará os valores rolados para calcular a pontuação. 
// Se a pontuação for maior do que um total arbitrário, você exibirá uma mensagem vencedora para o usuário. Se a pontuação estiver abaixo do ponto de corte, você exibirá uma mensagem de perda para o usuário.
// 1. Se dois dos dados que lançar obtiverem o mesmo valor, receberá dois pontos de bónus pelo lançamento duplo.
// 2. Se os três dados que lançar obtiverem o mesmo valor, receberá seis pontos de bónus pelo lançamento triplo.
// 3. Se a soma dos três dados, além de qualquer bónus, for igual a 15 ou superior, ganhará o jogo. Caso contrário, perderá.
// a. Se o jogador obtiver uma pontuação maior ou igual a 16, ganhará um carro novo.
// b. Se o jogador obtiver uma pontuação maior ou igual a 10, ganhará um computador portátil novo.
// c. Se o jogador obtiver uma pontuação igual a 7, ganhará uma viagem.
// d. Caso contrário, o jogador ganha um gatinho.

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // condição composta
{ 
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }
// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total ==7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}