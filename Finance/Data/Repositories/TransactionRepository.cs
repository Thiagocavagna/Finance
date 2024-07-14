using Finance.Data;
using Finance.Data.Repositories;
using Finance_Project.Model.Entities;

public class TransactionRepository : BaseRepository, ITransactionRepository
{
    public void Add(Transaction transaction)
    {
        _context.Transactions.Add(transaction);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public IEnumerable<Transaction> GetAll()
    {
        throw new System.NotImplementedException();
    }

    public void Delete(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public void Update(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Transaction> getAll()
    {
        throw new NotImplementedException();
    }
}
