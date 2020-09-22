using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsDeclaration; // Declaration.

            string declared;
            declared = "This is initialized."; // Initialized value.

            string delarationAndInitialization = "This is both declareding & initializing.";

            // Concatenation

            string firstName = "Bobert";
            string lastName = "Biliiam";
            string space = " ";

            string concatenatedFullName = firstName + " " + lastName;
            string concatenatedFullName2 = firstName + space + lastName; // Does the same thing as above.
            int age = 112;

            // Composite

            string compostieFullName = string.Format("Hello, I am {0} {1}: Attorney at Law. I am {2} years old.", firstName, lastName, age);

            // Interpolation

            string interpolationFullName = $"{lastName}, {firstName} {lastName}. I am {age} years old.";

            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compostieFullName);
            Console.WriteLine(interpolationFullName);
        }

        [TestMethod]
        public void Collections()
        {
            // Arrays

            string stringExample = "Hello World!"; // Strings are already arrays.

            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" }; // There are only 7 slots avaiable for this array.

            string thirdItem = stringArray[2]; // Items in arrays begin with 0; so the 3rd item in this array is slot 2.
            Console.WriteLine(thirdItem);
            Console.WriteLine(stringArray[0]);
            stringArray[0] = "Hey There!"; // Changes the 0 ("Hello") value to "Hey There!"
            Console.WriteLine(stringArray[0]);

            // Lists

            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();
            listOfStrings.Add("42");
            listOfIntegers.Add(44);
            Console.WriteLine(listOfIntegers[0]); // Output: 42
            Console.WriteLine(listOfStrings[0]); // Output: 44

            // Queues

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First!");
            firstInFirstOut.Enqueue("I'm Next.");
            string firstItem = firstInFirstOut.Dequeue(); // Grabs the first item in the queue. The 2nd then becomes the 1st, & so on.
            Console.WriteLine(firstItem);
            Console.WriteLine(firstItem);

            // Dictionary

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(127, "Agent");
            string valueSeven = keyAndValue[127];
            Console.WriteLine(valueSeven);

            // Other Examples

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random(); // Creates a random number.
            int randomNumber = rng.Next(); // Creates a 10 digit number.
            Console.WriteLine(randomNumber);
            int randomNumber2 = rng.Next(1, 100); // Creates a number between 1-100, not including 100.
            Console.WriteLine(randomNumber2);
        }
    }
}
