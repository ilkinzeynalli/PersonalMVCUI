using PersonelMVC.Models;
using PersonelMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Detay(int? id)
        {
            var departman = new Departman() { Id = id.Value, Ad = "Bilgi islem" };
            var personal = new List<Personal>()
            {
                new Personal(){Ad="Personal1"},
                new Personal(){Ad="Personal2"},
                new Personal(){Ad="Personal3"}
            };

            var model = new DepartmanDetayViewModel()
            {
                Departman = departman,
                Personals = personal
            };
            //ViewBag.Departman = departman;
            return View(model);
        }
    }
}