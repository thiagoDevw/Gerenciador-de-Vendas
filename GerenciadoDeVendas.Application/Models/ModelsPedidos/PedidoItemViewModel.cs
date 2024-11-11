using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadoDeVendas.Application.Models.ModelsPedidos
{
    internal class PedidoItemViewModel
    {
        public int PedidoId { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPedido { get; set; }
        public string ClienteNome { get; set; }
    }
}
