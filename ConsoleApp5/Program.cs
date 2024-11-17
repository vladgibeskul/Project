using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввод х=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ввод y=");
            int y = int.Parse(Console.ReadLine());
            Console.Write($"Cумма={Sum(x, y)}");
            Console.ReadLine();
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
