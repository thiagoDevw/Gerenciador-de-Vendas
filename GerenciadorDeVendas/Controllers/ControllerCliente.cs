using GerenciadorDeVendas.Entities;
using GerenciadorDeVendas.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // GET: api/clientes
        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return Ok(clientes);
        }

        // GET: api/clientes/
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // POST: api/clientes
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { id = cliente.ClientId }, cliente);
        }

        // PUT: api/cliente
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.ClientId)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;


            return NoContent();
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.ClientId == id);
        }
    }
}
