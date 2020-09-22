﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Person
    {
        // type: prop 'tab' 'tab':
        public string FirstName { get; set; }

        // type: propfull 'tab' 'tab':

        private string _lastName; // This is a Backing Field.
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth { get; set; }

        public Vehicle Trasport { get; set; } // Another property, but the value type is an object.

        public string FullName
        {
            get 
                {
                    return $"{FirstName} {LastName}";
                }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

        public Person() { } // Empty Constructor.
        public Person(string firstName, string lastName, DateTime dob, Vehicle transport) // Overloaded Constructor.
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            Trasport = transport;
        }

    }
}
