using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cit218_three_calculators.Models;

namespace cit218_three_calculators.Controllers
{
    public class FormCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(string operation, string operand1, string operand2)
        {
            return View();
        }
    }
}