using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a}+{b}={a + b}");
            //Console.Read();

            //Task 2 
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a}+{b}={b}+{a}");
            //Console.Read();

            //Task 3
            //Console.Write("a=");
            //float number1 = float.Parse(Console.ReadLine());
            //Console.Write("b=");
            //float number2 = float.Parse(Console.ReadLine());
            //float product = number1 * number2;
            //Console.WriteLine($"{number1}*{number2}={product:F1}");

            //Task 4  
            // Console.Write("a=");
            // double a=Convert.ToDouble(Console.ReadLine());
            // Console.Write("b=");
            // double b=Convert.ToDouble(Console.ReadLine());
            // Console.Write("c=");
            // double c=Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine($"({a:f2}+{b:f2})+{c:f2}={a:f2}+({b:f2}+{c:f2})");
            // Console.ReadLine();

            //Task 5
            //Console.Write("a=");
            //double a=Convert.ToDouble(Console.ReadLine());
            //Console.Write("b=");
            //double b=Convert.ToDouble(Console.ReadLine());
            //Console.Write("c=");
            //double c=Convert.ToDouble(Console.ReadLine());
            //Console.Write("d=");
            //double d=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{a:f2}/{b:f2} + {c:f2}/{d:f2}= {a / b + c / d:f2}");
            //Console.ReadLine();

            //Task 6
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write($"a+b={a}+{b}={a + b}\t"); Console.Write($"a-b={a}-{b}={a - b}\t"); Console.Write($"a*b={a}*{b}={a * b}");
            Console.ReadKey();






        }

    }
}
