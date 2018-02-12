using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace cit218_three_calculators.Controllers
{
    public class FormCalculatorController : Controller
    {
        BaseCalculator calculator;

        public FormCalculatorController()
        {
            calculator = new BaseCalculator();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(string operation, string operand1, string operand2)
        {
            double operationResult = 0;
            List<string> errorMessageText = new List<string>();
            ViewBag.errormessage = null;
            ViewBag.answer = null;
            ViewBag.ValidResult = false;

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
            }

            ViewBag.answer = operationResult;
            ViewBag.errorMessage = errorMessageText;
            return View();
        }
    }
}