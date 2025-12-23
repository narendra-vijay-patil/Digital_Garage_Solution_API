using System.ComponentModel.DataAnnotations;

namespace Digital_Garage_Solutions_API.ViewModel
{
    public class GarageRegistratioinViewModel
    {
        [Key]
        public int GarageId { get; set; }

        public string? GarageName { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerEmail { get; set; }
        public string? PrimaryContact { get; set; }
        public string? AlternateContact { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public List<string>? Vehicles { get; set; }
        public List<string>? Services { get; set; }
        public List<string>? WorkingTypes { get; set; }
        public string? OpeningTime { get; set; }
        public string? ClosingTime { get; set; }
    }
}
