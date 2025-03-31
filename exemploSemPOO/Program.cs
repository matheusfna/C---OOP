using System;
using System.Globalization;
using exemploSemPOO;

namespace problemaExemploSemPOO {
    internal class Program {
        static void Main(string[] args) {

            Triangulo x, y; //Classe Triangulo
            double areaX = 0, areaY = 0;

            x = new Triangulo(); //Instaciação da classe Triangulo
            y = new Triangulo(); //Instaciação da classe Triangulo

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            //Utilização do x. para atribuir a entrada de dados da classe Triangulo
             x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            //Utilização do x. para atribuir a entrada de dados da classe Triangulo
             y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            areaX = x.CalcularArea();
            areaY = y.CalcularArea();

            Console.WriteLine("Área de X: " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4",CultureInfo.InvariantCulture));

            if(areaX > areaY) {
                Console.WriteLine("Maior área é: X");
            } else {
                Console.WriteLine("Maior área é: Y");
            }
        }
    }
}


