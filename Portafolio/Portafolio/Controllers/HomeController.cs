using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IRepositorioProyectos RepositorioProyectos { get; }
        public ServicioDelimitado ServicioDelimitado { get; }
        public ServicioUnico ServicioUnico { get; }
        public ServicioTransitorio ServicioTransitorio { get; }

        public HomeController(ILogger<HomeController> logger,
            IRepositorioProyectos repositorioProyectos,ServicioDelimitado servicioDelimitado,ServicioUnico servicioUnico 
            ,ServicioTransitorio servicioTransitorio)
        {
            _logger = logger;
         
            RepositorioProyectos = repositorioProyectos;
            ServicioDelimitado = servicioDelimitado;
            ServicioUnico = servicioUnico;
            ServicioTransitorio = servicioTransitorio;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Este es un mensaje de log");

            var gidViewModel = new EjemploGuidViewModel()
            {
                Delimitado = ServicioDelimitado.ObtenerGuid,
                Transitorio = ServicioTransitorio.ObtenerGuid,
                Unico = ServicioUnico.ObtenerGuid
            };
            var proyectos = RepositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var persona = new Persona
            {
                Nombre = "Jonatan",
                Edad = 25
            };

            var modelo = new HomeIndexViewModel()
            {
                proyectos = proyectos,  // Cambiar 'proyectos' a 'Proyectos' si actualizaste el modelo
                Persona = persona,
                ejemplo1 = gidViewModel
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