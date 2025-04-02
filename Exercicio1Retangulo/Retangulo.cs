using System;

namespace exercicio1Retangulo {
    internal class Retangulo {

        public double Altura;
        public double Largura;

        //Metodo para calcular a Area do Retangulo
        public double Area() {
        return Largura * Altura;
        }

        //Metodo para calcular a Perimetro do Retangulo
        public double Perimetro() {
        return 2.0 * (Largura + Altura);
        }

        //Metodo para calcular a Diagonal do Retangulo
        public double Diagonal() {
        return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }


    }   
}
