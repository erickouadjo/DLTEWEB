﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEv3.Controllers
{
    public class AcSuiviEvaluationController : Controller
    {
        // GET: AcSuiviEvaluation
        public ActionResult Index()
        {
            return View();
        }

        // GET: AcSuiviEvaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcSuiviEvaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcSuiviEvaluation/Create
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

        // GET: AcSuiviEvaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcSuiviEvaluation/Edit/5
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

        // GET: AcSuiviEvaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcSuiviEvaluation/Delete/5
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
