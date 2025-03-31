using System;
using System.Globalization;

namespace problemaProduto {
    internal class Program {
        static void Main(string[] args) {

        Produto produto = new Produto();

        Console.WriteLine("Entre os dados do produto: ");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + produto);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        produto.AdicionarProduto(qte);

        Console.WriteLine();
        Console.WriteLine("Dados Atualizados: " + produto);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a serem removidos do estoque: ");
        qte = int.Parse(Console.ReadLine());
        produto.RemoverProduto(qte);

        Console.WriteLine();
        Console.WriteLine("Dados Atualizados: " + produto);






        }
    }
}


