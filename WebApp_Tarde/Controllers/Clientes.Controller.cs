﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class Clientes : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
