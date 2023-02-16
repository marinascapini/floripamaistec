List<string> frutas = new List<string>();
bool continuar = true;  // pois é o usuário que irá inserir as frutas

while (continuar)
{
    if (frutas.Count() == 15) // máximo de 15 itens
    {
        continuar = false;
        break;
    }

    Console.Write("Digite o nome de uma fruta: ");
    frutas.Add(Console.ReadLine()); // read line necessita que o usuário digite enter para ler, é preferível
    Console.Write("Você deseja continuar? ");
    string resposta = Console.ReadLine();

    if (resposta == "Nao" || resposta == "n")
    {
        continuar = false;
    }
}

frutas.Sort(); // colocar as frutas em ordem alfabética

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}