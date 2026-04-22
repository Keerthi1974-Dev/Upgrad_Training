using ContactManagementAPI.Models;

namespace ContactManagementAPI.Services
{
    public class ContactService : IContactService
    {
        private List<Contact> contacts = new List<Contact>();
        private int idCounter = 1;

        public List<Contact> GetAll() => contacts;

        public Contact GetById(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public Contact Add(Contact contact)
        {
            contact.Id = idCounter++;
            contacts.Add(contact);
            return contact;
        }

        public bool Update(int id, Contact contact)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Name = contact.Name;
            existing.Email = contact.Email;
            existing.Phone = contact.Phone;

            return true;
        }

        public bool Delete(int id)
        {
            var contact = GetById(id);
            if (contact == null) return false;

            contacts.Remove(contact);
            return true;
        }
    }
}
