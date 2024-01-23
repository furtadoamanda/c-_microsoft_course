Random random = new Random();
int hero = 10;
int monster = 10;

do {
    int atack = random.Next(1, 11);
    monster = monster - atack;
    Console.WriteLine($"Monster was damaged and lost {atack} health and now has {monster} health");
    if (monster > 0) continue;
    Console.WriteLine("Hero wins!");
} while (hero > 0) {
    int atack = random.Next(1, 11);
    hero = hero - atack;
    Console.WriteLine($"Hero was damaged and lost {atack} health and now has {hero} health");
} Console.WriteLine ("Monster wins!");

// Erro: não para a execução, está executando tudo sem parar e sem critério
// Talvez o ataque tenha que ser uma variável diferente para hero e monster
// As chaves após o while podem ser um problema