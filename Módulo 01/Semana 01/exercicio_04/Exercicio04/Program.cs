// Exercício 04 - Cálculo de média de aprovação

string[] nomeAlunos = new string[5];
decimal[] mediaAlunos = new decimal[5];

// receber o nome e as médias dos alunos, opção for
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nomeAlunos[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1}º aluno: ");
    mediaAlunos[i] = decimal.Parse(Console.ReadLine());
}

// verificar as médias e exibe se o aluno está aprovado ou não, if/else
for (int i = 0; i < 5; i++)
{
    if (mediaAlunos[i] >= 6)
    {
        Console.WriteLine($"O aluno {nomeAlunos[i]} está APROVADO");
    }
    else
    {
        Console.WriteLine($"O aluno {nomeAlunos[i]} está REPROVADO");
    }
}