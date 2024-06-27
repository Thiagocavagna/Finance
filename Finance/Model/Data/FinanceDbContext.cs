using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Finance.Model.Data
{
    public class FinanceDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
