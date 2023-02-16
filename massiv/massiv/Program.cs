using System;

namespace massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] first = new int[n];
            Random rand = new Random();
            Console.WriteLine("Значения массива до сортировки: ");
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = rand.Next(-100, 100);
                Console.Write(first[i] + " ");
            }
            Sort(first);
            Console.WriteLine("\n" + "Значения массива после сортировки: ");
            foreach (int num in first)
            {
                Console.Write(" " + num);
            }
            static void exchange(int[] massiv, int i, int j)
            {
                int peremenay = massiv[i];
                massiv[i] = massiv[j];
                massiv[j] = peremenay;
            }
            static void Sort(int[] inArray)
            {
                int x;
                int j;
                for (int i = 1; i < inArray.Length; i++)
                {
                    x = inArray[i];
                    j = i;
                    while (j > 0 && inArray[j - 1] > x)
                    {
                        exchange(inArray, j, j - 1);
                        j -= 1;
                    }
                    inArray[j] = x;
                }
            }
        }
    }
}
