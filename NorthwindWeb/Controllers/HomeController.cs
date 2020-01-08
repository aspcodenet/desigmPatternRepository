using NorthwindWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class HomeController : Controller
    {
        private ISupplierRepository repository = new FakeSupplierRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var model = repository.GetAll();

            return View(model);
        }

        public ActionResult Supplier(int ID)
        {
            var model = repository.Get(ID);
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}