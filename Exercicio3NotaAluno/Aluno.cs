﻿using System;


namespace Exercicio3NotaAluno {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;        
        }

        public double NotaQueFaltou() {
            return 60 - (Nota1 + Nota2 + Nota3);
        }
    }
}
