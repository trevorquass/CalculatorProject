using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SubtractionOperator
    {
        //public decimal value1;
        //public decimal value2;
        public decimal result;
        public decimal Subtract(decimal value1, decimal value2)
        {
            result = value1 - value2;
            return result;
        }
        public void PrintResult()
        {
            Console.WriteLine("\nResult: " + result);
        }            
    }
}
