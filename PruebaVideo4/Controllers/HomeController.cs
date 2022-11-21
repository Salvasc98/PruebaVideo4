using Microsoft.AspNetCore.Mvc;
using PruebaVideo4.Models;
using System.Diagnostics;
using PruebaVideo4.Models;

namespace PruebaVideo4.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public PruebaVideo4.Models.Bdvideo4Context db = new Bdvideo4Context();

        private readonly IHttpContextAccessor contxt;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            contxt = httpContextAccessor;
        }

        public IActionResult Index()
        {
            ViewData["Tittle"] = "Lista de Empleados con EF";

            var empleados = db.Empleados.ToList();

            return View(empleados);
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