using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Data;
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

        public HomeController(ILogger<HomeController> logger,  IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var result = productService.GetAll();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
            
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}