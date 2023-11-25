using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using PIM_DESENVOLTECH.Auxiliar;
using PIM_DESENVOLTECH.Models;
using PIM_DESENVOLTECH.ViewModels;

namespace PIM_DESENVOLTECH.Controllers
{
    public class FolhaPontoController : Controller
    {
        private readonly Contexto _context;
        private readonly Isessao _sessao;

        public FolhaPontoController(Contexto context, Isessao isessao)
        {
            _context = context;
            _sessao = isessao;
        }

        public IActionResult Index()
        {
            Login login = _sessao.BuscarSessaoDoUsuario();

            var funcionario = _context.Funcionario.FirstOrDefault(x => x.IdLogin == login.Id).IdFuncionario;

            var listFuncionario = _context.Funcionario.Where(x => x.IdLogin == login.Id);

            var listFolhaPonto = _context.FolhaPonto.Where(x => x.IdFuncionario == funcionario);

            FuncionarioViewData fvd = new FuncionarioViewData();

            return View(fvd);
        }

        public IActionResult CadastrarPonto(string NomeCompleto, DateTime dataHoraRegistro)
        {
            Login login = _sessao.BuscarSessaoDoUsuario();

            var func = _context.Funcionario.FirstOrDefault(x => x.IdLogin == login.Id);

            if (func == null)
            {
                //retorna mensagem erro
            }
            else
            {
                _context.FolhaPonto.Add(new FolhaPonto
                {
                    HoraPonto = DateTime.Now,
                    IdFuncionario = func.IdFuncionario
                });

                var IdFolhaPonto = _context.FolhaPonto.FirstOrDefault(x => x.IdFuncionario == func.IdFuncionario);

                //func.FolhaPonto = IdFolhaPonto;
                //func.IdFolhaPonto = IdFolhaPonto.IdFolhaPonto;

                _context.SaveChanges();
            }

            return RedirectToAction("Index", "FolhaPonto");
        }

        public IActionResult CadastrarFuncionarioLateral()
        {
            return RedirectToAction("Index", "CadastrarFuncionario");
        }

        public IActionResult FolhaPontoLateral()
        {
            return RedirectToAction("Index", "FolhaPonto");
        }
        public IActionResult FeriasLateral()
        {
            return RedirectToAction("Index", "Ferias");
        }
        public IActionResult CalculoPagamento()
        {
            return RedirectToAction("Index", "CalculoFolha");
        }

        public IActionResult SairSistema()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
