using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Greeter // Don't forget to add "public"
    {
        public void SayHello(string name) // All these are added parameters.
        {
            Console.WriteLine($"Hello there, {name}");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello Stranger!");
        }

        Random _rando = new Random();

        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello!", "Howdy!", "'Sup?", "What'up?", "Guten Tag!", "Ni Hao!", "Hi'ya!", "Wasaaauuup?", "Hi!", "Zdravstvuytye!" };
            int randomNumber = _rando.Next(0, availableGreetings.Length);
            string randoGreeting = availableGreetings.ElementAt(randomNumber);

            Console.WriteLine(randoGreeting);
        }
    }
}
