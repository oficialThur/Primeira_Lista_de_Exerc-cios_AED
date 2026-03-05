# Primeira Lista de Exercícios - Algoritmos e Estruturas de Dados

Este repositório contém as resoluções da primeira lista de exercícios da disciplina de **Algoritmos e Estruturas de Dados** , ministrada pelo **Professor Fernando Belém** no **COTEMIG**.

## 🚀 Questões

### 1. Vetores e Estatísticas

Escreva um programa que preencha um vetor de **N** elementos inteiros e calcule:

* A soma e a média aritmética;


* A quantidade de elementos abaixo da média;


* O índice do maior e o índice do menor elemento.



``` 
 Os: O valor de N deve ser informado pelo usuário no início da execução.
```
 

### 2. Matrizes

Escreva um programa que preencha aleatoriamente uma **matriz real de 6x6**. Calcule a soma e a média dos elementos situados **acima da diagonal secundária**, incluindo a própria diagonal.

### 3. Pesquisa de Audiência (IBOPE)

Desenvolva um programa para coletar dados de audiência de rádio. A entrada termina quando a **idade for igual a 0**.
**Dados coletados:** Idade, Sexo (1-M, 2-F), Estado Civil (1-C, 2-S, 3-V, 4-D) e Rádio Preferida (1-BHfm, 2-98fm, 3-Jovem Pan, 4-Itatiaia, 5-CDL, outros).
**Resultados esperados:**


**a)** % de audiência de cada rádio;



**b)** Número de mulheres divorciadas que preferem CDL;



**c)** Número de homens menores de 18 anos que preferem Jovem Pan;


 
**d)** Média das idades;


 
**e)** % de homens e de mulheres.



### 4. Classe Aluno

Implemente a classe **Aluno** conforme o diagrama fornecido.


* **Atributos:** `matricula` (int), `nome` (string), `nota1`, `nota2`, `nota3` (double).


 
* **Método `GetNotaFinal()`:** Retorna a média aritmética das três notas.



* **Método `GetResultado()`:** Retorna "Aprovado" (≥ 60), "Recuperação" (40-59) ou "Reprovado" (< 40).



### 5. Classe TestaAluno

Crie uma classe para cadastrar **N** alunos (informado pelo usuário) utilizando um vetor de objetos. Ao final, imprima o nome e o resultado final de cada aluno.

### 6. Classe Data

Projete uma classe **Data** para armazenar dia, mês e ano como inteiros (sem usar `DateTime`).

 
* **Requisitos:** Construtor, métodos Get/Set e conversão para string no formato "dd/mm/aaaa".

 
* **Validação:** Método booleano para validar se a data está entre 31/12/1899 e 01/01/2100, considerando anos bissextos.



* **Entregáveis:**  
    **a)** Diagrama de classe;



    **b)** Código fonte;


 
    **c)** Classe `TestaData` com método `Main`.





### 7. Verdadeiro ou Falso

Avalie as afirmações abaixo, corrigindo as falsas:


**a)** O construtor de uma classe `Triangulo` pode ser: `public void Triangulo()`.


 
**b)** O símbolo `-` no diagrama de classes indica membro protegido.



**c)** No trecho `int a=15, b=5; a-=b++1;`, os valores finais são `a=8` e `b=6`.


 
**d)** Se `x=50` e `y=60`, o comando `Console.WriteLine(" valor é " + ((x > y) ? x: (x == y) ? 0: y));` imprime "O valor é false".


 
**e)** Na matriz tridimensional `int[,,] mat`, o valor de `mat[1, 2, 2]` é 2.



**f)** Para um atributo `peso` (float), a assinatura correta do set é `public float setPeso()`.



---

Deseja que eu ajude com a resolução de algum desses exercícios específicos em C#?

