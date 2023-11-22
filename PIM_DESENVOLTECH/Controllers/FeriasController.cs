using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;
using PIM_DESENVOLTECH.Auxiliar;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Controllers
{
    public class FeriasController : Controller
    {
        private readonly Contexto _context;
        private readonly Isessao _sessao;

        public FeriasController(Contexto context, Isessao sessao)
        {
            _context = context;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            Login login = _sessao.BuscarSessaoDoUsuario();
            List<RelacaoFerias> list = new List<RelacaoFerias>();

            list.Where(x => x.IdFuncionario == login.Id);
            return View(list);
        }

        public IActionResult SolicitarFerias(DateTime DataInicio, DateTime DataFim)
        {
            Login funcionario = _sessao.BuscarSessaoDoUsuario();

            if (funcionario == null)
            {
                TempData["MensagemErro"] = "Usuário não autenticado. Faça o login novamente.";
                return RedirectToAction("Index", "Login");
            }
            else
            {
                int duracaoFerias = (int)(DataFim - DataInicio).TotalDays;

                if (duracaoFerias >= 5 && duracaoFerias <= 30)
                {
                    TempData["MensagemSucesso"] = "Sua solicitação foi aprovada.";

                    return RedirectToAction("Index", "Ferias");
                }
                else
                {
                    TempData["MensagemErro"] = "A duração das férias deve ser entre 5 e 30 dias.";
                }
            }
            return RedirectToAction("Index", "Ferias");
        }

        public IActionResult CadastrarFerias(DateTime DataInicio, DateTime DataFim)
        {
            Login login = _sessao.BuscarSessaoDoUsuario();

            var id = login.Id;

            _context.RelacaoFerias.Add(new RelacaoFerias 
            {
                FeriasInicio = DataInicio,
                FeriasFim = DataFim,
                IdFuncionario = id
            });

            _context.SaveChanges(); 

            return RedirectToAction("Index", "Ferias");
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
