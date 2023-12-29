using DapperDataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMadhan.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("View");
        }
    }
}
