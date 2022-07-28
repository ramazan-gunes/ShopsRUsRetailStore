using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUsRetailStore.Data.SeedData;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Data.Concrete.EntityFramework.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.ModifiedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.Number).HasMaxLength(250).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired().HasPrecision(18, 2);
            builder.HasMany(x => x.Invoices).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);
            builder.ToTable("Orders");

            // --------------   SEED DATA  --------- //
            builder.HasData(OrderSeedData.GetData());
        }
    }
}
