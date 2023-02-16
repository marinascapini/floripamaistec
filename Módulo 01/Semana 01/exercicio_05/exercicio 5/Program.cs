// sequencia de fibonacci: 0 1 1 2 3 5 8 13 - 0 + 1 = 1 + 2 = 3, etc...
// se quiser números muito grandes, no lugar do int usar o long, e se quiser número gigante, usar big int

int n;
int x = 1, y = 0, z = 0;
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    // z = 0, x = 1, y = 0.
    z = x + y; // soma o anterior com o atual
    Console.WriteLine(z);
    y = x;
    x = z;
}