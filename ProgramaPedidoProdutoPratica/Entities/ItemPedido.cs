using System;
using System.Globalization; 

namespace ProgramaPedidoProdutoPratica.Entities
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double  Preco { get; set; }

        public Produto Produto { get; set; }

        public ItemPedido()
        {

        }

        public ItemPedido(int quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
            Preco = produto.Preco;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;

        }

        public override string ToString()
        {
            
            return Produto.Nome 
                + ", Quantidade: " + Quantidade 
                + ", SubTotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture); 
           
        }
    }
}
