using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class Usuarios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

    }
}
