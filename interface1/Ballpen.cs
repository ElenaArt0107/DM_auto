using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    public class Ballpen : IOnOff
    {
        public bool Status { get; set; }
        public ConsoleColor ColorB { get; set; }

        public Ballpen(ConsoleColor colorB)
        {
            this.ColorB = colorB;
        }

        public void Write(string text)
        {
            Console.ForegroundColor = ColorB;
            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void TurnOn()
        {
            Console.WriteLine("ballpan on");
            Status = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("ballpan off");
            Status = false;
        }
        public override string ToString()
        {
            return $"Balpen:\n\tColour {ColorB}\n\tStatus {Status}";
        }
    }
}
