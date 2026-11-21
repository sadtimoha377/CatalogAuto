using Microsoft.AspNetCore.Mvc;
using CatalogAuto.Models;

namespace CatalogAuto.Controllers
{
    public class CarController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var cars = new List<CarModel>
            {
                new() { Brand = "Toyota", Model = "Camry", Price = 32000 },
                new() { Brand = "BMW", Model = "X5", Price = 75000 },
                new() { Brand = "Tesla", Model = "Model 3", Price = 42000 },
                new() { Brand = "Volkswagen", Model = "Golf", Price = 27000 }
            };

            return View(cars);
        }
    }
}
