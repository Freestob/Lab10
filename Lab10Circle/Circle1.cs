using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Circle
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
            return 2 * Math.PI * Radius;
            
        }
        public string  CalculateFormattedCircumference()
        {
            string formatedCircumference = RoundedNumber(CalculateCircumference());
            return formatedCircumference;
        }
        public double CalculatedArea()
            {
            return  Math.PI * Radius * Radius;
            
            }
        public string CalculateFormatedArea()
        {
            string formatedArea = RoundedNumber(CalculatedArea());
            return formatedArea;
        }
        public string RoundedNumber (double x)
        {
            return String.Format($"{Math.Round(x, 2)}");
        }
    }
}
