using System;
using System.Globalization;


namespace Exercicio2Funcionario {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {

            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcemtagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcemtagem / 100.0);
        }

        public override string ToString() {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
