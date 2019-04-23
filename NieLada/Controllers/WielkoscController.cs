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
    public class WielkoscController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Wielkosc
        public async Task<ActionResult> Index()
        {
            return View(await db.Wielkosci.ToListAsync());
        }

        public ActionResult PokazWielkosc()
        {
            string img = "/Img/pobrane.jpg";

            List<Wielkosc> Wielkosci = new List<Wielkosc> { new Wielkosc { Nazwa = "Malutki",
                                                    Numer=1,
                                                    Opis = "Dla małych dziewczynak",
                                                    ZdjecieUrl = img },
                                                     new Wielkosc { Nazwa = "Mały",
                                                     Numer=2,
                                                    Opis = "Dla trochę większych dziewczynek",
                                                    ZdjecieUrl = img },
                                                    new Wielkosc { Nazwa = "Średni na Jeża",
                                                    Numer=3,
                                                    Opis = "Idealny na wszelakie okazje",
                                                    ZdjecieUrl = img },
                                                     new Wielkosc { Nazwa = "Duży",
                                                     Numer=4,
                                                    Opis = "Całkiem dojebany",
                                                    ZdjecieUrl = img },
                                                    new Wielkosc { Nazwa = "Ogromny",
                                                     Numer=5,
                                                    Opis = "Nawet jak totalnie zjebałeś:)",
                                                    ZdjecieUrl = img },
                                                    new Wielkosc { Nazwa = "Mega",
                                                     Numer=6,
                                                    Opis = "Nie ogarniesz",
                                                    ZdjecieUrl = img }
            };
            var wielkosc = new Wielkosc { };


            ViewBag.IloscWielkosci = wielkosc.Ilosc;
            return View(Wielkosci);
        }



        // POST: Wielkosc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nazwa,Numer,ZdjecieUrl,Opis")] Wielkosc wielkosc)
        {
            if (ModelState.IsValid)
            {
                db.Wielkosci.Add(wielkosc);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(wielkosc);
        }

       
    }
}
