
using System;

namespace problemaExemploVetor01 {
    class Locatario {

        //ATRIBUTOS
        public string Nome {
            get; set;
        }
        public string Email {
            get; set;
        }

        //Constructor
        public Locatario(string nome,string email) {
            Nome = nome;
            Email = email;
        }

        //Override metodo ToString
        public override string ToString() {
            return Nome + ", " + Email;

        }

    }
}

