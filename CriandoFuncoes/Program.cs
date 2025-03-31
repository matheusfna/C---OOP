
using System;

namespace criandoFuncoes {
    internal class Program {
        static void Main(string[] args) {

            int n1, n2, n3;


            Console.WriteLine("Digite os três números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());


            double resultado = Maior(n1,n2,n3);

            Console.WriteLine("Maior = " + resultado);


            //Funcao para verificar qual numero é maior dentre os digitados
            static int Maior(int a,int b,int c) {
                int m;
                if(a > b && a > c) {
                    m = a;
                } else if(b > c) {
                    m = b;
                } else {
                    m = c;
                }
                return m;



            }
        }
    }
}

