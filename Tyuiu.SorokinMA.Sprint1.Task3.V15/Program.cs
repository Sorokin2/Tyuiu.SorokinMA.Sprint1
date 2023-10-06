using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.SorokinMA.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Сорокин М. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Сорокин Михаил Анатольевич | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля имеют     *");
            Console.WriteLine("* скорости V1 км/ч и V2 км/ч соответственно, находятся на расстоянии S км *");
            Console.WriteLine("* друг от друга и движутся в противоположные стороны.                     *");
            Console.WriteLine("* Определить расстояние между ними через T часов.                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double v1, v2, S, T;

            Console.WriteLine("Введите скорость первого автомобиля: ");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля: ");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние между ними: ");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время в часах: ");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DistanceOverTime(v1, v2, S, T)+ " км");
            Console.ReadKey();
        }
    }
}
