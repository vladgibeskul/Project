using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {


        //task1
        //static void Main(string[] args)
        //{
        //    // Получаем имя пользователя
        //    Console.Write("Как тебя зовут? ");
        //    string userName = Console.ReadLine();

        //    // Вызываем методы для приветствия  и прощания
        //    SayHello(userName);
        //    SayBuy(userName);
        //    Console.ReadKey();
        //}

        //// Метод для приветствия
        //static void SayHello(string name)
        //{
        //    Console.WriteLine($"привет {name}");
        //}

        //// Метод для прощания
        //static void SayBuy(string name)
        //{
        //    Console.WriteLine($"пока {name}");
        //}



        ////task2
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите первое слогаемое ");
        //    int x = int.Parse(Console.ReadLine());

        //    Console.Write("Введите второе слогаемое ");
        //    int y = int.Parse(Console.ReadLine());

        //    Console.Write($"Сумма: {Sum(x, y)}");
        //    Console.ReadKey();
        //}
        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        ////task3
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите a:  ");
        //    double a = double.Parse(Console.ReadLine());
        //    double b =0;
        //    Console.Write($"b = {Result(b ,a)}");

        //    Console.ReadKey();
        //}
        //public static double Result(double  b, double a)
        //{
        //    return 12 * Math.Pow(a, 2) + 7 * a - 6;
        //}

        //task4
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите первое число ");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("Введите второе число ");
        //    int y = int.Parse(Console.ReadLine());



        //    Console.WriteLine($"Сумма: {Sum(x, y)}");
        //    Console.WriteLine($"Разность: {Minus(x, y)}");
        //    Console.WriteLine($"Произведение: {Proizvd(x, y)}");
        //    Console.WriteLine($"Частное: {Chastn(x, y)}");
        //    Console.ReadKey();
        //}
        //    static int Sum(int x, int y)
        //    {
        //        return x + y;
        //    }
        //    static int Minus(int x, int y)
        //    {
        //        return x + (-y);
        //    }
        //    static int Proizvd(int x, int y)
        //    {
        //        return x * y;
        //    }
        //    static double Chastn(int x, int y)
        //    {
        //        return x / y;
        //    }

        //task5
        //static void Main(string[] args)
        //{
        //    // Координаты вершин треугольника
        //    Console.Write("Введите x1  ");
        //    int x1 = int.Parse(Console.ReadLine());     
        //    Console.Write("Введите x2  ");
        //    int x2 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите x3  ");
        //    int x3 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите y1  ");
        //    int y1 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите y2  ");
        //    int y2 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите y3  ");
        //    int y3 = int.Parse(Console.ReadLine());
        //    // Вычисление длин сторон треугольника
        //    double a = F(x1, y1, x2, y2);
        //    double b = F(x2, y2, x3, y3);
        //    double c = F(x1, y1, x3, y3);

        //    // Вычисление периметра треугольника
        //    double P = D(a, b, c);

        //    Console.WriteLine($"Периметр треугольника: {P}");
        //}

        //// Метод для вычисления длины отрезка по координатам
        //static double F(double x1, double y1, double x2, double y2)
        //{
        //    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //}

        //// Метод для вычисления периметра треугольника
        //static double D(double a, double b, double c)
        //{
        //    return a + b + c;
        //}

        //task6
        //static void Main()
        //{
        //    // Координаты вершин треугольника
        //    Console.Write("Введите x1  ");
        //    int x1 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите x2  ");
        //    int x2 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите x3  ");
        //    int x3 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите y1  ");
        //    int y1 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите y2  ");
        //    int y2 = int.Parse(Console.ReadLine());
        //    Console.Write("Введите y3  ");
        //    int y3 = int.Parse(Console.ReadLine());

        //    // Вычисление длин сторон
        //    double a = Length(x1, y1, x2, y2);
        //    double b = Length(x2, y2, x3, y3);
        //    double c = Length(x1, y1, x3, y3);

        //    // Вычисление периметра
        //    double P = a + b + c;

        //    // Вычисление площади
        //    double p = P / 2;
        //    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        //    Console.WriteLine($"Периметр треугольника: {P}");
        //    Console.WriteLine($"Площадь треугольника: {S}");
        //    Console.ReadKey();
        //}   

        //// Метод для вычисления длины отрезка по координатам
        //static double Length(double x1, double y1, double x2, double y2)
        //{
        //    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //}
    }

}