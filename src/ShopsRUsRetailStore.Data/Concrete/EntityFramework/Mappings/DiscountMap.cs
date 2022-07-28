using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUsRetailStore.Data.SeedData;
using ShopsRUsRetailStore.Entities.Concrete;

namespace ShopsRUsRetailStore.Data.Concrete.EntityFramework.Mappings
{
    public class DiscountMap : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IsPercentage);
            builder.HasIndex(x => x.Rate);
            builder.Property(x => x.CreatedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.ModifiedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.Rate).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.IsPercentage).HasDefaultValue(false);
            builder.ToTable("Discounts");


            // --------------   SEED DATA  --------- //
            builder.HasData(DiscountSeedData.GetData());
        }
    }
}
