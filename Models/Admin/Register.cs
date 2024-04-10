using System.ComponentModel.DataAnnotations;

namespace ONTProject3010.Models.Admin
{
    public class Register
    {
        [Key] 
        public int RegisterId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int IdNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public int MobilePhone { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
