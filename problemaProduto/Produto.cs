﻿using System.Globalization;

namespace problemaProduto {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

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
        return Nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + " , "
            + Quantidade + " unidades, Total: $ " 
            + ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }




    }
}
