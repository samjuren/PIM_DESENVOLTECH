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

            var folha = _context.FolhaPonto.FirstOrDefault(x => x.Funcionario.IdLogin == login.Id);
            var listFolhaPonto = _context.FolhaPonto.ToList().AsQueryable().Where(x => x.IdFuncionario == folha.IdFuncionario);
            var func = _context.Funcionario.FirstOrDefault(x => x.IdLogin == login.Id);

            bool listaPreenchida = _context.FolhaPonto
                .Any(x => x.IdFuncionario == func.IdFuncionario);

            FuncionarioViewData fvd = new FuncionarioViewData();

            if (listaPreenchida)
            {
                fvd.folhaPontoList = listFolhaPonto;
                fvd.folhaPonto = folha;
                fvd.folhaPonto.Funcionario = func;

                return View(fvd);
            }
            else
            {
                return View(fvd);
            }
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
                    IdFuncionario = func.IdFuncionario,
                    FK_Funcionario = func.IdFuncionario,
                    Funcionario = func
                });  

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
