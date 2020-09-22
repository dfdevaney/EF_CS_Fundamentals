using System;
using System.Collections.Generic;
using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Iheritance_Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.SetFirstName("Martha");
            martha.SetLastName("Wayne");
            Console.WriteLine(martha.Name);

            Customer bob = new Customer();
            bob.SetFirstName("Bobert");
            bob.SetLastName("Orb");

            SalaryEmployee tedEmployee = new SalaryEmployee // Another way to assign values.
            {
                PhoneNumber = "800-Awesome",
                Salary = 75123,
                HireDate = new DateTime(1304, 01, 13),
                EmployeeNumber = 205201
            };
            Console.WriteLine(tedEmployee.YearsWithCompany);
        }

        [TestMethod]
        public void EmployeeTest()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            tony.HoursWorked = 55;
            tony.HourlyWage = 303;
            pepper.Salary = 122333;
            HourlyEmployee peter = new HourlyEmployee();
            SalaryEmployee happy = new SalaryEmployee();
            happy.Salary = 88123;

            List<Employee> allEmployees = new List<Employee>();

            jarvis.SetFirstName("Jarvis");
            tony.SetFirstName("Tony");
            pepper.SetFirstName("Pepper");
            peter.SetFirstName("Peter");
            happy.SetFirstName("Happy");

            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper);
            allEmployees.Add(peter);
            allEmployees.Add(happy);

            foreach(Employee worker in allEmployees)
            {
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmloyee = (SalaryEmployee)worker; // This is called: Casting.
                    Console.WriteLine($"This is a Salary Employee that makes {sEmloyee.Salary}.");
                }
                else if (worker is HourlyEmployee hourlyWorker)
                {
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours.");
                }
            }
        }
    }
}
