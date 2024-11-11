using GerenciadorDeVendas.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeVendas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ControllerCliente : ControllerBase
    {
        private readonly AppDbContext _context;
        public ControllerCliente(AppDbContext context)
        {
            _context = context;
        }


    }
}
