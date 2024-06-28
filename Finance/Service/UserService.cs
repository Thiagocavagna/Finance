using Finance_Project.Model.Entities;
using Finance.Model.Data;


namespace Finance.Service
{
    public class UserService
    {
        private readonly _dbContext context;

        public UserService(_dbContext dbContext)
        {
            context = dbContext;
        }

        public bool CadastrarUsuario(User newUser)
        {

            try
            {
                // Código para salvar o usuário no banco de dados
                context.Users.Add(newUser);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
