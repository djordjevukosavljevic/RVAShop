using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using RVAProdavnica.Services;
using RVAProdavnica.Web.Models;
using System.Diagnostics;

namespace RVAProdavnica.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        //private readonly IUserService userService;

        public HomeController(ILogger<HomeController> logger,  IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var result = productService.GetAll();
            return View(result);
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Car()
        {
            return View();
        }
    }
}