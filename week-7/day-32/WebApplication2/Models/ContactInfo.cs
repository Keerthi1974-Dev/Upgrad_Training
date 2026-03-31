using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ContactInfo
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [EmailAddress]
        public string EmailId { get; set; }

        [Required]
        public long MobileNo { get; set; }

        [Required]
        public string Designation { get; set; }
    }
}