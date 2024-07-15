using Finance.Data.Repositories;
using Finance.Model.Enumerations;
using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;

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

    public List<Transaction> GetAll()
    {
        return _context.Transactions.Include(x => x.Category).ToList();
    }

    public bool HasAnyTrasactionWithCategory(Guid categoryId)
    {
        return _context.Transactions.Any(x => x.CategoryId == categoryId); 
    }

    public bool Exists(decimal amount, TransactionType type, Guid categoryId, DateTime registerDate)
    {
        return _context.Transactions.Any(x => x.Amount == amount && x.Type == type && x.CategoryId == categoryId &&
            x.RegisterDate == registerDate);
    }

    public Transaction GetById(Guid id)
    {
        return _context.Transactions.FirstOrDefault(x => x.Id == id);
    }

    public void Delete(Transaction transaction)
    {
        _context.Transactions.Remove(transaction);
    }

    public void Update(Transaction transaction)
    {
        throw new NotImplementedException();
    }
}
