using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Entities.Mapping
{
    public class BookAuthorMap : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => ba.BookAuthorId);

            //Şimdi bizim iki farklı bağlantımız olmalı bunun sebebi
            //many-to-manny relation kullanmamız yani hem book için hemde Author için bir relation oluşturmamız lazım


            builder.HasOne(ba => ba.Book)  //Maplenen class'ın içinde ne ilişkide kullanılacak  (BookAuthor içinde bulunan Book prop'u)
                 .WithMany(b => b.BookAuthors)  //nereye relation kuracak  (Book içinde bulunan BookAuthors Colection prop'una)
                 .HasForeignKey(ba => ba.BookId); // bağlantıyı kuracak olan anahtarın adı ne  (BookAuthor içinde bulunan BookId prop'u)

            builder.HasOne(ba => ba.Author)
                 .WithMany(a => a.BookAuthors)
                 .HasForeignKey(ba => ba.AuthorId);

        
        }
    }
}
