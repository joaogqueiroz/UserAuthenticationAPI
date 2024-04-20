using AspNetAPIProject02.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetAPIProject02.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Table name
            builder.ToTable("USER");

            //Primary key
            builder.HasKey(u => u.ID);

            //All fields
            builder.Property(u => u.ID).HasColumnName("ID");
            builder.Property(u => u.Name).HasColumnName("NAME").HasMaxLength(150).IsRequired();
            builder.Property(u => u.Email).HasColumnName("EMAIL").HasMaxLength(100).IsRequired();
            builder.Property(u => u.Password).HasColumnName("PASSWORD").HasMaxLength(20).IsRequired();
            builder.Property(u => u.RegistrationDate).HasColumnName("REGISTRATIONDATE").IsRequired();
        }
    }
}
