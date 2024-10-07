using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Enter the radius of the circle");

            double radius = Convert.ToDouble(Console.ReadLine());
            double areaBigSquare = 4 * radius * radius;
            double areaSmallSquare = 2 * radius * radius;
            double difference = areaBigSquare - areaSmallSquare;

            Console.WriteLine($"Difference is: {difference}");
            #endregion

            #region 2
            Console.WriteLine("Enter the symbols you got");

            var symbols = Console.ReadLine().Split(' ');
            bool jackpot = true;

            for (int i = 1; i < symbols.Length; i++)
            {
                if (symbols[i] != symbols[0])
                {
                    jackpot = false;
                    break;
                }
            }
            if (jackpot)
            {
                Console.WriteLine("Jackpot!");
            }
            else
            {
                Console.WriteLine("Not Jackpot.");
            }
            #endregion

            #region 3 
            Console.WriteLine("Input your results");

            var input = Console.ReadLine();
            var results = input.Split(','); // დასაყოფად, მასივი მაკლია????? idk the issue (unfinished)
            var totalPoints = 0; // start from 0 და მერე ვუმატებთ

            for (int i = 0; i < results.Length; i++)
            {
                var parts = results[i].Split(' '); // ეს ნაწილებად

                if (parts.Length == 2)
                {
                    int count = int.Parse(parts[0]); // ? 
                    string type = parts[1];

                    if (type == "Win")
                        totalPoints += count * 3;
                    else if (type == "Draw")
                        totalPoints += count * 1;
                }
            }

            Console.WriteLine("Total points: " + totalPoints);

            //////////////// ?????????????? რაღაცა არასწორია, არ მითვლის.
            #endregion

            #region 4 

            int normalHours = 8;
            int hourlyPay = 10;
            int overtimePay = 5;
            int weekendPay = 20;

            Console.WriteLine("Enter hours worked for everyday");
            input = Console.ReadLine();
            var allHours = input.Split(",");
            int total = 0;

            for (int day = 0; day < allHours.Length; day++)
            {
                int dailyPay = 0;

                if (int.TryParse(allHours[day].Trim(), out int hours))
                {
                    if (day < 5)
                    {
                        if (hours <= normalHours)
                        {
                            dailyPay = hours * hourlyPay;
                        }
                        else
                        {
                            dailyPay = (normalHours * hourlyPay) + ((hours - normalHours) * (hourlyPay + overtimePay));
                        }
                    }
                    else
                    {
                        dailyPay = hours * weekendPay;
                    }
                }

                total += dailyPay;
            }
            Console.WriteLine($"Total income for the week: ${total}");

            #endregion

            #region 5
            Console.WriteLine("Input Giorgi's perfomances for each day");
            input = Console.ReadLine();

            var performance = input.Split(",");
            int[] dailyPerformance = new int[performance.Length];

            for (int i = 0; i < performance.Length; i++)
            {
                dailyPerformance[i] = int.Parse(performance[i]); // storing in array
            }
            int improvementDays = 0;

            for (int i = 1; i < performance.Length; i++)
            {
                if (dailyPerformance[i] > dailyPerformance[i - 1])
                {
                    improvementDays++;
                }
            }
            Console.WriteLine(improvementDays);

            #endregion

            #region 6
            Console.WriteLine("Enter length of N");
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string> { "Hello", "World", "Programming", "Communication" };

            var result = words.Where(word => word.Length >= n);

            if (result.Any()) // ამოწმებს რამე ელემენტი არის თუ არა ასეთი
            {
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No elements found");
                
            }
            #endregion
        }
    }
}

    



    