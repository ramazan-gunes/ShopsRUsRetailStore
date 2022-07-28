using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.Enums;

namespace ShopsRUsRetailStore.Data.Concrete.EntityFramework.Mappings
{
    public class InvoiceDetailMap : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.CreatedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.Property(x => x.ModifiedDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
            builder.HasOne(x => x.Invoice).WithMany(x => x.Details).HasForeignKey(x => x.InvoiceId);
            builder.ToTable("InvoiceDetails");
        }
    }
}
