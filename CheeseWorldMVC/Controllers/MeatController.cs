using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheeseWorldMVC.Models;

namespace CheeseWorldMVC.Controllers
{
    public class MeatController : Controller
    {
        CheeseWorld_DatabaseEntities1 db = new CheeseWorld_DatabaseEntities1();
        //
        // GET: /Meat/

        public ActionResult Index()
        {
            return View(db.tblMeats);
        }

        //
        // GET: /Meat/Details/5

        public ActionResult Details(int id)
        {
            return View(db.tblMeats.Find(id));
        }

        //
        // GET: /Meat/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /Meat/Create

        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /Meat/Edit/5

        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Meat/Edit/5

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /Meat/Delete/5

        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Meat/Delete/5

        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
