using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    public class Vendedor
    {
        public static int geradorId = 0;
        public int id { get; set; }
        public string nome { get; set; }
        public string codigoCracha { get; set; }
        public Vendedor()
        {
            this.id = System.Threading.Interlocked.Increment(ref geradorId);
        }

        public Vendedor( string nome, string codigocracha)
        {
            this.nome = nome;
            this.codigoCracha = codigocracha;
            this.id = System.Threading.Interlocked.Increment(ref geradorId);
        }
    }
}
