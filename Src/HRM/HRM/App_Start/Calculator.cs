using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRM.App_Start
{
    public class Calculator
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}