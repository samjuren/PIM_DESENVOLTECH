using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.Auxiliar;
using PIM_DESENVOLTECH.Models;

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
            return View();
        }


        public IActionResult CadastrarPonto(string NomeCompleto, DateTime dataHoraRegistro)
        {
            var nomefunc = _context.Funcionario.FirstOrDefault(x => x.NomeCompleto == NomeCompleto);

            if (nomefunc == null)
            {
                //retorna mensagem erro
            }
            else
            {
                _context.FolhaPonto.Add(new FolhaPonto
                {
                    HoraPonto = DateTime.Now,
                    IdFuncionario = nomefunc.IdFuncionario
                });

                _context.SaveChanges();
            }

            var teste = _context.FolhaPonto.Where(x => x.IdFuncionario == nomefunc.IdFuncionario);

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
