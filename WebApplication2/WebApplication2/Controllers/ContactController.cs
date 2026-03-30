using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        public static List<ContactInfo> contacts = new List<ContactInfo>
        {
            new ContactInfo { ContactId = 1, FirstName = "Subham", LastName = "Kumar", CompanyName = "ABC Tech Solutions", EmailId = "subham@gmail.com", MobileNo = 9848012345, Designation = "Manager" },
            new ContactInfo { ContactId = 2, FirstName = "srihan", LastName = "srivasthava", CompanyName = "universal global systems", EmailId = "srihan@gmail.com", MobileNo = 99887766555, Designation = "Developer" },
            new ContactInfo { ContactId = 3, FirstName = "Samar", LastName = "Keshri", CompanyName = "xyz It&Consulting", EmailId = "Samar@gmail.com", MobileNo = 9123456, Designation = "Tester" }
        };

        public IActionResult ShowContacts()
        {
            return View(contacts);
        }

        public IActionResult GetContactById(int id)
        {
            var result = contacts.Where(x => x.ContactId == id).ToList();
            return View("ShowContacts", result);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(ContactInfo contactInfo)
        {
            if (ModelState.IsValid)
            {
                contactInfo.ContactId = contacts.Max(x => x.ContactId) + 1;
                contacts.Add(contactInfo);
                return RedirectToAction("ShowContacts");
            }
            return View(contactInfo);
        }
    }
}