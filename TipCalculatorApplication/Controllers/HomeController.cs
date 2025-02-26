using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TipCalculatorApplication.Models;

namespace TipCalculatorApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Calculate(decimal mealCost)
        {
            if (mealCost <= 0)
            {
                ViewBag.Error = "Please enter a valid meal cost greater than 0.";
                return View("Index");
            }

            var tipCalculator = new TipCalculator { MealCost = mealCost };
            ViewBag.Tip15 = tipCalculator.CalculateTip(0.15m);
            ViewBag.Tip20 = tipCalculator.CalculateTip(0.20m);
            ViewBag.Tip25 = tipCalculator.CalculateTip(0.25m);

            return View("Index");
        }
    }
}
