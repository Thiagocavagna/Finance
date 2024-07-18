namespace Finance.Model.Views
{
    public class TransactionFilter
    {
        public Guid? CategoryId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now.Date;
        public DateTime EndDate { get; set; } = DateTime.Now.Date.AddDays(1).AddTicks(-1);
    }

    public class Teste
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
