using Tyuiu.FisherMA.Sprint3.Task5.V30.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.Title = "Спринт #3 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда по формуле:            *");
            Console.WriteLine("* y = ∑(i=1 to 3)∑(k=1 to 11)(x³ - k) + x при x = 2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Переменная X: {x}");
            Console.WriteLine($"Старт шага i: {startValue1}");
            Console.WriteLine($"Конец шага i: {stopValue1}");
            Console.WriteLine($"Старт шага k: {startValue2}");
            Console.WriteLine($"Конец шага k: {stopValue2}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма ряда: {res}");
            Console.ReadKey();
        }
    }
}