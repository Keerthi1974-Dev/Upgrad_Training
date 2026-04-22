using Microsoft.AspNetCore.Http;
using ContactManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;
using ContactManagementAPI.Services;

namespace ContactManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _service;
        private readonly ILogger<ContactsController> _logger;

        public ContactsController(IContactService service, ILogger<ContactsController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("GET: Fetching all contacts");

            var contacts = _service.GetAll();

            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("GET: Fetching contact with ID {id}");

            var contact = _service.GetById(id);

            if (contact == null)
            {
                _logger.LogWarning("Contact with ID {id} not found");
                return NotFound();
            }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Contact contact)
        {
            _logger.LogInformation("POST: Adding new contact");

            if (contact == null)
            {
                _logger.LogWarning("POST failed: Contact is null");
                return BadRequest("Invalid data");
            }

            var result = _service.Add(contact);

            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,  Contact contact)
        {
            _logger.LogInformation($"PUT: Updating contact with ID {id}");

            if (contact == null)
            {
                _logger.LogWarning("PUT failed: Contact is null");
                return BadRequest("Invalid data");
            }

            if (!_service.Update(id, contact))
            {
                _logger.LogWarning("PUT failed: Contact with ID {id} not found");
                return NotFound();
            }

            return Ok("Updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("DELETE: Removing contact with ID {id}");

            if (!_service.Delete(id))
            {
                _logger.LogWarning("DELETE failed: Contact with ID {id} not found");
                return NotFound();
            }

            return Ok("Deleted successfully");
        }
    }
}