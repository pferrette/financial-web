using Microsoft.AspNetCore.Mvc;

namespace Financial_Web.Controllers
{
    public class GastosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EditGastos()
        {
            return View();
        }
    }
}
