using Finance.Data.Repositories;
using Finance_Project.Model.Entities;
 
public class CategoryController
{
    private readonly CategoryRepository _repository;

    public CategoryController()
    {
        _repository = new();
    }

    public IEnumerable<Category> GetAllCategories()
    {
        return _repository.GetAll();
    }

    public void AddCategory(string name, string description)
    {
        //TODO: validações?
        var category = new Category { Name = name, Description = description };
        _repository.Add(category);
        _repository.Save();
    }

    public void RemoveCategory(Category category) {
        _repository.Delete(category);
        _repository.Save();
    }
}
