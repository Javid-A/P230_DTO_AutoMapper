namespace P230DTO.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public short Pages { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
