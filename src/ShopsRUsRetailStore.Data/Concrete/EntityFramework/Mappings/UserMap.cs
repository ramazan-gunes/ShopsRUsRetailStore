using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUsRetailStore.Data.SeedData;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.Enums;


namespace ShopsRUsRetailStore.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.UserAgent).HasMaxLength(1000);
            builder.Property(x => x.IpAddress).HasMaxLength(100);
            builder.Property(x => x.Type).HasConversion<int>();
            builder.Property(x => x.CreatedDate).HasColumnType("timestamp without time zone");
            builder.HasMany(x => x.Orders).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            // --------------   SEED DATA  --------- //
            builder.HasData(UserSeedData.GetData());
        }
    }
}
