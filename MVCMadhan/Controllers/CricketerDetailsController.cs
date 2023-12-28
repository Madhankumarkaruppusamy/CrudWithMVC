using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;
using Microsoft.Extensions.Configuration;

namespace MVCMadhan.Controllers
{
    public class CricketerDetailsController : Controller
    {
        private readonly ICricketerRepository _obj;
        private readonly string _connectionstring;
        public CricketerDetailsController(ICricketerRepository result, IConfiguration configuration)
        {
            _obj = result;
            _connectionstring = configuration.GetConnectionString("DbConnection");
        }
        // GET: CricketerDetailsController
        public ActionResult Index()
        {
            var result = _obj.ReadSP();
            return View("View",result);
        }

        // GET: CricketerDetailsController/Details/5
        public ActionResult Details(int id)
        {
            var result = _obj.ReadSPById(id);
            return View("Details",result);
        }

        // GET: CricketerDetailsController/Create
        public ActionResult Create()
        {
            return View("Create",new Cricketer ());
        }

        // POST: CricketerDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cricketer add)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _obj.InsertSP(add);
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    return View("View",add);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: CricketerDetailsController/Edit/5
        public ActionResult Edit(long id)
        {
            var result = _obj.ReadSPById(id);
            return View("Edit",result);
        }

        // POST: CricketerDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, Cricketer update)
        {
            try
            {
                _obj.UpdateSP(id, update);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CricketerDetailsController/Delete/5
        public ActionResult Delete(long id)
        {
            var result = _obj.ReadSPById(id);
            return View("Delete",result);
        }

        // POST: CricketerDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id,Cricketer result)
        {
            try
            {
                _obj.DeleteSP(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
