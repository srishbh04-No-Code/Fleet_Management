using FleetManagement.Model;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private static List<Vehicle> _vehicles = new()
        {
            new Vehicle { Id = 1, DeviceName = "T-Harrier", Area = "Mumbai", FirmwareVersion = "v2.1.0", LastUpdated = DateTime.Now, Status = "Active" },
            new Vehicle { Id = 2, DeviceName = "T-Nexon",   Area = "Pune",   FirmwareVersion = "v1.9.3", LastUpdated = DateTime.Now.AddDays(-5), Status = "Active" },
            new Vehicle { Id = 3, DeviceName = "T-Safari",   Area = "Surat",  FirmwareVersion = "v2.0.1", LastUpdated = DateTime.Now.AddDays(-12), Status = "Inactive" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_vehicles);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
            if (vehicle == null)
                return NotFound($"Vehicle with ID {id} not found.");
            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Vehicle vehicle)
        {
            vehicle.Id = _vehicles.Max(v => v.Id) + 1;
            vehicle.LastUpdated = DateTime.Now;
            _vehicles.Add(vehicle);
            return CreatedAtAction(nameof(GetById), new { id = vehicle.Id }, vehicle);
        }
    }
}