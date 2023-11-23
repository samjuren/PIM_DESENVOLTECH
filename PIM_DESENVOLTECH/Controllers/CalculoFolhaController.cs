using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.GerarFolhaServices;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Controllers
{
    public class CalculoFolhaController : Controller
    {
        private readonly Contexto _context;
        private readonly GerarFolha _gerarFolha;

        public CalculoFolhaController(Contexto context, GerarFolha gerarFolha)
        {
            _context = context;
            _gerarFolha = gerarFolha;
        }
        public IActionResult Index()
        {
          var funcionario = _context.Funcionario.ToList();

            return View(funcionario);
        }
        //teste

        public IActionResult GerarFolhaPagamento()
        {
            _gerarFolha.CalcularFolha();

            var funcionarios = _context.Funcionario.ToList();
            return View("Index", funcionarios);
        }

        public IActionResult VisualizarDesconto(int id,double INSS, double ImpostoDeRenda, double ValeTransporte)
        {
            return View("Descontos", "CalculoFolha");
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
