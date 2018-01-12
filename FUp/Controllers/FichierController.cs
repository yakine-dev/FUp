using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FUp.Models;

namespace FUp.Controllers
{
    public class FichierController : Controller
    {
        // GET: Fichier
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(int id)
        {
            Fichier f = new Fichier();
            f.Id = 1;
            f.Nom = "fichier.txt";
            f.Taile = 0.1f;

            return View(f);
        }
    }
}