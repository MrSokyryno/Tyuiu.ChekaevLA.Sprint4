using Tyuiu.ChekaevLA.Sprint4.Task4.V26.Lib;

namespace Tyuiu.ChekaevLA.Sprint4.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 4 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Многомерные массивы (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 5. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("* 5, 4, 1, 1, 2,                                                          *");
            Console.WriteLine("* 3, 2, 4, 3, 5,                                                          *");
            Console.WriteLine("* 5, 2, 3, 2, 2,                                                          *");
            Console.WriteLine("* 2, 5, 1, 1, 4,                                                          *");
            Console.WriteLine("* 5, 3, 4, 3, 2                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5];
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write($"Введите значение для ячейки [{x},{y}]:");
                    array[x, y] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dataService.Calculate(array));
            Console.ReadKey();
        }
    }
}
