namespace Contectly.Models
{
    public class AddContactRequestDTO
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string phone { get; set; }
        public bool Favorite { get; set; }
    }
}
