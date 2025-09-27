using Tyuiu.FisherMA.Sprint3.Task2.V20.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task2.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x = 1;
            int startValue = 1;
            int stopValue = 6;
            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.Title = "Спринт #3 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Произведение ряда                                                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле: p = ∏ (2/(cos(x) + 0.5))^k, где k = 1..6,*");
            Console.WriteLine("* при x = 1                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Начальное значение k = {startValue}");
            Console.WriteLine($"Конечное значение k = {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение ряда p = {res}");
            Console.ReadKey();
        }
    }
}