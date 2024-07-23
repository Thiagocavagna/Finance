namespace Finance.Data.Repositories
{
    public class BaseRepository : IRepositoryBase
    {
        protected readonly FinanceDbContext _context;

        public BaseRepository()
        {
            _context = new FinanceDbContext();
        }

        public bool Save()
        {
            var count = _context.SaveChanges();

            return count > 0;
        }
    }
}