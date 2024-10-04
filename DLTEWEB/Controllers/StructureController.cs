using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEv3.Controllers
{
    public class StructureController : Controller
    {
        // GET: Structure
        public ActionResult Index()
        {
            return View();
        }

        // GET: Structure/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Structure/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Structure/Create
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

        // GET: Structure/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Structure/Edit/5
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

        // GET: Structure/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Structure/Delete/5
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
