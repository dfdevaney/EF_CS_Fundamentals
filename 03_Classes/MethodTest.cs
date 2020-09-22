using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void GreeterMethodExecution()
        {
            Greeter greeter = new Greeter(); // Creates a Greeter
            greeter.SayHello();

            greeter.SayHello("Squidward"); // The greeter grabs the SayHello then adds the next parameter.
            greeter.SayHello("Mr. Krabs");
            greeter.SayHello("Steve");
            greeter.SayHello("867-5309");

            greeter.GetRandomGreeting();
        }
    }
}
