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
                //pega o Id do Login
                var LoginId = _context.Login.FirstOrDefault(f => f.Id == login.Id);

                //Acha o funcionario pelo Id do Login
                var funcionario = _context.Funcionario.FirstOrDefault(x => x.IdLogin == login.Id);
                
                if (LoginId != null)
                {
                    _sessao.CriarSessaoDoUsuario(LoginId);
                    _sessao.CriarSessaoDoUsuarioNome(funcionario.NomeCompleto);
                }

                //atualizar a FK do Login na Model Funcionario
                var atualizarFk = funcionario.logins = LoginId;
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
