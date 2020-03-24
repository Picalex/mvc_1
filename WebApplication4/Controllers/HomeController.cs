using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models.DataContext.Tables;
using WebApplication4.Models.DataContext;
using System.Web.Mvc.Html;
using System.Data.Entity;
using System.Web.Mvc.Routing;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {

      HomeContext db = new HomeContext ();
        public ActionResult Index()
        {
            var names = db.TbEmployers.Include(p => p.TWork);
            return View(names.ToList());
        }

        //public ActionResult Index()
        //{
        //    IEnumerable<TbWork> Works = db.TbWorks;
        //    ViewBag.Works = Works;           
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Add()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public ActionResult add(TbWork label)
        //{
        //    db.TbWorks.Add(label);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    TbWork work = db.TbWorks.Find(id);
        //    if (work != null)
        //    {
        //        return View(work);
        //    }
        //    return HttpNotFound();
        //}
        //[HttpPost]
        //public ActionResult Edit(TbWork label)
        //{
        //    db.Entry(label).State = EntityState.Modified;         
        //    db.SaveChanges();
        //     return Redirect("/Home/Index");
        //}
        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //   TbWork b = db.TbWorks.Find(id);
        //    if (b == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(b);
        //}
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    TbWork b = db.TbWorks.Find(id);
        //    if (b == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    db.TbWorks.Remove(b);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}