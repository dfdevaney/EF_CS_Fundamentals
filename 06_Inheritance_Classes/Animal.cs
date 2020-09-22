﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public enum DietType { Herbivore = 1, Carnivore, Omnivore}
    public class Animal
    {
        public int NumberOfLegs { get; set; } // prop + tab + tab

        public bool IsMammal { get; set; }

        public bool HasFur { get; set; }

        public DietType TypeOfDiet { get; set; }

        public Animal()
        {
            Console.WriteLine("This is the Animal Constructor.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

    }
}
