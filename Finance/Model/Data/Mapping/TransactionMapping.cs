using Finance.Model.Enumerations;
using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finance.Model.Data.Mapping
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Trasaction");

            builder.Property(x => x.Id)
                .HasColumnName("TrasactionId");

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
        }
    }
}
