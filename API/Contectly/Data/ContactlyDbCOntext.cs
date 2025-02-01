using Microsoft.EntityFrameworkCore;
using Contectly.Models.Domain;
namespace Contectly.Data
{
    public class ContactlyDbCOntext : DbContext
    {
        public ContactlyDbCOntext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    } 
}
