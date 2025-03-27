using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            double saldo = 10.35784;
            int idade = 23;
            string nome = "Maria Silva";

            //Utilizada a tecnica de placeholder
            Console.WriteLine("{0} tem {1} anos e possui um saldo bancário de R${2:F3} reais", nome, idade, saldo);

            // Utilizada a tecnica de interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R${saldo:F3} reais");

            //Utilizada a tecnica de concatenação de strings
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$" + saldo.ToString("F3", CultureInfo.InvariantCulture) + " reais");

        }
    }
}
