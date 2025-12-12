using Microsoft.EntityFrameworkCore;
using Transportei.Web.Models;

namespace Transportei.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        // Depois você adiciona: Motoristas, Clientes, Cargas…
    }
}