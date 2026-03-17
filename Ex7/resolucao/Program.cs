using System;

namespace Ex7;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("=== Questao 7 - Verdadeiro ou Falso ===\n");

		Console.WriteLine("a) FALSO");
		Console.WriteLine("Construtor nao tem tipo de retorno.");
		Console.WriteLine("Correto: public Triangulo()\n");

		Console.WriteLine("b) FALSO");
		Console.WriteLine("No diagrama de classes UML, '-' indica membro privado.");
		Console.WriteLine("Protegido e indicado por '#'.\n");

		Console.WriteLine("c) FALSO");
		Console.WriteLine("O trecho 'a-=b++1;' esta com erro de sintaxe em C#.");
		Console.WriteLine("Exemplo valido: int a = 15, b = 5; a -= b++; // resultado: a = 10, b = 6\n");

		Console.WriteLine("d) FALSO");
		int x = 50;
		int y = 60;
		int resultado = (x > y) ? x : (x == y) ? 0 : y;
		Console.WriteLine($"Para x=50 e y=60, a expressao retorna {resultado}.");
		Console.WriteLine($"Saida correta: valor e {resultado}\n");

		Console.WriteLine("e) FALSO");
		Console.WriteLine("Em int[,,] mat, mat[1,2,2] nao vale 2 por causa dos indices.");
		Console.WriteLine("Se o array for criado e nao receber atribuicoes, o valor padrao sera 0.\n");

		Console.WriteLine("f) FALSO");
		Console.WriteLine("Setters normalmente retornam void e recebem o valor por parametro.");
		Console.WriteLine("Assinatura correta: public void SetPeso(float peso)");
	}
}
