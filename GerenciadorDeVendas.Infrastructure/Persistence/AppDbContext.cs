using GerenciadorDeVendas.Entities;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeVendas.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Cliente>(e =>
                {
                    e.HasKey(c => c.ClientId);

                    e.HasMany(e => e.Pedidos)
                        .WithOne(p => p.Cliente)
                        .HasForeignKey(p => p.ClienteId)
                        .OnDelete(DeleteBehavior.Restrict);
                        

                    e.Property(c => c.Nome)
                        .IsRequired()
                        .HasMaxLength(50);

                    e.Property(c => c.Email)
                        .IsRequired()
                        .HasMaxLength(100);
                });

            builder
                .Entity<Pedido>(e =>
                {
                    e.HasKey(p => p.PedidoId);

                    e.Property(p => p.Produto)
                        .IsRequired()
                        .HasMaxLength(100);

                    e.Property(p => p.Quantidade)
                        .IsRequired();

                    e.Property(p => p.DataPedido)
                        .IsRequired();
                });


            base.OnModelCreating(builder);
        }
    }
}
