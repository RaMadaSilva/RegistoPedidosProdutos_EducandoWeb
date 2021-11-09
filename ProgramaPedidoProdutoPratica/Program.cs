using ProgramaPedidoProdutoPratica.Entities;
using ProgramaPedidoProdutoPratica.Entities.Enums;
using System;
using System.Globalization; 

namespace ProgramaPedidoProdutoPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra com os dados do Cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data Nascimento(DD/MM/AAAA): ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, email, dataNasc);

            Console.WriteLine("Entra com os dados do Pedido: ");
            Console.Write("Estado do Pedido(Pendente/Processando/Enviado/Entregue): ");
            EstadoPedido estado = Enum.Parse<EstadoPedido>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, estado, cliente);

            Console.Write("Quantos Itens Este pedido tem? ");
            int n = int.Parse(Console.ReadLine());

            

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Dados do Item #{i}");
                Console.Write("Nome do Produto: ");
                string nomeproduto = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeproduto, preco);

                ItemPedido item = new ItemPedido(quantidade, produto);
                pedido.AdicionarItens(item); 

            }
            Console.WriteLine();


            Console.WriteLine("SUMARIO DO PEDIDO: ");
            Console.WriteLine(pedido);

        }
    }
}
