using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformTasks();
        }

        static void PerformTasks()
        {
            Task1();
            Task2();
            //Task3();
            Task4();
            Task5();
            Task6();
        }

        static void Task1()
        {
            Console.WriteLine("Input the number for A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the number for B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the power (n)");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int x = 1; ; x++)
            {
                double power = Math.Pow(x, n);
                if (power > b)
                    break;
                if (power > a)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} numbers to the power of {n} in between {a} and {b}");
        }

        static void Task2()
        {

            Console.WriteLine("Input symbols to find pairs");
            string symbols = Console.ReadLine();
            int pairs = SockPairCount(symbols);
            Console.WriteLine($"Number of pairs: {pairs}");

            static int SockPairCount(string symbols) // იღებს სტრინგის პარამეტრ სიმბოლოს და აბრუნებს ინტეჯერს. ეს მეთოდი დათვლის წინდების წყვილებს
            {
                Dictionary<char, int> sockCounts = new Dictionary<char, int>(); // dictionary-ში ვინახავთ, if AA key, value = 2, if A key, value = 1
                foreach (char sock in symbols)
                {
                    if (sockCounts.ContainsKey(sock)) // ამოწმებს თუ ეს სიმბოლო უკვე არსებობს, თუ არსებობს მაშინ ++
                    {
                        sockCounts[sock]++;
                    }
                    else
                    {
                        sockCounts[sock] = 1;
                    }
                }

                int totalpairs = 0;
                foreach (var count in sockCounts.Values)
                {
                    totalpairs += count / 2; // წყვილი
                }
                return totalpairs;
            }
        }
        //static void Task3()
        //{

        //     Console.WriteLine("Input words or phrases");
        //     string input = Console.ReadLine();
        //    }

        static void Task4()
        {
            Console.WriteLine("Enter your list");
            string input = Console.ReadLine();
            var items = input.Split(',');  // to divide it into an array of strings at each comma. creates an array called items
            List<string> allItems = new List<string>();

            foreach (var item in items)
            {
                allItems.Add(item.Trim()); // თითოეულ trimmed itemს ამატებს ლისთში. trim removes unneccessary whitespace
            }
            if (bool.TryParse(allItems[0], out bool BoolResult))
            {
                List<bool> bools = new List<bool>();
                foreach (var item in allItems)
                {
                    bools.Add(bool.Parse(item));
                }
                Console.WriteLine($"First Element is {bools[0]}");
                Console.WriteLine($"Last Element is {bools[bools.Count - 1]}");
                Console.WriteLine($"Middle Element is {bools[bools.Count / 2]}");
            }
            else if (int.TryParse(allItems[0], out int IntResult))
            {
                int sum = 0;
                foreach (var item in allItems)
                {
                    sum += int.Parse(item);
                }
                Console.WriteLine(sum);
            }
            else
            {
                foreach (var item in allItems)
                {
                    Console.WriteLine(item.ToUpper());
                }
            }
        }

        static void Task5()
        {

            Console.WriteLine("Please input the numbers");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                PrintDigits(number);
            }
            else
            {
                Console.WriteLine("Error handling. Please input valid numbers");
            }
        }
        static void PrintDigits(int number)
        {
            string numberStr = number.ToString(); // converting int to string to process each digit individually
            PrintDigitsRecursion(numberStr, 0);
            Console.WriteLine(); // იგივე ხაზზე უშვებდა resultს და შემდეგ ტასკს Console.Write-ის მერე, ამიტომ ცარიელი ხაზი დავამატე.
        }

        static void PrintDigitsRecursion(string numberStr, int index)
        {
            if (index >= numberStr.Length)
                return; // stops recursion if index is bigger than length of number string
            Console.Write(numberStr[index]);

            if (index < numberStr.Length - 1) // -1 რო ბოლო ციფრის მერე - აღარ გაუშვას
            {
                Console.Write("-");
            }
            PrintDigitsRecursion(numberStr, index + 1); // calls itself with the next index to process the next character
        }
    

        static void Task6()
        {
            Console.WriteLine("Input numbers");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(" "); // breaks the input string into an array of strings based on spaces
            int[] numbers = Array.ConvertAll(inputArr, int.Parse);

            bool isDuplicate = Duplicates(numbers);
            Console.WriteLine(isDuplicate ? "True" : "False");
        }

        static bool Duplicates(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++) // second loop starts from the next element to compare it with the current element (i)
                {
                    if (numbers[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }
            return false; //  if these loops complete without finding duplicates the method just returns false
        }
    }
}