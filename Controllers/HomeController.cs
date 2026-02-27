using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private LoginEntities1 db = new LoginEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Users()
        {

            var userList = db.Table_1.ToList();


            return View(userList);
        }

        [HttpPost]
        public ActionResult SaveData(Table_1 model)
        {

            try
            {
                db.Table_1.Add(model);
                db.SaveChanges();


                return RedirectToAction("Users");
            }
            catch (Exception ex)
            {

                return Content("เซฟไม่ได้จ้าาา Error: " + ex.Message + " | Inner: " + ex.InnerException?.Message);
            }
        }
    }
}