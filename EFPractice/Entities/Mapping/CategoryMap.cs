using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Entities.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(b => b.CategoryId);
            builder.Property(b => b.CategoryName).HasMaxLength(50).IsRequired().HasDefaultValue("CategoryName");
            builder.Property(b => b.Description).HasMaxLength(100).IsRequired(false).HasDefaultValue("Description");

            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Dİl Eğitimi", Description = "Dİl Eğitimi Test" },
                new Category { CategoryId = 2, CategoryName = "Programlama", Description = "Programlama Test" },
                new Category { CategoryId = 3, CategoryName = "Roman",       Description = "Roman Test" },
                new Category { CategoryId = 4, CategoryName = "Biyografi",   Description = "Biyografi Test" }); 


        }
    }
}
