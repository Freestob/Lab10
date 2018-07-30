using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Circle.Properties
{
    class Circle
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateCircumference()
        {
            double x = 2 * Math.PI * Radius;
            return x;
        }
        public string  CalculateFormattedCircumference()
        {
            double formatedCircumference = double.Parse($"{CalculateCircumference()}");
            return RoundedNumber(formatedCircumference);
        }
        public double CalculatedArea()
            {
            double x = Math.PI * Radius * Radius;
            return x;
            }
        public double CalculateFormatedArea()
        {
            double formatedArea = double.Parse($"{CalculateFormatedArea()}");
            return formatedArea;
        }
        public string RoundedNumber (double x)
        {
            return String.Format($"{Math.Round(x, 2)}");
        }
    }
}
