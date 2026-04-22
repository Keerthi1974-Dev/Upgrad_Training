using ContactManagementSystem.Models;
using ContactManagementSystem.Service;


namespace ContactManagementSystem.Service
{
    public class ContactService : IContactService
    {
        
        private static readonly List<Contact> _contacts = new()
        {
            new Contact { Id = 1, Name = "Samar", Email = "SamarModi@gmail.com", Phone = "9876543210" },
            new Contact { Id = 2, Name = "Sahir", Email = "SahirModi@gmail.com", Phone = "9123456780" },
            new Contact { Id = 3, Name = "Anjali", Email = "anjalisrivasthava@gmail.com", Phone = "9012345678" }
        };

        private const string ContactNotFoundMessage = "Contact not found";

        public void AddContact(Contact contact)
        {
            ValidateContact(contact);

            if (_contacts.Any(c => c.Id == contact.Id))
                throw new ArgumentException("Duplicate Id not allowed...");

            _contacts.Add(contact);
        }

        public void UpdateContact(int id, Contact updatedContact)
        {
            var existingContact = _contacts.FirstOrDefault(c => c.Id == id);

            if (existingContact == null)
                throw new Exception(ContactNotFoundMessage);

            ValidateContact(updatedContact);

            existingContact.Name = updatedContact.Name;
            existingContact.Email = updatedContact.Email;
            existingContact.Phone = updatedContact.Phone;
        }

        public void DeleteContact(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);

            if (contact == null)
                throw new Exception(ContactNotFoundMessage);

            _contacts.Remove(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return _contacts.ToList(); 
        }

        // Validations
        private void ValidateContact(Contact contact)
        {
            if (string.IsNullOrEmpty(contact.Name))
                throw new ArgumentException("Name is required");

            if (string.IsNullOrEmpty(contact.Email))
                throw new ArgumentException("Email is required");
        }
    }
}