using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


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
        private int Convert(string operand1)
        {
            try
            {
                return int.Parse(operand1);
            }
            catch (Exception)
            {
                throw new FormatException("Something happened.");
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
            if (double.Parse(operand2) == 0)
            {
                throw new FormatException("This calculator does not support division by zero.");
            }
            double[] numbers = Convert(operand1, operand2);
            return numbers[0] / numbers[1];
        }

        public int Factorial(string operand1, string operand2)
        {
            int value = 0;
            if (!Int32.TryParse(operand1, out value))
            {
                throw new Exception("The factorial operation is not defined for values that are not integers.");
            }
            
               
            
                
                if (value < 0)
                {
                    throw new FormatException("The factorial operation is not defined for values that are less than zero.");
                    
                }
            
            

            
            return factorialLogic(value);
        }

        private int factorialLogic(int operand)
        {
            if (operand > 0) return operand * factorialLogic(operand - 1);
            else return 1;
        }
    }

}