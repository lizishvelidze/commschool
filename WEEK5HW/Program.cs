using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Xml.Linq;
using System.Linq;

namespace WEEK5HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of an array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size];
            Console.WriteLine("Enter the numbers you want to sort");
            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            foreach (int number in num)
            {
                if (number % 2 == 0)
                {
                    even.Add(number);
                }
                else
                {
                    odd.Add(number);
                }
            }
            int[] evenArray = even.ToArray();
            int[] oddArray = odd.ToArray();
            Console.WriteLine("Even numbers:");
            foreach (int evenNum in evenArray)
            {
                Console.WriteLine(evenNum);
            }
            Console.WriteLine("Odd numbers:");
            foreach (int oddNum in oddArray)
            {
                Console.WriteLine(oddNum);
            }
            ////////////////////////////2

            var contacts = new Dictionary<string, int>();
            contacts.Add("John Doe", 112233);
            contacts.Add("Jane Doe", 445566);
            contacts.Add("Tom Holland", 667788);
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
            }
            contacts.Remove("John Doe");
            //////////////////////////ვერ ვქენი
            
            /////////////////////////3

            Console.WriteLine("Enter a number to define array size");
            int numb = Convert.ToInt32(Console.ReadLine());
            int[] arrNum = new int[numb];
            Console.WriteLine("Enter numbers");
            for (int i = 0; i < numb; i++)
            {
                arrNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            var results = arrNum
                .GroupBy(num => num);
            ///////////////////////////// ავირიე აქაც
            
            ///////////////////////////// 4

            int[] participants = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Enter the number of top participants you wish to display");
            int x = int.Parse(Console.ReadLine());
            int indexStart = participants.Length - x;
            for (int i = indexStart; i < participants.Length; i++)
            {
                Console.WriteLine(participants[i]);

            }


        }
    }
}


