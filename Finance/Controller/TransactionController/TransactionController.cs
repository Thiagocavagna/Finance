using Finance.Data.Repositories;
using Finance.Model.Enumerations;
using Finance_Project.Model.Entities;
using Microsoft.Extensions.Options;

namespace Finance.Controller.TransactionController
{
    public class TransactionController
    {
        private readonly ITransactionRepository _repository;

        public TransactionController(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public void SaveTransaction(string description, decimal amount, DateTime registerDate, TransactionType type, Category category)
        {
            var transaction = new Transaction
            {
                Description = description,
                Amount = amount,
                RegisterDate = registerDate,
                Type = type,
                Category = category
            };
            _repository.Add(transaction);
            _repository.Save();
        }

    }
}
