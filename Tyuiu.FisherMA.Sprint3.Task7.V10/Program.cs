
using Tyuiu.FisherMA.Sprint3.Task7.V10.Lib;

namespace Tyuiu.FisherMA.Sprint3.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetTabFunction(startValue, stopValue);

            Console.Title = "Спринт #3 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Операции сравнения и циклы                                        *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (5x + 2.5)/(sin(x) + 3) + 2x + cos(x)                            *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Проверить деление на ноль.              *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");
            Console.WriteLine("Шаг: 1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine("|{0,6}    | {1,8}  |", x, res[count]);
                count++;
            }
            Console.WriteLine("+----------+-----------+");

            Console.WriteLine("Массив значений:");
            Console.Write("[");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
                if (i < res.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");

            Console.ReadKey();
        }
    }
}