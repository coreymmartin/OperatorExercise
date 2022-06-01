using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    /*
     * Exercise1: create program to write out results of addition, subtraction, multiplication, division.
     * for division, print 17/4 = 4 remainder 1 (use mod)
     * 
     * Exercise2: Calculate area of a circle based on radius AreaOfCircle() = Math.PI * Math.Pow(r,2) returns double
     * method can accept r as a parameter using car radius = double.parse(console.readline())
     * 
     */

    internal class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        static void Divide(int a, int b)
        {
            int quotient  = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a} / {b} = {quotient} remainder {remainder}");
        }

        static double AreaOfCircle(double r)
        {
            double area = Math.PI * Math.Pow(r,2);
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input 2 integers to perform mathematical operations on");
            Console.Write("Please enter input 1: ");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter input 2: ");
            int userInput2 = int.Parse(Console.ReadLine());

            Add(userInput1, userInput2);
            Subtract(userInput1, userInput2);
            Multiply(userInput1, userInput2);
            Divide(userInput1, userInput2);

            Console.WriteLine("\nPlease enter a value for radius of a circle, we will calculate the area");
            double userRadius = double.Parse(Console.ReadLine());
            double circleArea = AreaOfCircle(userRadius);
            Console.WriteLine($"The area of a circle with radius of {userRadius} is {circleArea}");

        }
    }
}
