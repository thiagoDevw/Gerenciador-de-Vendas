using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadoDeVendas.Application.Models.ModelsPedidos
{
    internal class PedidoViewModel
    {
        public int PedidoId { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPedido { get; set; }

        // Propriedades do Cliente
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteEmail { get; set; }


    }
}
