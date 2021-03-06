using GamCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamCollection.Controllers
{
    public class AutoriController : Controller
    {
        private CollezioniContext db = new CollezioniContext();
        // GET: Autori
        public ActionResult Index()
        {
            return View(db.Autori.ToList());
        }
        public ActionResult ListMostre(int id)
        {
            return View(mostre);
        }
    }
}