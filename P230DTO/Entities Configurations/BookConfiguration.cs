using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P230DTO.Entities;
using System.Reflection.Emit;

namespace P230DTO.Entities_Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .HasOne(b => b.Author)
                .WithMany(a => a.Books);
            builder.Property(b => b.Name).HasMaxLength(20).IsRequired();
            builder.Property(b => b.Desc).HasMaxLength(150).IsRequired();
            builder.Property(b => b.Price).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(b => b.Pages).IsRequired();
        }
    }
}
