using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                bool success = false;
                while (!success)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    try
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                        success = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            while (true)
            {
                Console.Write("Введите индекс для вывода (0-4): ");
                try
                {
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Элемент [{index}]: {array[index]}");
                    break;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Некорректный индекс.");
                }
            }
        }
    }
}
