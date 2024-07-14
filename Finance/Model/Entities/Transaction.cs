using Finance.Model.Enumerations;

namespace Finance_Project.Model.Entities
{
    public class Transaction : Entity
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime RegisterDate { get; set; }
        public Guid CategoryId { get; set; } 
        public TransactionType Type { get; set; }
        public Category Category { get; set; }        
    }
}
