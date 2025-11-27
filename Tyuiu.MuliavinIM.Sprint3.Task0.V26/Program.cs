using Tyuiu.MuliavinIM.Sprint3.Task0.V26.Lib;

namespace Tyuiu.MuliavinIM.Sprint3.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Мулявин И.М. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Мулявин Иван Михайлович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу использую цикл for,                                  *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле.                         *");
            Console.WriteLine("***************************************************************************");

            int start = 1;
            int stop = 9;

            DataService ds = new DataService();
            double result = ds.GetMultiplySeries(start, stop);

            Console.WriteLine("* РЕЗУЛЬТАТ: " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
