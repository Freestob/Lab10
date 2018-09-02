using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10Circle;

namespace Lab10Circle
{
    class Program
    {


        static void Main(string[] args)
        {
            bool doAgain = true;
            int count = 1;
            do
            {
                
                    Console.WriteLine("Lets figure out a circle \nPlease enter in a radius");
                    double radius = double.Parse(Console.ReadLine());
                    var circle = new Circle(radius);

                    Console.WriteLine($"{circle.CalculateFormattedCircumference()}");
                    Console.WriteLine($"{circle.CalculateFormatedArea()}");

                    Console.WriteLine("Would you like to calculate another circle?");
                    string yesNo = Console.ReadLine();
                    if (yesNo == "y")
                    {
                    count++;
                        doAgain = true;
                    }
                    else
                    {
                        Console.WriteLine($"You created {count} circle(s)");
                    doAgain = false;
                    
                    }
                
            }
            while (doAgain == true);
            Console.ReadKey();
        }
    }
}
