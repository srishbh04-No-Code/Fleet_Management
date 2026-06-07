# Fleet Management API

A REST API built with **ASP.NET Core (.NET 9)** for tracking fleet vehicles in the automotive/IoT domain. This project is being built phase by phase to learn core C# and ASP.NET concepts hands-on.

---

## Current Status — Phase 1 Complete

Phase 1 establishes a working Web API with hardcoded in-memory data. No database yet.

### What the API does
- Returns a list of all fleet vehicles
- Returns a single vehicle by ID
- Accepts a new vehicle via POST request

### Endpoints

| Method | URL | Description |
|--------|-----|-------------|
| GET | `/api/vehicles` | Get all vehicles |
| GET | `/api/vehicles/{id}` | Get vehicle by ID |
| POST | `/api/vehicles` | Add a new vehicle |

---

## Project Structure

```
FleetManagement/
├── Controllers/
│   └── VehiclesController.cs   # Handles HTTP requests
├── Models/
│   └── Vehicle.cs              # Vehicle data blueprint
├── Program.cs                  # App startup and configuration
└── FleetManagement.csproj      # Project file
```

---

## Vehicle Model

```json
{
  "id": 1,
  "deviceName": "T-Harrier",
  "area": "Mumbai",
  "firmwareVersion": "v2.1.0",
  "lastUpdated": "2026-06-07T09:38:53",
  "status": "Active"
}
```

---

## How to Run

```bash
# Clone the repo
git clone https://github.com/srishbh04-No-Code/Fleet_Management.git

# Navigate to project
cd Fleet_Management/FleetManagement

# Run the app
dotnet run
```

Open browser and go to:
```
http://localhost:5000/api/vehicles
```

---

## How to Test

**GET all vehicles**
```
http://localhost:5000/api/vehicles
```

**GET vehicle by ID**
```
http://localhost:5000/api/vehicles/1
```

**POST a new vehicle** (use Postman or curl)
```bash
curl -X POST http://localhost:5000/api/vehicles \
  -H "Content-Type: application/json" \
  -d '{
    "deviceName": "T-Nexon EV",
    "area": "Ahmedabad",
    "firmwareVersion": "v3.0.0",
    "status": "Active"
  }'
```

---

## Tech Stack

| Technology | Purpose |
|------------|---------|
| C# / .NET 9 | Language and runtime |
| ASP.NET Core | Web API framework |
| Swashbuckle | Swagger UI for API docs |
| Visual Studio 2026 | IDE |
| GitHub | Version control |

---

## Roadmap

| Phase | Focus | Status |
|-------|-------|--------|
| Phase 1 | ASP.NET Core basics, Web API, routing | ✅ Complete |
| Phase 2 | Dependency Injection, design principles | 🔲 Upcoming |
| Phase 3 | File handling, JSON persistence | 🔲 Upcoming |
| Phase 4 | LINQ queries and filtering | 🔲 Upcoming |
| Phase 5 | Async/await, non-blocking I/O | 🔲 Upcoming |

---

## Concepts Learned in Phase 1

- How ASP.NET Core handles HTTP requests end to end
- What `[ApiController]`, `[Route]`, `[HttpGet]`, `[HttpPost]` attributes do
- How `Program.cs` wires up the app on startup
- HTTP status codes — 200, 201, 404 and when each is returned
- How JSON serialization works automatically
- Difference between `dotnet run` (port 5000) and F5 in Visual Studio (port 5230)
- How `launchSettings.json` controls the environment and port
