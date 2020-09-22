using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person firstPerson = new Person("Howard", "Stepin'OnBugs", new DateTime(1785,02,14), new Vehicle());
            Console.WriteLine(firstPerson);
            Console.WriteLine(firstPerson.Age);
            int anotherAge = firstPerson.Age;
            firstPerson.Trasport.Make = "Subaru";
            firstPerson.Trasport.Model = "Outback";
            firstPerson.Trasport.Milage = 721;
            firstPerson.Trasport.TypeOfVehicle = VehicleType.Car;

            Assert.AreEqual("Howard Stepin'OnBugs", firstPerson.FullName); // Assert lets you check what's expected without seeing all of the results.
            Assert.AreEqual("Subaru", firstPerson.Trasport.Make); // True, no errors
            Assert.AreEqual("Howard", firstPerson.FirstName); // True, no errors
        }
    }
}
