namespace EFPractice.Entities
{
    public class BookAuthor
    {

     //Burada many to many relation hakkında işlem yapacağız fakat manny-to-manny relation biraz farklı bir yöntem kullanıyor.
         //İlk once birleştireceğimiz klasörlerin adına uygun olacak şekilde bir class oluşturuyoruz
            // Daha sonra bu classlar içinde gerekli tanıtımları yapıyoruz
                 //Daha sonra ise Book ve Author classları içidne many to manny relation olacağı için şu an yazmış olduğumuz classı 
                     // ICollection olarak tanımlamak.
        // //ek olarak yapmamız gerekn bu class için bir map classı içinde Fluent api kullanarak tanımla yapmak.


        public int BookAuthorId { get; set; }



        //Book
        public int BookId { get ; set; }
        public Book Book { get; set; }

        //Author 
        public int AuthorId { get; set; }
        public Author Author { get; set; }



    }
}
