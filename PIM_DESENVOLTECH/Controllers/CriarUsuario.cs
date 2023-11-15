using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.Models;
using System.Globalization;

namespace PIM_DESENVOLTECH.Controllers
{
    public class CriarUsuario : Controller
    {
        private readonly Contexto _context;

        public CriarUsuario(Contexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void CriarUsuarioBanco(string Login, string Senha)
        {
            if (!String.IsNullOrEmpty(Login) && !String.IsNullOrEmpty(Senha))
            {
                _context.Login.Add(new Login
                {
                    NomeLogin = Login,
                    SenhaLogin = Senha,
                });

                _context.SaveChanges();
            }
            else
            {
                return;
            }

        }
    }
}
