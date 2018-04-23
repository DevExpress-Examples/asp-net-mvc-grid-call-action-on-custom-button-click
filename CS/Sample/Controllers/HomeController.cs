using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using Sample.Models;

namespace Sample.Controllers {
    public class HomeController : Controller {
        PersonsList list = new PersonsList();

        public ActionResult Index() {
            return View(list.GetPersons());
        }

        public ActionResult GridViewPartial() {
            return PartialView(list.GetPersons());
        }

        public ActionResult About(int id) {
            ViewData["Key"] = id;
            return View();
        }
    }
}