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
        BaseCalculator calculator; 
        public UrlCalculatorController()
        {
            calculator = new BaseCalculator();
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string operand1, string operand2)
        {
            ViewBag.Message = "";
            ViewBag.ValidResult = false;
            ViewBag.Operand1 = operand1;
            ViewBag.Operand2 = operand2;

            if (operand1 != "" && operand2 != "")
            {
               try
               {
                   double sum = calculator.Add(operand1, operand2);
                   ViewBag.Sum = sum;
                   ViewBag.ValidResult = true;
               }
               catch (Exception e)
               {
                   ViewBag.Message = e.Message;
               }
            }
            else
            {
                ViewBag.Message = "It appears you did not supply two operands";
            }

            return View();
        }

        public IActionResult Subtract(string operand1, string operand2)
        {
            ViewBag.Message = "";
            ViewBag.ValidResult = false;
            ViewBag.Operand1 = operand1;
            ViewBag.Operand2 = operand2;

            if (operand1 != "" && operand2 != "")
            {
               try
               {
                   double difference = calculator.Subtract(operand1, operand2);
                   ViewBag.Difference = difference;
                   ViewBag.ValidResult = true;
               }
               catch (Exception e)
               {
                   ViewBag.Message = e.Message;
               }
            }
            else
            {
                ViewBag.Message = "It appears you did not supply two operands";
            }

            return View();
        }

        public IActionResult Multiply(string operand1, string operand2)
        {
            ViewBag.Message = "";
            ViewBag.ValidResult = false;
            ViewBag.Operand1 = operand1;
            ViewBag.Operand2 = operand2;

            if (operand1 != "" && operand2 != "")
            {
               try
               {
                   double product = calculator.Multiply(operand1, operand2);
                   ViewBag.Product = product;
                   ViewBag.ValidResult = true;
               }
               catch (Exception e)
               {
                   ViewBag.Message = e.Message;
               }
            }
            else
            {
                ViewBag.Message = "It appears you did not supply two operands";
            }

            return View();
        }

        public IActionResult Divide(string operand1, string operand2)
        {
            ViewBag.Message = "";
            ViewBag.ValidResult = false;
            ViewBag.Operand1 = operand1;
            ViewBag.Operand2 = operand2;

            if (operand1 != "" && operand2 != "")
            {
               try
               {
                   double quotient = calculator.Divide(operand1, operand2);
                   ViewBag.Quotient = quotient;
                   ViewBag.ValidResult = true;
               }
               catch (Exception e)
               {
                   ViewBag.Message = e.Message;
               }
            }
            else
            {
                ViewBag.Message = "It appears you did not supply two operands";
            }

            return View();
        }
    }
}