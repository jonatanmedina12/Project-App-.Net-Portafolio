using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public RepositorioProyectos RepositorioProyectos { get; }

        public HomeController(ILogger<HomeController> logger,RepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            RepositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {

            var proyectos = RepositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var persona = new Persona
            {
                Nombre = "Jonatan",
                Edad = 25
            };

            var modelo = new HomeIndexViewModel()
            {
                proyectos = proyectos,
                Persona = persona
            };
            return View(modelo);
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