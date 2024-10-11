using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEv3.Controllers
{
    public class AcCommunicationController : Controller
    {
        // GET: AcCommunication
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bibliotheque()
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

        public ActionResult listeForm2()
        {
            return PartialView("_listeForm2");
        }
        public ActionResult listeForm3()
        {
            return PartialView("_listeForm3");
        }
       
        public ActionResult listeForm4()
        {
            return PartialView("_listeForm4");
        }

        // GET: AcCommunication/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcCommunication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcCommunication/Create
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

        // GET: AcCommunication/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcCommunication/Edit/5
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

        // GET: AcCommunication/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcCommunication/Delete/5
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
