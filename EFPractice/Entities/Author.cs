namespace EFPractice.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string FullName=>string.Concat(Name, LastName);  //Veri tabanında bu olmayacak

        public DateTime CreatedTime { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
