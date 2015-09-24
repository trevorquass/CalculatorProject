﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorDisplay
    {
        public decimal firstNumber, secondNumber;
        public string mathOperator;
        public void RunCalculator()
        {
            Console.WriteLine("Enter first number");
            firstNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter operator choice (+,-,*,/)");
            mathOperator = Console.ReadLine();
            Console.WriteLine("\nEnter second number");
            secondNumber = decimal.Parse(Console.ReadLine());

            if (mathOperator == "+")
            {
                AdditionOperator add = new AdditionOperator();
                add.Addition(firstNumber, secondNumber);
                add.PrintResult();
            }
            else if (mathOperator == "-")
            {
                SubtractionOperator subtract = new SubtractionOperator();
                subtract.Subtraction(firstNumber, secondNumber);
                subtract.PrintResult();
            }
            else if (mathOperator == "*")
            {
                MultiplicationOperator multiply = new MultiplicationOperator();
                multiply.Multiplication(firstNumber, secondNumber);
                multiply.PrintResult();
            }
            else if (mathOperator == "/")
            {
                DivisionOperator divide = new DivisionOperator();
                divide.Division(firstNumber, secondNumber);
                divide.PrintResult();
            }
            else
            {
                Console.WriteLine("\nInvalid input entered.");
            }

            Console.WriteLine("\nPerform new operation? (yes/no):");
            string performNewOperationResponse = Console.ReadLine();

            if (performNewOperationResponse == "yes")
            {
                CalculatorDisplay calculatorDisplay = new CalculatorDisplay();
                calculatorDisplay.RunCalculator();
            }
            else
            {
                Environment.Exit(0);
            }


        }
    }
}
