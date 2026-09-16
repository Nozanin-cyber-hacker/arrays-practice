using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 0)
            {
                Console.Write("Введите количество элементов: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Ошибка: Число элементов должно быть больше 0.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введено не число. Попробуйте еще раз.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое или слишком маленькое.");
                }
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                bool success = false;
                while (!success)
                {
                    Console.Write($"Элемент [{i}]: ");
                    try
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                        success = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка ввода: требуется целое число. Повторите ввод.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка ввода: число выходит за пределы допустимого диапазона (int). Повторите ввод.");
                    }
                }
            }

            Console.Write("Исходный массив: ");
            Console.WriteLine(string.Join(", ", array));

            Console.Write("Обратный порядок: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
                if (i > 0) Console.Write(", ");
            }
            Console.WriteLine();

            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            Array.Sort(array);
            Console.Write("Отсортированный: ");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}

