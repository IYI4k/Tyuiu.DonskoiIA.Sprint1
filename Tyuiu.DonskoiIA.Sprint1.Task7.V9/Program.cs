using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint1.Task7.V9.Lib;

namespace Tyuiu.DonskoiIA.Sprint1.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя два параметра x и  *");
            Console.WriteLine("* y, после чего вычисляет выражение, округляет до 3 знаков после запятой  *");
            Console.WriteLine("* и выводит на экран                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                        y^2 + cos(x^3) + 12xy - 3x^2                     *");
            Console.WriteLine("*             z = e^x - ------------------------------                    *");
            Console.WriteLine("*                           cos(x^3 + 3) + 18y - 1                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            double y;

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}