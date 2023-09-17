using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contractService)
        {
            _contactService = contractService;
        }

        [HttpGet("{id}")]
        public ContactDTO Get(int id)
        {
           return _contactService.GetContactById(id);
        }
    }
}
