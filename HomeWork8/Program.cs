using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] nums = new int[size, size];

            int num = 1;
            int i = 0;
            int j = 0;

            while (num <= size * size)
            {
                nums[i, j] = num;
                if (i <= j + 1 && i + j < size - 1)
                    ++j;
                else if (i < j && i + j >= size - 1)
                    ++i;
                else if (i >= j && i + j > size - 1)
                    --j;
                else
                    --i;
                ++num;
            }

            PrintArray(nums);

            void PrintArray(int[,] array)
            {
                for (int m = 0; m < array.GetLength(0); m++)
                {
                    Console.Write("[ ");
                    for (int n = 0; n < array.GetLength(1); n++)
                    {
                        Console.Write(array[m, n] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
        }
    }
}
