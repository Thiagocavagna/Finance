using Finance.Model.Enumerations;
using Finance.Model.Views;
using Finance_Project.Model.Entities;

namespace Finance.Data.Repositories
{
    public interface ITransactionRepository
    {
        public void Add(Transaction transaction);
        public void Delete(Transaction transaction);
        public void Update(Transaction transaction);
        Transaction GetById(Guid id);
        public List<Transaction> GetAll();
        List<Transaction> GetByFilter(TransactionFilter transactionFilter);
        bool HasAnyTrasactionWithCategory(Guid categoryId);
        bool Exists(string description, decimal amount, TransactionType type, Guid categoryId, DateTime registerDate);
    }
}
