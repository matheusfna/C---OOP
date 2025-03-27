using System;
using System.Globalization;

namespace Curse {
    internal class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 2147483647;
            //Colocar o L no final para identificar o uso de uma variavel do tipo Long
            long n3 = 2147483648L;
            float n4 = 4.5f;
            double n5 = 4.5;
            string nome = "Maria Silva";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            //Utilizando os MinValue e MaxValue

            int x1 = int.MinValue;
            int x2 = int.MaxValue;
            sbyte x3 = sbyte.MinValue;
            decimal x4 = decimal.MaxValue; 

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2); 
            Console.WriteLine(n3);
            Console.WriteLine(n4.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(n5.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);

        }
    }
}
