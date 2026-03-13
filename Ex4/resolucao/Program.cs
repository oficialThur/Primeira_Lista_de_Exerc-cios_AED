using System;

namespace Ex4;
public class Aluno
{
    private string nome;
    private int matricula;
    private double nota1;
    private double nota2;
    private double nota3;
    public Aluno(string nome, int matricula, double nota1, double nota2, double nota3)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
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