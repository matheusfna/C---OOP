using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicioFixacaoLista {
    class Program {
        static void Main(string[] args) {

            // Cria uma lista para armazenar objetos do tipo Funcionario
            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantos funcionarios você quer registrar? ");
            int registro = int.Parse(Console.ReadLine());

            // Coleta os dados de cada funcionário e adiciona na lista
            for(int i = 0; i < registro; i++) {

                Console.WriteLine($"Funcionario: #{i}");

                Console.Write("ID: ");
                int codigoId = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Cria o objeto Funcionario e adiciona à lista
                lista.Add(new Funcionario(codigoId,nome,salario));
            }



            Console.WriteLine();
            Console.Write("Entre com o ID do funcionario para o acrescimo do salario: ");
            int idBusca = int.Parse(Console.ReadLine());

            // Procura um funcionário na lista com o idBusca informado
            Funcionario resultado = lista.Find(x => x.Id == idBusca);

            // Se encontrar, aplica o aumento de salário
            if(resultado != null) {
                Console.Write("Entre com a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Metodo de calcular a porcentagem de aumento do salario
                resultado.aumentoSalario(porcentagem);
            } else {
                // Caso o ID não exista na lista
                Console.WriteLine("Esse ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionarios: ");
            // Exibe todos os funcionários da lista com os dados atualizados
            foreach(Funcionario func in lista) {
                Console.WriteLine(func);
            }

        }
    }
}
