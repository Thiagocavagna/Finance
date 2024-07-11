using Finance_Project.Model.Entities;

namespace Finance.Data.Repositories
{
    public interface IUserRepository : IRepositoryBase
    {
        void Register(User user);
    }
}