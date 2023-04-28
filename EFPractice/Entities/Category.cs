namespace EFPractice.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }


        //Collection Navigation Property
        //Her bir kategory birden fazla satıra sahip olsun 
        public ICollection<Book> Books { get; set; }
    }
}
