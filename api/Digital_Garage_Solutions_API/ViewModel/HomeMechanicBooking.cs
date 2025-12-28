using System.ComponentModel.DataAnnotations;

namespace Digital_Garage_Solutions_API.ViewModel
{
    public class HomeMechanicBooking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string VehicleType { get; set; }

        [Required]
        public string Garage { get; set; }

        [Required]
        public string ServiceType { get; set; }

        public DateTime ScheduledDate { get; set; }

        public string? AllocatedMechanic { get; set; } // You can assign later automatically
    }

}
