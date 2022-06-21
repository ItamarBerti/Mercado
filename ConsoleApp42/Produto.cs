using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    public class Produto
    {
        public static int geradorId = 0;
        public int id { get; set; }
        public string descricaoProduto { get; set; } 
        public string marca { get; set; } 
        public double preco { get; set; } 
        
        public Produto() {
            this.id = System.Threading.Interlocked.Increment(ref geradorId);
        }
        public Produto(string descricao, string marca, double preco)
        {
            this.descricaoProduto = descricao;
            this.marca = marca;
            this.preco = preco;
            this.id = System.Threading.Interlocked.Increment(ref geradorId);
        }

    }
}
