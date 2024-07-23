using Finance_Project.Model.Entities;

namespace Finance.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {        
        public void Register(User user)
        {
            _context.Users.Add(user);
        }

        public void Update(User user)
            => _context.Users.Update(user);

        public User GetUser()
        {
            return _context.Users.SingleOrDefault()!;
        }

        public bool IsUserRegistered()
            => _context.Users.Any();       
      
    }
    
    
}