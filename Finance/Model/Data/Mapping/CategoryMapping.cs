using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finance.Model.Data.Mapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("User");

            builder.Property(x => x.Id)
                .HasColumnName("UserId");

            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
          
            builder.Property(x => x.Description)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
