using System;

namespace exercicioMatriz02 {
    internal class Program {
        static void Main(string[] args) {


            Console.WriteLine("Digite os 2 numeros, Linha e Coluna: ");
            string[] entrada = Console.ReadLine().Split(' ');

            int linha = int.Parse(entrada[0]);
            int coluna = int.Parse(entrada[1]);

            int[,] mat = new int[linha,coluna];

            //Preenche toda a matriz
            for(int i = 0; i < linha; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < coluna; j++) {
                    mat[i,j] = int.Parse(values[j]);

                }
            }

            int x = int.Parse(Console.ReadLine());

            //Percorre toda a matriz
            for(int i = 0; i < linha; i++) {
                for(int j = 0; j < coluna; j++) {
                    if(mat[i,j] == x) {
                        //Posição do numero x
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if(j > 0) {
                            //Esquerda
                            Console.WriteLine("Left: " + mat[i,j - 1]);
                        }
                        if(i > 0) {
                            //Cima
                            Console.WriteLine("Up: " + mat[i - 1,j]);
                        }
                        if(j < coluna - 1) {
                            //Direta
                            Console.WriteLine("Right: " + mat[i,j + 1]);
                        }
                        if(i < linha - 1) {
                            //Baixo
                            Console.WriteLine("Down: " + mat[i + 1,j]);
                        }
                    }
                }
            }


        }
    }
}
