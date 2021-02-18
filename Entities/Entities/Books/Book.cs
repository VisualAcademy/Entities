namespace Entities.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //[Unicode(false)]
        //[MaxLength(22)]
        public string Isbn { get; set; }
    }
}
