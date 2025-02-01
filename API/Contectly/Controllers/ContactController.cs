using Contectly.Data;
using Contectly.Models;
using Contectly.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contectly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly ContactlyDbCOntext dbCOntext;

        //create constructor injection
        public ContactController(ContactlyDbCOntext dbCOntext)
        {
            this.dbCOntext = dbCOntext;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = dbCOntext.Contacts.ToList();
            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult AddContact(AddContactRequestDTO request)
        {
            var domainModelContact = new Contact
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                phone = request.phone,
                Favorite = request.Favorite
            };

            dbCOntext.Contacts.Add(domainModelContact);
            dbCOntext.SaveChanges();
            return Ok(domainModelContact);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteContact(Guid id)
        {
            var contact = dbCOntext.Contacts.Find(id);

            if(contact is not null)
            {
                dbCOntext.Contacts.Remove(contact);
                dbCOntext.SaveChanges();
            }

            return Ok();
        }
    }
}
