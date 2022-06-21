using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    public class Venda
    {
        List<Produto> produtos { get; set; }
        public double ValorTotalVenda { get
            {
                double total = 0;
                for (int i = 0; i < produtos.Count; i++)
                {
                    total  += produtos[i].preco;
                }
                return total;
            }         
        }
        public bool statusVenda { get; set; }
        public Cliente cliente { get; set; }
        public Vendedor vendedor { get; set; }
        public Venda() { }
        public Venda(bool status)
        {
            this.statusVenda = status;         
        }     

    }
}
