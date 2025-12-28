namespace Digital_Garage_Solutions_API.viewmodel
{
    public class ShowGarageModel
    {
        public string name { get; set; }
        public string GEmail { get; set; }
        public string phone { get; set; }
        public string GAlternateContact { get; set; }
        public string GAddress { get; set; }
        public List<string> GVehicles { get; set; }
        public List<string> services { get; set; }
        public List<string> GWorkingTypes { get; set; }
        public string GOpeningTime { get; set; }
        public string GClosingTime { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string status { get; set; }
    }
}
