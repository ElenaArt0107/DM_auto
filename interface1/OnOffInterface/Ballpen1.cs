using System;
using System.Collections.Generic;
using System.Text;

namespace OnOffInterface 
{
    public class Ballpen1 : IOnOff1, IWriteCapitals
    {
        public bool Status { get; set; }
        public ConsoleColor ColourW { get ; set ; }

        public Ballpen1(ConsoleColor colorB)
        {
            this.ColourW = colorB;
        }

        public void Write(string text)
        {
            Console.ForegroundColor = ColourW;
            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void TurnOn()
        {
            Console.WriteLine("ballpen on");
            Status = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("ballpen off");
            Status = false;
        }
        public override string ToString()
        {
            return $"Balpen:\n\tColour {ColourW}\n\tStatus {Status}";
        }

        public void WriteInUpperCase(string text)
        {
            Write(text.ToUpper());

        }
    }
}
