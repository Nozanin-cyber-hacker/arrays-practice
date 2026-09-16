using System;
using System.Linq;


Random random = new Random();
int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 101); 
}

Console.WriteLine($"Массив: {string.Join(", ", numbers)}");

int sum = numbers.Sum();

double product = 1;
foreach (int num in numbers)
{
    product *= num;
}

int evenCount = numbers.Count(n => n % 2 == 0);

double average = numbers.Average();
int countAboveAverage = numbers.Count(n => n > average);

Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Произведение: {product:1.23E+00}"); 
Console.WriteLine($"Чётных чисел: {evenCount}");
Console.WriteLine($"Больше среднего ({average:F1}): {countAboveAverage}");
