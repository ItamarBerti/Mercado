using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    public class Menu
    {
        public static void menu()
        {
            List<Produto> produtos = new List<Produto>();
            List<Vendedor> vendedors = new List<Vendedor>();
            List<Cliente> clientes = new List<Cliente>();
            List<Venda> vendas = new List<Venda>();
            Carrinho carrinho = new Carrinho();
            Venda venda = new Venda();
            
            

            do
            {             
                int opcao = 0;

                Console.WriteLine("[1]- cadastrar Cliente");
                Console.WriteLine("[2]- cadastrar Vendedor"); 
                Console.WriteLine("[3]- cadastrar Produto");
                Console.WriteLine("[4]- inserir um produto no carrinho de compras");
                Console.WriteLine("[5]- criar uma Venda");
                Console.WriteLine("[6]- finalizar a Venda");
                Console.WriteLine("[7]- limpar o carrinho");
                Console.WriteLine("[8]- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao == 8)
                {
                    break;
                }

                switch (opcao)
                {

                    case 1:
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
                        Vendedor vendedor = new Vendedor();
                        Console.WriteLine("Digite o crachá do vendedor: ");
                        vendedor.codigoCracha = Console.ReadLine();
                        Console.WriteLine("Digite o nome do vendedor: ");
                        vendedor.nome = Console.ReadLine();
                        vendedors.Add(vendedor);
                        foreach(Vendedor vendedor1 in vendedors)
                        {
                            Console.WriteLine(vendedor1.id + " - " + vendedor1.nome);
                        }
                        break;
                    case 3:
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
                        Menu.MostrarClientesCadastrados(clientes);
                        Console.WriteLine("Digite qual cliente você é: ");                    
                        cliente = Menu.ProcurarClientePorId(clientes, Convert.ToInt32(Console.ReadLine()));
                        Menu.MostrarListaDeProdutos(produtos);                    
                        Console.WriteLine("Voce deseja passar todos os produtos para o carrinho? ");
                        string res = Console.ReadLine();
                        if (res == "sim")
                            carrinho.produtos = produtos;
                        else
                            Console.WriteLine("nenhum item adicionado.");
                        break;
                    case 5:
                        if (vendedors.Count == 0)
                            Console.WriteLine("você nao cadastrou vendedor ou cliente, volte e confira.");
                        else
                            Console.WriteLine(venda.ValorTotalVenda);
                        break;
                    case 6:
                        Console.WriteLine("Finalizando a venda: ");
                        Console.WriteLine("nome do cliente: " + clientes);
                        Console.WriteLine("nome do vendedor: " + vendedors);
                        Console.WriteLine("Valor total da venda: " + venda.ValorTotalVenda);
                        break;
                    case 7:
                        Console.WriteLine("Limpando seu carrinho...");
                        carrinho = new Carrinho();
                        break;
                }
            }
            while (true);
        }

        public static void MostrarListaDeProdutos(List<Produto> produtos)
        {
           foreach(Produto produto in produtos)
            {
                Console.WriteLine("ID: " + produto.id + " - Descrição do produto: " + produto.descricaoProduto + " - Preço: " + produto.preco);           
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
            for(int i = 0; i < clientes.Count; i++)
            {
                if(clientes[i].id == id) return clientes[i];
            }
            return null;
        }
    }
}
