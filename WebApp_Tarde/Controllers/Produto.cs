using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class Produto : Controller
    {
        private readonly Contexto db;

        public Produto(Contexto opt)
        {
            db = opt;
        }

        public IActionResult Lista()
        {
            return View(db.Produtos.ToList());
        }
    }
}
   
