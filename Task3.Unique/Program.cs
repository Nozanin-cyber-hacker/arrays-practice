using System;

namespace Task3.Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };
            
            Console.Write("Исходный:  ");
            Console.WriteLine(string.Join(", ", source));

            int[] unique = GetUnique(source);

            Console.Write("Уникальные: ");
            Console.WriteLine(string.Join(", ", unique));
        }

        public static int[] GetUnique(int[] source)
        {
            if (source == null || source.Length == 0)
            {
                return new int[0];
            }

            int[] temp = new int[source.Length];
            int count = 0;

            for (int i = 0; i < source.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < count; j++)
                {
                    if (source[i] == temp[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp[count] = source[i];
                    count++;
                }
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }
    }
}
