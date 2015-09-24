using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DivisionOperator
    {
        public void Division(decimal amount, decimal amount2)
        {
            decimal total = 0;

            try
            {
                total = amount / amount2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught, cannot divide by zero.", e);
            }
            finally
            {
                Console.WriteLine("Result: " + total);
            }
        }        
    }
}
