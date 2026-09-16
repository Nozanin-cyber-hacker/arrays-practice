using System;

namespace Final.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 2
            Console.Write("Введите массив через пробел: ");
            string input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: Введена пустая строка.");
                return;
            }

            string[] elements = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                if (!int.TryParse(elements[i], out array[i]))
                {
                    Console.WriteLine("Ошибка: Массив должен состоять только из целых чисел.");
                    return;
                }
            }

            bool isPalindrome = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Массив — палиндром");
            }
            else
            {
                Console.WriteLine("Массив — не палиндром");
            }
        }
    }
}
