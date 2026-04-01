using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class ContactInfo
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Company is required")]
        public string CompanyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        public long MobileNo { get; set; }

        [Required(ErrorMessage = "Designation is required")]
        public string Designation { get; set; } = string.Empty;


    }
}
