using ControleDeEquipamentos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEquipamentos.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Identifier> Identifiers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<TypeOfEquipment> TypeOfEquipments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
