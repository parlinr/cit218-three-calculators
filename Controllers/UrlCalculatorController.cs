using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace cit218_three_calculators.Controllers
{
    public class UrlCalculatorController : Controller
    {
        BaseCalculator calculator; 
        public UrlCalculatorController()
        {
            calculator = new BaseCalculator();
        }

        public IActionResult Calculate(string operation, string operand1, string operand2)
        {
            double operationResult = 0;
            ViewBag.ValidResult = false;
            List<string> errorMessageText = new List<string>();
            ViewBag.errormessage = null;
            ViewBag.answer = null;
            switch (operation)
            {
                case "add":
                    try
                    {
                        operationResult = calculator.Add(operand1, operand2);
                        ViewBag.ValidResult = true;
                    }
                    catch (Exception e)
                    {
                        errorMessageText.Add(e.Message);
                    }
                    break;
                case "subtract":
                     try
                    {
                        operationResult = calculator.Subtract(operand1, operand2);
                        ViewBag.ValidResult = true;
                    }
                    catch (Exception e)
                    {
                        errorMessageText.Add(e.Message);
                    }
                    break;
                case "multiply":
                    try
                    {
                        operationResult = calculator.Multiply(operand1, operand2);
                        ViewBag.ValidResult = true;
                    }
                    catch (Exception e)
                    {
                        errorMessageText.Add(e.Message);
                    }
                    break;
                case "divide":
                     try
                    {
                        operationResult = calculator.Divide(operand1, operand2);
                        ViewBag.ValidResult = true;
                    }
                    catch (Exception e)
                    {
                        errorMessageText.Add(e.Message);
                    }
                    break;
                case "factorial":
                    try
                    {

                        operationResult = calculator.Factorial(operand1, operand2);
                        ViewBag.ValidResult = true;
                    }
                    catch (Exception e)
                    {
                        errorMessageText.Add(e.Message);
                    }
                    break;
            }
            ViewBag.answer = operationResult;
            ViewBag.errorMessage = errorMessageText;
            return View();
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