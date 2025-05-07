using Microsoft.AspNetCore.Mvc;
using Projeto01.Repositorio;

namespace Projeto01.Controllers
{
    public class UsuarioController : Controller
    {
        /*Declarando uma variavel privada somente para leitura do tipo UsuarioRepositorio
          Chamada _usuarioRepositorio
        */

        private readonly UsuarioRepositorio _usuarioRepositorio;
        
        /*Definindo o construtor da classe UsuarioController 
        que vai receber uma instaancia de UsuarioRepositorio.*/

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

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
