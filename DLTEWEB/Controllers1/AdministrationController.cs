using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DLTEWEB.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Administration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChargerProfilVuePartiel()
        {
            return PartialView("_ChargerProfilVuePartiel");
        }
        public ActionResult ChargerAccesVuePartiel()
        {
            return PartialView("_ChargerAccesVuePartiel");
        }
        public ActionResult ChargerUtilisateurVuePartiel()
        {
            return PartialView("_ChargerUtilisateurVuePartiel");
        }
        public ActionResult ChargerParametreVuePartiel()
        {
            return PartialView("_ChargerParametreVuePartiel");
        }
        public ActionResult ChargerSecuriteVuePartiel()
        {
            return PartialView("_ChargerSecuriteVuePartiel");
        }
        public ActionResult ChargerSecteurVuePartiel()
        {
            return PartialView("_ChargerSecteurVuePartiel");
        }
    }
}