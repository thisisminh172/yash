using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using yash.Data.Entities;

namespace yash.Data.Configurations
{
    public class GoldConfiguration : IEntityTypeConfiguration<Gold>
    {
        public void Configure(EntityTypeBuilder<Gold> builder)
        {
            builder.ToTable("Golds");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
