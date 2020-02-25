using RDB_Website.HomeViewModel;
using RDS_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDB_Website.Controllers
{
    public class HomeController : Controller
    {
        CategoriesServices categoryservice = new CategoriesServices();

        public ActionResult Index()
        {
            Category_Product_ViewModel model = new Category_Product_ViewModel();
            model.Categories = categoryservice.GetCategories();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}