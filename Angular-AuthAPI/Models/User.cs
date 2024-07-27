using System.ComponentModel.DataAnnotations;

namespace Angular_AuthAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }   
        public string lastName { get; set; }
        public string email { get; set; } 
        public string Token { get; set; }
        public string password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
 