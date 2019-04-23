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
    public class StylController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Styl
        public async Task<ActionResult> Index()
        {
            return View(await db.Style.ToListAsync());
        }

        public ActionResult PokazStyla()
        {
            string img = "/Img/pobrane.jpg";

            List<Styl> Style = new List<Styl> { new Styl { Nazwa = "Firmowy",
                                                    Opis = "Bukiet \"firmowy\" to nasz flagowy bukiet. Zawsze się podoba!",
                                                    ZdjecieUrl = img },
                                                     new Styl { Nazwa = "Zbity",
                                                    Opis = "Bukiet \"zbity\" to wypełniona po brzegi kwiatami kolorowa kulka:)!",
                                                    ZdjecieUrl = img },
                                                    new Styl { Nazwa = "Polny",
                                                    Opis = "Bukiet \"polny\" chłopsko-rolny",
                                                    ZdjecieUrl = img },
                                                     new Styl { Nazwa = "Biedermeier",
                                                    Opis = "Bukiet w stylu \"biedermeier\" rozjebuje umysł!",
                                                    ZdjecieUrl = img }};


            return View(Style);
        }

        

      
    }
}
