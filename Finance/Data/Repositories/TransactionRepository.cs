using Finance.Data;
using Finance.Data.Repositories;
using Finance_Project.Model.Entities;
using System.Collections.Generic;
using System.Linq;

public class TransactionRepository : ITransactionRepository
{
    private readonly FinanceDbContext _context;

    public TransactionRepository(FinanceDbContext context)
    {
        _context = context;
    }

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
