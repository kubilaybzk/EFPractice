namespace EFPractice.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
   

        public string ISSCode { get; set; }

        public string Language { get; set; }

        public string AddedDate { get; set; }


        //foreign key 
        public int BookId { get; set; }

        //navigation property (one-to-one)
        public Book Book { get; set; }


    }
}
