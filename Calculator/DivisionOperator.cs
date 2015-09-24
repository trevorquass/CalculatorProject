using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DivisionOperator
    {
        public decimal total;
        public void Division(decimal amount, decimal amount2)
        {
            try
            {
                total = amount / amount2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nException caught, cannot divide by zero.", e);
            }
        }
        public void PrintResult()
        {
            Console.WriteLine("\nResult: " + total);
        } 
    }
}
