﻿using System;
using System.Globalization;

namespace exercicio02POO {
    internal class Program {
        static void Main(string[] args) {


            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            double media;


            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário médio: " + media.ToString("F2",CultureInfo.InvariantCulture));




        }
    }
}



