using System;
using System.Formats.Asn1;
using System.Globalization;
using exercicio1Retangulo;

namespace exercicio1Retangulo {
    internal class Program {
        static void Main(string[] args) {

        //INSTANCIA DA CLASSE RETANGULO
        Retangulo retangulo = new Retangulo();
        
        //ENTRADA E LEITURA DE DADOS
        Console.WriteLine("Entre com a largura e altura do Retangulo: ");
        //PARA FAZER A LEITURA DOS DADOS TEM QUE PUXAR A VARIAVEL DA CLASSE DEPOIS DE CRIAR A INSTANCIA DA CLASSE
        retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine();

        //RESULTADO DO CALCULO DA AREA COM O METODO Area()
        Console.WriteLine("AREA = " + retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));

        //RESULTADO DO CALCULO DO PERIMETRO COM O METODO Perimetro()
        Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture));

        //RESULTADO DO CALCULO DA DIAGONAL COM O METODO Diagonal()
        Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}


