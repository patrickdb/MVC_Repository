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
            PersoonModel persoon = new PersoonModel();
            persoon.Naam = "Pietje";

            return View(persoon);
        }
        
        public ActionResult Save(PersoonModel persoon)
        {
            return View("Index", persoon);
        }
    }
}