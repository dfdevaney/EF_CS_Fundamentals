using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Conditionals
{
    public class Switch
    {
        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello!");
                    break;
                case 2:
                    Console.WriteLine("Thise is Option 2.");
                    break;
                default:
                    Console.WriteLine("This is the Default.");
                    break;
            }

            WeekDay today = WeekDay.Monday;
            switch (today)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    Console.WriteLine("Hope you are ready to work!");
                    break;
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    Console.WriteLine("Have a good weekend!");
                    break;
            }
        }
        [TestMethod]
        public void SwitchExpressions()
        {
            string output;
            int action = 1;
            switch (action)
            {
                case 0:
                    output = "Case 0";
                    break;
                case 1:
                    output = "Case 1";
                    break;
                default:
                    output = "Default Case";
                    break;
            }
            Console.WriteLine(output);
            // Switch Expression
        }

        [TestMethod]
        public void Ternary()
        {
            int age = 31;
            // (conditional/Boolean) ? trueResult : falseResult;
            bool isAdult = (age > 17) ? true : false;

            int numOne = 10; //UserInput
            string output = (numOne == 10) ? "Your guessed correctly!" : "You guessed incorrectly!";
            Console.WriteLine((output == "You guessed correctly!") ? "Congrats!" : "Try Again...");
        }
    }
}
