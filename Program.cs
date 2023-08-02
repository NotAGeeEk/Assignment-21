using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static List<string> fruitsList = new List<string> { "Apple", "Banana", "Orange", "Grapes", "Mango", "Watermelon", "Strawberry", "Pineapple", "Cherry", "Kiwi" };
        static List<string> daysList = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        static List<string> monthsList = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        static Dictionary<string, string> wordsMeaningsDict = new Dictionary<string, string>
        {
            { "joyful", "feeling or expressing great happiness or delight" },
            { "courageous", "possessing or characterized by bravery and courage" },
            { "mesmerizing", "capturing one's complete attention as if by magic" },
            { "compassionate", "showing a deep concern for the well-being of others" },
            { "innovative", "introducing new ideas; original and creative in thinking" }
        };

        static void DisplayDays()
        {
            Console.WriteLine("Days of the Week:");
            foreach (var day in daysList)
            {
                Thread.Sleep(2000); // Wait for 2 seconds
                Console.WriteLine(day);
            }
        }

        static void DisplayMonths()
        {
            Console.WriteLine("\nMonths of the Year:");
            foreach (var month in monthsList)
            {
                Thread.Sleep(2000); // Wait for 2 seconds
                Console.WriteLine(month);
            }
        }

        static void DisplayFruitsAndWords()
        {
            Console.WriteLine("\nFruits:");
            foreach (var fruit in fruitsList)
            {
                Thread.Sleep(1000); // Wait for 1 second
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nWords and Meanings:");
            foreach (var word in wordsMeaningsDict)
            {
                Thread.Sleep(1000); // Wait for 1 second
                Console.WriteLine($"{word.Key}: {word.Value}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----------------Welcome to Learning------------------");

            // Create and start the threads
            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsWordsThread = new Thread(DisplayFruitsAndWords);

            daysThread.Start();
            daysThread.Join(); // Wait for daysThread to finish before starting monthsThread

            monthsThread.Start();
            monthsThread.Join(); // Wait for monthsThread to finish before starting fruitsWordsThread

            fruitsWordsThread.Start();
            fruitsWordsThread.Join(); // Wait for fruitsWordsThread to finish

            Console.WriteLine("Learning Completed!");

            Console.ReadKey();
        }
    }
}