using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hi();
            By();
            Console.ReadLine();
                
        }
        public static void Hi()
        {
            Console.WriteLine("Добро пожаловать!");
        }
        public static void By()
        {
            Console.Write("До свидания");
        }
    }
}
