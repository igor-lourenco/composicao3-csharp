using Composicao3.Entidades;
using Composicao3.Entidades.Enums;
using System;
using System.Globalization;

namespace Composicao3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do Cliente: ");
            Console.Write("Nome: ");
            string clienteNome = Console.ReadLine();
            Console.Write("Email:");
            string clienteEmail = Console.ReadLine();
            Console.Write("Data Aniversario (DD/MM/YYYY): ");
            DateTime clienteAniversario = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do pedido:");
            Console.Write("Status:");
            PedidoStatus status = Enum.Parse<PedidoStatus>(Console.ReadLine());

            Cliente c1 = new Cliente(clienteNome, clienteEmail, clienteAniversario);
            Pedido ped1 = new Pedido(DateTime.Now, status, c1);


            Console.Write("Quantos itens para esse pedido: ");
            int it = int.Parse(Console.ReadLine());

            for(int i = 1; i <= it; i++) {

                Console.WriteLine($"Entre com os dados do {i} pedido: ");
                Console.Write("Nome do produto: ");
                string prod = Console.ReadLine();
                Console.Write("Preco do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto p1 = new Produto(prod, precoProduto);

                Console.Write("Quantidade : ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                ItemPedido itemPedido = new ItemPedido(quantidadeProduto, precoProduto, p1);

                ped1.AddItem(itemPedido);
            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO: ");
            Console.WriteLine(ped1);
        }
    }
}
