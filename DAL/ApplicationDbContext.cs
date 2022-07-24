using Microsoft.EntityFrameworkCore;
using pronia.Models;
using System.Linq;

namespace P127_Pronia.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<Silder> Silders { get; set; }
        public DbSet<Plant> Plants { get; set; }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<PlantCategory> PlantCategories { get; set; }

        public DbSet<PlantImage> PlantImages { get; set; }

        public DbSet<PlantInformation> PlantInformations { get; set; }
        public DbSet<Setting> Settings { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in modelBuilder.Model.GetEntityTypes()
                  .SelectMany(e => e.GetProperties()
                  .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
                  )
            {
                item.SetColumnType("decimal(6,2)");
            }

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Setting>()
               .HasIndex(p => p.Key)
               .IsUnique();
        }
    }
}
