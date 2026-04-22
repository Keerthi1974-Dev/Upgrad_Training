using ContactManagementSystem.Models;
using System.Collections.Generic;

namespace ContactManagementSystem.Service
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        void UpdateContact(int id, Contact updatedContact);
        void DeleteContact(int id);
        List<Contact> GetAllContacts();
    }
}