namespace P230DTO.DTOs
{
    public class BookGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public short Pages { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
