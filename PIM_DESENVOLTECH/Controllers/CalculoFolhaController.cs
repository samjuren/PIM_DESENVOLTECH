using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Controllers
{
    public class CalculoFolhaController : Controller
    {
        private readonly Contexto _context;

        public CalculoFolhaController(Contexto context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          var funcionario = _context.Funcionario.ToList();
            

            return View(funcionario);
        }

        public IActionResult VisualizarDesconto()
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
