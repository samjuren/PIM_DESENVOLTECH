using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _context;

        public LoginController(Contexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult ChecarUsuario(string Login, string Senha)
        {
            var login = _context.Login.FirstOrDefault(x =>
                x.NomeLogin == Login 
                &&
                x.SenhaLogin == Senha
                );

            if (login == null)            
                return Index();
            else
                return RedirectToAction("Index", "Home");
        }
    }
}
