using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {
            HashSet<string> Showroom = new HashSet<string> ();

            Showroom.Add ("Civic");
            Showroom.Add ("Tacoma");
            Showroom.Add ("CB750");
            Showroom.Add ("350z");
            Showroom.Add ("Civic");

            HashSet<string> UsedLot = new HashSet<string> ();

            UsedLot.Add ("Xterra");
            UsedLot.Add ("Yaris");

            Showroom.UnionWith (UsedLot);

            Showroom.Remove ("Yaris");

            HashSet<string> Junkyard = new HashSet<string> ();
            Junkyard.Add ("Tacoma");
            Junkyard.Add ("Vespa");
            Junkyard.Add ("Golf");
            Junkyard.Add ("Tiguan");
            Junkyard.Add ("Altima");
            Junkyard.Add ("CB750");

            HashSet<string> clone = new HashSet<string> (Showroom);

            clone.IntersectWith (Junkyard);

            Showroom.UnionWith (Junkyard);

            Showroom.Remove("Golf");

            foreach (string vehicle in Showroom) {
                Console.WriteLine(vehicle);
            }
        }

    }
}