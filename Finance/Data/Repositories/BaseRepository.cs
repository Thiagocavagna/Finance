namespace Finance.Data.Repositories
{
    public class BaseRepository
    {
        protected readonly FinanceDbContext _context;

        public BaseRepository()
        {
            _context = new FinanceDbContext();
        }
    }
}