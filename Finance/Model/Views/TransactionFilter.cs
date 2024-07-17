namespace Finance.Model.Views
{
    public class TransactionFilter
    {
        public Guid? CategoryId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now.AddDays(-30);
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
    }
}
