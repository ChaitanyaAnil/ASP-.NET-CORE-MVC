using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieWebAPP.Models;

namespace MovieWebAPP
{
    public class MultiplexesController : Controller
    {
        private MovieDbEntities db = new MovieDbEntities();

        // GET: Multiplexes
        /*   public ActionResult Index()
           {
               var multiplexes = db.Multiplexes.Include(m => m.Movie);
               return View(multiplexes.ToList());
           }*/
        public ActionResult Index(string SearchText)
        {
            var model = db.Multiplexes.ToList();
            if (!string.IsNullOrEmpty(SearchText))
            {
                model = model.Where(s => s.Multiplex_Name
                .Contains(SearchText)).ToList();
            }
            return View(model);
        }

        // GET: Multiplexes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multiplex multiplex = db.Multiplexes.Find(id);
            if (multiplex == null)
            {
                return HttpNotFound();
            }
            return View(multiplex);
        }

        // GET: Multiplexes/Create
        public ActionResult Create()
        {
            ViewBag.MovieMovie_id = new SelectList(db.Movies, "Movie_id", "Movie_Name");
            return View();
        }

        // POST: Multiplexes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Multiplex_id,Multiplex_Name,Location,Movie_id,MovieMovie_id")] Multiplex multiplex)
        {
            if (ModelState.IsValid)
            {
                db.Multiplexes.Add(multiplex);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieMovie_id = new SelectList(db.Movies, "Movie_id", "Movie_Name", multiplex.MovieMovie_id);
            return View(multiplex);
        }

        // GET: Multiplexes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multiplex multiplex = db.Multiplexes.Find(id);
            if (multiplex == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieMovie_id = new SelectList(db.Movies, "Movie_id", "Movie_Name", multiplex.MovieMovie_id);
            return View(multiplex);
        }

        // POST: Multiplexes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Multiplex_id,Multiplex_Name,Location,Movie_id,MovieMovie_id")] Multiplex multiplex)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multiplex).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieMovie_id = new SelectList(db.Movies, "Movie_id", "Movie_Name", multiplex.MovieMovie_id);
            return View(multiplex);
        }

        // GET: Multiplexes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Multiplex multiplex = db.Multiplexes.Find(id);
            if (multiplex == null)
            {
                return HttpNotFound();
            }
            return View(multiplex);
        }

        // POST: Multiplexes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Multiplex multiplex = db.Multiplexes.Find(id);
            db.Multiplexes.Remove(multiplex);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
