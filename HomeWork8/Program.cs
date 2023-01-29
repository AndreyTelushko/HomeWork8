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
            Console.WriteLine("введите количество строк");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[m, n];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Массив до изменения");
            PrintArray(numbers);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {
                    for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                    {
                        if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                        {
                            int temp = 0;
                            temp = numbers[i, z];
                            numbers[i, z] = numbers[i, z + 1];
                            numbers[i, z + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив с упорядоченными значениями");
            PrintArray(numbers);

            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                    }
                }
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
        }
    }
}
