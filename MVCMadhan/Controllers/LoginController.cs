using DapperDataAccessLayer;
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
    public class LoginController : Controller
    { 
        private readonly IRegistrationRepository _reg;
        private readonly string Connection;
        public LoginController(IRegistrationRepository Obj, IConfiguration configuration)
        {
            _reg = Obj;
            Connection = configuration.GetConnectionString("Dbconnection");
        }
        // GET: LoginController
        public ActionResult Index()
        {
            return View("Login");
        }

        // GET: LoginController/Details/5
        public ActionResult Details(long id)
        {
            var data = _reg.GetByid(id);
            return View("View", data);
        }

        // GET: LoginController/Create
        public ActionResult Create(Registration Obj)
        {
            try
            {
                var Get = _reg.Register(Obj);
                if (Get == true)
                {
                    var get = _reg.GetAllRegistration();
                    return View("View", get);

                }
                else
                {
                    return View("Login");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(Registration id)

        {
            var data = _reg.GetAllRegistration();
            return View("Edit", data);
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            var send = _reg.GetByid(id);
            return View("Delete", send);
        }

        // POST: LoginController/Delete/5
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

        // GET: LoginController/Authentication/
        public ActionResult Authentication(Registration log)
        {
            try
            {
                var result = _reg.Register(log);
                if (result = true)
                {
                    return Redirect("/Home/Index");

                }
                else
                {
                    ModelState.AddModelError("Password", "Invalid EmailID and Password");
                    return View("Login");
                }
            
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
