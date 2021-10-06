using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Views;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult PaginaInicial(PaginaInicialModel modelo)
        {
            return View(modelo);
        }

        [HttpPost]
        public IActionResult OnPost(AssinanteModel modelo)
        {
            return View(modelo);
        }
    }
}