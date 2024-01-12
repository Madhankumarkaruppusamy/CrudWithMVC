using EntityFrameworkMVC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMadhan.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegistrationRepository _add;
        private readonly string _connectionstring;
        public RegisterController(IRegistrationRepository add, IConfiguration configuration)
        {
            _add = add;
            _connectionstring = configuration.GetConnectionString("DbConnection");
        }
        // GET: RegisterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegisterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterController/Create
        public ActionResult Create()
        {
            var result = new Registration();
            return View("Register",result);
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Registration value)
        {
            var result = _add.Login(value);
            try
            {
                if (result == true)
                {
                    _add.Insert(value);
                    return Redirect("/Login/Index");
                }
                else
                {
                    return View("Register");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
