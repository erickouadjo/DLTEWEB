using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEv3.Controllers
{
    public class AcCartographieController : Controller
    {
        // GET: AcCartographie
        public ActionResult Index()
        {
            return View();
        }

        // GET: AcCartographie
        public ActionResult Index1()
        {
            return View();
        }

        // GET: AcCartographie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcCartographie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcCartographie/Create
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

        // GET: AcCartographie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcCartographie/Edit/5
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

        // GET: AcCartographie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcCartographie/Delete/5
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
