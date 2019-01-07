using System;


namespace AreaOfACirle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varables
            double radius = 0, area = 0;
            //input a radius and output the area
            Console.WriteLine("Please enter the radius of a circle: ");
            radius = double.Parse (Console.ReadLine());

            //Calculate the area
            area = Math.PI * radius * radius;

            //Output
            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
        }
    }
}
