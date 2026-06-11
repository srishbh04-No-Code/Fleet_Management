using FleetManagement.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace FleetManagement.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DevicesController : ControllerBase
    {
            private static List<Device> _devices = new()
        {
            new Device { DeviceID = "D-001", DeviceType = "Sensor", HW_Version = "v1.0", FirmwareVersion = "v1.2.0", Status = "Active", LastUpdated = DateTime.Now },
            new Device { DeviceID = "D-002", DeviceType = "Camera", HW_Version = "v2.0", FirmwareVersion = "v2.3.1", Status = "Inactive", LastUpdated = DateTime.Now.AddDays(-7) },
            new Device { DeviceID = "D-003", DeviceType = "GPS", HW_Version = "v1.5", FirmwareVersion = "v1.8.4", Status = "Active", LastUpdated = DateTime.Now.AddDays(-3) },
            new Device { DeviceID = "D-004", DeviceType = "Front_Radar", HW_Version = "v2.5", FirmwareVersion = "v1.5.0", Status = "Inactive", LastUpdated = DateTime.Now.AddDays(+3) }
        };

        #region Route-Based Approach

        //[HttpGet]
        //public IActionResult GetAllDevices()
        //{
        //    return Ok(_devices);
        //}

        //[HttpGet("status/{status}")]
        //public IActionResult GetDeviceStatus(string status)
        //{
        //    var deviceStatus = _devices.FindAll(x => x.Status == status);
        //    var deviceType = _devices.FindAll(x => x.DeviceType == status);
        //    if (deviceStatus == null)
        //        return NotFound($"Device with status {status} not found.");
        //    return Ok(deviceStatus);
        //}

        //[HttpGet("type/{deviceType}")]
        //public IActionResult GetDeviceByType(string deviceType)
        //{
        //    var device = _devices.FirstOrDefault(x => x.DeviceType == deviceType);
        //    if (device == null)
        //        return NotFound($"Device with type {deviceType} not found.");
        //    return Ok(device);
        //}

        #endregion
        #region Query_Based Approach
        
        [HttpGet]
        public IActionResult GetDevices([FromQuery] string status, [FromQuery] string deviceType)
        {
            if (!string.IsNullOrEmpty(status))
            {
                var deviceStatus = _devices.FindAll(x => x.Status == status);
                if (deviceStatus.Count == 0)
                    return NotFound($"No devices found with status {status}.");
                return Ok(deviceStatus);
            }
            else if (!string.IsNullOrEmpty(deviceType))
            {
                var deviceTypeDevices = _devices.FindAll(x => x.DeviceType == deviceType);
                if (deviceTypeDevices.Count == 0)
                    return NotFound($"No devices found with type {deviceType}.");
                return Ok(deviceTypeDevices);
            }
            else
            {
                // If no query parameters are provided, return all devices
                return Ok(_devices);
            }
        }

        #endregion
    }

}
