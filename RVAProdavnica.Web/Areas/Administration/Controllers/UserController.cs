using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using RVAProdavnica.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Route("/Administration/Views/LoginPage/[controller]/[action]/{id}")]
    public class UserController
    {
        private readonly IUserService userService;


        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        /*
        public IActionResult Users()
        {
            return View();
        }
        */

    }
}
