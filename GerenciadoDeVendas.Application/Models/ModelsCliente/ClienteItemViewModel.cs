﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadoDeVendas.Application.Models.ModelsCliente
{
    internal class ClienteItemViewModel
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}