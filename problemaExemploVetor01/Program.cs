using System;
using System.Globalization;

namespace problemaExemploVetor01 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produto[] prod = new Produto[n];

            for(int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Produto(nome,preco);
            }

            double soma = 0;

            for(int i = 0; i < n; i++) {
                soma += prod[i].getPreco();
            }

            double media = soma / n;

            Console.WriteLine("PRECO MEDIA IGUAL = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}