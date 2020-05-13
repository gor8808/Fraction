using System;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(5, 4);
            Fraction b = new Fraction(1, 2);
            
            Console.WriteLine($"-{a} = {-a}");
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % 23 = {a % 23}");
            Console.WriteLine($"{a} ^ 2 = {a ^ 2}");
            Console.WriteLine($"{a} > {b} -- {a > b}");
            Console.WriteLine($"{a} < {b} -- {a < b}");
            Console.WriteLine($"{a} == {b} -- {a == b}");
            Console.WriteLine($"{a} != {b} -- {a != b}");

            a = new Fraction(1, 2);
            b = new Fraction(1, 2);
            Console.WriteLine($"{a} >= {b} -- {a >= b}");
            Console.WriteLine($"{a} <= {b} -- {a <= b}");
            if (a)
            {
                Console.WriteLine($"{a} is a fraction");
            }
            else
            {
                Console.WriteLine($"{a} is not a fraction");
            }
        }
    }
}
