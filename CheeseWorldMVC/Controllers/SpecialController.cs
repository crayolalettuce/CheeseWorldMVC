using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheeseWorldMVC.Models;

namespace CheeseWorldMVC.Controllers
{
    public class SpecialController : Controller
    {
        CheeseWorld_DatabaseEntities1 db = new CheeseWorld_DatabaseEntities1();
        // tblSpecial --->
        //
        // GET: /Special/

        public ActionResult Index()
        {
            return View(db.tblSpecials);
        }

        //
        // GET: /Special/Details/5

        public ActionResult Details(int id)
        {
            return View(db.tblSpecials.Find(id));
        }

        //
        // GET: /Special/Create

        [Authorize(Users="Admin")]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Special/Create

        [HttpPost]
        public ActionResult Create(tblSpecial special)
        {
            try
            {
                // TODO: Add insert logic here
                using (var db = new CheeseWorld_DatabaseEntities1())
                {
                    db.tblSpecials.Add(special);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Special/Edit/5
        [Authorize(Users = "Admin")]
        public ActionResult Edit(int id)
        {
            using (var db = new CheeseWorld_DatabaseEntities1())
            {
                return View();
            }
        }

        //
        // POST: /Special/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, tblSpecial special)
        {
            try
            {
                // TODO: Add update logic here
                using (var db = new CheeseWorld_DatabaseEntities1())
                {
                    db.Entry(special).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Special/Delete/5
        [Authorize(Users = "Admin")]
        public ActionResult Delete(int id)
        {
            using (var db = new CheeseWorld_DatabaseEntities1())
            {
                return View();
            }
        }

        //
        // POST: /Special/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, tblSpecial special)
        {
            try
            {
                // TODO: Add delete logic here
                using (var db = new CheeseWorld_DatabaseEntities1())
                {
                    db.Entry(special).State = System.Data.EntityState.Deleted;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
