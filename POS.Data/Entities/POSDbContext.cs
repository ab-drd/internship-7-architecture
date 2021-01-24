using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using POS.Data.Entities.Models;
using POS.Data.Seeds;

namespace POS.Data.Entities
{
    public class POSDbContext : DbContext
    {
        public POSDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferBill> OfferBills { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceBill> ServiceBills { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            DataBaseSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class POSContextFactory : IDesignTimeDbContextFactory<POSDbContext>
    {
        public POSDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();
            configuration
                .Providers
                .First()
                .TryGet("connectionStrings:add:RentACar:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<POSDbContext>().UseSqlServer(connectionString).Options;
            return new POSDbContext(options);
        }
    }
}
