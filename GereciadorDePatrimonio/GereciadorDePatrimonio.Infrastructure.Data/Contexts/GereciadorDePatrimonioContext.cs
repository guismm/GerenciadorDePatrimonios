using GereciadorDePatrimonio.Domain.Marcas.Models;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GereciadorDePatrimonio.Infrastructure.Data.Contexts
{
    public class GereciadorDePatrimonioContext : DbContext
    {
        public GereciadorDePatrimonioContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RTJTOOB;Initial Catalog=GerenciadorDePatrimonio;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }
}
