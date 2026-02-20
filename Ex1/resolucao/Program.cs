
int N = 0;
int soma = 0;
int qtdAbaixoMedia = 0;
int indiceMaior = 0;
int indiceMenor = 0;

Console.Write("Digite os numero de elementos:");
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------");


int[] numeros = new int[N];

for (int i = 0; i < N; i++)
{
    Console.Write($"Digite {i + 1}º numero:");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("----------------------------------");
Console.Write("\nNumeros digitados: ");

foreach (int numero in numeros)
{
    Console.Write(numero + " "); 
    soma += numero;
}

decimal media = (decimal)soma / N;

Console.WriteLine($"\nSoma: {soma}");
Console.WriteLine($"Média: {media}");
Console.WriteLine("----------------------------------"); 

for (int i = 0; i < N; i++)
{
    if (numeros[i] < media) qtdAbaixoMedia++;
    if (numeros[i] > numeros[indiceMaior]) indiceMaior = i;
    if (numeros[i] < numeros[indiceMenor]) indiceMenor = i;
}

Console.WriteLine($"\nQuantidade abaixo da média: {qtdAbaixoMedia}");
Console.WriteLine("----------------------------------"); 
Console.WriteLine($"\nÍndice do maior: {indiceMaior} (valor: {numeros[indiceMaior]})");
Console.WriteLine($"Índice do menor: {indiceMenor} (valor: {numeros[indiceMenor]})");
Console.WriteLine("---------------FIM----------------");