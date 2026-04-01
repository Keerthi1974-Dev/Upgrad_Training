using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        // Constructor Injection
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // 1. Show All Contacts (Index)
        public IActionResult Index()
        {
            var contacts = _contactService.GetAllContacts();
            return View(contacts);
        }

        // 2. Get Contact By ID
        public IActionResult GetContactById(int id)
        {
            var contact = _contactService.GetContactById(id);

            if (contact == null)
                return NotFound();

            return View(contact);
        }

        // 3. Add Contact (GET)
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        // 4. Add Contact (POST)
        [HttpPost]
        public IActionResult AddContact(ContactInfo contactInfo)
        {
            if (!ModelState.IsValid)
                return View(contactInfo);

            _contactService.AddContact(contactInfo);
            return RedirectToAction("Index");
        }
    }
}