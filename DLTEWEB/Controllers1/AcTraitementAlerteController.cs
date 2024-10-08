using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEv3.Controllers
{
    public class AcTraitementAlerteController : Controller
    {
        // GET: AcTraitementAlerte
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TraitementActivité()
        {
            return View();
        }

        // GET: AcTraitementAlerte/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcTraitementAlerte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcTraitementAlerte/Create
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

        // GET: AcTraitementAlerte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcTraitementAlerte/Edit/5
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

        // GET: AcTraitementAlerte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcTraitementAlerte/Delete/5
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
