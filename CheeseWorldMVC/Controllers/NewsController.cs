using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheeseWorldMVC.Models;

namespace CheeseWorldMVC.Controllers
{
    public class NewsController : Controller
    {
        CheeseWorld_DatabaseEntities1 db = new CheeseWorld_DatabaseEntities1();
        //
        // GET: /News/

        public ActionResult Index()
        {
            return View(db.tblNews);
        }

        //
        // GET: /News/Details/5

        public ActionResult Details(int id)
        {
            return View(db.tblNews.Find(id));
        }

        //
        // GET: /News/Create
        [Authorize(Users = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /News/Create

        [HttpPost]
        public ActionResult Create(tblNew news)
        {
            try
            {
                // TODO: Add insert logic here
                using (var db = new CheeseWorld_DatabaseEntities1())
                {
                    db.tblNews.Add(news);
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
        // GET: /News/Edit/5
        [Authorize(Users = "Admin")]
        public ActionResult Edit(int id)
        {
            using  (var db = new CheeseWorld_DatabaseEntities1())
            {
                return View(db.tblNews.Find(id));
            }
        }

        //
        // POST: /News/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, tblNew news)
        {
            try
            {
                // TODO: Add update logic here
                using (var db = new CheeseWorld_DatabaseEntities1())
                {
                    db.Entry(news).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /News/Delete/5
        [Authorize(Users = "Admin")]
        public ActionResult Delete(int id)
        {
            using (var db = new CheeseWorld_DatabaseEntities1())
            {
                return View(db.tblNews.Find(id));
            }
        }

        //
        // POST: /News/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, tblNew news)
        {
            try
            {
                // TODO: Add delete logic here
                using (var db = new CheeseWorld_DatabaseEntities1())
                {
                    db.Entry(news).State = System.Data.EntityState.Deleted;
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
