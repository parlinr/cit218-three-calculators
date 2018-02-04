using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cit218_three_calculators.Models;

namespace cit218_three_calculators.Controllers
{
    public class BaseCalculator
    {
        private double[] Convert(string operand1, string operand2)
        {
            double[] returnArray = new double[2];
            try
            {
                returnArray[0] = double.Parse(operand1);
                returnArray[1] = double.Parse(operand2);
                return returnArray; 
            }
            catch (Exception)
            {
                throw new FormatException("The inputs were not entered in the correct format. They were either not numbers, too large, too small, or null.");
            }
        }
        public double Add(string operand1, string operand2)
        {
            double[] numbers = Convert(operand1, operand2);
            return numbers[0] + numbers[1];
        }

        public double Subtract(string operand1, string operand2)
        {
            double[] numbers = Convert(operand1, operand2);
            return numbers[0] - numbers[1];
        }

        public double Multiply(string operand1, string operand2)
        {
            double[] numbers = Convert(operand1, operand2);
            return numbers[0] * numbers[1];
        }

        public double Divide(string operand1, string operand2)
        {
            double[] numbers = Convert(operand1, operand2);
            return numbers[0] / numbers[1];
        }
    }

}