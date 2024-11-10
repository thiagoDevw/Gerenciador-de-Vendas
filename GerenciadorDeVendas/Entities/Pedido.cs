namespace GerenciadorDeVendas.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public string Produto { get; set; } 
        public int Quantidade { get; set; }
        public DateTime DataPedido {  get; set; }
    }
}
