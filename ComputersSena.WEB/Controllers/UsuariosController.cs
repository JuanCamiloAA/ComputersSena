using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputersSena.WEB.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult usuarios()
        {
            return View();
        }
    }
}
