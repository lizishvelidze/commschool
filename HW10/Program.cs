using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;


namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformTasks();
        }
             public class DateInfo
        {
            public string currentDate { get; set; }
            public string Birthday { get; set; }
        }
        static void PerformTasks()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        static void Task1()
        {
            var FilePath = "C:\\Users\\User\\source\\repos\\HW10\\HW10\\NewFolder\\some.txt";
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close(); // ქმნის და ეგრევე ხურავს ?
            }

            Console.WriteLine("Input the number of words you want to write:");
            int numberofwords = int.Parse(Console.ReadLine());
            string[] words = new string[numberofwords];


            Console.WriteLine($"Input {numberofwords} words");
            for (int i = 0; i < numberofwords; i++)
            {
                Console.Write($"Line {i + 1}: ");
                words[i] = Console.ReadLine();
            }

            System.IO.File.WriteAllLines(FilePath, words);
            Console.Write("\nThe content of the last line of the file {0} is:\n", FilePath);
            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);
                Console.WriteLine("{0}", lines[numberofwords - 1]);
            }
            Console.WriteLine();
        }

        static void Task2()
        {
            Console.WriteLine("Input the value of N:");
            int n = int.Parse(Console.ReadLine());

            var filePath = "C:\\Users\\User\\source\\repos\\HW10\\HW10\\NewFolder\\multiplication_table.txt";
            string content = ""; // "initializes an empty string that will hold the entire content before writing it to the file" ?? a bit confusing check later, or ask

            for (int i = 1; i <= 9; i++)  // 1იდან 9მდე, multiplicand
            {
                for (int j = 1; j <= n; j++)  // for each number from 1 to N, multiplier
                {
                    int result = i * j;
                    content += $"{j} * {i} = {result}";

                    if (j < n) // adds separator
                    {
                        content += " | ";
                    }
                }
                content += Environment.NewLine; // moves to next line after finishing a row
            }
            File.WriteAllText(filePath, content); // writes content in file
            Console.WriteLine(content); // display multiplication table in console
        }

        static void Task3()
        {
            Console.WriteLine("Input the word you want to separate:");
            string input = Console.ReadLine();

            Console.WriteLine("Input the number you want the word to be separated by:");
            int n = int.Parse(Console.ReadLine());

            int length = input.Length;
            int partLength = input.Length / n;

            StringBuilder xmlText = new StringBuilder(); // namespace designed to create and manipulate strings

            for (int i = 0; i < n; i++) // loop that iterates n times to create an xml node for each part of the string
            {
                int startindex = i * partLength;
                if (i == n - 1)
                {
                    partLength = length - startindex; // captures any remaining characters, რო არ დაიკარგოს მაგალითად 10/3
                }
                string part = input.Substring(startindex, partLength);
                xmlText.AppendLine($" <{part}> string {i + 1} </{part}>"); // takes string and adds it to the existing content in the stringbuilder, adds newline character
            }

            var filepath = "C:\\Users\\User\\source\\repos\\HW10\\HW10\\NewFolder\\output.xml";
            File.WriteAllText(filepath, xmlText.ToString());
            Console.WriteLine(xmlText.ToString());
        }
        static void Task4()
        {
            var jsonFilepath = "C:\\Users\\User\\source\\repos\\HW10\\HW10\\NewFolder\\date.json";
            string jsonData = File.ReadAllText(jsonFilepath);
           
            DateInfo dateInfo = JsonConvert.DeserializeObject<DateInfo>(jsonData);
            DateTime currentDate = DateTime.Parse(dateInfo.currentDate);
            DateTime birthday = DateTime.Parse(dateInfo.Birthday);
            TimeSpan daysRemaining = birthday - currentDate;

            Console.WriteLine($"Current Date: {dateInfo.currentDate}");
            Console.WriteLine($"Birthday: {dateInfo.Birthday}");
            Console.WriteLine($"Days remaining until birthday: {daysRemaining.Days}");
        }
    }
}