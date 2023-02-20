using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _20230131_MVCIdentity.Areas.Identity.Data
{
    internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(50).IsRequired();
        }
    }
}