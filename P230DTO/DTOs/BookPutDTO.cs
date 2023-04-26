namespace P230DTO.DTOs
{
    public class BookPutDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public double Price { get; set; }
        public short Pages { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AuthorId { get; set; }
    }
}
