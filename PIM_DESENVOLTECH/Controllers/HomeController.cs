using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.Models;
using System.Diagnostics;

namespace PIM_DESENVOLTECH.Controllers
{
    public class HomeController : Controller
    {
        private readonly Contexto _context;

        public HomeController(Contexto context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ApontamentoHoras()
        {
            return RedirectToAction("Index", "ApontamentoHoras");
        }

        public IActionResult CadastrarFuncionario() 
        {
            return RedirectToAction("Index", "CadastrarFuncionario");
        }
    }
}