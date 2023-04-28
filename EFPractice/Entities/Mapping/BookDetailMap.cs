using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Entities.Mapping
{
    public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetailId);
            builder.Property(bd => bd.Language).IsRequired();
            builder.Property(bd=>bd.ISSCode).HasDefaultValue("0000-000--00-000");
            builder.Property(bd => bd.AddedDate).HasDefaultValue(DateTime.Now).HasDefaultValue(DateTime.Now);


            builder.HasOne(bd => bd.Book)  //navigation property
                    .WithOne(b => b.BookDetail) 
                    .HasForeignKey<BookDetail>(bd => bd.BookId)
                    .OnDelete(DeleteBehavior.Cascade);
        


        }
    }
}
