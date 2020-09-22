using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 142;
            string username = "Steve";
            bool equals = age == 12; // Asks if the Age is equal to 12.
            bool userIsAdam = username == "SpongeBob"; // Asks if username is SpongeBob.

            bool notEqual = age != 1001; // The ! is a a "Bang". Asks if age is not 1001.
            bool userIsNotPatrick = username != "Patrick"; // Asks if username is not Patrick.

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);
            bool listsAreEqual = firstList == secondList; // This is false ... I'm not sure why. They are their own seperate items, even though their values are the same.
            bool itemOnList = firstList[0] == secondList[0]; // This one is true because the values are equal.

            Console.WriteLine(listsAreEqual); // False
            Console.WriteLine(itemOnList); // True

            bool greaterThan = age > 10; // True
            bool greatherThanOrEqual = age >= 142; // True
            bool lessThan = age < 50; // False
            bool lessThanOrEqual = age <= 142; // True

            Console.WriteLine(greaterThan);
            Console.WriteLine(greatherThanOrEqual);
            Console.WriteLine(lessThan);
            Console.WriteLine(lessThanOrEqual);

            bool orValue = greaterThan || lessThan; // Compares truths: is one of these true?
            bool anotherOr = age < 9005 || username == "Banana";

            Console.WriteLine(orValue); // True
            Console.WriteLine(anotherOr); // True

            bool andValue = greaterThan && lessThan; // Compares truths: are both true?
            bool anotherAnd = username == "Steve" && age >= 42;

            Console.WriteLine(andValue); // False
            Console.WriteLine(anotherAnd); // True
        }
    }
}
