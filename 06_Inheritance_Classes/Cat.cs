using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public class Cat : Animal // Adding to the Class (only 1 at a time).
    {
        public double ClawLength { get; set; }

        public Cat()
        {
            Console.WriteLine("This is the Cat Constructor.");
            IsMammal = true;
            TypeOfDiet = DietType.Carnivore;
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Liger : Cat // Subclass of Cat, which is a subclass of Animal.
    {
        public Liger()
        {
            Console.WriteLine("This is the Liger constructor.");
        }

        public override void Move() // Overrides the Cat override.
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey.");
            base.Move();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
