using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Finance.Data.Repositories
{
    public class UserRepository
    {
        private readonly FinanceDbContext _context;

        public UserRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<FinanceDbContext>();
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