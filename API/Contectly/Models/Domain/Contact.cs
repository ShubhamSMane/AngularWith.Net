using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Contectly.Models.Domain
{
    public class Contact
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string phone { get; set; }
        public bool Favorite {  get; set; }


    }
}
