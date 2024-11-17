using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    { // 7 практикум
        static void Main(string[] args)
        {
            //Задание 1.Часть а
            //Console.Write("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Вас зовут:" + name);
            //Console.ReadKey();

            //Часть б
            //Console.Write("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Добро пожаловать:" + name);
            //Console.ReadKey();

            //Задание 2
            //Console.Write("Введите название футбольной команды:");
            //string name = Console.ReadLine();
            //Console.Write(name + "-Это чемпион!");
            //Console.ReadKey();

            //Задание 3
            //Console.Write("Введите ваше имя:");
            //string im = Console.ReadLine();
            //Console.Write("Введите вашу фамилию:");
            //string fam = Console.ReadLine();
            //Console.Write(im + fam);
            //Console.ReadKey();

            //Задание 4
            //Console.Write("Введите название государства:");
            //string name = Console.ReadLine();
            //Console.Write("Введите название столицы:");
            //string stol = Console.ReadLine();
            //Console.Write($"Столица государства {name} — город {stol}");
            //Console.ReadKey();


            //Задание 5
            //Console.Write("Введите название романа:");
            //string name = Console.ReadLine();
            //Console.Write("Как зовут автора романа:");
            //string stol = Console.ReadLine();
            //Console.Write($"Писатель {stol} — автор романа {name}");
            //Console.ReadKey();

            //Задача 6
            //Console.Write("Введите название футбольного клуба: ");
            //string club = Console.ReadLine();
            //Console.Write($"количество символов: {club.Length}");
            //Console.ReadKey();

            //Задание 7
            //Console.WriteLine("Ты вчера был болен.");
            //Console.WriteLine("Измерь - ка  температуру!");
            //Console.Write("Сообщи, какая у тебя  температура: ");
            //double temp = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ты здоров дружок!");
            //Console.WriteLine("Можешь идти в школу.");
            //Console.WriteLine("Желаю успехов!");
            //Console.ReadKey();

            //Задание 8
            //Console.WriteLine("Здравствуй, я компьютер, а тебя как зовут?");
            //Console.Write("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Очень приятно,{name}.");
            //Console.Write("Сколько тебе лет?");
            //string age = Console.ReadLine();
            //Console.Write($"Ого! Целых {age} лет! Ты уже совсем взрослый!");
            //Console.ReadKey();

            //Задание 9
            //Console.WriteLine("Как тебя зовут?");
            //Console.Write("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Привет, {name}!");
            //Console.Write("Сколько тебе лет? ");
            //string age = Console.ReadLine();
            //Console.Write("Какой у тебя любимый предмет в техникуме? ");
            //string pred = Console.ReadLine();
            //Console.Write("Какая у тебя любимая книга? ");
            //string book = Console.ReadLine();
            //Console.WriteLine($"Значит тебя зовут, {name}");
            //Console.WriteLine($"Тебе {age} лет");
            //Console.WriteLine($"Твой любимый предмет {pred}");
            //Console.WriteLine($"И твоя любимая книга {book}");
            //Console.ReadKey();

            //Задание 10
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.Write("Cколько тебе лет? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write($"{name}, ты родился в {2024 - age} году");
            Console.ReadKey();
        }
    }
}
