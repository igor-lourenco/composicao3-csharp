using Composicao3.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Composicao3.Entidades {
    class Pedido {

        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }
        public Cliente Cliente { get; set; }

        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido(DateTime momento, PedidoStatus status, Cliente cliente) {
            Momento = momento;
            Status = status;
            this.Cliente = cliente;
        }

        public void AddItem(ItemPedido item) {
            Itens.Add(item);
        }

        public void RemoveItem(ItemPedido item) {
            Itens.Remove(item);
        }

        public double Total() {
            double soma = 0.0;

            foreach(ItemPedido item in Itens) {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido:");
            foreach (ItemPedido item in Itens) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preco total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
