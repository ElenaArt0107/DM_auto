using System;
using System.Collections.Generic;

namespace interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ballpen> pens = new List<Ballpen>();
            pens.Add(new Ballpen(ConsoleColor.Yellow));
            pens.Add(new Ballpen(ConsoleColor.Green));
            pens.Add(new Ballpen(ConsoleColor.Cyan));
            pens.Add(new Ballpen(ConsoleColor.Magenta));

            List<Lamp> lamps = new List<Lamp>();
            lamps.Add(new Lamp());
            lamps.Add(new Lamp());
            lamps.Add(new Lamp());
            lamps.Add(new Lamp());

            foreach (var lamp in lamps)
            {
                lamp.TurnOn();
                Console.WriteLine(lamp);
                lamp.TurnOff();
                Console.WriteLine(lamp);
                Console.WriteLine("_____________________________");
                Console.WriteLine();
            }
            foreach (var pen in pens)
            {
                pen.TurnOn();
                Console.WriteLine(pen);
                Console.WriteLine("A coloured pen");
                pen.TurnOff();
                Console.WriteLine(pen);
                Console.WriteLine("_____________________________");
                Console.WriteLine();
            }
        }
    }
}
