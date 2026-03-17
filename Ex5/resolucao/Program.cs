using System;

namespace Ex5;

public class Aluno
{
	private int matricula;
	private string nome;
	private double nota1;
	private double nota2;
	private double nota3;

	public Aluno(int matricula, string nome, double nota1, double nota2, double nota3)
	{
		this.matricula = matricula;
		this.nome = nome;
		this.nota1 = nota1;
		this.nota2 = nota2;
		this.nota3 = nota3;
	}

	public string GetNome()
	{
		return nome;
	}

	public double GetNotaFinal()
	{
		return (nota1 + nota2 + nota3) / 3.0;
	}

	public string GetResultado()
	{
		double notaFinal = GetNotaFinal();

		if (notaFinal >= 60)
		{
			return "Aprovado";
		}

		if (notaFinal >= 40)
		{
			return "Recuperacao";
		}

		return "Reprovado";
	}
}

public class Program
{
	public static void Main()
	{
		Console.Write("Digite a quantidade de alunos: ");
		int quantidade = int.Parse(Console.ReadLine() ?? "0");

		while (quantidade <= 0)
		{
			Console.Write("Quantidade invalida. Digite novamente: ");
			quantidade = int.Parse(Console.ReadLine() ?? "0");
		}

		Aluno[] alunos = new Aluno[quantidade];

		for (int i = 0; i < quantidade; i++)
		{
			Console.WriteLine($"\nCadastro do {i + 1}o aluno");

			Console.Write("Matricula: ");
			int matricula = int.Parse(Console.ReadLine() ?? "0");

			Console.Write("Nome: ");
			string nome = Console.ReadLine() ?? string.Empty;

			Console.Write("Nota 1: ");
			double nota1 = double.Parse(Console.ReadLine() ?? "0");

			Console.Write("Nota 2: ");
			double nota2 = double.Parse(Console.ReadLine() ?? "0");

			Console.Write("Nota 3: ");
			double nota3 = double.Parse(Console.ReadLine() ?? "0");

			alunos[i] = new Aluno(matricula, nome, nota1, nota2, nota3);
		}

		Console.WriteLine("\nResultado final dos alunos:");
		Console.WriteLine("------------------------------------------");

		for (int i = 0; i < alunos.Length; i++)
		{
			Console.WriteLine($"Nome: {alunos[i].GetNome()} | Resultado: {alunos[i].GetResultado()}");
		}
	}
}
