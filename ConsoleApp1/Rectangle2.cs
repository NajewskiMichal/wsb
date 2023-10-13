using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle
    {
        public double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double CalculateRectangleArea(double a, double b)
        {
            return a * b;
        }
    }
}