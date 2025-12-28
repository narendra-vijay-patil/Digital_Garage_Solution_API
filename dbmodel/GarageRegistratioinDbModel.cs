using System.ComponentModel.DataAnnotations;

namespace Digital_Garage_Solutions_API.ViewModel
{
    public class GarageRegistratioinDbModel
    {
        [Key]
        public int GarageId { get; set; }
        public string? MobileEmail { get; set; }
        
        public string? Password { get; set; }

        public string? GarageName { get; set; }
        public string? OwnerName { get; set; }
        public string? GEmail { get; set; }
        public string? GMobile { get; set; }
        public string? GAlternateContact { get; set; }
        public string? GState { get; set; }
        public string? GDistrict { get; set; }
        public string? GCity { get; set; }
        public string? GAddress { get; set; }
        public List<string>? GVehicles { get; set; }
        public List<string>? GServices { get; set; }
        public List<string>? GWorkingTypes { get; set; }
        public TimeOnly? GOpeningTime { get; set; }
        public TimeOnly? GClosingTime { get; set; }
        public string? GLatitude { get; set; }
        public string? GLongitude { get; set; }
        public Boolean? GISActive { get; set; }
    }
}
