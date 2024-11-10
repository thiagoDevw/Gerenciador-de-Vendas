using GerenciadorDeVendas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Infrastructure.Persistence
{
    internal class AppDbContext : DbContext
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
                        .WithOne(e => e.Clientes)
                        

                    e.Property(c => c.Nome)
                        .IsRequired()
                        .HasMaxLength(50);

                    e.Property(c => c.Email)
                        .IsRequired()
                        .HasMaxLength(100);
                });


            base.OnModelCreating(builder);
        }
    }
}
