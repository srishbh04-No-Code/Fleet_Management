namespace FleetManagement.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string DeviceName { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string FirmwareVersion { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
        public string Status { get; set; } = "Active";
    }
}