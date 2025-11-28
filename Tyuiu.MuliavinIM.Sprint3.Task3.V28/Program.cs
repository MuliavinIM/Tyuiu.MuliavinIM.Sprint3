using Tyuiu.MuliavinIM.Sprint3.Task3.V28.Lib;

namespace Tyuiu.MuliavinIM.Sprint3.Task3.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Мулявин И.М. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "f35hyt t4j 3gkg45";
            char replaceChar = 'r';

            var ds = new DataService();
            string result = ds.ReplaceNumOnChar(value, replaceChar);

            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Результат:       {result}");
        }
    }
}