using Tyuiu.ChekaevLA.Sprint4.Task3.V25.Lib;

namespace Tyuiu.ChekaevLA.Sprint4.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 4 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Многомерные массивы (статический ввод)                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7. Найдите произведение     *");
            Console.WriteLine("* элементов в четвертом столбце массива.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 7, 3, 5, 3, 6,                                                          *");
            Console.WriteLine("* 4, 6, 2, 5, 7,                                                          *");
            Console.WriteLine("* 2, 3, 3, 3, 5,                                                          *");
            Console.WriteLine("* 2, 7, 7, 6, 2,                                                          *");
            Console.WriteLine("* 6, 6, 4, 3, 6,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] array = { 
                { 7, 3, 5, 3, 6 }, 
                { 4, 6, 2, 5, 7 }, 
                { 2, 3, 3, 3, 5 }, 
                { 2, 7, 7, 6, 2 }, 
                { 6, 6, 4, 3, 6 } 
            };
            Console.WriteLine(dataService.Calculate(array));


            Console.ReadKey();
        }
    }
}
