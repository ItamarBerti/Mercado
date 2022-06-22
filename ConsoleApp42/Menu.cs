using System;
using System.Collections.Generic;
namespace ConsoleApp42
{
    public class Menu
    {
        public static void menu()
        {
            List<Produto> produtos = new List<Produto>();
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Cliente> clientes = new List<Cliente>();
            List<Venda> vendas = new List<Venda>();
            Venda venda = new Venda();
            do
            {
                int opcao = 0;

                Console.WriteLine("[1]- cadastrar Cliente");
                Console.WriteLine("[2]- cadastrar Vendedor");
                Console.WriteLine("[3]- cadastrar Produto");
                Console.WriteLine("[4]- inserir um produto no carrinho de compra");
                Console.WriteLine("[5]- finalizar a Venda");
                Console.WriteLine("[6]- limpar o carrinho");
                Console.WriteLine("[7]- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 7)
                {
                    Console.WriteLine("Obrigado por usar o nosso sistema! ");
                    break;
                }
                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Cadastrando o cliente... ");
                        Cliente cliente = new Cliente();
                        Console.WriteLine("Digite o nome: ");
                        cliente.nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF: ");
                        cliente.cpf = Console.ReadLine();
                        Console.WriteLine("Digite o Endereço: ");
                        cliente.endereco = Console.ReadLine();
                        clientes.Add(cliente);
                        break;
                    case 2:
                        Console.WriteLine("Cadastrando o vendedor... ");
                        Vendedor vendedor = new Vendedor();
                        Console.WriteLine("Digite o crachá do vendedor: ");
                        vendedor.codigoCracha = Console.ReadLine();
                        Console.WriteLine("Digite o nome do vendedor: ");
                        vendedor.nome = Console.ReadLine();
                        vendedores.Add(vendedor);
                        break;
                    case 3:
                        Console.WriteLine("Cadastrando o produto... ");
                        Produto produto = new Produto();
                        Console.WriteLine("Digite a descrição do produto: ");
                        produto.descricaoProduto = Console.ReadLine();
                        Console.WriteLine("Digite a marca do produto: ");
                        produto.marca = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto: ");
                        produto.preco = Convert.ToDouble(Console.ReadLine());
                        produtos.Add(produto);
                        break;
                    case 4:
                        Console.WriteLine("Insira seu produto ao seu carrinho... ");
                        Menu.MostrarClientesCadastrados(clientes);
                        Console.WriteLine("Digite qual cliente você é: ");
                        cliente = Menu.ProcurarClientePorId(clientes, Convert.ToInt32(Console.ReadLine()));
                        Menu.MostrarListaDeProdutos(produtos);
                        Console.WriteLine("Qual produtos você deseja inserir no carrinho? ");
                        produto = Menu.ProcurarProdutoPorId(produtos, Convert.ToInt32(Console.ReadLine()));
                        cliente.carrinho.produtos.Add(produto);
                        break;
                    case 5:
                        Console.WriteLine("Finalizando a sua venda... ");
                        Menu.MostrarListaDeVendedores(vendedores);
                        Console.WriteLine("Digite qual vendedor está criando a venda: ");
                        vendedor = Menu.ProcurarVendedorPorId(vendedores, Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine();
                        Menu.MostrarClientesCadastrados(clientes);
                        Console.WriteLine("Digite qual cliente você quer inicar a venda: ");
                        cliente = Menu.ProcurarClientePorId(clientes, Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("O valor total da sua compra é: " + cliente.carrinho.ValorTotalCarrinho());
                        break;
                    case 6:
                        Console.WriteLine("Limpando o seu carrinho... ");
                        Menu.MostrarClientesCadastrados(clientes);
                        Console.WriteLine("Qual cliente você deseja limpar o carrinho? ");
                        cliente = Menu.ProcurarClientePorId(clientes, Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Limpando seu carrinho...");
                        cliente.carrinho = new Carrinho();
                        break;
                }
            }
            while (true);
        }
        public static void MostrarListaDeProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine("ID: " + produto.id + " - Descrição do produto: " + produto.descricaoProduto + " - Preço: " + produto.preco);
            }
        }
        public static void MostrarListaDeVendedores(List<Vendedor> vendedores)
        {
            foreach (Vendedor vendedor in vendedores)
            {
                Console.WriteLine("ID: " + vendedor.id + " - Nome do vendedor: " + vendedor.nome);
            }
        }
        public static void MostrarClientesCadastrados(List<Cliente> clientes)
        {
            foreach (Cliente cliente1 in clientes)
            {
                Console.WriteLine(cliente1.id + " - " + cliente1.nome);
            }
        }
        public static Cliente ProcurarClientePorId(List<Cliente> clientes, int id)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].id == id) return clientes[i];
            }
            return null;
        }
        public static Produto ProcurarProdutoPorId(List<Produto> produtos, int id)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].id == id) return produtos[i];
            }
            return null;
        }
        public static Vendedor ProcurarVendedorPorId(List<Vendedor> vendedores, int id)
        {
            for (int i = 0; i < vendedores.Count; i++)
            {
                if (vendedores[i].id == id) return vendedores[i];
            }
            return null;
        }
    }
}
