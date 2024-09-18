using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Description = "E-Commerce realizado en ASP.NET CORE",
                    Link = "https://Amazon.com",
                    ImagenUrl = "/img/assassin.jpg",
                },
                new Proyecto
                {
                    Titulo = "New York",
                    Description = "E-Commerce realizado en ASP.NET CORE",
                    Link = "https://Amazon.com",
                    ImagenUrl = "/img/assassin.jpg"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Description = "E-Commerce realizado en ASP.NET CORE",
                    Link = "https://Amazon.com",
                    ImagenUrl = "/img/assassin.jpg"
                }
            };
        }
    }
}
