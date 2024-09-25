using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEv3.Controllers
{
    public class AcTableauBordController : Controller
    {
        // GET: AcTableauBord
        public ActionResult Index()
        {
            return View();
        }

        // GET: AcTableauBord/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcTableauBord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcTableauBord/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AcTableauBord/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcTableauBord/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AcTableauBord/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcTableauBord/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
