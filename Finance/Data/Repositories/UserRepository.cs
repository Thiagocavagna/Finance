using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Finance.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FinanceDbContext _context;

        public UserRepository()
        {
            _context = new FinanceDbContext();
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
        }

        public User GetUserByPassword(string password)
        {
            return _context.Users.FirstOrDefault(u => u.Password == password)!;
        }

        public bool IsUserRegistered()
            => _context.Users.Any();

        public bool Save()
        {
            var count = _context.SaveChanges();

            return count > 0;
        }
    }
    
    
}