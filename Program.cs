using System;
using System.Collections.Generic;

namespace Puzzling
{
    class Program
    {
        public static int[] RandomArray()
        {
            Random chance = new Random();
            int[] newArr = new int[10];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = chance.Next(5,25);
            }
            return newArr;
        }

        public static void MinMax(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            foreach (int num in numbers)
            {
                // Console.Write($"{num} ");
                if (min > num)
                {
                    min = num;
                }
                if (max < num)
                {
                    max = num;
                }
            }
            // System.Console.WriteLine("");
            Console.WriteLine($"the MIN and MAX this time are {min} and {max}.");
        }

        public static void PrintSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"the SUM this time is {sum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("#####It's alive!");
            int[] arbitrary = RandomArray();
            MinMax(arbitrary);
            PrintSum(arbitrary);
        }
    }
}
