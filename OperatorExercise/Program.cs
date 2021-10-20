using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var sum = a + b;
            var difference = a - b;
            var product = a * b;

            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} * {b} is {product}");

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            Console.WriteLine("What is the radius of the circle?");

            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with radius {radius} is {area}."); 
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
