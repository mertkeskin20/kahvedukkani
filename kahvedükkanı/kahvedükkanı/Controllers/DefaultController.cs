using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kahvedükkanı.Models.Siniflar;

namespace kahvedükkanı.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.AnaSayfas.ToList();
            return View(degerler);
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public ActionResult Menu()
        //{
        //    return View();
        //}
    }
}