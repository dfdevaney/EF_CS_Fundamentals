using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared; // Booleans are either True or False.
            isDeclared = true; // This Boolian has been asigned as True.

            bool isDeclarationAndInitialized = false; // This Boolian has been asigned as False.
            isDeclarationAndInitialized = true; // Changed to True.
        }

        [TestMethod]
        public void Characters() // Types of Characters.
        {
            char character = 's'; // Make sure to use single quote, not double.
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sbyteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647; // Int32 is the same as int.
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808; // Int64 is the same as long.

            int a = 42;
            int b = 20;

            byte age = 87;
        }

        [TestMethod]
        public void Decimals()
        {
            float floadExample = 1.045231f; // f at the end marks it as a float.
            double doubleExample = 1.789053278907036d; // d at the end designates it as a double.
            decimal decimalExample = 1.25789072890457897897897897897m; // m at the end designates it as a decimal.

            // Examples of adding f, d, or, m at the end of a long number.
            Console.WriteLine(1.25789072890457897897897897897f); // Output: 1.257891
            Console.WriteLine(1.25789072890457897897897897897d); // Output: 1.25789072890458
            Console.WriteLine(1.25789072890457897897897897897m); // Output: 1.2578907289045789789789789790
        }
        // enums are user created values.
        enum PastryType { Cake, Cupcake, Croissant, Poptart, Pie, Donut};
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Donut;
            PastryType anotherOne = PastryType.Croissant;
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 112; // When hovering the cursor over Int32, you can see Struct.

            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(1978, 01, 28);
        }
    }
}
