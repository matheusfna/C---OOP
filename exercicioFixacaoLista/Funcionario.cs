using System;
using System.Globalization;

namespace exercicioFixacaoLista {
    internal class Funcionario {

        public int Id {
            get; set;
        }
        public string Name {
            get; set;
        }
        public double Salario {
            get; set;
        }

        // Constructor da classe
        public Funcionario(int id,string name,double salario) {
            Id = id;
            Name = name;
            Salario = salario;
        }

        // Metodo do tipo VOID para o aumento de salario do funcionario
        public void aumentoSalario(double aumentoPorcentagem) {
            Salario += Salario * aumentoPorcentagem / 100.0;
        }

        // Metodo override ToString para imprimir a atualização de funcionarios
        public override string ToString() {
            return "ID: " + Id +
                ", "
                + Name +
                ", R$ "
                + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
