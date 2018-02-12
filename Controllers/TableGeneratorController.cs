using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace cit218_three_calculators.Controllers
{
    public class TableGeneratorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string temperature, string windSpeed)
        {
            double temperatureNum=0;
            double windSpeedNum=0;
            List<string> errorMessageText = new List<string>();
            ViewBag.errorMessage = null;

            if (!(double.TryParse(temperature, out temperatureNum)) || !(double.TryParse(windSpeed, out windSpeedNum)))
            {
                errorMessageText.Add("It appears that you did not enter valid numbers.");
                errorMessageText.Add("Please click the Try Again button below to re-enter your numbers.");
            }

            ViewBag.errorMessage = errorMessageText;
            ViewBag.Temperature = temperatureNum;
            ViewBag.WindSpeed = windSpeedNum;
            return View("DisplayTable");
        }
    }
}