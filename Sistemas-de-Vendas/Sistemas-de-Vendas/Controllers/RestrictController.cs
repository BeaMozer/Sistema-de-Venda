using Microsoft.AspNetCore.Mvc;

namespace Sistemas_de_Vendas.Controllers
{
    public class RestrictController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
