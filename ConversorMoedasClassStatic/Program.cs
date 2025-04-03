using System;
using System.Globalization;

namespace ConversorMoedasClassStatic {
    internal class Program {
        static void Main(string[] args) {

            //ENTRADA DE DADOS
            Console.Write("Qual é a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //ENTRADA DE DADOS
            Console.Write("Quantos dólares você vai comprar: ");
            double quantidadeDolares = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //REALIZANDO OS CALCULOS
            double result = ConversorMoedas.DolarParaReal(quantidadeDolares,cotacao);

            //SAIDA DE DADOS
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}



