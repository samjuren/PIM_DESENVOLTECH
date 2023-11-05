using Microsoft.AspNetCore.Mvc;

namespace PIM_DESENVOLTECH.Controllers
{
    public class PaginaFrenteLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
