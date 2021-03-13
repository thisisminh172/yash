﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using yash.Data.Entities;

namespace yash.Data.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Email).HasMaxLength(200);
            builder.Property(x => x.FirstName).HasMaxLength(200);
            builder.Property(x => x.LastName).HasMaxLength(200);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Password).HasMaxLength(200);
            builder.Property(x => x.Role).HasDefaultValue(true);

        }
    }
}
