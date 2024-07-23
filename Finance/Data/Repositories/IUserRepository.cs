using Finance_Project.Model.Entities;

namespace Finance.Data.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        void Update(User user);
        User GetUser();
        bool IsUserRegistered();
    }
}