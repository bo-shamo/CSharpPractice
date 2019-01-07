using System;

namespace AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input the Radius and output the area of a circle
            //Varables
            double radius = 0, area = 0;

            //Input
            Console.WriteLine("Enter a radius:");
            radius = double.Parse(Console.ReadLine());

            //Math
            area = Math.PI * radius * radius;

            //Output
            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
        }
    }
}
