using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRepo.Models;
using MVCRepo.Repository;

namespace MVCRepo.Controllers
{
    public class PersoonController : Controller
    {
        // GET: Persoon
        public ActionResult Index()
        {
            PersoonRepo persoon = new PersoonRepo();
            PersoonModel pm = persoon.laad(1712556789);

            return View(pm);
        }
        
        public ActionResult Save(PersoonModel newPersoon)
        {
            ModelState.Clear();

            newPersoon.BSN = 1712556700;

            PersoonRepo persoonOpslag = new PersoonRepo();
            persoonOpslag.slaOp(newPersoon);

            return View("Index", newPersoon);
        }
    }
}