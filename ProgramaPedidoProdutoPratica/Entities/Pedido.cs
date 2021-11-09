using System;
using System.Collections.Generic;
using System.Text;
using ProgramaPedidoProdutoPratica.Entities.Enums;
using System.Globalization; 

namespace ProgramaPedidoProdutoPratica.Entities
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public EstadoPedido Estado { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
                
        }

        public Pedido(DateTime momento, EstadoPedido estado, Cliente cliente)
        {
            Momento = momento;
            Estado = estado;
            Cliente = cliente;
        }

        public void AdicionarItens(ItemPedido item)
        {
            ItemPedidos.Add(item); 
        }

        public void RemoverItens(ItemPedido item)
        {
            ItemPedidos.Remove(item); 
        }
        public double Total()
        {
            double valorTotal = 0; 
            foreach(var item in ItemPedidos)
            {
                valorTotal += item.SubTotal(); 
            }
            return valorTotal; 
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(); 
            builder.AppendLine("Momento do Pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.AppendLine("Estado do Pedido: " + Estado);
            builder.AppendLine("Cliente: " + Cliente);
            builder.AppendLine("Itens do Pedido:"); 
                foreach (var item in ItemPedidos) {
                builder.AppendLine(item.ToString()); 
                    }
            builder.AppendLine(" Preço Total: " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return builder.ToString(); 
        }
    }
}
