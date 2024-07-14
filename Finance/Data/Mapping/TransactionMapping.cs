using Finance.Model.Enumerations;
using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finance.Data.Mapping
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.Property(x => x.Id)
                .HasColumnName("TransactionId");

            builder.Property(x => x.Description)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Amount)
                .IsRequired();

            builder.Property(x => x.Type)
                .HasConversion(
                x => x.ToString(),
                x => Enum.Parse<TransactionType>(x))
                .IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(x => new { x.Amount, x.Type, x.CategoryId, x.RegisterDate })
                .IsUnique();
        }
    }
}
