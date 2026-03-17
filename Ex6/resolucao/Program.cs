using System;

namespace Ex6;

public class Data
{
	private int dia;
	private int mes;
	private int ano;

	public Data(int dia, int mes, int ano)
	{
		this.dia = dia;
		this.mes = mes;
		this.ano = ano;
	}

	public int GetDia()
	{
		return dia;
	}

	public void SetDia(int dia)
	{
		this.dia = dia;
	}

	public int GetMes()
	{
		return mes;
	}

	public void SetMes(int mes)
	{
		this.mes = mes;
	}

	public int GetAno()
	{
		return ano;
	}

	public void SetAno(int ano)
	{
		this.ano = ano;
	}

	public override string ToString()
	{
		return $"{dia:00}/{mes:00}/{ano:0000}";
	}

	public bool IsValida()
	{
		if (ano < 1899 || ano > 2100)
		{
			return false;
		}

		if (mes < 1 || mes > 12)
		{
			return false;
		}

		int diasNoMes = GetDiasNoMes(mes, ano);

		if (dia < 1 || dia > diasNoMes)
		{
			return false;
		}

		if (ano == 1899)
		{
			return mes == 12 && dia == 31;
		}

		if (ano == 2100)
		{
			return mes == 1 && dia == 1;
		}

		return true;
	}

	private int GetDiasNoMes(int mes, int ano)
	{
		switch (mes)
		{
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
			case 10:
			case 12:
				return 31;

			case 4:
			case 6:
			case 9:
			case 11:
				return 30;

			case 2:
				return IsBissexto(ano) ? 29 : 28;

			default:
				return 0;
		}
	}

	private bool IsBissexto(int ano)
	{
		return (ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0);
	}
}

public class TestaData
{
	public static void Main()
	{
		Console.WriteLine("=== Teste da Classe Data ===");

		Console.Write("Digite o dia: ");
		int dia = int.Parse(Console.ReadLine() ?? "0");

		Console.Write("Digite o mes: ");
		int mes = int.Parse(Console.ReadLine() ?? "0");

		Console.Write("Digite o ano: ");
		int ano = int.Parse(Console.ReadLine() ?? "0");

		Data data = new Data(dia, mes, ano);

		Console.WriteLine($"Data informada: {data}");
		Console.WriteLine($"Data valida no intervalo [31/12/1899, 01/01/2100]: {(data.IsValida() ? "Sim" : "Nao")}");
	}
}
