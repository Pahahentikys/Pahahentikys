using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientForKOMK.Controllers
{
    // Это - контроллер
    public class HomeController : Controller
    {

        KOMK_v6Entities db = new KOMK_v6Entities();
        public ActionResult Index()
        {
            return View();
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
        public ActionResult hDish()
        {
            int DishId = 2;
            //test pGetDishComposition(dishId)
            IEnumerable<pGetDishComposition_Result> GetDish = db.pGetDishComposition(DishId);
            ViewBag.pGetDishComposition = GetDish;
            return View();
        }
    }
}