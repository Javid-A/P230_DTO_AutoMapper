namespace P230DTO.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public DateTime PassedAway { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
