﻿namespace Assignment8ex2
{
    public delegate double Calc(double x, double y);
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            Action<double, double> smallNumber = answer.GetSmaller;
            smallNumber(num1, num2);

            Func<double, double, double> sum = answer.GetSum;
            Console.WriteLine($" {num1} + {num2} = {sum(num1, num2)}");

            Calc product = new Calc(answer.GetProduct);
            Console.WriteLine($" {num1} + {num2} = {product(num1, num2)}");
        }
    }
}
