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
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace NieLada.Controllers
{
    [Authorize]
    public class ZamowienieController : Controller
    {



        private ApplicationDbContext db = new ApplicationDbContext();
        public ZamowienieController()
        {
            db = new ApplicationDbContext();
        }

        //private IApplicationDbContext db = new ApplicationDbContext();
        //public ZamowienieController(IApplicationDbContext dbContext)
        //{
        //    db = dbContext;
        //}

        // GET: Zamowienie
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            string sUser = user.ToString();

            var zamowieniaUrzytkownika = db.Zamowienia.Where(m => m.KontoUzytkownikaId == sUser).ToList();

            return View(zamowieniaUrzytkownika);
        }

        

        //GET: Zamowienie/Details/5
        //[Authorize]
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Zamowienie zamowienie = await db.Zamowienia.FindAsync(id);
        //    if (zamowienie == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(zamowienie);
        //}

        // GET: Zamowienie/Create
        public ActionResult Create()
        {
            Zamowienie zamowienie = new Zamowienie { KontoUzytkownikaId = User.Identity.GetUserId(), KiedyZlozone = DateTime.Now };
            return View(zamowienie);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Create( Zamowienie zamowienie)
        { 
            if (ModelState.IsValid)
            {
                db.Zamowienia.Add(zamowienie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zamowienie);
        }

       
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zamowienie zamowienie =  db.Zamowienia.Find(id);
            if (zamowienie == null)
            {
                return HttpNotFound();
            }
            return View(zamowienie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Zamowienie zamowienie)
        {
            {
                if (ModelState.IsValid)
                {
                    //db.Entry(zamowienie).State = EntityState.Modified;
                    Zamowienie zam = db.Zamowienia.FirstOrDefault(x => x.Id == zamowienie.Id);
                    zam.Nazwa = zamowienie.Nazwa;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(zamowienie);
            }
        }


        // GET: Zamowienie/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Zamowienie zamowienie = await db.Zamowienia.FindAsync(id);
        //    if (zamowienie == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(zamowienie);
        //}

        // POST: Zamowienie/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Zamowienie zamowienie = await db.Zamowienia.FindAsync(id);
        //    db.Zamowienia.Remove(zamowienie);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
