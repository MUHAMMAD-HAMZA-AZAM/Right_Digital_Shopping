using RDS_Entities;
using RDS_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDB_Website.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productsServices = new ProductServices();
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductTable(string search)

        {
            var products = productsServices.GetProducts();
           // call is nulloremplty built in function for search
            if (string.IsNullOrEmpty(search) == false)
            {
                //Linq Query
                products = products.Where(p => p.Name !=null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsServices.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var product = productsServices.GetProduct(Id);
            return PartialView(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productsServices.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var product = productsServices.GetProduct(Id);
            return PartialView(product);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            productsServices.DeleteProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            var product = productsServices.GetProduct(Id);
            return View(product);

        }

    }
}