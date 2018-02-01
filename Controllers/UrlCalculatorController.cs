using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cit218_three_calculators.Models;

namespace cit218_three_calculators.Controllers
{
    public class UrlCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string operand1, string operand2)
        {
            ViewBag.Message = "";
            ViewBag.Operand1 = operand1;
            ViewBag.Operand2 = operand2;

            if (operand1 != "" && operand2 != "")
            {
                double sum = double.Parse(operand1) + double.Parse(operand2);
                ViewBag.Sum = sum;
            }
            else
            {
                ViewBag.Message = "It appears you did not supply two operands";
            }

            return View();
        }
    }
}