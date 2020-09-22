using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuizTest01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 23;

            if (age <= 18)

            {

                Console.WriteLine($"You are: {age}.");

            }

            else if (age > 18 && age <= 35)

            {

                Console.WriteLine($"How are you? You are: {age}.");

            }

            else

            {

                Console.WriteLine("...");

            }
        }
    }
}
