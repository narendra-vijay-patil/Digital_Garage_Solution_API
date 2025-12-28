using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Digital_Garage_Solutions_API.ViewModel
{
    public class login_model
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        
        public string username { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        
        public string password { get; set; }
    }
}
