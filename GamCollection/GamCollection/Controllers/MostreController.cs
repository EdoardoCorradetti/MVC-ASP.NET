using GamCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamCollection.Controllers
{
    public class MostreController : Controller
    {
        private CollezioniContext db = new CollezioniContext();
        // GET: Mostre
        public ActionResult Index()
        {
            var mostre = db.Mostre.ToList();
            return View(mostre);
        }
    }
}