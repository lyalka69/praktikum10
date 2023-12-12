﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace praktikum10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
            Console.WriteLine("введите номер дня недели от 1 до 7: ");
            byte day = byte.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
                case 7:
                    Console.WriteLine("воскресенье");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            //Задача 2. В зависимости от порядкового номера месяца (1, 2, ... , 12) вывести на экран его название (январь, февраль, ... , декабрь).

            Console.WriteLine("введите номер месяца от 1 до 12: ");
            byte month1 = byte.Parse(Console.ReadLine());
            switch (month1)
            {
                case 1:
                    Console.WriteLine("январь");
                    break;
                case 2:
                    Console.WriteLine("февраль");
                    break;
                case 3:
                    Console.WriteLine("март");
                    break;
                case 4:
                    Console.WriteLine("апрель");
                    break;
                case 5:
                    Console.WriteLine("май");
                    break;
                case 6:
                    Console.WriteLine("июнь");
                    break;
                case 7:
                    Console.WriteLine("июль");
                    break;
                case 8:
                    Console.WriteLine("август");
                    break;
                case 9:
                    Console.WriteLine("сентябрь");
                    break;
                case 10:
                    Console.WriteLine("октябрь");
                    break;
                case 11:
                    Console.WriteLine("ноябрь");
                    break;
                case 12:
                    Console.WriteLine("декабрь");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            //Задача 3. По номеру месяца вывести название времени года.

            Console.WriteLine("введите номер месяца от 1 до 12: ");
            byte month = byte.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("осень");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }


            //Задача 4. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.

            Console.WriteLine("введите номер месяца от 1 до 12: ");
            char lessons = char.Parse(Console.ReadLine());
            switch (lessons)
            {
                case 'ф':
                case 'Ф':
                    Console.WriteLine("физика");
                    break;
                case 'м':
                case 'М':
                    Console.WriteLine("математика");
                    break;
                case 'и':
                case 'И':
                    Console.WriteLine("история");
                    break;
                case 'г':
                case 'Г':
                    Console.WriteLine("география");
                    break;
                case 'б':
                case 'Б':
                    Console.WriteLine("биология");
                    break;
            }


            Console.ReadKey();
        }
    }
}
