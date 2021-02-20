using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using yash.Data.Entities;

namespace yash.Data.Configurations
{
    public class RingSizeConfiguration : IEntityTypeConfiguration<RingSize>
    {
        public void Configure(EntityTypeBuilder<RingSize> builder)
        {
            builder.ToTable("RingSizes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.SizeNumber).IsRequired();
        }

    }
}
