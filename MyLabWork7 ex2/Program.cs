using System;

namespace MyLabWork7_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a; //переменная вещественного типа
            Console.WriteLine("Площадь квадрата равна"); //просим пользователя ввести площадь квадрата
            a = Convert.ToDouble(Console.ReadLine()); //задание переменной вещественного типа
            a = Math.Sqrt(a); // задание переменной по формуле, нахождение одной стороны квадрата
            a = a * 4; // задание переменной по формуле, нахождение периметра квадрата
            Console.WriteLine($"Периметр квадрата с данной площадью равен {a}"); //вывод на экран 
        }
    }
}
