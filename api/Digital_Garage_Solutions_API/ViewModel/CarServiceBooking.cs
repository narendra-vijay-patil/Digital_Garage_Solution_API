using System.ComponentModel.DataAnnotations;

namespace Digital_Garage_Solutions_API.ViewModel
{
    public class CarServiceBooking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }  // User name

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Garage { get; set; }

        [Required]
        public string CarServiceType { get; set; } // Dropdown for service type

        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}

