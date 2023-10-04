using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kahvedükkanı.Models.Siniflar;
namespace kahvedükkanı.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.AnaSayfas.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult NewCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCategory(AnaSayfa anaSayfa)
        {
            context.AnaSayfas.Add(anaSayfa);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCategory(int id)
        {
            var r = context.AnaSayfas.Find(id);
            context.AnaSayfas.Remove(r);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult FindCategory(int id)
        {
            var cat = context.AnaSayfas.Find(id);
            return View("FindCategory", cat);
        }
        public ActionResult UpdateCategory(AnaSayfa anaSayfa)
        {
            var cat = context.AnaSayfas.Find(anaSayfa.CategoryID);
            cat.CategoryName = anaSayfa.CategoryName;
            cat.CategoryImgUrl = anaSayfa.CategoryImgUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }




        // @ @ @ @ @ PRODUCT PART @ @ @ @ @
        [Authorize]
        public ActionResult ListProduct()
        {
            var product = context.Menus.ToList();
            return View(product);
        }
        [HttpGet]
        public ActionResult NewProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewProduct(Menu menu)
        {
            context.Menus.Add(menu);
            context.SaveChanges();
            return RedirectToAction("ListProduct");
        }
        public ActionResult RemoveProduct(int id)
        {
            var r = context.Menus.Find(id);
            context.Menus.Remove(r);
            context.SaveChanges();
            return RedirectToAction("ListProduct");
        }

        public ActionResult FindProduct(int id)
        {
            var prod = context.Menus.Find(id);
            return View("FindProduct", prod);
        }
        public ActionResult UpdateProduct(Menu menu)
        {
            var prod = context.Menus.Find(menu.ProductID);
            prod.ProductName = menu.ProductName;
            prod.ProductImgUrl = menu.ProductImgUrl;
            prod.CategoryID = menu.CategoryID;
            //prod.CategoryName = menu.CategoryName;

            context.SaveChanges();
            return RedirectToAction("ListProduct");
        }
    }
}