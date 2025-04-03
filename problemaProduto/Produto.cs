using System.Globalization;

namespace problemaProduto {
    internal class Produto {

        //Nomes padrões do C# sendo eles Private: _nomeAtributo
        private string _nome;
        //Propriedades de implementação da AutoProperties
        public double Preco {
            get; private set;
        }
        public int Quantidade {
            get;
            private set;
        }

        //Construtores
        public Produto() {
        }

        public Produto(string nome,double preco,int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedades Customizadas
        public string Nome {
            get {
                return _nome;
            }
            set {
                if(value != null && value.Length > 1) {
                    _nome = value;
                }

            }
        }

        //Metodos da Classe
        public double ValorTotalEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + " , "
                + Quantidade + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }




    }
}
