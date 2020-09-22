using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something!");
            }

            int hoursSpentStuying = 4;
            if (hoursSpentStuying < 10)
            {
                Console.WriteLine("Are you even trying?");
            }
        }
        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Relax! Play some video games!");
            }
            else
            {
                Console.WriteLine("Please finish the chores for the day.");
            }

            string input = "7";
            int totalHours = int.Parse(input); // Parse converts a string to it's int equivalent.

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested.");
            }
            else
            {
                Console.WriteLine("You might be tired today.");
                if (totalHours < 3)
                {
                    Console.WriteLine("It's gonna be a rough day - you might need a nap.");
                }
            }

            int age = 18;
            if (age > 17)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                if (age > 12)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else if (age > 2)
                {
                    Console.WriteLine("You are still a little kid");
                }
                else
                {
                    Console.WriteLine("How are you on the coputer?");
                }
            }

            if (age < 65 && age > 18)
            {
                Console.WriteLine("Your age is between 19 & 64.");
            }
            if (age < 18 || age > 18)
            {
                Console.WriteLine("18 isn't a real age.");
            }
        }
    }
}
