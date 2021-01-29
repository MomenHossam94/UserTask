using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UserTask.Domain.Entities;

namespace UserTask.Presistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Age).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(60);
            builder.Property(e => e.Phone).IsRequired();
        }
    }
}
