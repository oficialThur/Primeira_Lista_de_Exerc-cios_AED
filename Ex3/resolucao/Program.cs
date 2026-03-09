// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int idade, homens = 0, mulheres = 0, total_entrevistados = 0, total_divorciadas = 0, total_homens_menores = 0;
int bhFm = 0, fm98 = 0, jovemPan = 0, itatiaia = 0, cdl = 0, outros = 0;
double media = 0, soma = 0;

do
{
    Console.WriteLine("Digite a idade do entrevistado (ou -1 para encerrar): ");
    idade = int.Parse(Console.ReadLine());

    if (idade == -1)
        break;

    Console.WriteLine("Digite o sexo do entrevistado (M/F): ");
    char sexo = char.Parse(Console.ReadLine().ToUpper());

    Console.WriteLine("Digite o estado civil do entrevistado (S/C/D): ");
    char estadoCivil = char.Parse(Console.ReadLine().ToUpper());

    Console.WriteLine("Digite a emissora de rádio preferida do entrevistado (1-BH FM, 2-FM 98, 3-Jovem Pan, 4-Itatiaia, 5-CDL, 6-Outros): ");
    int emissora = int.Parse(Console.ReadLine());

    total_entrevistados++;

    if (sexo == 'M')
        homens++;
    else if (sexo == 'F')
        mulheres++;

    if (estadoCivil == 'D')
        total_divorciadas++;

    if (idade < 18)
        total_homens_menores++;

    switch (emissora)
    {
        case 1:
            bhFm++;
            break;
        case 2:
            fm98++;
            break;
        case 3:
            jovemPan++;
            break;
        case 4:
            itatiaia++;
            break;
        case 5:
            cdl++;
            break;
        case 6:
            outros++;
            break;
    }

    soma += idade;

} while (true);

if (total_entrevistados > 0)
{
    Console.WriteLine($"Bhfm: {(bhFm * 100 / total_entrevistados):F2}%");
    Console.WriteLine($"98fm: {(fm98 * 100 / total_entrevistados):F2}%");
    Console.WriteLine($"Jovem Pan: {(jovemPan * 100 / total_entrevistados):F2}%");
    Console.WriteLine($"Itatiaia: {(itatiaia * 100 / total_entrevistados):F2}%");
    Console.WriteLine($"CDL: {(cdl * 100 / total_entrevistados):F2}%");
    Console.WriteLine($"Outros: {(outros * 100 / total_entrevistados):F2}%");
}

Console.WriteLine($"\nTotal de mulheres divorciadas que preferem CDL: {total_divorciadas}");
Console.WriteLine($"\nTotal de homens menores de 18 anos que preferem Jovem Pan: {total_homens_menores}");
Console.WriteLine($"\nMédia das idades dos entrevistados: {media:F2} anos");
Console.WriteLine($"\nQuantidade de Homens registrados: {homens}");
Console.WriteLine($"\nQuantidade de Mulheres registrados: {mulheres}");
Console.WriteLine("\nEntrevista encerrada!");
Console.ReadKey()!;
