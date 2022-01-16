using FrediTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).UseIdentityColumn();

            builder.HasOne(c => c.Category).WithMany(p => p.Products).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.Name).IsRequired();
        }
    }
}
