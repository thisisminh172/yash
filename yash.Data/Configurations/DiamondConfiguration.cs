using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using yash.Data.Entities;

namespace yash.Data.Configurations
{
    public class DiamondConfiguration : IEntityTypeConfiguration<Diamond>
    {
        public void Configure(EntityTypeBuilder<Diamond> builder)
        {
            builder.ToTable("Diamonds");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
