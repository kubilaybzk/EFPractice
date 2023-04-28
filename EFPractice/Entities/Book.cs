namespace EFPractice.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        //foreign key
        public int CategoryId { get; set; }
        //Simple Navigation Property(one-to-manny)
        //Her bir kitabın tek bir kategory bilgisi olsun 
        public Category Category { get; set; }

        //navigation property (one-to-one)
        //Her bir kitabın bir tane detay satırı olur.
        public BookDetail BookDetail { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }

   
}
