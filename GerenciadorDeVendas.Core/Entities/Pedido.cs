namespace GerenciadorDeVendas.Entities
{
    public class Pedido
    {
        public Pedido(int pedidoId, int clienteId, string produto, int quantidade, DateTime dataPedido)
        {
            PedidoId = pedidoId;
            ClienteId = clienteId;
            Produto = produto;
            Quantidade = quantidade;
            DataPedido = dataPedido;
        }

        public int PedidoId { get; set; }
        public string Produto { get; set; } 
        public int Quantidade { get; set; }
        public DateTime DataPedido {  get; set; }

        // Chave estrangeira e referencia ao Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
