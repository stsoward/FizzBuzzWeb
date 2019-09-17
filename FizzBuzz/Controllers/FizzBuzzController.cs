using FizzBuzz.BusinessLayer;
using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculateFizzBuzz(FizzBuzzModel fizzBuzzModel)
        {
            InRange inRange = new InRange();
            if (inRange.IsInRange(fizzBuzzModel.input))
            {
                StringList stringList = new StringList();
                fizzBuzzModel.result = stringList.NumList(fizzBuzzModel.input);
            }
            else
            {
                fizzBuzzModel.result = "The number was not in range, Please try again.";
            }

            return View(fizzBuzzModel);
        }
    }
}