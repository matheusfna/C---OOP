using System;
using System.Globalization;

namespace Exercicio3NotaAluno {
    internal class Program {
        static void Main(string[] args) {

            //INSTANCIA DA CLASSE ALUNO
            Aluno aluno = new Aluno();

            //ENTRADA DE DADOS DE NOME
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            //ENTRADA DE DADOS DAS NOTAS
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //NOTA FINAL COM CALCULO COM O METODO NotaFinal
            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            //VERIFICACAO SE FOI APROVADO OU REPROVADO
            if(aluno.NotaFinal() > 60.00) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaQueFaltou().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS ");
            }
        }
    }
}



