using System;


namespace exercicioMatrizResolvido {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de linha e colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            // LINHA
            for(int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');

                //COLUNAS
                for(int j = 0; j < n; j++) {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " "); // Pegar a diagonal da matriz
            }
            Console.WriteLine();

            // Verifica quais os numeros dentro da matriz sao negativos, e armazena em um contador
            int count = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(mat[i,j] < 0 ) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numeros Negativos: " + count);


        }
    }
}
