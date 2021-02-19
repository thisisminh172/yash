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
            builder.Property(x => x.Quantity).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.GoldWeight).IsRequired().HasDefaultValue(1);
            builder.Property(x => x.WastageInPercentage).IsRequired().HasDefaultValue(20);
            builder.Property(x => x.ProductId).IsRequired();


            //gold and diamond>>>>>>>>>>>>
            builder.Property(x => x.GoldId).IsRequired().HasDefaultValue(2);
            //builder.Property(x => x.BrandId).IsRequired();
            builder.Property(x => x.CertifyId).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.TotalMaking).IsRequired();


            //foreign key>>>>>>>>>>>>>>>
            builder.HasOne(x => x.Product).WithMany(x => x.Items).HasForeignKey(x => x.ProductId);
            //builder.HasOne(x => x.Brand).WithMany(x => x.Items).HasForeignKey(x => x.BrandId);
            builder.HasOne(x => x.Category).WithMany(x => x.Items).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Gold).WithMany(x => x.Items).HasForeignKey(x => x.GoldId);
            builder.HasOne(x => x.Diamond).WithMany(x => x.Items).HasForeignKey(x => x.DiamondId);
            builder.HasOne(x => x.Certification).WithMany(x => x.Items).HasForeignKey(x => x.CertifyId);


        }
    }
}
