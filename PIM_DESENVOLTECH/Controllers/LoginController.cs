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
                var LoginId = _context.Login.FirstOrDefault(f => f.Id == login.Id);

                var nomeCompleto = _context.Funcionario.FirstOrDefault(x => x.IdLogin == login.Id)?.NomeCompleto;
                
                if (LoginId != null)
                {
                    _sessao.CriarSessaoDoUsuario(LoginId);
                    _sessao.CriarSessaoDoUsuarioNome(nomeCompleto);
                }

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
