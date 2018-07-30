using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10Circle.Properties;

namespace Lab10Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets figure out a circle \nPlease enter in a radius");
            double radius = double.Parse(Console.ReadLine());
            var circle = new Circle(radius);
            
            Console.WriteLine($"{Circle.formatedCircumference()}");
            Console.WriteLine($"{Circle.formatedArea()}");
        }
    }
}
