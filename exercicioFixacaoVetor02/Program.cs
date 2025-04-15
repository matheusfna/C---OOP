using System;

namespace problemaExemploVetor01 {
    class Program {
        static void Main(string[] args) {

            Locatario[] locatario = new Locatario[10];

            Console.Write("Quantos quartos você quer alugar: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {

                Console.WriteLine($"Rent: #{i}:");
                Console.Write("Nome: ");
                string nomeLocatario = Console.ReadLine();
                Console.Write("Email: " );
                string emailLocatario = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                //Alocar na memoria depois dos dados passados de cada locatario
                locatario[numQuarto] = new Locatario(nomeLocatario,emailLocatario);
            }

            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++) {
                if(locatario[i] != null)
                    //Esta pegando o numero do quarto dentro do loop FOR e 
                    Console.WriteLine(i + ": " + locatario[i]);
            }
            
        }



    }
}

