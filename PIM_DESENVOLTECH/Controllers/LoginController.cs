using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.Auxiliar;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _context;
        private readonly Isessao _sessao;
        public LoginController(Contexto context, Isessao sessao)
        {
            _context = context;
            _sessao = sessao;
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
            {

                TempData["MensagemErro"] = "Nome de usuário ou senha incorretos.";
                return RedirectToAction("Index");
            }
            else
            {
                var funcionario = _context.Funcionario.FirstOrDefault(f => f.IdLogin == login.Id);

                if (funcionario != null)
                {
                    _sessao.CriarSessaoDoUsuario(funcionario);
                    _sessao.CriarSessaoDoUsuarioNome(funcionario.NomeCompleto);
                }

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
