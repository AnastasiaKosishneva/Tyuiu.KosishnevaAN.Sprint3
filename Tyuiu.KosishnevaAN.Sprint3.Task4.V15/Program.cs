﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint3.Task4.V15.Lib;

namespace Tyuiu.KosishnevaAN.Sprint3.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах              *");
            Console.WriteLine("* Задание #4                                                            *");
            Console.WriteLine("* Вариант #15                                                           *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение   *");
            Console.WriteLine("* функции y=((sin(x)+x)/x)+0.75. При х = 0 пропустить значение.        * ");
            Console.WriteLine("* Полученные значения перемножать.                                     * ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("результат = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
