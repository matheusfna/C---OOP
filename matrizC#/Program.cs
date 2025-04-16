using System;

namespace matrizCSharp {
    internal class Program {
        static void Main(string[] args) {

            // Declaração de matriz e sua instancia
            double[,] matriz = new double[2,3];

            // Pega o total de elementos dentro da matriz em todas as dimensoes
            Console.WriteLine(matriz.Length);

            // Para retornar a dimensao da matriz 
            Console.WriteLine(matriz.Rank);

            // Quantidade de linhas da matriz
            Console.WriteLine(matriz.GetLength(0));

            // Quantidade de colunas da matriz
            Console.WriteLine(matriz.GetLength(1));

        }
    }
}