using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    public class Carrinho
    {
        public List<Produto> produtos { get; set; } = new List<Produto>();

        public double ValorTotalCarrinho()
        {             
            double total = 0;
            for (int i = 0; i < produtos.Count; i++)
            {
                total += produtos[i].preco;
            }
            return total;           
        }

        public Carrinho() { }
    }
}
