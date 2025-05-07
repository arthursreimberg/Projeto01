using Microsoft.AspNetCore.Mvc;

namespace Projeto01.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();

        }
    }
}
