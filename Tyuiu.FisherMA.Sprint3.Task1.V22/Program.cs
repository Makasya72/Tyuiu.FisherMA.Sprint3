using Tyuiu.FisherMA.Sprint3.Task1.V22.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double a = 1.5;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetSumSeries(a, startValue, stopValue);

            Console.Title = "Спринт #3 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Сумма ряда                                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле: S = Σ (a^k + 1/2) * cos(k), где k = 1..20, a = 1.5         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"Начальное значение k = {startValue}");
            Console.WriteLine($"Конечное значение k = {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма ряда S = {res}");
            Console.ReadKey();
        }
    }
}