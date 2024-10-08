﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint1.Task3.V4.Lib;

namespace Tyuiu.DonskoiIA.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* производит необходимые расчёты, округляет результат до 3 знаков после   *");
            Console.WriteLine("* запятой и печатает его на экране.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double Tetrad;

            Console.WriteLine("Введите цену тетради:");
            Tetrad = Convert.ToDouble(Console.ReadLine());

            double Oblozhka;

            Console.WriteLine("Введите цену обложки:");
            Oblozhka = Convert.ToDouble(Console.ReadLine());

            int Kolvo;

            Console.WriteLine("Введите количество комплектов:");
            Kolvo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.PurchaseAmount(Tetrad, Oblozhka, Kolvo));

            Console.ReadLine();
        }
    }
}