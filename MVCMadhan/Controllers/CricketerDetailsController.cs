using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

namespace MVCMadhan.Controllers
{
    public class CricketerDetailsController : Controller
    {
        private readonly ICricketerRepository _obje;

        public CricketerDetailsController()
        {
            _obje = new CricketerRepository();
        }
        // GET: CricketerDetailsController
        public ActionResult Index()
        {
            var result = _obje.ReadSP();
            return View("View",result);
        }

        // GET: CricketerDetailsController/Details/5
        public ActionResult Details(int id)
        {
            var result = _obje.ReadSPById(id);
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
        public ActionResult Create(Cricketer pro)
        {
            try
            {
                _obje.InsertSP(pro);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CricketerDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _obje.ReadSPById(id);
            return View("Edit",result);
        }

        // POST: CricketerDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cricketer pro)
        {
            try
            {
                _obje.Update(id, pro);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CricketerDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _obje.ReadSPById(id);
            return View("Delete",result);
        }

        // POST: CricketerDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteById(int id)
        {
            try
            {
                _obje.DeleteSPById(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
