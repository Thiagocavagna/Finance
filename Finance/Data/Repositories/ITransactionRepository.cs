using Finance.Model.Views;
using Finance_Project.Model.Entities;

namespace Finance.Data.Repositories
{
    public interface ITransactionRepository
    {
        public void Add(Transaction transaction);
        public void Delete(Transaction transaction);
        public void Update(Transaction transaction);
        public List<Transaction> GetAll();
        List<Transaction> GetByFilter(TransactionFilter transactionFilter);
        public void Save();
    }
}
