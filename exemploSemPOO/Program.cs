﻿using System;
using System.Globalization;

namespace problemaExemploSemPOO {
    internal class Program {
        static void Main(string[] args) {

            double xA = 0, xB = 0, xC = 0;
            double yA = 0, yB = 0, yC = 0;
            double areaX = 0, areaY = 0, p;

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            yA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            p = (xA + xB + xC) / 2.0;

            areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;

            areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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


