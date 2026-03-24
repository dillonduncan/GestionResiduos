using Microsoft.EntityFrameworkCore;
using GestionResiduos.Models;

namespace GestionResiduos.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Residuo> Residuos { get; set; }

    }
}
