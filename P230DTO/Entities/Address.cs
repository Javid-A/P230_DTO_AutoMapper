namespace P230DTO.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}
