﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCalculatorApp
{
    public class Calculator
    {

        public int Add(int x, int y)
        {
            Thread.Sleep(2000);
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        //public int Divide(int x, int y)
        //{
        //    return x / y;
        //}
        public int? Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
                return null;
            }
        }
    }
}
