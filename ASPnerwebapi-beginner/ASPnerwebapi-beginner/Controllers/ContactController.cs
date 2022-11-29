using ASPnerwebapi_beginner.Data;
using ASPnerwebapi_beginner.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ASPnerwebapi_beginner.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ContactController : Controller
    {
        private readonly ContactApiDbContext dbContext;
        public ContactController(ContactApiDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        [HttpGet]
        public IActionResult GetContact()
        {
            return Ok(dbContext.contacts.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest addContactRequest)
        {
            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                Address = addContactRequest.Address,
                Email = addContactRequest.Email,
                FullName = addContactRequest.FullName,
                Phone = addContactRequest.Phone
            };
            await dbContext.contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();
            return Ok(contact);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContact([FromRoute] Guid id, UpdateContactRequest updateContactRequest)
        {
            var contact = await dbContext.contacts.FindAsync(id);
            if (contact != null)
            {
                contact.FullName = updateContactRequest.FullName;
                contact.Address = updateContactRequest.Address;
                contact.Phone = updateContactRequest.Phone;
                contact.Email = updateContactRequest.Email;
                await dbContext.SaveChangesAsync();
                return Ok(contact);

            }
            return NotFound();
        }

            [HttpGet]

            [Route("{id:guid}")]
            public async Task<IActionResult> GetContacts([FromRoute] Guid id)
            {
            var c = await dbContext.contacts.FindAsync(id);
            if(c==null)
            {
                return NotFound();
            }
            return Ok(c);

            }
        [HttpDelete]
        [Route("{id:guid}")]

        public async Task<IActionResult> DeleteContacts([FromRoute] Guid id)
        {
            var c = await dbContext.contacts.FindAsync(id);
            if(c!=null)
            {
                dbContext.Remove(c);
                dbContext.SaveChangesAsync();
                return Ok(c);
            }
            return NotFound();

        }


    }
}
