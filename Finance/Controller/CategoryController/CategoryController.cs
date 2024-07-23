using Finance.Controller;
using Finance.Data.Repositories;
using Finance_Project.Model.Entities;
 
public class CategoryController : ControllerBase
{
    private readonly CategoryRepository _repository;

    public CategoryController()
    {
        _repository = new();
    }

    public bool AlreadyExists(string name) => _repository.AlreadyExists(name);
    
    public IEnumerable<Category> GetAllCategories()
    {
        return _repository.GetAll();
    }

    public void AddCategory(string name, string description)
    {        
        var category = new Category { Name = name, Description = description };
        _repository.Add(category);
        _repository.Save();
    }

    public void RemoveCategory(Category category) {
        _repository.Delete(category);
        _repository.Save();
    }
}
