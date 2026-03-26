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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Residuo>().HasData(
                new Residuo
                {
                    IdResiduo = 1,
                    NameResiduo = "Cascara de Guineo",
                    TipoResiduo = "Organico",
                    PesoResiduo = 0.5,
                    FechaRecoleccionResiduo = new DateTime(2026, 3, 25)
                },
                new Residuo
                {
                    IdResiduo = 2,
                    NameResiduo = "Botella de Vidrio rota",
                    TipoResiduo = "Vidrio",
                    PesoResiduo = 1,
                    FechaRecoleccionResiduo = new DateTime(2026, 3, 25)
                },
                new Residuo
                {
                    IdResiduo = 3,
                    NameResiduo = "Botellas de Agua",
                    TipoResiduo = "Plastico",
                    PesoResiduo = 1.5,
                    FechaRecoleccionResiduo = new DateTime(2026, 3, 25)
                },
                new Residuo
                {
                    IdResiduo = 4,
                    NameResiduo = "Restos de comida",
                    TipoResiduo = "Organico",
                    PesoResiduo = 2,
                    FechaRecoleccionResiduo = new DateTime(2026, 3, 25)
                }
                );
        }

    }
}
