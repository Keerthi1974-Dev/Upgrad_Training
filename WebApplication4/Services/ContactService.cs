using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class ContactService : IContactService
    {
        static List<ContactInfo> contacts = new List<ContactInfo>
        {
            new ContactInfo
            {
                ContactId = 1,
                FirstName = "Subham",
                LastName = "Srivastava",
                CompanyName = "Infosys",
                EmailId = "subham@gmail.com",
                MobileNo = 9876543210,
                Designation = "Software Engineer"
            },
            new ContactInfo
            {
                ContactId = 2,
                FirstName = "Arun",
                LastName = "Keshri",
                CompanyName = "TCS",
                EmailId = "arun@gmail.com",
                MobileNo = 9123456780,
                Designation = "Developer"
            },
            new ContactInfo
            {
                ContactId = 3,
                FirstName = "Samar",
                LastName = "Modi",
                CompanyName = "Wipro",
                EmailId = "samar@gmail.com",
                MobileNo = 9988776655,
                Designation = "Analyst"
            },
            new ContactInfo
            {
                ContactId = 4,
                FirstName = "Sahir",
                LastName = "Modi",
                CompanyName = "Capgemini",
                EmailId = "sahir@gmail.com",
                MobileNo = 9871234567,
                Designation = "Consultant"
            }
        };

        
        static int nextId = contacts.Max(c => c.ContactId) + 1;

        public List<ContactInfo> GetAllContacts()
        {
            return contacts;
        }

        public ContactInfo GetContactById(int id)
        {
            return contacts.FirstOrDefault(c => c.ContactId == id);
        }

        public void AddContact(ContactInfo contact)
        {
            
            contact.ContactId = nextId++;

            contacts.Add(contact);
        }
    }
}