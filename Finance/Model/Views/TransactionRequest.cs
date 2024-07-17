using Finance.Model.Enumerations;
using Finance_Project.Model.Entities;

namespace Finance.Model.Views
{
    public class TransactionRequest
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime RegisterDate { get; set; }
        public Guid CategoryId { get; set; }
        public TransactionType Type { get; set; }
    }
}
