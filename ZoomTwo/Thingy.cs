using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomTwo  // Nope! This guy is all over the place - making me nervous ... he's too twitchy.
{
    public enum ThingyType { Normal = 1, Wierd, Huge, Tiny };

    public class Thingy
    {
        public string OneThing { get; set; }
        public int OtherThing { get; set; }

        public ThingyType Type { get; set; }

        public Thingy() { }

            Thingy thingy = new Thingy();

            Thingy thingy2 = new Thingy("lalala");

            Thingy thingy3 = new Thingy(3);

            Thingy thingy4 = new Thingy("lalala", 5);



        public class CompletThingy : Thingy
        {
            public string Mood { get; set; }
        }
    }
}
