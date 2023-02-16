// criar array de 10 posições

int[] numeros = new int[10];
for(int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1} número: "); // $ indica que o q estiver dentro de chaves é variável
    // para ler 10 arrays e nao ficar repetindo "digite o seg, terc.. numero
    numeros[i] = int.Parse(Console.ReadLine());
        }

for (int i = 0; i < numeros.Length; i++) // para ver se o numero será primo
{
    int contador = 1;

    for (int j = 1; j < numeros[i]; j++)
    {
        if (numeros[i] % j == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        Console.WriteLine($"O número {numeros[i]} é um número primo, e está na posição {i}");
    }
}