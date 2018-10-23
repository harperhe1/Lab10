using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            double UserInput = 0;
            Circle myCircle = new Circle(UserInput);
            Console.WriteLine("Please enter the radius of a circle!");
            UserInput = double.Parse(Console.ReadLine());
            myCircle.Radius = UserInput;
            Console.WriteLine($"Circumference Formatted! {myCircle.CalculateFormattedCircumference()}");
            Console.WriteLine($"Area: {myCircle.CalculateFormattedArea(),0:N2}");
        }
    }
}
