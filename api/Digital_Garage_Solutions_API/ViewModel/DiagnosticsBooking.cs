using System.ComponentModel.DataAnnotations;

namespace Digital_Garage_Solutions_API.ViewModel
{
    public class DiagnosticsBooking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Garage { get; set; }

        [Required]
        public string IssueType { get; set; } // Type of diagnostics issue

        public DateTime BookingDate { get; set; } = DateTime.Now;

    }
}
