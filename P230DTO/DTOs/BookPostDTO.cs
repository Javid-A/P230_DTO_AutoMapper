using P230DTO.Entities;

namespace P230DTO.DTOs
{
    public class BookPostDTO
    {
        public string Name { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public double Price { get; set; }
        public short Pages { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AuthorId { get; set; }
    }
}
