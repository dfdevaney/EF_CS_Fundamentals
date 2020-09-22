using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while(true)
            {
                if(total == 10)
                {
                    Console.WriteLine("Goal Reached!");
                    break;
                }
                total++; // For increments of 1. With increments of 2, total+2 would be used.
            }

            int someCount;
            bool keepLooping = true;
            Random rand = new Random();
            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if(someCount == 15)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studenCount = 47;

            for(int i = 0; i < studenCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Gordon", "Adam", "Andrew", "Amanda", "Steve" };
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there, {students[i]}|");
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Jon", "Tom", "Gordon", "Brandon", "Amanda", "Jamie", "Andrew" };

            // foreach / item / name /  
            foreach(string student in students)
            {
                Console.WriteLine($"Hello, my name is {student}");
            }

            string myName = "Doug F DeVaney";
            foreach(char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            }
            while (false);

            while (false)
            {
                Console.WriteLine("My while condition is false."); // Unreachable code
            }
        }
    }
}
