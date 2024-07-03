using Finance.Model.Data;
using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Finance.Controller.Services
{
    public class UserControllers
    {
        public class UserRepository
        {
            private readonly FinanceDbContext _context;

            public UserRepository()
            {
                var optionsBuilder = new DbContextOptionsBuilder<FinanceDbContext>();
                optionsBuilder.UseSqlServer("Server=ABNER\\SQLEXPRESS;Database=Finance;Trusted_Connection=True;TrustServerCertificate=True");
                _context = new FinanceDbContext(optionsBuilder.Options);
            }

            public void SaveUser(User user)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            public User GetUserByPassword(string password)
            {
                return _context.Users.FirstOrDefault(u => u.Password == password);
            }
        }

    }
}
