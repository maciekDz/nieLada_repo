using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NieLada.Models;

namespace NieLada.Controllers
{
    public class GestoscController : Controller
    {
        private ApplicationDbContext db;
        //private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Gestosc
        public async Task<ActionResult> Index()
        {
            return View(await db.Gestosci.ToListAsync());
        }

        public ActionResult PokazGestosc()
        {
            string img = "/Img/pobrane.jpg";

            List<Gestosc> Wielkosci = new List<Gestosc> { new Gestosc { Nazwa = "Chudzitki",
                                                    Numer=1,
                                                    Opis = "Do 30% kwiatów",
                                                    ZdjecieUrl = img },
                                                     new Gestosc { Nazwa = "Standartowy",
                                                     Numer=2,
                                                    Opis = "Do 50% kwiatów",
                                                    ZdjecieUrl = img },
                                                    new Gestosc { Nazwa = "Wypchany",
                                                    Numer=3,
                                                    Opis = "Do 75% kwiatów",
                                                    ZdjecieUrl = img },
                                                     new Gestosc { Nazwa = "Przegięty",
                                                     Numer=4,
                                                    Opis = "Do 100% kwiatów",
                                                    ZdjecieUrl = img }
            };
            var gestosc = new Gestosc { };


            ViewBag.IloscGestosci = gestosc.Ilosc;
            return View(Wielkosci);
        }
    }
}
