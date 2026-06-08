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

    public class Device
    {
        public string DeviceID { get; set; } = string.Empty;
        public string DeviceType { get; set; } = string.Empty;
        public string HW_Version { get; set; } = string.Empty;
        public string FirmwareVersion { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
    }
}