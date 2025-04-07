

using System.Globalization;

namespace ExercicioContaBanco {
    internal class Conta {

        private int _numeroConta;
        private int _taxaBanco = 5;

        public string NomeTitularConta {
            get; private set;
        }

        public double Saldo {
            get; private set;
        }

        //Construtores
        public Conta() {
        }

        //Propriedades Customizadas

        public Conta(int numeroConta,string nomeTitularConta,double saldo) {
            _numeroConta = numeroConta;
            NomeTitularConta = nomeTitularConta;
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
            return "Conta " + _numeroConta + ", Titular: " + NomeTitularConta + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }



        /*
           - Atributos Privados
           - Propriedades Autoimplementadas
           - Construtores
           - Propriedades customizadas
           - Outros métodos da classe
         */
    }
}
