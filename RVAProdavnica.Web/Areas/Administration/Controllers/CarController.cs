using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Models;
using RVAProdavnica.Services;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Route("Administration/[controller]/[action]/{id}")]
    public class CarController : Controller
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        public IActionResult Cars()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        

    }
}
