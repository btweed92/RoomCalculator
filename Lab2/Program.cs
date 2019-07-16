using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Hello, welcome to the rectangular room calculator!");

                Console.WriteLine("Please enter the length of your room");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please etner the width of your room");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of your room");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("The perimeter of your rectangular is: " + ((length * 2) + (width * 2)));
                Console.WriteLine("The area of your rectangular room is: " + (length * width));
                Console.WriteLine("The volume of your rectangular room is: " + (length * width * height));

                Console.WriteLine("Would you like to continue measuring rectangular rooms? (y/n)");
            } while (Console.ReadLine() == "y");
        }
    }
}
