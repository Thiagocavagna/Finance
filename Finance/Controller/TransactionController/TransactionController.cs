using Finance.Data.Repositories;
using Finance.Model.Enumerations;
using Finance.Model.Views;
using Finance_Project.Model.Entities;

namespace Finance.Controller.TransactionController
{
    public class TransactionController : ControllerBase
    {
        private readonly TransactionRepository _repository;
        private readonly CategoryRepository _categoryRepository;
        public TransactionController()
        {
            _repository = new();
            _categoryRepository = new();
        }

        public bool HasAnyTransactionWithCategory(Guid categoryId)
            => _repository.HasAnyTrasactionWithCategory(categoryId);
        
        public bool Exists(string description, decimal amount, TransactionType type, Guid categoryId, DateTime registerDate)
            => _repository.Exists(description, amount, type, categoryId, registerDate);

        public void SaveTransaction(string description, decimal amount, DateTime registerDate, TransactionType type, Category category)
        {
            var transaction = new Transaction
            {
                Description = description,
                Amount = amount,
                RegisterDate = registerDate,
                Type = type,
                CategoryId = category.Id
            };

            _repository.Add(transaction);
            _repository.Save();
        }

        public List<Transaction> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Transaction> GetByFilter(TransactionFilter filter)
        {
            return _repository.GetByFilter(filter);
        }
        public Result UpdateTransaction(Guid id, TransactionRequest request)
        {
            var transaction = _repository.GetById(id);
            var category = _categoryRepository.GetById(request.CategoryId);

            if(category == null)
                return Unsuccessful("Categoria não encontrada!");

            if(transaction == null)
                return Unsuccessful("Transação não encontrada!");

            transaction.Update(request.Description, request.Amount, request.RegisterDate, request.CategoryId, request.Type);

            _repository.Update(transaction);
            _repository.Save();

            return Successful("Transação atualizada com sucesso!");
        }

        public Transaction GetById(Guid id)
        {
            Transaction transaction;
            transaction = _repository.GetById(id);
            return transaction;
        }
        public void DeleteTransaction(Transaction transaction)
        {
            _repository.Delete(transaction);
            _repository.Save();
        }
    }
}
