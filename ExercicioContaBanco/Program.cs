using System;
using System.Globalization;

namespace ExercicioContaBanco;
internal class Program {
    static void Main(string[] args) {



        Console.Write("Entre com o número da conta: ");
        int contaBanco = int.Parse(Console.ReadLine());

        Console.Write("Entre com o nome do titular da conta: ");
        string nomeTitular = Console.ReadLine();

        Console.Write("Havera deposito inicial (s/n)? ");
        char resposta = char.Parse(Console.ReadLine());
        if(resposta == 's') {
            Console.Write("Entre com o valor do deposito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resposta = (char) depositoInicial;
        } else {
            resposta = (char) 0.0;
            
        }
        Conta conta = new Conta(contaBanco,nomeTitular,resposta);
        Console.WriteLine();

        Console.WriteLine("Dados da Conta: ");
        Console.WriteLine(conta);

        Console.WriteLine();

        Console.Write("Entre com um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
        conta.RealizarDeposito(deposito);
        Console.WriteLine("Dados da Conta atualizados: ");
        Console.WriteLine(conta);

        Console.WriteLine();

        Console.Write("Entre com um valor para saque: ");
        double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        conta.RealizarSaque(saque);
        Console.WriteLine("Dados da Conta atualizados: ");
        Console.WriteLine(conta);



    }
}
