namespace GerenciadoDeVendas.Application.Models.ModelsPedidos
{
    internal class UpdateClienteViewModel
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPedido { get; set; }

        public int ClienteId { get; set; }// Id do cliente
    }
}
