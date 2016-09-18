using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ClientForKOMK.Controllers
{
    // Это - контроллер
    public class HomeController : AsyncController
    {

        KOMK_v11_Procedure_BasePackEntities db = new KOMK_v11_Procedure_BasePackEntities();
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
        public ActionResult hDish(int? id)
        {
            int DishIdInt;
            if (int.TryParse("2", out DishIdInt))
            //test pGetDishComposition(dishId)
            {
                DishIdInt = 2;
                IEnumerable<pGetDishComposition_Result> GetDish = db.pGetDishComposition(DishIdInt);
                ViewBag.pGetDishComposition = GetDish;
                return View();
            }
            else
            {
                IEnumerable<pGetDishComposition_Result> GetDish = db.pGetDishComposition(DishIdInt);
                ViewBag.pGetDishComposition = GetDish;
                return View();
            }
        }
        //public async Task<ActionResult> hDishList()
        //{

        //    int DishId = 2;
        //    //test pGetDishComposition(dishId)
        //    IEnumerable<pGetDishComposition_Result> GetDish = await db.pGetDishComposition(DishId).ToListAsync();
        //    ViewBag.pGetDishComposition = GetDish;
        //    return View("hDish");
        //}

    }
}