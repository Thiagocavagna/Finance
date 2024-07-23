using Finance_Project.Model.Entities;

namespace Finance.Data.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {       
        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(Guid id)
        {
            return _context.Categories.Find(id);
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
        }
        
        public bool AlreadyExists(string name)
        {
            return _context.Categories.Any(x => x.Name == name);
        }

    }
}