using Finance.Model.Enumerations;
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

    }
}
