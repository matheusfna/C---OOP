
using System;


namespace entradaESaidadeDeDados 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {

            //Leitura dos dados de entrada
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine(); 
            string palavra3 = Console.ReadLine(); 
            string palavra4 = Console.ReadLine();

            //Vetor de string para pegar cada palavra dentro do vetor depois do espaço 
            string[] s = Console.ReadLine().Split(' ');

            string palavra5 = s[0]; 
            string palavra6 = s[1]; 
            string palavra7 = s[2];

            //Saida dos dados de entrada mostrando na tela 
            Console.WriteLine(palavra1);
            Console.WriteLine(palavra2); 
            Console.WriteLine(palavra3); 
            Console.WriteLine(palavra4); 
            Console.WriteLine(palavra5); 
            Console.WriteLine(palavra6); 
            Console.WriteLine(palavra7); 



        }
    }
}
