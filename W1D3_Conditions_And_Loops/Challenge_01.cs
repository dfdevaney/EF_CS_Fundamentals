using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace W1D3_Conditions_And_Loops
{
    [TestClass]
    public class Challenge_01
    {
        [TestMethod]
        public void LoopExample_01()
        {
            string testWord = "Supercalifragilisticexpialidocious";
            foreach (char letter in testWord)
            {
                    Console.WriteLine(letter);
            }
        }
        [TestMethod]
        public void LoopExample_02()
        {
            string testWord = "Supercalifragilisticexpialidocious";
            foreach (char letter in testWord)
                if (letter != 'i')
            {
                Console.WriteLine("Not an 'i'.");
            }
            else
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void LoopExample_Bonus()
        {
            string testWord = "Supercalifragilisticexpialidocious";
            int letterCount = 0;
            foreach (char letter in testWord)
            {
                letterCount++;
            }
            Console.WriteLine(letterCount);
        }

        [TestMethod]
        public void LoopExample_Bonus_02()
        {
            string testWord = "Supercalifragilisticexpialidocious";
            foreach (char letter in testWord)
                if (letter == 'l')
                {
                    Console.WriteLine("l");
                }
        }
    }
}
