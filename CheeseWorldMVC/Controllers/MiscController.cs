using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheeseWorldMVC.Models;

namespace CheeseWorldMVC.Controllers
{
    public class MiscController : Controller
    {
        CheeseWorld_DatabaseEntities1 db = new CheeseWorld_DatabaseEntities1();
        //
        // GET: /Misc/

        public ActionResult Index()
        {
            return View(db.tblMiscProducts);
        }

        //
        // GET: /Misc/Details/5

        public ActionResult Details(int id)
        {
            return View(db.tblMiscProducts.Find(id));
        }

        //
        // GET: /Misc/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /Misc/Create

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
        //// GET: /Misc/Edit/5

        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Misc/Edit/5

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
        //// GET: /Misc/Delete/5

        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Misc/Delete/5

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
