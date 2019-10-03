using System;
using System.Collections.Generic;

namespace Puzzling
{
    class Program
    {
        public static int[] RandomArray()
        {
            // add a "Random" object to the method
            Random chance = new Random();
            int[] newArr = new int[10];
            for (int i = 0; i < newArr.Length; i++)
            {// use "chance" to add random values to "newArr"
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
        //Simulate a coin toss
        public static string TossCoin()
        {
            Random chance = new Random();
            System.Console.WriteLine("Tossing a coin!");
            int ht = chance.Next(1, 100);
            if (ht == 50)
            {
                System.Console.WriteLine("The coin magically landed on the edge! That calls for a re-toss!");
                TossCoin();
            }
            else if (ht > 50)
            {
                return "Heads!";
            }
            return "Tails!";
        }
        // Toss a lot of coins
        public static double Multi(int coins)
        {
            int heads = 0;
            double ratio = 0.0;
            if (coins == 0)
            {
                System.Console.WriteLine("that is not how this works. COIN++");
                coins = 1;
            }
            else if (coins > 0)
            {
                for (int toss = 1; toss <= coins; toss++)
                {
                    string tc = TossCoin();
                    if (tc=="Heads!")
                    {
                        heads ++;
                    }
                }
            }
           ratio += (double)heads/coins;
           Console.WriteLine("The ration of head flips to the total is...");
           return ratio;
        }

        public static List<string> Names()
        {
            List<string> namesList = new List<string>(){"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            return namesList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
            //// get a randomly generated array
            // int[] arbitrary = RandomArray();
            //// determine some values from it
            // MinMax(arbitrary);
            // PrintSum(arbitrary);
            // toss a coin
            // var outcome = Multi(25);
            // System.Console.WriteLine(outcome);
            foreach (string name in Names())
            {
                System.Console.Write($"{name} ");
            }
        }
    }
}
