using Finance.Model.Enumerations;
using Finance.Model.Views;
using Finance_Project.Model.Entities;

namespace Finance.Controller.TransactionController
{
    public class TransactionController
    {
        private readonly TransactionRepository _repository;

        public TransactionController()
        {
            _repository = new();
        }

        public bool HasAnyTransactionWithCategory(Guid categoryId)
            => _repository.HasAnyTrasactionWithCategory(categoryId);
        
        public bool Exists(decimal amount, TransactionType type, Guid categoryId, DateTime registerDate)
            => _repository.Exists(amount, type, categoryId, registerDate);

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

        public List<TransactionView> GetAll()
        {
            List<TransactionView> transactionViews = new();

            _repository.GetAll()?.ForEach(x => transactionViews.Add(x));

            return transactionViews;
        }        
    }
}
