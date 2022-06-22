using System;
using System.Collections.Generic;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Guia de uso do programa. ");
            Console.WriteLine("1- cadastrar o cliente. ");
            Console.WriteLine("2- cadastrar o vendedor. ");
            Console.WriteLine("3- cadastrar os produtos. ");
            Console.WriteLine("4- inserir os produtos no carrinho do cliente. ");
            Console.WriteLine("5- finalizar a venda do cliente. ");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Menu.menu();                          
        }
    }
}
