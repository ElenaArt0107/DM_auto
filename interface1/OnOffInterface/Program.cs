using System;
using System.Collections.Generic;

namespace OnOffInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOnOff1> things = new List<IOnOff1>(); 
            // interface can be used as a referense type for all classes that implements I
            things.Add(new Ballpen1(ConsoleColor.Yellow));
            things.Add(new Ballpen1(ConsoleColor.Green));
            things.Add(new Marker(ConsoleColor.Cyan));
            things.Add(new Marker(ConsoleColor.Magenta));
            things.Add(new Lamp1());
            things.Add(new Lamp1());
            things.Add(new Lamp1());
            things.Add(new Lamp1());

            foreach (var thing in things)
            {
                thing.TurnOn();
                Console.WriteLine(thing);
                if (thing is IAbleToWrite writable)
                    //if (thing is Ballpen1 pen) 
                    // to check a type in c# in if=clause and add the variable where we store the value
                {
                    if (writable is Marker m)
                    {
                        m.Write("This is a nice marker");
                        m.WriteInUpperCase("This is a nice marker");
                    }
                    if(writable is Ballpen1 pen)
                    {
                        pen.Write("That's a color pen");
                        pen.WriteInUpperCase("That's a color pen");

                    }
                }
                thing.TurnOff();
                Console.WriteLine(thing);
                Console.WriteLine("_____________________________");
                Console.WriteLine();
            }

            // if we have got a pen we can write
            
        }
    }
}
