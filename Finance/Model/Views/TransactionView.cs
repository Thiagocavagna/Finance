using Finance.Model.Enumerations;
using Finance_Project.Model.Entities;

namespace Finance.Model.Views
{
    public class TransactionView
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public string CategoryName { get; set; } //TODO: Verificar se é necessário
        public Category Category { get; set; }
        public DateTime RegisterDate { get; set; }

        public static implicit operator TransactionView(Transaction transaction)
        {
            return new TransactionView
            {
                Id = transaction.Id,
                Description = transaction.Description,
                Amount = transaction.Amount,
                Type = transaction.Type,
                RegisterDate = transaction.RegisterDate,
                CategoryName = transaction.Category.Name,
                Category = transaction.Category
            };
        }
    }
}
