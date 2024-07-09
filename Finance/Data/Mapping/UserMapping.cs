using Finance_Project.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finance.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.Property(x => x.Id)
                .HasColumnName("UserId");

            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Password)
                .HasColumnType("varchar(256)")
                .IsRequired();
        }
    }
}
