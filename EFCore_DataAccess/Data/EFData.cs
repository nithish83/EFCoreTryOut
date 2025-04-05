using EFCore_ModelAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_DataAccess.Data
{
    public class EFData : DbContext
    {
        public DbSet<Phone> Phone { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=EFCoreTryOutSolutions;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>()
                .Property(p => p.Price)
                .HasPrecision(10, 5); // Specify the precision and scale for the decimal type
            modelBuilder.Entity<Phone>().HasData(
                new Phone { Id = 1, CompanyFullName = "Samsung", PhoneModel = "Samsung S24", Price = 3500 },
                new Phone { Id=2, CompanyFullName="MI", Price=4500, PhoneModel="MIPhone2345"} );

            var arrlist = new Phone[]
            {
                new Phone { Id = 3, CompanyFullName = "Apple", PhoneModel = "iPhone 14", Price = 1000 },
                new Phone { Id = 4, CompanyFullName = "Nokia", PhoneModel = "Nokia 3310", Price = 500 }
            };
            modelBuilder.Entity<Phone>().HasData(arrlist);
        }


    }
}
