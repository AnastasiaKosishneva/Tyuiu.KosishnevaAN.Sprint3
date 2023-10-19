using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint3.Task1.V25.Lib;

namespace Tyuiu.KosishnevaAN.Sprint3.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Оператор цикла while                                            *");
            Console.WriteLine("* Задание #1                                                            *");
            Console.WriteLine("* Вариант #25                                                           *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле, при a=2                                 *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int startValue = 1;
            int stopValue = 6;
            int value = 2;
            Console.WriteLine("Переменаая A = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Произведение рада = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
