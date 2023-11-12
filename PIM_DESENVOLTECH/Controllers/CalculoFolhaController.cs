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
            return View();
        }
    }
}
