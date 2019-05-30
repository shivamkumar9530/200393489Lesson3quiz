using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication6.Models;
namespace WebApplication6.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
    {
    new Car {Id  = 1, Brand = "Toyota", Model = "Corrola", Type = "Compact", Year = 2017},
    new Car {Id  = 2, Brand = "Ford", Model = "f-150",Type = "Truck", Year = 2016},
    new Car {Id  = 3, Brand = "Dodge", Model = "Caravan",Type = "Minivan", Year = 2018}
        };


        public ActionResult Index()
        {

            return View();

        }






        public ActionResult Details(int? id)
        {
            if (id == null || id > carList.Count)
            {
                return Content("Invalid car Id ");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }

        public ActionResult page()
        {

            return View(page);

        }

        private ActionResult View(Func<ActionResult> page)
        {
            throw new NotImplementedException();
        }
    }
}

