using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Entities.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);

            builder.Property(a => a.CreatedTime).HasDefaultValueSql("GETDATE()");

            builder.Ignore(a => a.FullName);

            builder.HasData(
                new Author { AuthorId = 1, Name = "Kubilay", LastName = "Bozak" },
                new Author { AuthorId = 2, Name = "Samet",   LastName = "Kara" },
                new Author { AuthorId = 3, Name = "Buğrahan Çağrı ", LastName = "Demirbaş" },
                new Author { AuthorId = 4, Name = "Burak", LastName = "Eriç" },
                new Author { AuthorId = 5, Name = "Fatih Mert", LastName = "Söz" },
                new Author { AuthorId = 6, Name = "Yasirhan", LastName = "Kökçen" }
                );
        }
    }
}
