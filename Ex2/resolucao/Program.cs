Console.WriteLine("Hello, World!");

double[,] matriz = new double[6,6];

Random random = new Random();

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        matriz[i,j] = random.NextDouble() * 100;        
    }
}

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(matriz[i, j].ToString("F2") + " ");
    }
    Console.WriteLine();
}

int soma = 0;
int contador = 0;

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        if (i + j < 5)
        {
            soma += (int)matriz[i, j];
            contador++;
        }
    }
}

double media = (double)soma / contador;

Console.WriteLine("______________________________");

Console.Write("Soma: " + soma + " | ");
Console.WriteLine("Média: " + media.ToString("F2"));
