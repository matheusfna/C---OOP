

namespace ConversorMoedasClassStatic {
    internal class ConversorMoedas {

        public static double IoF = 6.0;

        public static double DolarParaReal(double quantidadeDolares,double cotacao) {
            double total = quantidadeDolares * cotacao;
            return total + total * IoF / 100.0;
        }
    }
}
