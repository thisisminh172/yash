using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using yash.Data.Entities;

namespace yash.Data.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Quantity).HasDefaultValue(0);
            builder.Property(x => x.GoldWeight).HasDefaultValue(1);
            builder.Property(x => x.WastageInPercentage).HasDefaultValue(20);
            


            //gold and diamond>>>>>>>>>>>>
            builder.Property(x => x.GoldId).HasDefaultValue(2);
           


            //foreign key>>>>>>>>>>>>>>>
            builder.HasOne(x => x.ProductType).WithMany(x => x.Items).HasForeignKey(x => x.ProductId);
            //builder.HasOne(x => x.Brand).WithMany(x => x.Items).HasForeignKey(x => x.BrandId);
            builder.HasOne(x => x.Category).WithMany(x => x.Items).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Gold).WithMany(x => x.Items).HasForeignKey(x => x.GoldId);
            builder.HasOne(x => x.Diamond).WithMany(x => x.Items).HasForeignKey(x => x.DiamondId);
            builder.HasOne(x => x.Certification).WithMany(x => x.Items).HasForeignKey(x => x.CertifyId);
            builder.HasOne(x => x.RingSize).WithMany(x => x.Items).HasForeignKey(x => x.RingSizeId);


        }
    }
}
