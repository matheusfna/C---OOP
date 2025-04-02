
using System;
using System.Globalization;

namespace Exercicio2Funcionario {
    internal class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + funcionario);

            Console.Write("Digite a porcemtagem para aumentar o salário: ");
            double porcemtagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcemtagem);

            Console.Write("Dados atualizados: " + funcionario);

        }
    }
}


