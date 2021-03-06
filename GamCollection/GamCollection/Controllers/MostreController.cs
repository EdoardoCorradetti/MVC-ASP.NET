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
            //List of the first 100 Mostre
            var mostre = db.Mostre.Take(100).ToList();
            return View(mostre);
        }

        public ActionResult Mostra(int id)
        {
            var mostra = db.Mostre.Find(id);
            if (mostra == null)
                return HttpNotFound();
            return View(mostra);
        }
    }
}