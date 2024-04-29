using Autos.Data;
using Autos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Autos.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ManageVehicleController : Controller
	{
		
		private readonly AutoDbContext DbContext;
		public ManageVehicleController(AutoDbContext context)
		{
			DbContext = context;
		}
		public IActionResult Index()
		{
			return View();
		}
      
        public IActionResult ListOfVehicles()
		{
			var vehicles = DbContext.Vehicles.ToList();
			return View(vehicles);
		}
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(Vehicle newVehicle)
		{
			DbContext.Vehicles.Add(newVehicle);
			await DbContext.SaveChangesAsync();
			return RedirectToAction("ListOfVehicles");
		}

		// Edit Vehicle Controllers
		public IActionResult EditVehicle(int id)
		{
			var vehicle = DbContext.Vehicles.Find(id);
			if (vehicle == null)
			{
				return NotFound();
			}
			return View(vehicle);
		}
		[HttpPost]
		public async Task<IActionResult> EditVehicle(Vehicle updatedVehicle)
		{
			if (ModelState.IsValid)
			{
				DbContext.Update(updatedVehicle);
				await DbContext.SaveChangesAsync();
				return RedirectToAction("ListOfVehicles");

			}
            return RedirectToAction();

        }
		[HttpPost]
		public async Task<IActionResult> Remove(int id)
		{
			// Retrieve the vehicle from the database
			var vehicleToRemove = await DbContext.Vehicles.FindAsync(id);

			if (vehicleToRemove == null)
			{
				// If the vehicle with the specified ID is not found, return a not found response
				return NotFound();
			}

            // Remove the vehicle
            DbContext.Vehicles.Remove(vehicleToRemove);
			await DbContext.SaveChangesAsync();

			// Redirect to a suitable action (e.g., index page)
			return RedirectToAction("ListOfVehicles");
		}

	}
    }
