using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint3.Task0.V19.Lib;

namespace Tyuiu.KosishnevaAN.Sprint3.Task0.V19
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Оператор цикла for                                              *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Вариант #19                                                           *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму        *");
            Console.WriteLine("* ряда по формуле                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма рада = " + ds.GetSumSeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
