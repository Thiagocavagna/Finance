using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Finance.Model.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Server=thiagocavagna;Database=Finance;Trusted_Connection=True;TrustServerCertificate=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FinanceDbContext).Assembly);
        }

    }
}
