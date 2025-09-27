using Tyuiu.FisherMA.Sprint3.Task6.V15.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 6;
            int stopValue = 15;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.Title = "Спринт #3 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [6, 15] сумму всех делителей           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Начало отрезка: {startValue}");
            Console.WriteLine($"Конец отрезка: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма всех делителей: {res}");
            Console.ReadKey();
        }
    }
}