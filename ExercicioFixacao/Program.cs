using System;
using System.Globalization;

namespace MyApp
{
    internal class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de Escrit�rio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            // Utilizada a tecnica de interpola��o
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo pre�o � $ {preco1}");
            Console.WriteLine($"{produto2}, cujo o pre�o � $ {preco2}");
            Console.WriteLine($"Registro {idade} anos de idade, c�digo {codigo} e g�nero {genero}: ");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8} ");
            Console.WriteLine($"Arredondando (tr�s casas decimais): {medida:F3} ");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)} ");

               




        }
    }
}
