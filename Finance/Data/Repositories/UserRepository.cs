using Finance_Project.Model.Entities;

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

        public User GetUser()
        {
            return _context.Users.SingleOrDefault()!;
        }

        public bool IsUserRegistered()
            => _context.Users.Any();

        public bool Save()
        {
            var count = _context.SaveChanges();

            return count > 0;
        }
        public void updatePassword(string senhaAtual, string novaSenha, string confirmSenha)
        {
            var user = _context.Users.FirstOrDefault();
            if (user == null) {
                MessageBox.Show("Usuario não encontrado!");
                return;
            }
            user.Password = novaSenha;
            _context.Update(user);
            _context.SaveChanges();
        }
    }
    
    
}