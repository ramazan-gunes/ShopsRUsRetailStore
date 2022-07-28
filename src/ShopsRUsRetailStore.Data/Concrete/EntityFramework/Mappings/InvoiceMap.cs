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
    public class InvoiceMap : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderId).IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.ModifiedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.Number).HasMaxLength(250).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired().HasPrecision(18, 2);
            builder.HasMany(x => x.Details).WithOne(x => x.Invoice).HasForeignKey(x => x.InvoiceId);
            builder.HasOne(x => x.Order).WithMany(x => x.Invoices).HasForeignKey(x => x.OrderId);
            builder.ToTable("Invoices");



            // --------------   SEED DATA  --------- //
            builder.HasData(InvoiceSeedData.GetData());
        }
    }
}
