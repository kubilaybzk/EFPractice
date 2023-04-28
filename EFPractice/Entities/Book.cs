namespace EFPractice.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }

   
}
