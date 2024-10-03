using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEv3.Controllers
{
    public class AcCollecteDonneesController : Controller
    {

        // GET: AcCollecteDonnees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form1()
        {
            return View();
        }
        public ActionResult listeForm1()
        {
            return PartialView("_listeForm1");
        }

        public ActionResult Form2()
        {
            return View();
        }
        public ActionResult listeForm2()
        {
            return PartialView("_listeForm2");
        }
        public ActionResult Form3()
        {
            return View();
        }
        public ActionResult listeForm3()
        {
            return PartialView("_listeForm3");
        }
        public ActionResult Form4()
        {
            return View();
        }
        public ActionResult listeForm4()
        {
            return PartialView("_listeForm4");
        }
        public ActionResult Form5()
        {
            return View();
        }
        public ActionResult listeForm5()
        {
            return PartialView("_listeForm5");
        }
        public ActionResult Form6()
        {
            return View();
        }
        public ActionResult listeForm6()
        {
            return PartialView("_listeForm6");
        }

        // GET: AcCollecteDonnees/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcCollecteDonnees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcCollecteDonnees/Create
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

        // GET: AcCollecteDonnees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcCollecteDonnees/Edit/5
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

        // GET: AcCollecteDonnees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcCollecteDonnees/Delete/5
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
