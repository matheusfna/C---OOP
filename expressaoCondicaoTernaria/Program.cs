using System;
using System.Globalization;

namespace expressaoCondicaoTernaria {
    internal class Program {
        static void Main(string[] args) {

            /*
            (condicao) ? valor_se_verdadeiro : valor_se_falso 
                ( 2 > 4 ) ? 50 : 80 = 80 Porque 2 nao é maior que 4, dando falso e entao a resposta é valor_se_falso
                ( 10 != 3 ) ? "Maria" : "Alex" Resultado Maria, porque 10 é diferente de 3, resposta valor_se_verdadeiro
            */

            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? desconto = preco * 0.1 : desconto = preco * 0.05;

            /*
            if(preco < 20.0) {
                desconto = preco * 0.1;
            } else {
                desconto = preco * 0.05;
            }
            */

            Console.WriteLine(desconto);
        }
    }
}