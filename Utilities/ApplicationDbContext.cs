using Microsoft.EntityFrameworkCore;
using SistemaCodigoProgramacionBack.Models;

namespace SistemaCodigoProgramacionBack.Utilities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Codigo> codigos { get; set; }

    }
}
