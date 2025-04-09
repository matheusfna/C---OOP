using System;

namespace problemaExemploVetor01 {
    class Produto {
        
        //ATRIBUTOS
        private string Nome {
            get; set;
        }
        private double Preco {
            get; set;
        }

        //METODO GET
        public string getNome() {
            return Nome;
        }

        public double getPreco() {
            return Preco;
        }

        //CONSTRUCTOR
        public Produto() {
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
}