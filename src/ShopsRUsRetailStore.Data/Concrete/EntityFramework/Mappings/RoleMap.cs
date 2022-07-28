using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.ModifiedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(false);

        }
    }
}
