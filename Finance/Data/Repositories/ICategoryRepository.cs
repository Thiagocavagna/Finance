using Finance_Project.Model.Entities;

namespace Finance.Data.Repositories
{
    public interface ICategoryRepository : IRepositoryBase
    {
        IEnumerable<Category> GetAll();
        Category GetById(Guid id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        bool AlreadyExists(string name);
    }
}