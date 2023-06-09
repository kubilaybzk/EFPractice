﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Threading.Tasks;
namespace EFPractice.Entities.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId); //Burada buranın primary key olduğunu belirtiyoruz.

            builder.Property(b => b.Title).IsRequired().HasMaxLength(150); //Burada required bir değer olduğunu ve maxsimum 150 karakter olmasını set ediyoruz.

            //Aynı zamanda oluşma anında fake datalar oluşturmak istersek onlarıda burada ekleyebiliriz.

            builder.HasData(
                    new Book
                    {
                        BookId = 2,
                        Title = "Title"
                    },
               
            new Book
            {
                BookId = 3,
                Title = "Title2"
            }
              
             );

        }
    }
}
