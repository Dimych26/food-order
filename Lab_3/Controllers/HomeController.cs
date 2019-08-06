using BLL.Interfaces;
using BLL.ModelDTO;
using Lab_3.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace Lab_3.Controllers
{
    public class HomeController : Controller
    {
        IDishLogic dishLogic;
        // GET: api/Dish

        public HomeController(IDishLogic logic)
        {

            dishLogic = logic;

        }
        public HomeController()
        {
            dishLogic = UIDependencyResolver<IDishLogic>.ResolveDependency();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Dish()
        {
            return View();
        }

        public ActionResult GetAllDish()
        {
            //List<SelectListItem> list = new List<SelectListItem>
            //{

            //    new SelectListItem { Text = dishLogic.GetAll().ElementAt(0).Name, Value = dishLogic.GetAll().ElementAt(0).Price.ToString() }
            //};
            //ViewBag.List = list;
            return View(dishLogic.GetAll());
        }
        [HttpPost]
        public string Index(IEnumerable<SelectListItem> List)
        {
            string result = "";
            int price = 0;
            foreach (var c in List)
            {
                result += c.Text;//.Name;
                result += ";";
                price += Convert.ToInt32(c.Value);
            }
            return "Вы выбрали: " + result + price;
        }
    }
}
