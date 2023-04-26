using System.ComponentModel.DataAnnotations;

namespace EFPractice.Entities
{
    public class Book
    {
        [Key] //Bu bu alanın bir primary kes olarak tanımlandığını ifade eder.
        public int BookId { get; set; }
        [MaxLength(50)] //Maksimum 50 kelime olsun
        [Required] // Sorunlu alan

        public string Title { get; set; }
    }
}
