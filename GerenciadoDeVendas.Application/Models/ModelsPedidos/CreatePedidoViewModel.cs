using System.ComponentModel.DataAnnotations;

namespace GerenciadoDeVendas.Application.Models.ModelsPedidos
{
    internal class CreatePedidoViewModel
    {
        [Required(ErrorMessage = "O produto é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O nome do produto não pode exceder 100 caracteres.")]
        public string Produto { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que 0.")]
        public int Quantidade { get; set; }


        [Required(ErrorMessage = "A data do pedido é obrigatória.")]
        public DateTime DataPedido { get; set; }

        // Propriedade de chave estrangeira para associar o pedido a um cliente
        [Required(ErrorMessage = "O cliente é obrigatório.")]
        public int ClienteId { get; set; }  
    }
}
