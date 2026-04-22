using ContactManagementSystem.Service;
using ContactManagementSystem.Models;

namespace ContactManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // service object
            IContactService service = new ContactService();

            Console.WriteLine("Initial Contacts:");
            foreach (var contact in service.GetAllContacts())
            {
                Console.WriteLine($"{contact.Id} - {contact.Name} - {contact.Email}");
            }

            service.AddContact(new Contact
            {
                Id = 4,
                Name = "Sita",
                Email = "sita@gmail.com",
                Phone = "9988776655"
            });

            // Update contact
            service.UpdateContact(3, new Contact
            {
                Name = "Anjali",
                Email = "anjalisrivasthava@gmail.com",
                Phone = "9848012345"
            });

            // Delete contact
            service.DeleteContact(2);

            // Display final contacts
            Console.WriteLine("\nAfter Operations:");
            foreach (var contact in service.GetAllContacts())
            {
                Console.WriteLine($"{contact.Id} - {contact.Name} - {contact.Email}");
            }
        }
    }
}