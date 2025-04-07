

using System.Globalization;

namespace ExercicioContaBanco {
    internal class Conta {

        public int NumeroConta {
            get; private set;
        }

        public string NomeTitularConta {
            get; set;
        }

        public double Saldo {
            get; set;
        }

        private int _taxaBanco = 5;


        //Construtores
        public Conta(int numeroConta,string nomeTitularConta) {
            NumeroConta = numeroConta;
            NomeTitularConta = nomeTitularConta;


        }
        //Chamada do construtor com 2 argumento utilizando o " : this() "
        public Conta(int numeroConta,string nomeTitularConta,double saldo) : this(numeroConta,nomeTitularConta) {
            Saldo = saldo;

        }


        //METODOS
        public void RealizarDeposito(double depositoInicial) {
            Saldo = Saldo + depositoInicial;
        }

        public void RealizarSaque(double saque) {
            Saldo = Saldo - saque - _taxaBanco;
        }

        public override string ToString() {
            return "Conta " + NumeroConta + ", Titular: " + NomeTitularConta + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
