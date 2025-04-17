using System;

namespace funcoesString {
    internal class Program {
        static void Main(string[] args) {

            string original = "abcde ABC DEFG abc defg    ";


            string s1 = original.ToUpper();//Todos maiusculos
            string s2 = original.ToLower();//Todos minusculos
            string s3 = original.Trim();//Remove todos os espaços em branco

            int n1 = original.IndexOf("bc");//Busca a primeira condicao
            int n2 = original.LastIndexOf("bc");//Busca a ultima condicao

            string n4 = original.Substring(3);//Remove os caracteres ate o especificado
            string n5 = original.Substring(3,5);//Inicia no 3 string e remove 5 caracteres

            string s6 = original.Replace('a', 'x');//Troca todos os 'a' por 'x'
            string s7 = original.Replace("abc", "xy");//Troca todos os 'abc' por 'xy
                                                      
            bool b1 = string.IsNullOrEmpty(original);//Testa se é nulo ou vazio
            bool b2 = string.IsNullOrWhiteSpace(original);//Testa se é nulo ou é espaço em branco


            Console.WriteLine("Original:  -" + original + "-");
            Console.WriteLine("ToUpper:  -" + s1 + "-");
            Console.WriteLine("ToLower:  -" + s2 + "-");
            Console.WriteLine("Trim:  -" + s3 + "-");
            Console.WriteLine("IndexOf(bc):  -" + n1 + "-");
            Console.WriteLine("LastIndexOf(bc):  -" + n2 + "-");
            Console.WriteLine("Substring(3):  -" + n4 + "-");
            Console.WriteLine("Substring(3,5):  -" + n5 + "-");
            Console.WriteLine("Replace('a', 'x'):  -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'):  -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);



        }
    }
}
