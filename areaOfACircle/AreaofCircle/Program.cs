using System;

namespace AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input the Radius and output the area of a circle
            //Varables
            string input;
            double radius = 0, area = 0;
            bool goodInput = true;

            //Input
            do
            {
                Console.WriteLine("Enter a radius:");
                input = (Console.ReadLine());
                if (double.TryParse(input,out radius)==true)
                {
                    //radius = double.Parse(input);
                    goodInput = true;
                }
                else
                {
                    goodInput = false;
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number");
                    Console.WriteLine();
                }
            } while (goodInput == false);
            //Math
            area = Math.PI * radius * radius;

            //Output
            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
        }
    }
}
