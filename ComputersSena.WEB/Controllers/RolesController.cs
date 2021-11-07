using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputersSena.WEB.Controllers
{
    public class RolesController : Controller
    {
        public IActionResult Roles()
        {
            return View();
        }
    }
}
