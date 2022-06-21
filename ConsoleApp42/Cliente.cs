using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    public class Cliente
    {
        private static int geradorId = 0;
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public Carrinho carrinho { get; set; }
        public Cliente() {
            this.id = System.Threading.Interlocked.Increment(ref geradorId);
        }
        public Cliente(string nome, string cpf, string endereço)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereço;
            this.id = System.Threading.Interlocked.Increment(ref geradorId);
        } 
    }

}
